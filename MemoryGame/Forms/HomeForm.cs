using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void MenuBtn_MouseEnter(object sender, EventArgs e)
        {
            int zoomAbs = 30;
            MenuBtn.Size = new Size(MenuBtn.Size.Width + zoomAbs, MenuBtn.Size.Height + zoomAbs);
            MenuBtn.Location = new Point(MenuBtn.Location.X - (zoomAbs / 2), MenuBtn.Location.Y - (zoomAbs / 2));
            MenuBtn.Cursor = Cursors.Hand;
        }

        private void MenuBtn_MouseLeave(object sender, EventArgs e)
        {
            int zoomAbs = 30;
            MenuBtn.Size = new Size(MenuBtn.Size.Width - zoomAbs, MenuBtn.Size.Height - zoomAbs);
            MenuBtn.Location = new Point(MenuBtn.Location.X + (zoomAbs / 2), MenuBtn.Location.Y + (zoomAbs / 2));
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetActiveForm(new Forms.MenuForm(), "選單");
        }
    }
}
