namespace MemoryGame.Forms
{
    partial class MenuForm
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
            this.EasyBtn = new System.Windows.Forms.Button();
            this.normalBtn = new System.Windows.Forms.Button();
            this.HardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EasyBtn
            // 
            this.EasyBtn.Location = new System.Drawing.Point(333, 117);
            this.EasyBtn.Name = "EasyBtn";
            this.EasyBtn.Size = new System.Drawing.Size(75, 23);
            this.EasyBtn.TabIndex = 0;
            this.EasyBtn.Text = "初級";
            this.EasyBtn.UseVisualStyleBackColor = true;
            this.EasyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // normalBtn
            // 
            this.normalBtn.Location = new System.Drawing.Point(333, 169);
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(75, 23);
            this.normalBtn.TabIndex = 1;
            this.normalBtn.Text = "中級";
            this.normalBtn.UseVisualStyleBackColor = true;
            // 
            // HardBtn
            // 
            this.HardBtn.Location = new System.Drawing.Point(333, 230);
            this.HardBtn.Name = "HardBtn";
            this.HardBtn.Size = new System.Drawing.Size(75, 23);
            this.HardBtn.TabIndex = 2;
            this.HardBtn.Text = "高級";
            this.HardBtn.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HardBtn);
            this.Controls.Add(this.normalBtn);
            this.Controls.Add(this.EasyBtn);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EasyBtn;
        private System.Windows.Forms.Button normalBtn;
        private System.Windows.Forms.Button HardBtn;
    }
}