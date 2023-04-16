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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPACE_SHOOTER.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(784, 560);
            this.Controls.Add(this.lblNoBullets);
            this.MaximumSize = new System.Drawing.Size(800, 600);
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
    }
}

