namespace Star_War
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MoveBackgroundSpeedTimer = new System.Windows.Forms.Timer(components);
            Player = new PictureBox();
            LeftMoveTimer = new System.Windows.Forms.Timer(components);
            RightMoveTimer = new System.Windows.Forms.Timer(components);
            DownMoveTimer = new System.Windows.Forms.Timer(components);
            UpMoveTimer = new System.Windows.Forms.Timer(components);
            AmmunitionSpeedTimer = new System.Windows.Forms.Timer(components);
            EnemiesMoveTimer = new System.Windows.Forms.Timer(components);
            EnemiesAmmunitionTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            SuspendLayout();
            // 
            // MoveBackgroundSpeedTimer
            // 
            MoveBackgroundSpeedTimer.Interval = 10;
            MoveBackgroundSpeedTimer.Tick += MoveBackgroundSpeed_Tick;
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(267, 366);
            Player.Name = "Player";
            Player.Size = new Size(50, 50);
            Player.SizeMode = PictureBoxSizeMode.Zoom;
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // LeftMoveTimer
            // 
            LeftMoveTimer.Interval = 5;
            LeftMoveTimer.Tick += LeftMoveTimer_Tick;
            // 
            // RightMoveTimer
            // 
            RightMoveTimer.Interval = 5;
            RightMoveTimer.Tick += RightMoveTimer_Tick;
            // 
            // DownMoveTimer
            // 
            DownMoveTimer.Interval = 5;
            DownMoveTimer.Tick += DownMoveTimer_Tick;
            // 
            // UpMoveTimer
            // 
            UpMoveTimer.Interval = 5;
            UpMoveTimer.Tick += UpMoveTimer_Tick;
            // 
            // AmmunitionSpeedTimer
            // 
            AmmunitionSpeedTimer.Enabled = true;
            AmmunitionSpeedTimer.Interval = 15;
            AmmunitionSpeedTimer.Tick += ammunitionSpeedTimer_Tick;
            // 
            // EnemiesMoveTimer
            // 
            EnemiesMoveTimer.Enabled = true;
            EnemiesMoveTimer.Tick += EnemiesMoveTimer_Tick;
            // 
            // EnemiesAmmunitionTimer
            // 
            EnemiesAmmunitionTimer.Enabled = true;
            EnemiesAmmunitionTimer.Interval = 20;
            EnemiesAmmunitionTimer.Tick += EnemiesAmmunitionTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(584, 461);
            Controls.Add(Player);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(600, 500);
            MinimumSize = new Size(600, 500);
            Name = "Form1";
            Text = "Star War";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer MoveBackgroundSpeedTimer;
        private PictureBox Player;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer AmmunitionSpeedTimer;
        private System.Windows.Forms.Timer EnemiesMoveTimer;
        private System.Windows.Forms.Timer EnemiesAmmunitionTimer;
    }
}
