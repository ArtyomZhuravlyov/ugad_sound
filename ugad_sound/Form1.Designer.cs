namespace ugad_sound
{
    partial class fmenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmenu));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(169, 176);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(98, 36);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(169, 120);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(98, 36);
            this.btn_setting.TabIndex = 1;
            this.btn_setting.Text = "настройки";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_game
            // 
            this.btn_game.Location = new System.Drawing.Point(169, 61);
            this.btn_game.Name = "btn_game";
            this.btn_game.Size = new System.Drawing.Size(98, 36);
            this.btn_game.TabIndex = 2;
            this.btn_game.Text = "игра";
            this.btn_game.UseVisualStyleBackColor = true;
            this.btn_game.Click += new System.EventHandler(this.btn_game_Click);
            // 
            // fmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.btn_game);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmenu_FormClosed);
            this.Load += new System.EventHandler(this.fmenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_game;
    }
}

