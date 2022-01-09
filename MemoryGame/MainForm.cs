using MemoryGame.Forms;
using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 單一實體(Singleton)
        /// </summary>
        private static MainForm _instance = null;
        public static MainForm Instance => _instance;

        /// <summary>
        /// 當前子表單
        /// </summary>
        private Form ChildForm;

        public MainForm()
        {
            InitializeComponent();
            if (_instance == null)
            {
                _instance = this;
            }
            this.Text = string.Empty;
            this.ControlBox = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            if (ChildForm == null)
            {
                GoHome();
            }
        }

        /// <summary>
        /// 回首頁
        /// </summary>
        public void GoHome()
        {
            OpenChildForm(new HomeForm(), "首頁");
        }

        /// <summary>
        /// 設定子表單
        /// </summary>
        /// <param name="childForm">表單物件</param>
        /// <param name="title">主程式標題</param>
        public void SetActiveForm(Form childForm, string title = null)
        {
            OpenChildForm(childForm, title);
        }

        /// <summary>
        /// 設定子視窗
        /// </summary>
        /// <param name="childForm">表單物件</param>
        /// <param name="title">主程式標題</param>
        private void OpenChildForm(Form childForm, string title = null)
        {
            if (ChildForm != null)
            {
                ChildForm.Close();
            }
            ChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Add(childForm);
            DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            if (!string.IsNullOrEmpty(title))
            {
                this.Text = title;
            }
        }

        /// <summary>
        /// 返回首頁
        /// </summary>
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            GoHome();
        }
    }
}
