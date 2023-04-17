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
        public static bool level_passed=false;
        PictureBox player = new PictureBox();
        List<List<PictureBox>> enemies = new List<List<PictureBox>>();
        List<PictureBox> my_bullets= new List<PictureBox>();
        const int longer_row = 5;
        const int shorter_row = 3;

        bool game_active = true;
        public Form1()
        {
            InitializeComponent();
            
            //Kretanje picturebox-ova je vise smooth
            DoubleBuffered=true;

            Width=800;
            Height=600;
           
            //Postavljam labelu na sredini
            lblNoBullets.Left=Width/2-lblNoBullets.Width/2;
            lblNoBullets.Hide();
            lblLose.Hide();
            lblWin.Hide();

            //DEFINISEM SPACESHIP IGRACA
            /////////////////////////////////////////////////////////////////
            player.Image=Properties.Resources.player_ship;
            player.Size = new Size(30,30);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.Location = new Point(Width/2-player.Width/2, Height-3*player.Height);
            player.BackColor=Color.Transparent;
            this.Controls.Add(player);
            ////////////////////////////////////////////////////////////////// 
            

            //DEFINISEM LISTU LISTI ENEMIES
            //////////////////////////////////////////////////////////////////
            for(int i=0;i<5;i++)
            {
                int column=(i%2==0) ? shorter_row:longer_row;
                enemies.Add(new List<PictureBox>(column));
                for(int j=0;j<column;j++)
                {    
                    enemies[i].Add(new PictureBox());
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

        bool has_won;

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            if(game_active==false)
            {
                if(has_won==true)
                {
                    lblWin.Show();
                    level_passed=true;
                }
                else
                {
                    lblLose.Show();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int move_for_value = 50;
            if(game_active==true)
            {
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

                else if (e.KeyCode==Keys.Enter)
                {
                    //postavi inicijalno tajmere da budu false pa ih ovim postavi na true
                }
                else if (e.KeyCode==Keys.Space)
                {
                    add_Bullet();
                }
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
           
               
        }

        public void add_Bullet()
        {
            if(my_bullets.Count<3)
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


        private void tmr_my_bullets_Tick(object sender, EventArgs e)
        {
            
            for (int k = my_bullets.Count - 1; k >= 0; k--)
            {
                bool has_hit = false;
                my_bullets[k].Top -= 45;
                if(my_bullets[k].Top<0)
                {
                    Controls.Remove(my_bullets[k]);
                    my_bullets.RemoveAt(k);
                    lblNoBullets.Hide();
                }
                    
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
    
                        for (int j = 0; j < enemies[i].Count; j++)
                        {
                            if (my_bullets[k].Bounds.IntersectsWith(enemies[i][j].Bounds))
                            {
                                Controls.Remove(my_bullets[k]);
                                Controls.Remove(enemies[i][j]);
                                my_bullets.RemoveAt(k);
                                enemies[i].RemoveAt(j);
                                has_hit = true;
                                lblNoBullets.Hide();
                                break;
                            }
                            
                        }
                        if (has_hit==true)
                            break;
                    }
                }
               
            }
            Enemies_alive(); //kad crknu da mi se zatvori ekran
         }





        //ZA SVAKI ENEMY RED IMAM PO TAJMER KAKO BI SE POMERANJE BRZE IZVRSILO + KAKO BI PLAYER MOGAO DA REAGUJE NA KOMANDE
        //SA TASTATURE SA STO MANJIM KASNJENJEM
        //////////////////////////////////////////////////////////////////////////////////////////////
        bool[] to_left = { true, false, false, true, false };
        
        void Move_Enemies(int enemy_row_index)
        {
            int columns=enemies[enemy_row_index].Count;
            int move_for_value =10; 
            if (to_left[enemy_row_index]==true)
            {
                if (enemies[enemy_row_index][0].Left-move_for_value>0) 
                {
                    for (int j = 0; j<columns; j++)
                        enemies[enemy_row_index][j].Left-=move_for_value;
                }
                else
                    to_left[enemy_row_index]=false;
            }

            else if (to_left[enemy_row_index]==false)
            {
                if (enemies[enemy_row_index][columns-1].Left+move_for_value+enemies[enemy_row_index][columns-1].Width<Width) 
                {
                    for (int j = columns-1; j>=0; j--)
                        enemies[enemy_row_index][j].Left+=move_for_value;
                }
                else
                    to_left[enemy_row_index] = true;
                
            }
        }

        
        
        private void tmrGenerate_EnemyShot_Tick(object sender, EventArgs e)
        {
            int maximum_bullets = 3;
            int enemies_alive = Enemies_alive();

            if (enemies_alive==2)
                maximum_bullets=2;
            else if (enemies_alive==1)
                maximum_bullets=1;
            else if (enemies_alive==0)
                return;

            Generate_Enemy_bullet(maximum_bullets);
        }

        int Enemies_alive()
        {
            int enemies_alive = 0;
            for (int i = 0; i<enemies.Count; i++)
            {
                for (int j = 0; j<enemies[i].Count; j++)
                {
                    enemies_alive++;
                }
            }
            if (enemies_alive==0)
            {
                has_won=true;
                game_active=false;
            }
                
            return enemies_alive;
        }

        List<PictureBox> enemy_bullets = new List<PictureBox>();
        Random rand = new Random();

        void Generate_Enemy_bullet(int bullet_amount)
        {
            bool first = true;
            
            List<PictureBox>enemy_that_fires=new List<PictureBox>();
            while (bullet_amount!=0)
            {
                tmrEnemies.Stop();
                tmrEnemies2.Stop();
                tmrEnemies3.Stop();
                tmrEnemies4.Stop();
                tmrEnemies5.Stop();
                bool already_firing = false;
                int row;

                do
                {
                    row = rand.Next(enemies.Count);
                } while (enemies[row].Count==0);
                
                int column = rand.Next(enemies[row].Count);
                if(first==true)
                {
                    enemy_that_fires.Add(enemies[row][column]);
                    first=false;
                }
                else
                {
                    for(int i=0; i<enemy_that_fires.Count; i++)
                    {
                        if (enemies[row][column]==enemy_that_fires[i])
                        {
                            already_firing = true;
                            break;
                        }
                    }
                }
                if (already_firing==true)
                    continue;
                enemy_that_fires.Add(enemies[row][column]);
                PictureBox bullet = new PictureBox();
                bullet.Width = 40;
                bullet.Height=40;
                bullet.Image=Properties.Resources.enemy_bullet;
                bullet.BackColor=Color.Transparent;
                bullet.SizeMode=PictureBoxSizeMode.StretchImage;
                bullet.Location=new Point(enemies[row][column].Left, enemies[row][column].Top+enemies[row][column].Height);
                enemy_bullets.Add(bullet);
                Controls.Add(bullet);
                bullet_amount--;
                tmr_enemy_bullets.Start();
            }
        }
        private void tmr_enemy_bullets_Tick(object sender, EventArgs e)
        {
            
            for (int k = 0; k<enemy_bullets.Count; k++)
            {
                
                enemy_bullets[k].Top += 30;
                if (enemy_bullets[k].Top>Height)
                {
                    Controls.Remove(enemy_bullets[k]);
                    enemy_bullets.RemoveAt(k);
                }

                else if (enemy_bullets[k].Bounds.IntersectsWith(player.Bounds))
                {
                    Controls.Remove(enemy_bullets[k]);
                    enemy_bullets.RemoveAt(k);
                    player.Image=Properties.Resources.explosion;
                    player.Size=new Size(50, 50);
                    game_active=false;
                    has_won=false;
                    break;
                }
            }
            if (enemy_bullets.Count==0)
            {
                tmrEnemies.Start();
                tmrEnemies2.Start();
                tmrEnemies3.Start();
                tmrEnemies4.Start();
                tmrEnemies5.Start();
                tmr_enemy_bullets.Stop();
            }
                
        }


        private void tmrEnemies_Tick(object sender, EventArgs e)
        {
            if (enemies[0].Count>0)
                 Move_Enemies(0);
        }
  
        private void tmrEnemies2_Tick(object sender, EventArgs e)
        {
            if (enemies[1].Count>0)
                Move_Enemies(1);
        }

        private void tmrEnemies3_tick(object sender, EventArgs e)
        {
            if (enemies[2].Count>0)
                Move_Enemies(2);
            
        }

        private void tmrEnemies4_Tick(object sender, EventArgs e)
        {
            if (enemies[3].Count>0)
                Move_Enemies(3);   
        }

        private void tmrEnemies5_Tick(object sender, EventArgs e)
        {
            if (enemies[4].Count>0)
                Move_Enemies(4);  
        }
        ///////////////////////////////////////////////////////////////////////////
    }
}
