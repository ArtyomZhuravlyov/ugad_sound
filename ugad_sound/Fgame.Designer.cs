namespace ugad_sound
{
    partial class Fgame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fgame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_counter1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_counter2 = new System.Windows.Forms.Label();
            this.bt_continue = new System.Windows.Forms.Button();
            this.bt_pause = new System.Windows.Forms.Button();
            this.bt_ago = new System.Windows.Forms.Button();
            this.lb_count_music = new System.Windows.Forms.Label();
            this.progressBar_music = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(1, 301);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(135, 10);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "следующая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(85, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Игрок 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_counter1
            // 
            this.lb_counter1.AutoSize = true;
            this.lb_counter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_counter1.Location = new System.Drawing.Point(103, 57);
            this.lb_counter1.Name = "lb_counter1";
            this.lb_counter1.Size = new System.Drawing.Size(18, 20);
            this.lb_counter1.TabIndex = 3;
            this.lb_counter1.Text = "0";
            this.lb_counter1.Click += new System.EventHandler(this.label2_Click);
            this.lb_counter1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_counter1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(294, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Игрок 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_counter2
            // 
            this.lb_counter2.AutoSize = true;
            this.lb_counter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_counter2.Location = new System.Drawing.Point(315, 57);
            this.lb_counter2.Name = "lb_counter2";
            this.lb_counter2.Size = new System.Drawing.Size(18, 20);
            this.lb_counter2.TabIndex = 5;
            this.lb_counter2.Text = "0";
            this.lb_counter2.Click += new System.EventHandler(this.label4_Click);
            this.lb_counter2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_counter1_MouseClick);
            // 
            // bt_continue
            // 
            this.bt_continue.Location = new System.Drawing.Point(254, 250);
            this.bt_continue.Name = "bt_continue";
            this.bt_continue.Size = new System.Drawing.Size(88, 49);
            this.bt_continue.TabIndex = 6;
            this.bt_continue.Text = "Продолжить";
            this.bt_continue.UseVisualStyleBackColor = true;
            this.bt_continue.Click += new System.EventHandler(this.bt_continue_Click);
            // 
            // bt_pause
            // 
            this.bt_pause.Location = new System.Drawing.Point(144, 250);
            this.bt_pause.Name = "bt_pause";
            this.bt_pause.Size = new System.Drawing.Size(97, 49);
            this.bt_pause.TabIndex = 7;
            this.bt_pause.Text = "пауза";
            this.bt_pause.UseVisualStyleBackColor = true;
            this.bt_pause.Click += new System.EventHandler(this.bt_pause_Click);
            // 
            // bt_ago
            // 
            this.bt_ago.Location = new System.Drawing.Point(358, 250);
            this.bt_ago.Name = "bt_ago";
            this.bt_ago.Size = new System.Drawing.Size(75, 49);
            this.bt_ago.TabIndex = 8;
            this.bt_ago.Text = "назад";
            this.bt_ago.UseVisualStyleBackColor = true;
            this.bt_ago.Click += new System.EventHandler(this.bt_ago_Click);
            // 
            // lb_count_music
            // 
            this.lb_count_music.AutoSize = true;
            this.lb_count_music.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_count_music.Location = new System.Drawing.Point(212, 92);
            this.lb_count_music.Name = "lb_count_music";
            this.lb_count_music.Size = new System.Drawing.Size(20, 24);
            this.lb_count_music.TabIndex = 9;
            this.lb_count_music.Text = "0";
            // 
            // progressBar_music
            // 
            this.progressBar_music.Location = new System.Drawing.Point(19, 200);
            this.progressBar_music.Name = "progressBar_music";
            this.progressBar_music.Size = new System.Drawing.Size(403, 23);
            this.progressBar_music.TabIndex = 10;
            this.progressBar_music.Click += new System.EventHandler(this.progressBar_music_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(382, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Fgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar_music);
            this.Controls.Add(this.lb_count_music);
            this.Controls.Add(this.bt_ago);
            this.Controls.Add(this.bt_pause);
            this.Controls.Add(this.bt_continue);
            this.Controls.Add(this.lb_counter2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_counter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Fgame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fgame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fgame_FormClosed);
            this.Load += new System.EventHandler(this.Fgame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fgame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_counter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_counter2;
        private System.Windows.Forms.Button bt_continue;
        private System.Windows.Forms.Button bt_pause;
        private System.Windows.Forms.Button bt_ago;
        private System.Windows.Forms.Label lb_count_music;
        private System.Windows.Forms.ProgressBar progressBar_music;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
    }
}