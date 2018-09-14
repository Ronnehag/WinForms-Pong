namespace Pong
{
    partial class frm_Pong
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
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.tb_playerScore = new System.Windows.Forms.Label();
            this.tb_cpuScore = new System.Windows.Forms.Label();
            this.bgTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Yellow;
            this.player.Location = new System.Drawing.Point(12, 186);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(27, 127);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ball.Location = new System.Drawing.Point(434, 239);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(27, 26);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.Fuchsia;
            this.cpu.Location = new System.Drawing.Point(883, 186);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(27, 127);
            this.cpu.TabIndex = 2;
            this.cpu.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timertick);
            // 
            // tb_playerScore
            // 
            this.tb_playerScore.AutoSize = true;
            this.tb_playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_playerScore.ForeColor = System.Drawing.Color.Lime;
            this.tb_playerScore.Location = new System.Drawing.Point(43, 24);
            this.tb_playerScore.Name = "tb_playerScore";
            this.tb_playerScore.Size = new System.Drawing.Size(55, 37);
            this.tb_playerScore.TabIndex = 3;
            this.tb_playerScore.Text = "00";
            // 
            // tb_cpuScore
            // 
            this.tb_cpuScore.AutoSize = true;
            this.tb_cpuScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cpuScore.ForeColor = System.Drawing.Color.Red;
            this.tb_cpuScore.Location = new System.Drawing.Point(817, 24);
            this.tb_cpuScore.Name = "tb_cpuScore";
            this.tb_cpuScore.Size = new System.Drawing.Size(55, 37);
            this.tb_cpuScore.TabIndex = 4;
            this.tb_cpuScore.Text = "00";
            // 
            // bgTimer
            // 
            this.bgTimer.Interval = 150;
            this.bgTimer.Tick += new System.EventHandler(this.bgtimertick);
            // 
            // frm_Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(957, 521);
            this.Controls.Add(this.tb_cpuScore);
            this.Controls.Add(this.tb_playerScore);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Name = "frm_Pong";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label tb_playerScore;
        private System.Windows.Forms.Label tb_cpuScore;
        private System.Windows.Forms.Timer bgTimer;
    }
}

