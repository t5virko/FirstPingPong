namespace PingPong
{
    partial class Form1
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
            this.backgroundpanel = new System.Windows.Forms.Panel();
            this.gameball = new System.Windows.Forms.PictureBox();
            this.gamepanel = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.LoseLabel = new System.Windows.Forms.Label();
            this.backgroundpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundpanel
            // 
            this.backgroundpanel.Controls.Add(this.LoseLabel);
            this.backgroundpanel.Controls.Add(this.ScoreLabel);
            this.backgroundpanel.Controls.Add(this.gameball);
            this.backgroundpanel.Controls.Add(this.gamepanel);
            this.backgroundpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundpanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundpanel.Name = "backgroundpanel";
            this.backgroundpanel.Size = new System.Drawing.Size(800, 450);
            this.backgroundpanel.TabIndex = 0;
            // 
            // gameball
            // 
            this.gameball.BackColor = System.Drawing.Color.IndianRed;
            this.gameball.Location = new System.Drawing.Point(343, 143);
            this.gameball.Name = "gameball";
            this.gameball.Size = new System.Drawing.Size(40, 40);
            this.gameball.TabIndex = 1;
            this.gameball.TabStop = false;
            // 
            // gamepanel
            // 
            this.gamepanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gamepanel.Location = new System.Drawing.Point(295, 397);
            this.gamepanel.Name = "gamepanel";
            this.gamepanel.Size = new System.Drawing.Size(176, 15);
            this.gamepanel.TabIndex = 0;
            this.gamepanel.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(698, 16);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(90, 27);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Счет: 0";
            // 
            // LoseLabel
            // 
            this.LoseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoseLabel.AutoSize = true;
            this.LoseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoseLabel.Location = new System.Drawing.Point(287, 186);
            this.LoseLabel.Name = "LoseLabel";
            this.LoseLabel.Size = new System.Drawing.Size(254, 47);
            this.LoseLabel.TabIndex = 4;
            this.LoseLabel.Text = "Game Over!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backgroundpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.backgroundpanel.ResumeLayout(false);
            this.backgroundpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundpanel;
        private System.Windows.Forms.PictureBox gameball;
        private System.Windows.Forms.PictureBox gamepanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label LoseLabel;
    }
}

