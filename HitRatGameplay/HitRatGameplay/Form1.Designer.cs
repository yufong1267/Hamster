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
            this.Apress = new System.Windows.Forms.Button();
            this.Spress = new System.Windows.Forms.Button();
            this.Dpress = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timeleft = new System.Windows.Forms.Label();
            this.animation_timer = new System.Windows.Forms.Timer(this.components);
            this.test = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.killrat_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Apress
            // 
            this.Apress.Image = global::HitRatGameplay.Properties.Resources.花路米;
            this.Apress.Location = new System.Drawing.Point(12, 384);
            this.Apress.Name = "Apress";
            this.Apress.Size = new System.Drawing.Size(104, 57);
            this.Apress.TabIndex = 0;
            this.Apress.Text = "按A";
            this.Apress.UseVisualStyleBackColor = true;
            this.Apress.Click += new System.EventHandler(this.btn_Click);
            // 
            // Spress
            // 
            this.Spress.Location = new System.Drawing.Point(134, 384);
            this.Spress.Name = "Spress";
            this.Spress.Size = new System.Drawing.Size(85, 57);
            this.Spress.TabIndex = 1;
            this.Spress.Text = "按S";
            this.Spress.UseVisualStyleBackColor = true;
            this.Spress.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dpress
            // 
            this.Dpress.Location = new System.Drawing.Point(249, 384);
            this.Dpress.Name = "Dpress";
            this.Dpress.Size = new System.Drawing.Size(91, 57);
            this.Dpress.TabIndex = 2;
            this.Dpress.Text = "按D";
            this.Dpress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Timeleft.Location = new System.Drawing.Point(667, 20);
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
            this.Quit.Location = new System.Drawing.Point(848, 418);
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(960, 479);
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
    }
}

