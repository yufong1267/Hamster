namespace HitRatGameplay
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Spress = new System.Windows.Forms.Button();
            this.Dpress = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timeleft = new System.Windows.Forms.Label();
            this.animation_timer = new System.Windows.Forms.Timer(this.components);
            this.test = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.killrat_timer = new System.Windows.Forms.Timer(this.components);
            this.Apress = new System.Windows.Forms.Button();
            this.malletA = new System.Windows.Forms.Button();
            this.malletS = new System.Windows.Forms.Button();
            this.malletD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Spress
            // 
            this.Spress.Location = new System.Drawing.Point(142, 379);
            this.Spress.Name = "Spress";
            this.Spress.Size = new System.Drawing.Size(100, 100);
            this.Spress.TabIndex = 1;
            this.Spress.Text = "按S";
            this.Spress.UseVisualStyleBackColor = true;
            this.Spress.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dpress
            // 
            this.Dpress.Location = new System.Drawing.Point(276, 379);
            this.Dpress.Name = "Dpress";
            this.Dpress.Size = new System.Drawing.Size(100, 100);
            this.Dpress.TabIndex = 2;
            this.Dpress.Text = "按D";
            this.Dpress.UseVisualStyleBackColor = true;
            this.Dpress.Click += new System.EventHandler(this.Dpress_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timeleft
            // 
            this.Timeleft.AutoSize = true;
            this.Timeleft.Location = new System.Drawing.Point(600, 25);
            this.Timeleft.Name = "Timeleft";
            this.Timeleft.Size = new System.Drawing.Size(39, 15);
            this.Timeleft.TabIndex = 3;
            this.Timeleft.Text = "30:00";
            // 
            // animation_timer
            // 
            this.animation_timer.Tick += new System.EventHandler(this.animation_timer_Tick);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(667, 109);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(0, 15);
            this.test.TabIndex = 4;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(564, 418);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "結束";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // killrat_timer
            // 
            this.killrat_timer.Tick += new System.EventHandler(this.killrat_timer_Tick);
            // 
            // Apress
            // 
            this.Apress.Location = new System.Drawing.Point(12, 379);
            this.Apress.Name = "Apress";
            this.Apress.Size = new System.Drawing.Size(100, 100);
            this.Apress.TabIndex = 0;
            this.Apress.Text = "按A";
            this.Apress.UseVisualStyleBackColor = true;
            this.Apress.Click += new System.EventHandler(this.btn_Click);
            // 
            // malletA
            // 
            this.malletA.Image = global::HitRatGameplay.Properties.Resources.iron2;
            this.malletA.Location = new System.Drawing.Point(12, 172);
            this.malletA.Name = "malletA";
            this.malletA.Size = new System.Drawing.Size(100, 100);
            this.malletA.TabIndex = 6;
            this.malletA.UseVisualStyleBackColor = true;
            // 
            // malletS
            // 
            this.malletS.Image = global::HitRatGameplay.Properties.Resources.iron2;
            this.malletS.Location = new System.Drawing.Point(142, 172);
            this.malletS.Name = "malletS";
            this.malletS.Size = new System.Drawing.Size(100, 100);
            this.malletS.TabIndex = 7;
            this.malletS.UseVisualStyleBackColor = true;
            // 
            // malletD
            // 
            this.malletD.Image = global::HitRatGameplay.Properties.Resources.iron2;
            this.malletD.Location = new System.Drawing.Point(276, 172);
            this.malletD.Name = "malletD";
            this.malletD.Size = new System.Drawing.Size(100, 100);
            this.malletD.TabIndex = 8;
            this.malletD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(731, 479);
            this.Controls.Add(this.malletD);
            this.Controls.Add(this.malletS);
            this.Controls.Add(this.malletA);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.test);
            this.Controls.Add(this.Timeleft);
            this.Controls.Add(this.Dpress);
            this.Controls.Add(this.Spress);
            this.Controls.Add(this.Apress);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "sdaasaddsadsaadsadddsaads";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Apress;
        private System.Windows.Forms.Button Spress;
        private System.Windows.Forms.Button Dpress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Timeleft;
        private System.Windows.Forms.Timer animation_timer;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Timer killrat_timer;
        private System.Windows.Forms.Button malletA;
        private System.Windows.Forms.Button malletS;
        private System.Windows.Forms.Button malletD;
    }
}

