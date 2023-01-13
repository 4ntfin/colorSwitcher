namespace colorSwitcher
{
    partial class ColorSwitch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nextColor = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Instructions = new System.Windows.Forms.Label();
            this.Scoreboard = new System.Windows.Forms.ListBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.block1);
            this.panel1.Controls.Add(this.nextColor);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.block2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 580);
            this.panel1.TabIndex = 0;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.OliveDrab;
            this.block1.Location = new System.Drawing.Point(-21, 28);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(518, 30);
            this.block1.TabIndex = 0;
            this.block1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Next Color:";
            // 
            // nextColor
            // 
            this.nextColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nextColor.Location = new System.Drawing.Point(123, 527);
            this.nextColor.Name = "nextColor";
            this.nextColor.Size = new System.Drawing.Size(20, 20);
            this.nextColor.TabIndex = 3;
            this.nextColor.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Orange;
            this.player.Location = new System.Drawing.Point(212, 458);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 30);
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Orange;
            this.block2.Location = new System.Drawing.Point(-21, 186);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(518, 30);
            this.block2.TabIndex = 1;
            this.block2.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Black;
            this.Score.Location = new System.Drawing.Point(577, 2);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(107, 25);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score: 0 ";
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.ForeColor = System.Drawing.Color.Black;
            this.Instructions.Location = new System.Drawing.Point(521, 509);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(207, 26);
            this.Instructions.TabIndex = 2;
            this.Instructions.Text = "Press Space To Change Your Color\r\nPress R to Reset";
            this.Instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Scoreboard
            // 
            this.Scoreboard.BackColor = System.Drawing.Color.Silver;
            this.Scoreboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scoreboard.Enabled = false;
            this.Scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Scoreboard.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Scoreboard.FormattingEnabled = true;
            this.Scoreboard.ItemHeight = 25;
            this.Scoreboard.Location = new System.Drawing.Point(480, 38);
            this.Scoreboard.Name = "Scoreboard";
            this.Scoreboard.Size = new System.Drawing.Size(286, 450);
            this.Scoreboard.TabIndex = 3;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.playGame);
            // 
            // ColorSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(759, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Scoreboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ColorSwitch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Switch | Finlay Lecheminant";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorSwitch_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.ListBox Scoreboard;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox nextColor;
    }
}

