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
            this.NormalBtn = new System.Windows.Forms.Button();
            this.HardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EasyBtn
            // 
            this.EasyBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EasyBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EasyBtn.Location = new System.Drawing.Point(476, 157);
            this.EasyBtn.Name = "EasyBtn";
            this.EasyBtn.Size = new System.Drawing.Size(134, 56);
            this.EasyBtn.TabIndex = 0;
            this.EasyBtn.Text = "初級";
            this.EasyBtn.UseVisualStyleBackColor = false;
            this.EasyBtn.Click += new System.EventHandler(this.EasyBtn_Click);
            // 
            // NormalBtn
            // 
            this.NormalBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NormalBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NormalBtn.Location = new System.Drawing.Point(476, 242);
            this.NormalBtn.Name = "NormalBtn";
            this.NormalBtn.Size = new System.Drawing.Size(134, 56);
            this.NormalBtn.TabIndex = 1;
            this.NormalBtn.Text = "中級";
            this.NormalBtn.UseVisualStyleBackColor = false;
            this.NormalBtn.Click += new System.EventHandler(this.NormalBtn_Click);
            // 
            // HardBtn
            // 
            this.HardBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HardBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HardBtn.Location = new System.Drawing.Point(476, 326);
            this.HardBtn.Name = "HardBtn";
            this.HardBtn.Size = new System.Drawing.Size(134, 56);
            this.HardBtn.TabIndex = 2;
            this.HardBtn.Text = "高級";
            this.HardBtn.UseVisualStyleBackColor = false;
            this.HardBtn.Click += new System.EventHandler(this.HardBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HardBtn);
            this.Controls.Add(this.NormalBtn);
            this.Controls.Add(this.EasyBtn);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EasyBtn;
        private System.Windows.Forms.Button NormalBtn;
        private System.Windows.Forms.Button HardBtn;
    }
}