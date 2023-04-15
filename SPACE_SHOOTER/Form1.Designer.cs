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
            this.SuspendLayout();
            // 
            // tmrEnemies
            // 
            this.tmrEnemies.Enabled = true;
            this.tmrEnemies.Interval = 20;
            this.tmrEnemies.Tick += new System.EventHandler(this.tmrEnemies_Tick);
            // 
            // tmrEnemies2
            // 
            this.tmrEnemies2.Enabled = true;
            this.tmrEnemies2.Interval = 20;
            this.tmrEnemies2.Tick += new System.EventHandler(this.tmrEnemies2_Tick);
            // 
            // tmrEnemies3
            // 
            this.tmrEnemies3.Enabled = true;
            this.tmrEnemies3.Interval = 20;
            this.tmrEnemies3.Tick += new System.EventHandler(this.tmrEnemies3_tick);
            // 
            // tmrEnemies4
            // 
            this.tmrEnemies4.Enabled = true;
            this.tmrEnemies4.Interval = 20;
            this.tmrEnemies4.Tick += new System.EventHandler(this.tmrEnemies4_Tick);
            // 
            // tmrEnemies5
            // 
            this.tmrEnemies5.Enabled = true;
            this.tmrEnemies5.Interval = 20;
            this.tmrEnemies5.Tick += new System.EventHandler(this.tmrEnemies5_Tick);
            // 
            // tmr_my_bullets
            // 
            this.tmr_my_bullets.Enabled = true;
            this.tmr_my_bullets.Interval = 1;
            this.tmr_my_bullets.Tick += new System.EventHandler(this.tmr_my_bullets_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPACE_SHOOTER.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(784, 528);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.When_Key_Down);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.When_Key_Pressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrEnemies;
        private System.Windows.Forms.Timer tmrEnemies2;
        private System.Windows.Forms.Timer tmrEnemies3;
        private System.Windows.Forms.Timer tmrEnemies4;
        private System.Windows.Forms.Timer tmrEnemies5;
        private System.Windows.Forms.Timer tmr_my_bullets;
    }
}

