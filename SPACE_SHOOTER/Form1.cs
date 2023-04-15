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
  
    public partial class Form1 : Form
    {
        PictureBox player = new PictureBox();
        PictureBox[][] enemies = new PictureBox[5][]; //5 redova neprijatelja
        List<PictureBox> my_bullets= new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            /* WindowState = FormWindowState.Maximized;
             Width=1900;
             Height=980;*/

            Width=800;
            Height=600;


            //DEFINISEM SPACESHIP IGRACA
            /////////////////////////////////////////////////////////////////
            player.Image=Properties.Resources.player_ship;
            player.Size = new Size(30,30);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.Location = new Point(Width/2-player.Width/2, Height-3*player.Height);
            player.BackColor=Color.Transparent;
            this.Controls.Add(player);
            ////////////////////////////////////////////////////////////////// 
            

            //DEFINISEM NIZ NIZOVA ENEMIES
            //////////////////////////////////////////////////////////////////
            for(int i=0;i<5;i++)
            {
                int column=(i%2==0) ? 5:8;
                enemies[i]=new PictureBox[column];
                for(int j=0;j<column;j++)
                {    
                    enemies[i][j] = new PictureBox();
                    enemies[i][j].Image=Properties.Resources.enemy;
                    enemies[i][j].Size = new Size(40,40);
                    enemies[i][j].BackColor=Color.Transparent;
                    enemies[i][j].SizeMode=PictureBoxSizeMode.StretchImage;

                    int spacing = Width/2-(column*enemies[i][j].Width)+20;
                    enemies[i][j].Location=new Point(spacing +j*enemies[i][j].Width*2,i*enemies[i][j].Height*2);
                    this.Controls.Add(enemies[i][j]);
                }
            }
            //////////////////////////////////////////////////////////////////

        }

        private void When_Key_Down(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.A)
                player.Left-=15;
            else if (e.KeyCode==Keys.D)
                player.Left+=15;*/
        }

        private void When_Key_Pressed(object sender, KeyPressEventArgs e)
        {
          /*  if (e.KeyChar == 'a')
                player.Left-=15;
            else if (e.KeyChar=='d')
                player.Left+=15;*/
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int move_for_value = 50;
            if (e.KeyCode == Keys.A)
            {
                if(player.Left-move_for_value>0)
                    player.Left-=move_for_value;
            }
               
           else if (e.KeyCode==Keys.D)
            {
                if (player.Left+move_for_value+player.Width<Width)
                    player.Left+=move_for_value;
            }

            else if(e.KeyCode==Keys.Enter)
            {
                //postavi inicijalno tajmere da budu false pa ih ovim postavi na true
            }
            else if(e.KeyCode==Keys.Space)
            {
                add_Bullet();
            }
               
        }

        public void add_Bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Width = 20;
            bullet.Height=40;
            bullet.Image=Properties.Resources.PLAYER_bullet;
            bullet.BackColor=Color.Transparent;
            bullet.SizeMode=PictureBoxSizeMode.StretchImage;
            bullet.Location=new Point(player.Left+player.Width/2-bullet.Width/2,player.Top-bullet.Height);
            my_bullets.Add(bullet);
            Controls.Add(bullet);
        }


        private void tmr_my_bullets_Tick(object sender, EventArgs e)
        {
            
            for (int k = my_bullets.Count - 1; k >= 0; k--)
            {
                bool has_hit = false;
                my_bullets[k].Top -= 45;
                if(my_bullets[k].Top<0)
                    my_bullets.RemoveAt(k);
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int column = (i % 2 == 0) ? 5 : 8;
                        for (int j = 0; j < column; j++)
                        {
                            if (my_bullets[k].Top <= enemies[i][j].Top)
                            {
                                Controls.Remove(my_bullets[k]);
                                my_bullets.RemoveAt(k);
                                has_hit = true;
                                break;
                            }
                        }
                        if (has_hit==true)
                            break;
                    }
                }
               
            }
        
         }





        //ZA SVAKI ENEMY RED IMAM PO TAJMER KAKO BI SE POMERANJE BRZE IZVRSILO + KAKO BI PLAYER MOGAO DA REAGUJE NA KOMANDE
        //SA TASTATURE SA STO MANJIM KASNJENJEM
        //////////////////////////////////////////////////////////////////////////////////////////////
        bool[] to_left = { true, false, false, true, false };
        
        void Move_Enemies(int enemy_index,int column)
        {
            int move_for_value =10; //50
            if (to_left[enemy_index]==true)
            {
                if (enemies[enemy_index][0].Left-move_for_value>0)
                {
                    for (int j = 0; j<column; j++)
                        enemies[enemy_index][j].Left-=move_for_value;
                }
                else
                    to_left[enemy_index]=false;
            }

            else if (to_left[enemy_index]==false)
            {
                if (enemies[enemy_index][column-1].Left+move_for_value+enemies[0][0].Width<Width)
                {
                    for (int j = column-1; j>=0; j--)
                        enemies[enemy_index][j].Left+=move_for_value;
                }
                else
                    to_left[enemy_index] = true;

            }
        }
        private void tmrEnemies_Tick(object sender, EventArgs e)
        {
            Move_Enemies(0, 5);
        }
  
        private void tmrEnemies2_Tick(object sender, EventArgs e)
        {
            Move_Enemies(1, 8);
        }

        private void tmrEnemies3_tick(object sender, EventArgs e)
        {
            Move_Enemies(2, 5);
            
        }

        private void tmrEnemies4_Tick(object sender, EventArgs e)
        {
            Move_Enemies(3, 8);
        }

        private void tmrEnemies5_Tick(object sender, EventArgs e)
        {
            Move_Enemies(4, 5);
        }
        ///////////////////////////////////////////////////////////////////////////
    }
}
