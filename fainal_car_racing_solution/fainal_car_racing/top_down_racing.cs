using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading.Tasks;

namespace fainal_car_racing
{

    // Coding MD BAIJID HOSSAIN
    // Student at bogra polytechnic institute




    public partial class Form_top_down_racing : Form
    {
        bool started = false;
       

        int [] enemylocation= new int[12];
        int enemy1car =0, enemy2car = -75, enemy3car = -145, enemy4car = -215, enemy5car = -285, enemy6car = -355, enemy7car = -425, enemy8car = -495, enemy9car = -565, enemy10car = -635, enemy11car = -705, enemy12car =-775;

        int tawarscor = 0,tawarscor2=0;

        int[] topp= new int[12];
        int top1 = 1000, top2 = 1200, top3 = 1300, top4 = 1400, top5=800, top6=900,top7=800,top8=1300,top9=1400,top10=1300,top11=1200,top12=1000;

        SoundPlayer gamebackroundsound = new SoundPlayer(fainal_car_racing.Properties.Resources.Minimal_Electro_Beat_120_bpm___Best_Online_SFX_Library);
        SoundPlayer caraccidentsound = new SoundPlayer(fainal_car_racing.Properties.Resources.Car_Crash_Sounds___Download_Car_Crash_Sound_Effects_1);
        PictureBox[] tracline = new PictureBox[8];
        PictureBox[] star = new PictureBox[7];
        PictureBox[] enemycar = new PictureBox[12];
        int x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12;
        int[] int2 = new int[12];      
        int[] intt = new int[7];
        int star1, star2, star3, star4, star5, star6, star7;
        int scoreret;
        int currentspeed;
        int ene1, ene2, ene3, ene4;
        int playerspeed;
        int enemyspeedcontrol;
        int playertotalpoint;
       
        public Form_top_down_racing()
        {

            

            InitializeComponent();
            ///Car Crash Sounds - Download Car Crash Sound Effects        
           /// groupBox1.Visible = true;
           /// 

         
            total_scor_txt.Visible = false;
            game_over_txt.Visible = false;
          
            start_btn2.Visible = false;
            timer1.Enabled = false;
            groupBox2.Visible = false;
            int a = ene1 + ene2 + ene3 + ene4;
            player2.Text = ene1.ToString();
        }

        private void gameover()
        {

            for (int index = 0; index < 12; index++)
            {

                if (player.Bounds.IntersectsWith(enemycar[index].Bounds))
                {

                    if (player.Height < 100 & player.Width < 40)
                    {

                        fire_picturebox.Left = player.Left +-1;
                        fire_picturebox.Top = player.Top +-8;
                        fire_picturebox.Visible = true;
                      



                        timer1.Stop();
                        timer2.Stop();
                        score = 0;
                        Score_txt.Text = "Score: 0";
          
                        timer1.Enabled = false;
                        game_over_txt.Visible = true;
                        speed_txt.Text = "Speed:0 " + "kmph";
                        total_scor_txt.Text = "score: " + scoreret.ToString();
                        groupBox1.Visible = true;
                        total_scor_txt.Visible = true;
                        groupBox1.Enabled = true;

                   

                       // button4.FlatStyle = FlatStyle.Flat;

                        tawarscor = 0;
                        label6.Text = "0";
                        tawar1.BackColor = Color.LightGray;
                        tawar2.BackColor = Color.LightGray;
                        tawar3.BackColor = Color.LightGray;
                        tawar4.BackColor = Color.LightGray;
                        tawar5.BackColor = Color.LightGray;
                        if (timer1.Enabled == false)
                        {
                            gamebackroundsound.Stop();
                        }

                        if (timer1.Enabled == false)
                        {
                            caraccidentsound.Play();
                        }
                    }
                }
            }
            }
       // Track line

        int tracktop = 535;
        private void track_line(int speed)
        {

            if (tawarcontroll.Top >= 400)
            {
                tawarcontroll.Top = 0;

                tawarscor++;
                //tawarscor2 = tawarscor;
                if (tawarscor > 5)
                {
                    tawarscor -= 1;
                }

                if (tawarscor <= 5)
                {
                    label6.Text = tawarscor.ToString();
                }

              //  ss = rnd.Next(0, 100);
               /// tawarcontroll.Location = new Point(ss, 0);
            }
            else
            {
                tawarcontroll.Top += 2;
            }
           
            if (tawarscor>0&&tawarscor <= 1)
            {
                tawar1.BackColor = Color.Red;
                tawar2.BackColor = Color.LightGray;
                tawar3.BackColor = Color.LightGray;
                tawar4.BackColor = Color.LightGray;
                tawar5.BackColor = Color.LightGray;
            }
            if (tawarscor > 1 && tawarscor <= 2)
            {
                tawar1.BackColor = Color.Red;
                tawar2.BackColor = Color.Red;
                tawar3.BackColor = Color.LightGray;
                tawar4.BackColor = Color.LightGray;
                tawar5.BackColor = Color.LightGray;
            }
            if (tawarscor >2 && tawarscor <= 3)
            {
                tawar1.BackColor = Color.Red;
                tawar2.BackColor = Color.Red;
                tawar3.BackColor = Color.Red;
                tawar4.BackColor = Color.LightGray;
                tawar5.BackColor = Color.LightGray;

            }
            if (tawarscor >3 && tawarscor <= 4)
            {

                tawar1.BackColor = Color.Red;
                tawar2.BackColor = Color.Red;
                tawar3.BackColor = Color.Red;
                tawar4.BackColor = Color.Red;
                tawar5.BackColor = Color.LightGray;

            }
            if (tawarscor >4 && tawarscor <= 5)
            {
                tawar1.BackColor = Color.Red;
                tawar2.BackColor = Color.Red;
                tawar3.BackColor = Color.Red;
                tawar4.BackColor = Color.Red;
                tawar5.BackColor = Color.Red;
            }
            if (tawarscor == 0)
            {
                tawar1.BackColor = Color.LightGray;
                tawar2.BackColor = Color.LightGray;
                tawar3.BackColor = Color.LightGray;
                tawar4.BackColor = Color.LightGray;
                tawar5.BackColor = Color.LightGray;
            }

            for (int index2 = 0; index2 < 8; index2++)
            {
                if (tracline[index2].Top >=535)
                {
                    tracline[index2].Top = 0;
                    
                }
                else
                {
                    tracline[index2].Top += speed;
                }
            }

            ////random enemy
            Random rnd = new Random();
            int toop = 535;
            for (int index5 = 0; index5 < 12; index5++)
            {


                if (enemycar[index5].Top >=580)
                {
                 
                 
                    ene1++;
                    ene11.Text = ene1.ToString();
                    ene2++;
                    ene22.Text = ene2.ToString();
                    ene3++;
                    ene33.Text = ene3.ToString();
                    ene4++;
                    ene44.Text = ene4.ToString();
                    totalscore2.Text = player.ToString();
                    score++;

                    //scoreret = score;
                   // Score_txt.Text = "score: " + scoreret;
                    

                    scoreret = score;
                    Score_txt.Text = "score: " + scoreret;
                    for (int index6 = 0; index6 < 12; index6++)
                    {

                        int2[index6] = rnd.Next(0, 380);
                        enemycar[index5].Location = new Point(int2[index6], enemylocation[index6]);
                    }
                }

                else
                {
                    enemycar[index5].Top += speed;
                }
            }
            if (player_control.Top == 100)
            {
                player.Height = 60;
                player.Width = 28;
            }
            else
            {
                player_control.Top += 2;

            }
            if (player_control.Top < 100)
            {
                player.Top -= 1;
            }


            if (enemy_speed_control.Top >= 580)
            {
                playerspeed++;
                currentspeed += 1;
                speed_txt.Text = "Speed:" + currentspeed + " Kmph".ToString();
                currentspeed++;
               // ene4++;
               // ene44.Text = ene4.ToString();
               // score++;
               // scoreret = score;
               // Score_txt.Text = "score" + scoreret;
                x4 = rnd.Next(0, 300);
                enemy_speed_control.Location = new Point(x4, 0);
            }

            else
            {
                enemy_speed_control.Top += enemyspeedcontrol;

            }

         



            for (int index3 = 0; index3 < 7; index3++)
            {

                if (star[index3].Top >= toop)
                {
                    for (int index4 = 0; index4 < 7; index4++)
                    {
                        intt[index4] = rnd.Next(0, 500);
                    }
                    star[index3].Location = new Point(intt[index3], 0);
                }

                else
                {
                    star[index3].Top += starspeed;
                }

            }

        }

        // random closs enemy
        private void Form1_Load(object sender, EventArgs e)
        {
       




            if (timer1.Enabled == true)
            {
                timer2.Enabled = false;
            }

            player.BackColor = Color.Transparent;
            /// track line aray
            tracline[0] = track_1;
            tracline[1] = track_2;
            tracline[2] = track_3;
            tracline[3] = track_4;
            tracline[4] = track_5;
            tracline[5] = track_6;
            tracline[6] = track_7;
            tracline[7] = track_8;
            //star picturebox aray
            star[0] = star_1;
            star[1] = star_2;
            star[2] = star_3;
            star[3] = star_4;
            star[4] = star_5;
            star[5] = star_6;
            star[6] = star_7;
            //star variable
            intt[0] = star1;
            intt[1] = star2;
            intt[2] = star3;
            intt[3] = star4;
            intt[4] = star5;
            intt[5] = star6;
            intt[6] = star7;
            //enemycare  aeay      
            enemycar[0] = enemy_1;
            enemycar[1] = enemy_3;
            enemycar[2] = enemy_5;
            enemycar[3] = enemy_6;
            enemycar[4] = enemy_9;
            enemycar[5] = enemy_12;
            enemycar[6] = enemy_2;
            enemycar[7] = enemy_4;
            enemycar[8] = enemy_8;
            enemycar[9] = enemy_7;
            enemycar[10] = enemy_10;
            enemycar[11] = enemy_11;
            //enemycar[6] = enemy_control;
            //enemy car variable
            int2[0] = x1;
            int2[1] = x2;
            int2[2] = x3;
            int2[3] = x4;
            int2[4] = x5;
            int2[5] = x6;
            int2[6] = x7;
            int2[7] = x8;
            int2[8] = x9;
            int2[9] = x10;
            int2[10] = x11;
            int2[11] = x12;

            topp[0] = top1;
            topp[1] = top2;
            topp[2] = top3;
            topp[3] = top4;
            topp[4] = top5;
            topp[5] = top6;
            topp[6] = top7;
            topp[7] = top8;
            topp[8] = top9;
            topp[9] = top10;
            topp[10] = top11;
            topp[11] = top12;

            ///////
            enemylocation[0] = enemy1car;
            enemylocation[1] = enemy2car;
            enemylocation[2] = enemy3car;
            enemylocation[3] = enemy4car;
            enemylocation[4] = enemy5car;
            enemylocation[5] = enemy6car;
            enemylocation[6] = enemy7car;
            enemylocation[7] = enemy8car;
            enemylocation[8] = enemy9car;
            enemylocation[9] = enemy10car;
            enemylocation[10] = enemy11car;
            enemylocation[11] = enemy12car;



           // player.Location = new Point(180, 430);


        }
      
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch(e.KeyCode)
            {
                case Keys.Right:

                    if (player.Left < 343)
                    {
                        player.Left += 20;

                    }
                    break;

                case Keys.Left:

                    if (player.Left > 10)
                    {
                        player.Left -= 20;

                    }
                    break;
                case Keys.Up:
                    if (player.Top > 30)
                    {
                        player.Top -= 30;

                    }
                    break;
                case Keys.Down:

                    if (player.Top < 460)
                    {
                        player.Top += 30;
                    }
                    break;
                case Keys.Space:

                    if (tawarscor>0)
                   {

                       player.Height = 110;
                       player.Width = 41;


                      tawarscor -= 1;
                    
                       label6.Text = "" + tawarscor;
                       player_control.Top = 0;
                     
                    }
                    break;
                case Keys.S:

                    if (start_btn2.Visible == true)
                    {
                        playerspeed = currentspeed;
                        timer1.Enabled = true;
                        start_btn2.Visible = false;
                        groupBox1.Visible = false;
                        gamebackroundsound.PlayLooping();
                    }
                    else
                    {
                        if (timer1.Enabled == true)
                        {
                            timer1.Enabled = false;

                            start_btn2.Visible = true;
                            gamebackroundsound.Stop();
                        }
                    }
                    break;
                case Keys.B:

                    fire_picturebox.Visible = false;
                enemyspeedcontrol = 1;
                groupBox1.Visible = false;
                if (playerspeed < 51)
                {
                    timer1.Enabled = true;
                    if(timer1.Enabled==true)
                    {
                         playerspeed++;
                         currentspeed++;
                    }
                   
                  
                    speed_txt.Text = "Speed:" + currentspeed + " Kmph".ToString();
         
                }


                if (timer1.Enabled == true)
                {
                    gamebackroundsound.PlayLooping();
                }
                break;
                case Keys.L:
                if (playerspeed > 0)
                {
                    playerspeed--;
                    speed_txt.Text = "Speed:" + currentspeed + " Kmph".ToString();
                    currentspeed--;

                }
                break;
                case Keys.Enter:
                fire_picturebox.Visible = false;
              
                gamebackroundsound.PlayLooping();
              
                if (start_btn2.Visible == true)
                {
                    timer1.Enabled = true;
                    playerspeed = currentspeed;
                    start_btn2.Visible = false;
                }


                if (timer1.Enabled == false)
                {
                    timer1.Start();
                    timer2.Start();

                    enemyspeedcontrol = 1;
                    groupBox2.Visible = false;
                    groupBox1.Visible = false;
                    start_btn2.Visible = false;

                    Score_txt.Text = "";
                    playerspeed = 1;
                    currentspeed = 1;
                    speed_txt.Text = "Speed:" + currentspeed + " Kmph".ToString();
                    enemyspeedcontrol = 1;
                    timer1.Enabled = true;

                    player.Location = new Point(180, 430);

                  //  enemy_1.Top = 700;
                    //enemy_2.Top = 600;
                    //enemy_3.Top = 500;
                    //enemy_4.Top = 530;
                    //enemy_5.Top = 800;
                    //enemy_6.Top = 900;

                  //  enemy_7.Top = 1100;
                    //enemy_8.Top = 1300;
                    //enemy_9.Top = 1200;
                    //enemy_10.Top = 1400;
                    //enemy_11.Top = 1600;
                    //enemy_12.Top = 1500;

                  
                  

                        for (int index13 = 0; index13 < 12; index13++)
                        {
                            enemycar[index13].Top = enemylocation[index13];
                        }
                    
                    
                    if (timer1.Enabled == true)
                    {

                        gamebackroundsound.PlayLooping();
                    }


                }
                player.Visible = true;

                break;
                   


            }



          
        }
        int score = 0;
        int starspeed;


        private void timer1_Tick(object sender, EventArgs e)
        {
        

            track_line(playerspeed);
            gameover();
            starspeed = 5;
            playertotalpoint = ene1 + ene2 + ene3 + ene4;
            player2.Text = playertotalpoint.ToString();
            totalscore2.Text = "Last total score " + scoreret.ToString();
            lastspeed.Text = "High speed " + currentspeed + " Kmph";
            // 
            //currentspeed++;
            if (timer1.Enabled == true)
            {
                time_lvl.Text = DateTime.Now.ToLongTimeString();

            }
            if (timer1.Enabled == false)
            {
                time_end.Text = "Time end: " + DateTime.Now.ToLongTimeString();
              
            }

          

        }

    

        private void label1_Click_1(object sender, EventArgs e)
        {
            fire_picturebox.Visible = false;
            playerspeed = currentspeed;
            timer1.Enabled = true;
            start_btn2.Visible = false;
            groupBox1.Visible = false;
            gamebackroundsound.PlayLooping();

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {

                groupBox2.Visible = true;
                groupBox2.Height = 700;
                groupBox2.Width = 535;
            }
            else
            {
                MessageBox.Show("Game is stop next for details");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fire_picturebox.Visible = false;
            

            Form_top_down_racing game = new Form_top_down_racing();
            game.Show();
            groupBox2.Visible = false;
            if (Form_top_down_racing.ActiveForm.Visible == true)
            {
                Form_top_down_racing.ActiveForm.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                time_start.Text = "Time start" + DateTime.Now.ToLongTimeString();
                timer2.Stop();
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fire_picturebox.Visible = false;

            gamebackroundsound.PlayLooping();

            if (start_btn2.Visible == true)
            {
                timer1.Enabled = true;
                playerspeed = currentspeed;
                start_btn2.Visible = false;
            }


            if (timer1.Enabled == false)
            {
                timer1.Start();
                timer2.Start();

                enemyspeedcontrol = 1;
                groupBox2.Visible = false;
                groupBox1.Visible = false;
                start_btn2.Visible = false;

                Score_txt.Text = "";
                playerspeed = 1;
                currentspeed = 1;
                speed_txt.Text = "Speed:" + currentspeed + " Kmph".ToString();
                enemyspeedcontrol = 1;
                timer1.Enabled = true;

                player.Location = new Point(180, 430);

                //  enemy_1.Top = 700;
                //enemy_2.Top = 600;
                //enemy_3.Top = 500;
                //enemy_4.Top = 530;
                //enemy_5.Top = 800;
                //enemy_6.Top = 900;

                //  enemy_7.Top = 1100;
                //enemy_8.Top = 1300;
                //enemy_9.Top = 1200;
                //enemy_10.Top = 1400;
                //enemy_11.Top = 1600;
                //enemy_12.Top = 1500;




                for (int index13 = 0; index13 < 12; index13++)
                {
                    enemycar[index13].Top = enemylocation[index13];
                }


                if (timer1.Enabled == true)
                {

                    gamebackroundsound.PlayLooping();
                }


            }
            player.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        
            fire_picturebox.Visible = false;
          

            gamebackroundsound.PlayLooping();

            if (start_btn2.Visible == true)
            {
                timer1.Enabled = true;
                playerspeed = currentspeed;
                start_btn2.Visible = false;
            }


            if (timer1.Enabled == false)
            {
                timer1.Start();
                timer2.Start();

                enemyspeedcontrol = 1;
                groupBox2.Visible = false;
                groupBox1.Visible = false;
                start_btn2.Visible = false;
                groupBox1.Enabled = false;

                Score_txt.Text = "";
                playerspeed = 1;
                currentspeed = 1;
                speed_txt.Text = "Speed:" + currentspeed + " Kmph".ToString();
                enemyspeedcontrol = 1;
                timer1.Enabled = true;

                player.Location = new Point(180, 430);

                //  enemy_1.Top = 700;
                //enemy_2.Top = 600;
                //enemy_3.Top = 500;
                //enemy_4.Top = 530;
                //enemy_5.Top = 800;
                //enemy_6.Top = 900;

                //  enemy_7.Top = 1100;
                //enemy_8.Top = 1300;
                //enemy_9.Top = 1200;
                //enemy_10.Top = 1400;
                //enemy_11.Top = 1600;
                //enemy_12.Top = 1500;




                for (int index13 = 0; index13 < 12; index13++)
                {
                    enemycar[index13].Top = enemylocation[index13];
                }


                if (timer1.Enabled == true)
                {

                    gamebackroundsound.PlayLooping();
                }


            }
            player.Visible = true;
        }

      
        private void button3_Click_2(object sender, EventArgs e)
        {

            fire_picturebox.Visible = false;


            gamebackroundsound.PlayLooping();

            if (start_btn2.Visible == true)
            {
                timer1.Enabled = true;
                playerspeed = currentspeed;
                start_btn2.Visible = false;
            }


            if (timer1.Enabled == false)
            {
                timer1.Start();
                timer2.Start();

                enemyspeedcontrol = 1;
                groupBox2.Visible = false;
                groupBox1.Visible = false;
                start_btn2.Visible = false;
                groupBox1.Enabled = false;

                Score_txt.Text = "";
                playerspeed = 1;
                currentspeed = 1;
                speed_txt.Text = "Speed:" + currentspeed + " Kmph".ToString();
                enemyspeedcontrol = 1;
                timer1.Enabled = true;

                player.Location = new Point(180, 430);

                //  enemy_1.Top = 700;
                //enemy_2.Top = 600;
                //enemy_3.Top = 500;
                //enemy_4.Top = 530;
                //enemy_5.Top = 800;
                //enemy_6.Top = 900;

                //  enemy_7.Top = 1100;
                //enemy_8.Top = 1300;
                //enemy_9.Top = 1200;
                //enemy_10.Top = 1400;
                //enemy_11.Top = 1600;
                //enemy_12.Top = 1500;




                for (int index13 = 0; index13 < 12; index13++)
                {
                    enemycar[index13].Top = enemylocation[index13];
                }


                if (timer1.Enabled == true)
                {

                    gamebackroundsound.PlayLooping();
                }


            }
            player.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            fire_picturebox.Visible = false;


            gamebackroundsound.PlayLooping();

            if (start_btn2.Visible == true)
            {
                timer1.Enabled = true;
                playerspeed = currentspeed;
                start_btn2.Visible = false;
            }


            if (timer1.Enabled == false)
            {
                timer1.Start();
                timer2.Start();

                enemyspeedcontrol = 1;
                groupBox2.Visible = false;
                groupBox1.Visible = false;
                start_btn2.Visible = false;
                groupBox1.Enabled = false;

                Score_txt.Text = "";
                playerspeed = 1;
                currentspeed = 1;
                speed_txt.Text = "Speed:" + currentspeed + " Kmph".ToString();
                enemyspeedcontrol = 1;
                timer1.Enabled = true;

                player.Location = new Point(180, 430);

                //  enemy_1.Top = 700;
                //enemy_2.Top = 600;
                //enemy_3.Top = 500;
                //enemy_4.Top = 530;
                //enemy_5.Top = 800;
                //enemy_6.Top = 900;

                //  enemy_7.Top = 1100;
                //enemy_8.Top = 1300;
                //enemy_9.Top = 1200;
                //enemy_10.Top = 1400;
                //enemy_11.Top = 1600;
                //enemy_12.Top = 1500;




                for (int index13 = 0; index13 < 12; index13++)
                {
                    enemycar[index13].Top = enemylocation[index13];
                }


                if (timer1.Enabled == true)
                {

                    gamebackroundsound.PlayLooping();
                }


            }
            player.Visible = true;
        }

        private void button3_Click_3(object sender, EventArgs e)
        {

            if (timer1.Enabled == false)
            {

                groupBox2.Visible = true;
                groupBox2.Height = 700;
                groupBox2.Width = 535;
            }
            else
            {
                MessageBox.Show("Game is stop next for details");
            }
        }

      
    }
    
    }




 
        

