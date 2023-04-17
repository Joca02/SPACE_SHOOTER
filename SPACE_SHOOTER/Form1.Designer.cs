namespace SPACE_SHOOTER
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
            this.tmrEnemies = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemies2 = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemies3 = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemies4 = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemies5 = new System.Windows.Forms.Timer(this.components);
            this.tmr_my_bullets = new System.Windows.Forms.Timer(this.components);
            this.lblNoBullets = new System.Windows.Forms.Label();
            this.tmrGenerate_EnemyShot = new System.Windows.Forms.Timer(this.components);
            this.tmr_enemy_bullets = new System.Windows.Forms.Timer(this.components);
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblLose = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrEnemies
            // 
            this.tmrEnemies.Enabled = true;
            this.tmrEnemies.Tick += new System.EventHandler(this.tmrEnemies_Tick);
            // 
            // tmrEnemies2
            // 
            this.tmrEnemies2.Enabled = true;
            this.tmrEnemies2.Tick += new System.EventHandler(this.tmrEnemies2_Tick);
            // 
            // tmrEnemies3
            // 
            this.tmrEnemies3.Enabled = true;
            this.tmrEnemies3.Tick += new System.EventHandler(this.tmrEnemies3_tick);
            // 
            // tmrEnemies4
            // 
            this.tmrEnemies4.Enabled = true;
            this.tmrEnemies4.Tick += new System.EventHandler(this.tmrEnemies4_Tick);
            // 
            // tmrEnemies5
            // 
            this.tmrEnemies5.Enabled = true;
            this.tmrEnemies5.Tick += new System.EventHandler(this.tmrEnemies5_Tick);
            // 
            // tmr_my_bullets
            // 
            this.tmr_my_bullets.Enabled = true;
            this.tmr_my_bullets.Tick += new System.EventHandler(this.tmr_my_bullets_Tick);
            // 
            // lblNoBullets
            // 
            this.lblNoBullets.AutoSize = true;
            this.lblNoBullets.BackColor = System.Drawing.Color.Transparent;
            this.lblNoBullets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBullets.ForeColor = System.Drawing.Color.Red;
            this.lblNoBullets.Location = new System.Drawing.Point(326, 434);
            this.lblNoBullets.Name = "lblNoBullets";
            this.lblNoBullets.Size = new System.Drawing.Size(107, 16);
            this.lblNoBullets.TabIndex = 0;
            this.lblNoBullets.Text = "No Bullets Left";
            // 
            // tmrGenerate_EnemyShot
            // 
            this.tmrGenerate_EnemyShot.Enabled = true;
            this.tmrGenerate_EnemyShot.Interval = 5000;
            this.tmrGenerate_EnemyShot.Tick += new System.EventHandler(this.tmrGenerate_EnemyShot_Tick);
            // 
            // tmr_enemy_bullets
            // 
            this.tmr_enemy_bullets.Enabled = true;
            this.tmr_enemy_bullets.Tick += new System.EventHandler(this.tmr_enemy_bullets_Tick);
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.BackColor = System.Drawing.Color.Transparent;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.ForeColor = System.Drawing.Color.Red;
            this.lblLose.Location = new System.Drawing.Point(237, 174);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(305, 126);
            this.lblLose.TabIndex = 4;
            this.lblLose.Text = "YOU LOST!\r\npress esc to exit\r\n\r\n";
            this.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Lime;
            this.lblWin.Location = new System.Drawing.Point(237, 174);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(305, 84);
            this.lblWin.TabIndex = 5;
            this.lblWin.Text = "YOU WON!  \r\npress esc to exit\r\n";
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPACE_SHOOTER.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblNoBullets);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrEnemies;
        private System.Windows.Forms.Timer tmrEnemies2;
        private System.Windows.Forms.Timer tmrEnemies3;
        private System.Windows.Forms.Timer tmrEnemies4;
        private System.Windows.Forms.Timer tmrEnemies5;
        private System.Windows.Forms.Timer tmr_my_bullets;
        private System.Windows.Forms.Label lblNoBullets;
        private System.Windows.Forms.Timer tmrGenerate_EnemyShot;
        private System.Windows.Forms.Timer tmr_enemy_bullets;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblWin;
    }
}

