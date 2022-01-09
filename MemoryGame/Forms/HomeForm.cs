using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 開始按鈕縮放 - 放大
        /// </summary>
        private void MenuBtn_MouseEnter(object sender, EventArgs e)
        {
            int zoomAbs = 30;
            MenuBtn.Size = new Size(MenuBtn.Size.Width + zoomAbs, MenuBtn.Size.Height + zoomAbs);
            MenuBtn.Location = new Point(MenuBtn.Location.X - (zoomAbs / 2), MenuBtn.Location.Y - (zoomAbs / 2));
            MenuBtn.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// 開始按鈕縮放 - 縮小
        /// </summary>
        private void MenuBtn_MouseLeave(object sender, EventArgs e)
        {
            int zoomAbs = 30;
            MenuBtn.Size = new Size(MenuBtn.Size.Width - zoomAbs, MenuBtn.Size.Height - zoomAbs);
            MenuBtn.Location = new Point(MenuBtn.Location.X + (zoomAbs / 2), MenuBtn.Location.Y + (zoomAbs / 2));
        }

        /// <summary>
        /// 開啟按鈕 - 載入選單
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetActiveForm(new Forms.MenuForm(), "選單");
        }
    }
}
