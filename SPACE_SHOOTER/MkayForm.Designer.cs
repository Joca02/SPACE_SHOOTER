namespace SPACE_SHOOTER
{
    partial class MkayForm
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
            this.tmrMackey = new System.Windows.Forms.Timer(this.components);
            this.lblNoBullets = new System.Windows.Forms.Label();
            this.tmr_my_bullets = new System.Windows.Forms.Timer(this.components);
            this.lblWin = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblLose = new System.Windows.Forms.Label();
            this.tmrGenerateMkay = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveLabels = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrMackey
            // 
            this.tmrMackey.Enabled = true;
            this.tmrMackey.Tick += new System.EventHandler(this.tmrMackey_Tick);
            // 
            // lblNoBullets
            // 
            this.lblNoBullets.AutoSize = true;
            this.lblNoBullets.BackColor = System.Drawing.Color.Transparent;
            this.lblNoBullets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBullets.ForeColor = System.Drawing.Color.Red;
            this.lblNoBullets.Location = new System.Drawing.Point(327, 410);
            this.lblNoBullets.Name = "lblNoBullets";
            this.lblNoBullets.Size = new System.Drawing.Size(107, 16);
            this.lblNoBullets.TabIndex = 1;
            this.lblNoBullets.Text = "No Bullets Left";
            // 
            // tmr_my_bullets
            // 
            this.tmr_my_bullets.Enabled = true;
            this.tmr_my_bullets.Tick += new System.EventHandler(this.tmr_my_bullets_Tick);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Lime;
            this.lblWin.Location = new System.Drawing.Point(247, 195);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(305, 84);
            this.lblWin.TabIndex = 2;
            this.lblWin.Text = "YOU WON!  \r\npress esc to exit\r\n";
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 50;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.BackColor = System.Drawing.Color.Transparent;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.ForeColor = System.Drawing.Color.Red;
            this.lblLose.Location = new System.Drawing.Point(237, 195);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(305, 126);
            this.lblLose.TabIndex = 3;
            this.lblLose.Text = "YOU LOST!\r\npress esc to exit\r\n\r\n";
            this.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrGenerateMkay
            // 
            this.tmrGenerateMkay.Enabled = true;
            this.tmrGenerateMkay.Interval = 2000;
            this.tmrGenerateMkay.Tick += new System.EventHandler(this.tmrGenerateMkay_Tick);
            // 
            // tmrMoveLabels
            // 
            this.tmrMoveLabels.Enabled = true;
            this.tmrMoveLabels.Interval = 50;
            this.tmrMoveLabels.Tick += new System.EventHandler(this.tmrMoveLabels_Tick);
            // 
            // MkayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPACE_SHOOTER.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblNoBullets);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MkayForm";
            this.Text = "MkayForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MkayForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMackey;
        private System.Windows.Forms.Label lblNoBullets;
        private System.Windows.Forms.Timer tmr_my_bullets;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Timer tmrGenerateMkay;
        private System.Windows.Forms.Timer tmrMoveLabels;
    }
}