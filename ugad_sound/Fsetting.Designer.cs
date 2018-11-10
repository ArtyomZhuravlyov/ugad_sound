namespace ugad_sound
{
    partial class Fsetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fsetting));
            this.btnselect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_random_start = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_answear = new System.Windows.Forms.ComboBox();
            this.cbdeep = new System.Windows.Forms.ComboBox();
            this.lb_player1 = new System.Windows.Forms.Label();
            this.lb_player2 = new System.Windows.Forms.Label();
            this.cb_player_1_knopka = new System.Windows.Forms.ComboBox();
            this.cb_player_2_knopka = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(0, 127);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 0;
            this.btnselect.Text = "выбрать";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "очистить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(440, 121);
            this.listBox1.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(0, 248);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(0, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_player_2_knopka);
            this.groupBox1.Controls.Add(this.cb_player_1_knopka);
            this.groupBox1.Controls.Add(this.lb_player2);
            this.groupBox1.Controls.Add(this.lb_player1);
            this.groupBox1.Controls.Add(this.check_random_start);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_answear);
            this.groupBox1.Controls.Add(this.cbdeep);
            this.groupBox1.Location = new System.Drawing.Point(162, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "настройки игры";
            // 
            // check_random_start
            // 
            this.check_random_start.AutoSize = true;
            this.check_random_start.Location = new System.Drawing.Point(66, 93);
            this.check_random_start.Name = "check_random_start";
            this.check_random_start.Size = new System.Drawing.Size(133, 17);
            this.check_random_start.TabIndex = 4;
            this.check_random_start.Text = "Со случайного места";
            this.check_random_start.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "время ответа";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "продолжительность игры";
            // 
            // cb_answear
            // 
            this.cb_answear.FormattingEnabled = true;
            this.cb_answear.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.cb_answear.Location = new System.Drawing.Point(158, 66);
            this.cb_answear.Name = "cb_answear";
            this.cb_answear.Size = new System.Drawing.Size(102, 21);
            this.cb_answear.TabIndex = 1;
            this.cb_answear.Text = "10";
            this.cb_answear.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbdeep
            // 
            this.cbdeep.AutoCompleteCustomSource.AddRange(new string[] {
            "30",
            "45",
            "60"});
            this.cbdeep.FormattingEnabled = true;
            this.cbdeep.Items.AddRange(new object[] {
            "30",
            "45",
            "60"});
            this.cbdeep.Location = new System.Drawing.Point(158, 39);
            this.cbdeep.Name = "cbdeep";
            this.cbdeep.Size = new System.Drawing.Size(102, 21);
            this.cbdeep.TabIndex = 0;
            this.cbdeep.Text = "45";
            this.cbdeep.SelectedIndexChanged += new System.EventHandler(this.cbdeep_SelectedIndexChanged);
            // 
            // lb_player1
            // 
            this.lb_player1.AutoSize = true;
            this.lb_player1.Location = new System.Drawing.Point(41, 128);
            this.lb_player1.Name = "lb_player1";
            this.lb_player1.Size = new System.Drawing.Size(45, 13);
            this.lb_player1.TabIndex = 5;
            this.lb_player1.Text = "игрок 1";
            // 
            // lb_player2
            // 
            this.lb_player2.AutoSize = true;
            this.lb_player2.Location = new System.Drawing.Point(41, 156);
            this.lb_player2.Name = "lb_player2";
            this.lb_player2.Size = new System.Drawing.Size(45, 13);
            this.lb_player2.TabIndex = 6;
            this.lb_player2.Text = "игрок 2";
            // 
            // cb_player_1_knopka
            // 
            this.cb_player_1_knopka.FormattingEnabled = true;
            this.cb_player_1_knopka.Items.AddRange(new object[] {
            "a"});
            this.cb_player_1_knopka.Location = new System.Drawing.Point(158, 125);
            this.cb_player_1_knopka.Name = "cb_player_1_knopka";
            this.cb_player_1_knopka.Size = new System.Drawing.Size(102, 21);
            this.cb_player_1_knopka.TabIndex = 7;
            this.cb_player_1_knopka.Text = "A";
            // 
            // cb_player_2_knopka
            // 
            this.cb_player_2_knopka.FormattingEnabled = true;
            this.cb_player_2_knopka.Items.AddRange(new object[] {
            "l"});
            this.cb_player_2_knopka.Location = new System.Drawing.Point(158, 156);
            this.cb_player_2_knopka.Name = "cb_player_2_knopka";
            this.cb_player_2_knopka.Size = new System.Drawing.Size(102, 21);
            this.cb_player_2_knopka.TabIndex = 7;
            this.cb_player_2_knopka.Text = "L";
            // 
            // Fsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnselect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fsetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fsetting";
            this.Load += new System.EventHandler(this.Fsetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_answear;
        private System.Windows.Forms.ComboBox cbdeep;
        private System.Windows.Forms.CheckBox check_random_start;
        private System.Windows.Forms.ComboBox cb_player_1_knopka;
        private System.Windows.Forms.Label lb_player2;
        private System.Windows.Forms.Label lb_player1;
        private System.Windows.Forms.ComboBox cb_player_2_knopka;
    }
}