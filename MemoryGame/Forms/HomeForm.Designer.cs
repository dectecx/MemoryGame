namespace MemoryGame.Forms
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.DesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackgroundImage = global::MemoryGame.Properties.Resources.wood00;
            this.DesktopPanel.Controls.Add(this.VersionLabel);
            this.DesktopPanel.Controls.Add(this.LogoPictureBox);
            this.DesktopPanel.Controls.Add(this.MenuBtn);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.DesktopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(1067, 562);
            this.DesktopPanel.TabIndex = 1;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.VersionLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.VersionLabel.Location = new System.Drawing.Point(973, 526);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(74, 25);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "ver 1.0";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox.Image = global::MemoryGame.Properties.Resources.Home_LogoText;
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 79);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(1067, 162);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.MenuBtn.BackgroundImage = global::MemoryGame.Properties.Resources.Home_StartText;
            this.MenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Location = new System.Drawing.Point(431, 371);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(207, 80);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            this.MenuBtn.MouseEnter += new System.EventHandler(this.MenuBtn_MouseEnter);
            this.MenuBtn.MouseLeave += new System.EventHandler(this.MenuBtn_MouseLeave);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.DesktopPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.DesktopPanel.ResumeLayout(false);
            this.DesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Label VersionLabel;
    }
}