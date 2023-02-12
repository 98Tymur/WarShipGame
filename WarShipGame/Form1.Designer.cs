namespace WarShipGame
{
    partial class SpaceWar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceWar));
            this.MoveBackgraundTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.UpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveMinitionsTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemiesMutionTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Replay = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.levelLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBackgraundTimer
            // 
            this.MoveBackgraundTimer.Enabled = true;
            this.MoveBackgraundTimer.Interval = 10;
            this.MoveBackgraundTimer.Tick += new System.EventHandler(this.MoveBackgraundTimer_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(260, 400);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 5;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 5;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 5;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Interval = 5;
            this.UpMoveTimer.Tick += new System.EventHandler(this.UpMoveTimer_Tick);
            // 
            // MoveMinitionsTimer
            // 
            this.MoveMinitionsTimer.Enabled = true;
            this.MoveMinitionsTimer.Interval = 20;
            this.MoveMinitionsTimer.Tick += new System.EventHandler(this.MoveMinitionsTimer_Tick);
            // 
            // MoveEnemiesTimer
            // 
            this.MoveEnemiesTimer.Enabled = true;
            this.MoveEnemiesTimer.Tick += new System.EventHandler(this.MoveEnemiesTimer_Tick);
            // 
            // EnemiesMutionTimer
            // 
            this.EnemiesMutionTimer.Enabled = true;
            this.EnemiesMutionTimer.Interval = 20;
            this.EnemiesMutionTimer.Tick += new System.EventHandler(this.EnemiesMutionTimer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(160, 123);
            this.label1.MinimumSize = new System.Drawing.Size(257, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Replay
            // 
            this.Replay.Location = new System.Drawing.Point(168, 210);
            this.Replay.Name = "Replay";
            this.Replay.Size = new System.Drawing.Size(249, 43);
            this.Replay.TabIndex = 2;
            this.Replay.Text = "Replay";
            this.Replay.UseVisualStyleBackColor = true;
            this.Replay.Visible = false;
            this.Replay.Click += new System.EventHandler(this.Replay_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(168, 269);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(249, 43);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.ForeColor = System.Drawing.Color.Transparent;
            this.scoreLbl.Location = new System.Drawing.Point(12, 20);
            this.scoreLbl.MaximumSize = new System.Drawing.Size(200, 100);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(122, 25);
            this.scoreLbl.TabIndex = 4;
            this.scoreLbl.Text = "scoreLbl";
            // 
            // levelLbl
            // 
            this.levelLbl.AutoSize = true;
            this.levelLbl.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLbl.ForeColor = System.Drawing.Color.Transparent;
            this.levelLbl.Location = new System.Drawing.Point(442, 20);
            this.levelLbl.MaximumSize = new System.Drawing.Size(200, 100);
            this.levelLbl.Name = "levelLbl";
            this.levelLbl.Size = new System.Drawing.Size(86, 25);
            this.levelLbl.TabIndex = 5;
            this.levelLbl.Text = "level:";
            // 
            // SpaceWar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.levelLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Replay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.Name = "SpaceWar";
            this.Text = "SpaceWar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceWar_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceWar_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MoveBackgraundTimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer MoveMinitionsTimer;
        private System.Windows.Forms.Timer MoveEnemiesTimer;
        private System.Windows.Forms.Timer EnemiesMutionTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Replay;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label levelLbl;
    }
}

