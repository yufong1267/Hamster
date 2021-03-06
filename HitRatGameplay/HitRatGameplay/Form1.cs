﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //调用WINDOWS API函数时要用到
using Microsoft.Win32; //写入注册表时要用到
using System;
using System.Threading;
using System.Drawing.Drawing2D;

namespace HitRatGameplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        
        private int left_time = 3000;

        private char ran_rat = 'A'; //default
        private int Final_Point = 0;
        //定義遊戲按鍵
        private char[] sign = new char[] { 'A' , 'S' , 'D' };
        private Random rnd = null;
        //定義rat
        private Button rat = null;
        private void Form1_Load(object sender, EventArgs e )
        {
            
            this.Text = "打地鼠";
            Timeleft.Size = new Size(100, 50);
            //建立亂數
            Random reg  = new Random(Guid.NewGuid().GetHashCode());
            rnd = reg;

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            animation_timer = new System.Windows.Forms.Timer();
            animation_timer.Interval = 1;
            animation_timer.Tick += new EventHandler(animation_timer_Tick);

            killrat_timer = new System.Windows.Forms.Timer();
            killrat_timer.Interval = 1;
            killrat_timer.Tick += new EventHandler(killrat_timer_Tick);
        }

        private bool rat_to_bottom = false;
        private bool point_added = false;
        private void btn_Click(object sender, EventArgs e)
        {
            //確認按下A 這邊做 確認random = 1 確認後random要做更換圖片(往下移/往上移)
               if(ran_rat == 'A')
                {
                
                animation_timer.Enabled = false;
                killrat_timer.Enabled = true;
                if(rat_to_bottom)
                {
                    rat.Dispose();
                    this.Controls.Remove(rat);
                    rat_alive = false;
                    if (!point_added)
                    {//檢查分數加過沒
                        Final_Point++;
                        point_added = true;
                    }
                    rat_to_bottom = false;
                    killrat_timer.Enabled = false;
                }
                }
        }

        private bool pressed = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && !pressed)
            {
                malletA.Image = new Bitmap(Properties.Resources.iron);
                btn_Click(null, null);
                pressed = true;
            }
            if (e.KeyCode == Keys.S && !pressed)
            {
                malletS.Image = new Bitmap(Properties.Resources.iron);
                button2_Click(null, null);
                pressed = true;
            }
            if (e.KeyCode == Keys.D && !pressed)
            {
                malletD.Image = new Bitmap(Properties.Resources.iron);
                Dpress_Click(null, null);
                pressed = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //這邊按S
            //這邊做 確認random 確認後random = 2要做更換圖片(往下移/往上移)
            if (ran_rat == 'S')
            {
                
                animation_timer.Enabled = false;
                killrat_timer.Enabled = true;
                //這邊放animation
                if(rat_to_bottom)
                {
                    rat.Dispose();
                    this.Controls.Remove(rat);
                    rat_alive = false;
                    if (!point_added)
                    {//檢查分數加過沒
                        Final_Point++;
                        point_added = true;
                    }
                    rat_to_bottom = false;
                    killrat_timer.Enabled = false;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //這邊解除已經按下
            pressed = false;
            malletA.Image = new Bitmap(Properties.Resources.iron2);
            malletS.Image = new Bitmap(Properties.Resources.iron2);
            malletD.Image = new Bitmap(Properties.Resources.iron2);
        }

        private void Dpress_Click(object sender, EventArgs e)
        {
            //確認按下的"D" 確認random 確認後random = 3要做更換圖片(往下移/往上移)
            if (ran_rat == 'D')
            {
                
                animation_timer.Enabled = false;
                killrat_timer.Enabled = true;
                if(rat_to_bottom)
                {
                    rat.Dispose();
                    this.Controls.Remove(rat);
                    rat_alive = false;
                    if (!point_added)
                    {
                        //檢查分數加過沒
                        Final_Point++;
                        point_added = true;
                    }
                    rat_to_bottom = false;
                    killrat_timer.Enabled = false;
                }  
            }
        }

        private bool rat_alive = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (left_time == 1)
            {
                timer1.Stop();
                MessageBox.Show("最後的分數是" + Final_Point);
                Application.Restart();
            }
            left_time--;
            Timeleft.Text = "剩下：" + left_time / 100 + "." + left_time % 100 + "\n 現在的分數是：" + Final_Point;

            if (left_time % 50 == 0 && !rat_alive)
            {
                rat_alive = true;
                ran_rat = sign[rnd.Next(0,3)];
                //這邊生成1隻地鼠
                Button reg_btn = new Button();
                reg_btn.Size = new Size(100, 100);
                // reg_btn.Text = "我是地鼠";
                reg_btn.Image = new Bitmap(Properties.Resources.rat2);
                    
                switch(ran_rat)
                {
                    case 'A':
                        reg_btn.Location = new Point(Apress.Location.X, Apress.Location.Y - 52);
                        break;
                    case 'S':
                        reg_btn.Location = new Point(Spress.Location.X, Spress.Location.Y - 52);
                        break;
                    case 'D':
                        reg_btn.Location = new Point(Dpress.Location.X, Dpress.Location.Y - 52);
                        break;
                }
                rat = reg_btn;
                this.Controls.Add(rat);
                //新物件分數重算
                point_added = false;
                killrat_timer.Enabled = false;
                animation_timer.Enabled = true;
                delay_time = 46;
            }

        }

        private int delay_time = 46;
        private void animation_timer_Tick(object sender, EventArgs e)
        {
            //do nothing just for delay
            delay_time-=5; 
              
            rat.Top--;
            if(rat.Top <= 200)
            {
                animation_timer.Enabled = false;
                rat_to_bottom = false;
            }
            if(delay_time == 1)
            {
                animation_timer.Stop();
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void killrat_timer_Tick(object sender, EventArgs e)
        {
            delay_time++;
            rat.Top+=3;
            if (rat.Top >= 400)
            {
                animation_timer.Enabled = false;
                rat_to_bottom = true;
                switch (ran_rat)
                {
                    case 'A':
                        btn_Click(null, null);
                        break;
                    case 'S':
                        button2_Click(null, null);
                        break;
                    case 'D':
                        Dpress_Click(null, null);
                        break;
                }
            }

            if (delay_time == 46)
            {
                animation_timer.Stop();
            }
        }
    }
}
