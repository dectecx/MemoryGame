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
            this.components = new System.ComponentModel.Container();
            this.LastTimeLabel = new System.Windows.Forms.Label();
            this.GameLevelLabel = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.GameLevelValueLabel = new System.Windows.Forms.Label();
            this.GamingTimer = new System.Windows.Forms.Timer(this.components);
            this.SysMsgLabel = new System.Windows.Forms.Label();
            this.MemoryTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastTimeLabel
            // 
            this.LastTimeLabel.AutoSize = true;
            this.LastTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastTimeLabel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LastTimeLabel.Location = new System.Drawing.Point(328, 13);
            this.LastTimeLabel.Name = "LastTimeLabel";
            this.LastTimeLabel.Size = new System.Drawing.Size(192, 40);
            this.LastTimeLabel.TabIndex = 0;
            this.LastTimeLabel.Text = "{{LastTime}}";
            this.LastTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameLevelLabel
            // 
            this.GameLevelLabel.AutoSize = true;
            this.GameLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameLevelLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GameLevelLabel.Location = new System.Drawing.Point(649, 22);
            this.GameLevelLabel.Name = "GameLevelLabel";
            this.GameLevelLabel.Size = new System.Drawing.Size(57, 20);
            this.GameLevelLabel.TabIndex = 1;
            this.GameLevelLabel.Text = "難度：";
            // 
            // GamePanel
            // 
            this.GamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GamePanel.BackColor = System.Drawing.Color.Transparent;
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GamePanel.Location = new System.Drawing.Point(100, 65);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(600, 350);
            this.GamePanel.TabIndex = 3;
            // 
            // GameLevelValueLabel
            // 
            this.GameLevelValueLabel.AutoSize = true;
            this.GameLevelValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameLevelValueLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GameLevelValueLabel.Location = new System.Drawing.Point(712, 22);
            this.GameLevelValueLabel.Name = "GameLevelValueLabel";
            this.GameLevelValueLabel.Size = new System.Drawing.Size(63, 20);
            this.GameLevelValueLabel.TabIndex = 4;
            this.GameLevelValueLabel.Text = "{{level}}";
            // 
            // GamingTimer
            // 
            this.GamingTimer.Interval = 1000;
            this.GamingTimer.Tick += new System.EventHandler(this.GamingTimer_Tick);
            // 
            // SysMsgLabel
            // 
            this.SysMsgLabel.AutoSize = true;
            this.SysMsgLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.SysMsgLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SysMsgLabel.Location = new System.Drawing.Point(94, 22);
            this.SysMsgLabel.Name = "SysMsgLabel";
            this.SysMsgLabel.Size = new System.Drawing.Size(147, 34);
            this.SysMsgLabel.TabIndex = 0;
            this.SysMsgLabel.Text = "{{SysMsg}}";
            // 
            // MemoryTimer
            // 
            this.MemoryTimer.Interval = 1000;
            this.MemoryTimer.Tick += new System.EventHandler(this.MemoryTimer_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.LightPink;
            this.ScoreLabel.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ScoreLabel.Location = new System.Drawing.Point(94, 22);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(121, 34);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "{{Score}}";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScoreLabel.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.wood00;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.SysMsgLabel);
            this.Controls.Add(this.GameLevelValueLabel);
            this.Controls.Add(this.GamePanel);
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
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label GameLevelValueLabel;
        private System.Windows.Forms.Timer GamingTimer;
        private System.Windows.Forms.Label SysMsgLabel;
        private System.Windows.Forms.Timer MemoryTimer;
        private System.Windows.Forms.Label ScoreLabel;
    }
}