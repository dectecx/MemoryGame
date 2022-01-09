namespace MemoryGame.Forms
{
    partial class GameForm
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
            this.LastTimeLabel = new System.Windows.Forms.Label();
            this.GameLevelLabel = new System.Windows.Forms.Label();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.GameLevelValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastTimeLabel
            // 
            this.LastTimeLabel.AutoSize = true;
            this.LastTimeLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LastTimeLabel.Location = new System.Drawing.Point(334, 34);
            this.LastTimeLabel.Name = "LastTimeLabel";
            this.LastTimeLabel.Size = new System.Drawing.Size(73, 20);
            this.LastTimeLabel.TabIndex = 0;
            this.LastTimeLabel.Text = "剩餘時間";
            // 
            // GameLevelLabel
            // 
            this.GameLevelLabel.AutoSize = true;
            this.GameLevelLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GameLevelLabel.Location = new System.Drawing.Point(649, 34);
            this.GameLevelLabel.Name = "GameLevelLabel";
            this.GameLevelLabel.Size = new System.Drawing.Size(57, 20);
            this.GameLevelLabel.TabIndex = 1;
            this.GameLevelLabel.Text = "難度：";
            // 
            // FooterPanel
            // 
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 421);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(800, 29);
            this.FooterPanel.TabIndex = 2;
            // 
            // GamePanel
            // 
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GamePanel.Location = new System.Drawing.Point(0, 85);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(800, 336);
            this.GamePanel.TabIndex = 3;
            // 
            // GameLevelValueLabel
            // 
            this.GameLevelValueLabel.AutoSize = true;
            this.GameLevelValueLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GameLevelValueLabel.Location = new System.Drawing.Point(712, 34);
            this.GameLevelValueLabel.Name = "GameLevelValueLabel";
            this.GameLevelValueLabel.Size = new System.Drawing.Size(63, 20);
            this.GameLevelValueLabel.TabIndex = 4;
            this.GameLevelValueLabel.Text = "{{level}}";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameLevelValueLabel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.GameLevelLabel);
            this.Controls.Add(this.LastTimeLabel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastTimeLabel;
        private System.Windows.Forms.Label GameLevelLabel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label GameLevelValueLabel;
    }
}