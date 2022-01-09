using MemoryGame.Models.Enum;
using System;
using System.Windows.Forms;

namespace MemoryGame.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初級
        /// </summary>
        private void EasyBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetActiveForm(new GameForm(LevelEnum.Easy), "初級");
        }

        /// <summary>
        /// 中級
        /// </summary>
        private void NormalBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetActiveForm(new GameForm(LevelEnum.Normal), "中級");
        }

        /// <summary>
        /// 高級
        /// </summary>
        private void HardBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetActiveForm(new GameForm(LevelEnum.Hard), "高級");
        }
    }
}
