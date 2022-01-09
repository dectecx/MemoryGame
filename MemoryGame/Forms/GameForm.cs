using MemoryGame.Models.Enum;
using System;
using System.Windows.Forms;

namespace MemoryGame.Forms
{
    public partial class GameForm : Form
    {
        /// <summary>
        /// 當前子表單
        /// </summary>
        private Form ChildForm;

        /// <summary>
        /// 遊戲難度
        /// </summary>
        private LevelEnum GameLevel;

        /// <summary>
        /// 遊戲狀態
        /// </summary>
        private StatusEnum GameStatus;

        /// <summary>
        /// 剩餘時間
        /// </summary>
        private int LastTime;

        /// <summary>
        /// 總點擊次數
        /// </summary>
        private int ClickCount;

        public GameForm(LevelEnum level)
        {
            InitializeComponent();
            GameLevel = level;

            switch (GameLevel)
            {
                case LevelEnum.Easy:
                    GameLevelValueLabel.Text = "初級";
                    ChildForm = new EasyForm(this);
                    break;
                case LevelEnum.Normal:
                    GameLevelValueLabel.Text = "中級";
                    ChildForm = new NormalForm(this);
                    break;
                case LevelEnum.Hard:
                    GameLevelValueLabel.Text = "高級";
                    ChildForm = new HardForm(this);
                    break;
                default:
                    GameLevelValueLabel.Text = "未知";
                    ChildForm = new EasyForm(this);
                    break;
            }

            OpenChildForm(ChildForm);
            GameStatus = StatusEnum.Null;
            PushFlow();
        }

        /// <summary>
        /// 增加點擊次數
        /// </summary>
        public void AddClickCount()
        {
            ClickCount++;
        }

        /// <summary>
        /// 獲勝
        /// </summary>
        public void GoToWin()
        {
            GamingTimer.Enabled = false;
            PushFlow();
        }

        /// <summary>
        /// 設定子視窗
        /// </summary>
        /// <param name="childForm">表單物件</param>
        /// <param name="title">主程式標題</param>
        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            GamePanel.Controls.Add(childForm);
            GamePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// 推關
        /// </summary>
        private void PushFlow()
        {
            switch (GameStatus)
            {
                default:
                    SysMsgLabel.Text = "記憶Time~";
                    GameStatus = StatusEnum.MemoryTime;
                    LastTime = 8;
                    MemoryTimer.Enabled = true;
                    DisableChildPictureBox();
                    break;
                case StatusEnum.MemoryTime:
                    SysMsgLabel.Text = "遊戲開始";
                    GameStatus = StatusEnum.Gaming;
                    LastTime = 20;
                    ClickCount = 0;
                    GamingTimer.Enabled = true;
                    EnableChildPictureBox();
                    break;
                case StatusEnum.Gaming:
                    GameStatus = StatusEnum.GameOver;
                    DisableChildPictureBox();
                    CalculateGrades();
                    break;
                case StatusEnum.GameOver:
                    MainForm.Instance.GoHome();
                    break;
            }
        }

        private void MemoryTimer_Tick(object sender, EventArgs e)
        {
            LastTime--;
            LastTimeLabel.Text = LastTime.ToString();
            if (LastTime <= 0)
            {
                MemoryTimer.Enabled = false;
                PushFlow();
            }
        }

        private void GamingTimer_Tick(object sender, EventArgs e)
        {
            LastTime--;
            LastTimeLabel.Text = LastTime.ToString();
            if (LastTime <= 17)
            {
                SysMsgLabel.Text = string.Empty;
            }
            if (LastTime <= 0)
            {
                GamingTimer.Enabled = false;
                PushFlow();
            }
        }

        /// <summary>
        /// 啟用圖片
        /// </summary>
        private void EnableChildPictureBox()
        {
            foreach (Control ctl in ChildForm.Controls)
            {
                if (ctl is PictureBox pictureBox)
                {
                    pictureBox.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 關閉圖片
        /// </summary>
        private void DisableChildPictureBox()
        {
            foreach (Control ctl in ChildForm.Controls)
            {
                if (ctl is PictureBox pictureBox)
                {
                    pictureBox.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 計算分數
        /// 剩餘秒數*(100/點擊圖片次數)
        /// </summary>
        private void CalculateGrades()
        {
            SysMsgLabel.Text = string.Empty;
            // 找出子表單內是否還有尚未隱藏的圖片物件
            foreach (Control ctl in ChildForm.Controls)
            {
                if (ctl is PictureBox pictureBox)
                {
                    if (pictureBox.Visible)
                    {
                        // 挑戰失敗
                        string failText = "挑戰失敗";
                        ScoreLabel.Visible = true;
                        ScoreLabel.Text = failText;
                        MessageBox.Show(failText);
                        PushFlow();
                        return;
                    }
                }
            }

            string scoreText = "得分：" + (LastTime * (100 / ClickCount)).ToString();
            ScoreLabel.Visible = true;
            ScoreLabel.Text = scoreText;
            MessageBox.Show(scoreText);
            PushFlow();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = ClickCount.ToString();
        }
    }
}
