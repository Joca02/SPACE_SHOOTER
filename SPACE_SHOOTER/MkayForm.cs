using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPACE_SHOOTER
{
    public partial class MkayForm : Form
    {
        PictureBox mr_mackey = new PictureBox();
        PictureBox player = new PictureBox();
        List<PictureBox> my_bullets = new List<PictureBox>();
        Random rnd = new Random();
        public MkayForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            lblWin.Hide();
            lblLose.Hide();
            lblNoBullets.Hide();

            player.Image=Properties.Resources.player_ship;
            player.Size = new Size(60, 60);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.Location = new Point(Width/2-player.Width/2, Height-2*player.Height);
            player.BackColor=Color.Transparent;
            this.Controls.Add(player);

            mr_mackey.Image=Properties.Resources.Mr_mackey;
            mr_mackey.Size = new Size(100, 100);
            mr_mackey.SizeMode = PictureBoxSizeMode.StretchImage;
            mr_mackey.Location = new Point(Width/2-mr_mackey.Width/2,-mr_mackey.Width);
            mr_mackey.BackColor=Color.Transparent;
            this.Controls.Add(mr_mackey);
        }

        private void tmrMackey_Tick(object sender, EventArgs e)
        {
            int move_for = 5;
            if (mr_mackey.Top<20)
                mr_mackey.Top+=move_for;
            else
            {
                tmrMackey.Interval=100;
                move_for=rnd.Next(10,30);  
               
                bool to_left = (rnd.Next(2)==1);

                if(to_left==true)
                {
                    if (mr_mackey.Left-move_for>0)
                        mr_mackey.Left-=move_for;
                }

                else
                {
                    if (mr_mackey.Left+move_for+mr_mackey.Width<Width)
                        mr_mackey.Left+=move_for;
                }
            }
            


            
        }

        bool game_active = true;
        private void MkayForm_KeyUp(object sender, KeyEventArgs e)
        {
            if(game_active==true)
            {
                int move_for_value = 50;
                if (e.KeyCode == Keys.A)
                {
                    if (player.Left-move_for_value>0)
                        player.Left-=move_for_value;
                }

                else if (e.KeyCode==Keys.D)
                {
                    if (player.Left+move_for_value+player.Width<Width)
                        player.Left+=move_for_value;
                }

                else if (e.KeyCode==Keys.Space)
                {
                    add_Bullet();
                }
            }
            if(e.KeyCode==Keys.Escape)
                this.Close();
            
        }


        public void add_Bullet()
        {
            if (my_bullets.Count<3)
            {
                PictureBox bullet = new PictureBox();
                bullet.Width = 20;
                bullet.Height=40;
                bullet.Image=Properties.Resources.PLAYER_bullet;
                bullet.BackColor=Color.Transparent;
                bullet.SizeMode=PictureBoxSizeMode.StretchImage;
                bullet.Location=new Point(player.Left+player.Width/2-bullet.Width/2, player.Top-bullet.Height);
                my_bullets.Add(bullet);
                Controls.Add(bullet);
            }
            else
            {
                lblNoBullets.Show();
            }

        }

        int Mackey_Health = 100;

        private void tmr_my_bullets_Tick(object sender, EventArgs e)
        {
            for (int k = my_bullets.Count - 1; k >= 0; k--)
            {
                my_bullets[k].Top -= 45;
                if (my_bullets[k].Top<0)
                {
                    Controls.Remove(my_bullets[k]);
                    my_bullets.RemoveAt(k);
                    lblNoBullets.Hide();
                }
                else if(my_bullets[k].Bounds.IntersectsWith(mr_mackey.Bounds))
                {
                    Mackey_Health-=4;
                    Controls.Remove(my_bullets[k]);
                    my_bullets.RemoveAt(k);
                    lblNoBullets.Hide();
                }
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            if (Mackey_Health<=0)
            {
                Controls.Remove(mr_mackey);
                tmrMackey.Stop();
                tmrGenerateMkay.Stop();
                tmrMoveLabels.Stop();
                game_active=false;
                lblWin.Show();
            }
            else if(game_active==false && Mackey_Health>0)
            {

                player.Image=Properties.Resources.explosion;
                player.Size=new Size(80, 80);
                lblLose.Show();
            }
                
        }
        List<Label>mkay=new List<Label>();
        private void tmrGenerateMkay_Tick(object sender, EventArgs e)
        {
            int lbl_count=rnd.Next(1,4);
            while(lbl_count>0)
            {
                Label lbl = new Label();
                lbl.Text = "Mkay";

                lbl.Font = new Font("Arial", 13, FontStyle.Regular);
                lbl.BackColor = Color.Green;
                lbl.Width=60;
                int top = -rnd.Next(50);
                int left = rnd.Next(0, Width-lbl.Width);
                lbl.Location = new Point(left, top);
                lbl.TextAlign=ContentAlignment.MiddleCenter;
                lbl.ForeColor = Color.White;
                mkay.Add(lbl);
                Controls.Add(lbl);
                lbl_count--;
            }
           
        }

        private void tmrMoveLabels_Tick(object sender, EventArgs e)
        {
            for(int i=0;i<mkay.Count;i++)
            {
                mkay[i].Top+=10;
                if(mkay[i].Top>Height)
                {
                    Controls.Remove(mkay[i]);
                    mkay.RemoveAt(i);
                }
                else if(mkay[i].Bounds.IntersectsWith(player.Bounds))
                {
                    game_active=false;
                }
            }
        }
    }
}
