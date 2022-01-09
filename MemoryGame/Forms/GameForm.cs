using MemoryGame.Models.Enum;
using System;
using System.Windows.Forms;

namespace MemoryGame.Forms
{
    public partial class GameForm : Form
    {
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

        public GameForm(LevelEnum level)
        {
            InitializeComponent();
            GameLevel = level;

            switch (GameLevel)
            {
                case LevelEnum.Easy:
                    GameLevelValueLabel.Text = "初級";
                    OpenChildForm(new EasyForm());
                    break;
                case LevelEnum.Normal:
                    GameLevelValueLabel.Text = "中級";
                    OpenChildForm(new NormalForm());
                    break;
                case LevelEnum.Hard:
                    GameLevelValueLabel.Text = "高級";
                    OpenChildForm(new HardForm());
                    break;
                default:
                    GameLevelValueLabel.Text = "未知";
                    OpenChildForm(new EasyForm());
                    break;
            }

            GameStatus = StatusEnum.Null;
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
        /// 遊戲狀態監聽
        /// </summary>
        private void GameStatusTimer_Tick(object sender, EventArgs e)
        {
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
                    break;
                case StatusEnum.MemoryTime:
                    SysMsgLabel.Text = "遊戲開始";
                    GameStatus = StatusEnum.Gaming;
                    LastTime = 60;
                    GamingTimer.Enabled = true;
                    break;
                case StatusEnum.Gaming:
                    break;
                case StatusEnum.Stop:
                    break;
                case StatusEnum.GameOver:
                    CalculateGrades();
                    break;
            }
        }

        private void MemoryTimer_Tick(object sender, EventArgs e)
        {
            LastTime--;
            LastTimeLabel.Text = LastTime.ToString();
            if (LastTime < 0)
            {
                MemoryTimer.Enabled = false;
                PushFlow();
            }
        }

        private void GamingTimer_Tick(object sender, EventArgs e)
        {
            LastTime--;
            LastTimeLabel.Text = LastTime.ToString();
            if (LastTime < 57)
            {
                SysMsgLabel.Text = string.Empty;
            }
            if (LastTime < 0)
            {
                GamingTimer.Enabled = false;
                PushFlow();
            }
        }

        private void CalculateGrades()
        {

        }
    }
}
