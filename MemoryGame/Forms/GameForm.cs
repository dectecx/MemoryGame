using MemoryGame.Models.Enum;
using System.Windows.Forms;

namespace MemoryGame.Forms
{
    public partial class GameForm : Form
    {
        /// <summary>
        /// 遊戲難度
        /// </summary>
        private LevelEnum GameLevel;

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
                    OpenChildForm(new EasyForm());
                    break;
                case LevelEnum.Hard:
                    GameLevelValueLabel.Text = "高級";
                    OpenChildForm(new EasyForm());
                    break;
                default:
                    GameLevelValueLabel.Text = "未知";
                    OpenChildForm(new EasyForm());
                    break;
            }
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
    }
}
