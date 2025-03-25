namespace pizza
{
    partial class PİZZA
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEbat = new System.Windows.Forms.ComboBox();
            this.listBoxPizza = new System.Windows.Forms.ListBox();
            this.radioInceKenar = new System.Windows.Forms.RadioButton();
            this.radioKalinKenar = new System.Windows.Forms.RadioButton();
            this.groupBoxMalzemeler = new System.Windows.Forms.GroupBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxadet = new System.Windows.Forms.TextBox();
            this.textBoxToplam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxMalzemeler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ebat:";
            // 
            // comboBoxEbat
            // 
            this.comboBoxEbat.FormattingEnabled = true;
            this.comboBoxEbat.Location = new System.Drawing.Point(71, 99);
            this.comboBoxEbat.Name = "comboBoxEbat";
            this.comboBoxEbat.Size = new System.Drawing.Size(281, 24);
            this.comboBoxEbat.TabIndex = 1;
            this.comboBoxEbat.SelectedIndexChanged += new System.EventHandler(this.comboBoxEbat_SelectedIndexChanged_1);
            // 
            // listBoxPizza
            // 
            this.listBoxPizza.FormattingEnabled = true;
            this.listBoxPizza.ItemHeight = 16;
            this.listBoxPizza.Location = new System.Drawing.Point(71, 141);
            this.listBoxPizza.Name = "listBoxPizza";
            this.listBoxPizza.Size = new System.Drawing.Size(281, 84);
            this.listBoxPizza.TabIndex = 2;
            this.listBoxPizza.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioInceKenar
            // 
            this.radioInceKenar.AutoSize = true;
            this.radioInceKenar.Location = new System.Drawing.Point(71, 247);
            this.radioInceKenar.Name = "radioInceKenar";
            this.radioInceKenar.Size = new System.Drawing.Size(94, 20);
            this.radioInceKenar.TabIndex = 3;
            this.radioInceKenar.TabStop = true;
            this.radioInceKenar.Text = "İnce Kenar ";
            this.radioInceKenar.UseVisualStyleBackColor = true;
            this.radioInceKenar.CheckedChanged += new System.EventHandler(this.radioKenar);
            // 
            // radioKalinKenar
            // 
            this.radioKalinKenar.AutoSize = true;
            this.radioKalinKenar.Location = new System.Drawing.Point(201, 247);
            this.radioKalinKenar.Name = "radioKalinKenar";
            this.radioKalinKenar.Size = new System.Drawing.Size(95, 20);
            this.radioKalinKenar.TabIndex = 4;
            this.radioKalinKenar.TabStop = true;
            this.radioKalinKenar.Text = "Kalın Kenar";
            this.radioKalinKenar.UseVisualStyleBackColor = true;
            this.radioKalinKenar.CheckedChanged += new System.EventHandler(this.radioKenar);
            // 
            // groupBoxMalzemeler
            // 
            this.groupBoxMalzemeler.Controls.Add(this.checkBox10);
            this.groupBoxMalzemeler.Controls.Add(this.checkBox9);
            this.groupBoxMalzemeler.Controls.Add(this.checkBox8);
            this.groupBoxMalzemeler.Controls.Add(this.checkBox7);
            this.groupBoxMalzemeler.Controls.Add(this.checkBox6);
            this.groupBoxMalzemeler.Controls.Add(this.checkBox5);
            this.groupBoxMalzemeler.Controls.Add(this.checkBox4);
            this.groupBoxMalzemeler.Controls.Add(this.checkBox3);
            this.groupBoxMalzemeler.Controls.Add(this.checkBox2);
            this.groupBoxMalzemeler.Controls.Add(this.checkBox1);
            this.groupBoxMalzemeler.Location = new System.Drawing.Point(64, 273);
            this.groupBoxMalzemeler.Name = "groupBoxMalzemeler";
            this.groupBoxMalzemeler.Size = new System.Drawing.Size(288, 151);
            this.groupBoxMalzemeler.TabIndex = 5;
            this.groupBoxMalzemeler.TabStop = false;
            this.groupBoxMalzemeler.Text = "Malzemeler";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(127, 125);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(67, 20);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Peynir";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBoxMalzeme);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(127, 99);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(90, 20);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Ton Balığı";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBoxMalzeme);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(127, 73);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(73, 20);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Mantar ";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBoxMalzeme);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(127, 47);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(66, 20);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Sucuk";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBoxMalzeme);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(127, 21);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(71, 20);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Salam ";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBoxMalzeme);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 125);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(65, 20);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Zeytin";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBoxMalzeme);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 99);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(73, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Ançuez";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBoxMalzeme);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 73);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Mısır";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBoxMalzeme);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Sosois";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBoxMalzeme);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Dana jambon";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBoxMalzeme);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toplam:";
            // 
            // textBoxadet
            // 
            this.textBoxadet.Location = new System.Drawing.Point(81, 437);
            this.textBoxadet.Name = "textBoxadet";
            this.textBoxadet.Size = new System.Drawing.Size(100, 22);
            this.textBoxadet.TabIndex = 8;
            this.textBoxadet.TextChanged += new System.EventHandler(this.textBoxAdet);
            // 
            // textBoxToplam
            // 
            this.textBoxToplam.Enabled = false;
            this.textBoxToplam.Location = new System.Drawing.Point(251, 434);
            this.textBoxToplam.Name = "textBoxToplam";
            this.textBoxToplam.ReadOnly = true;
            this.textBoxToplam.ShortcutsEnabled = false;
            this.textBoxToplam.Size = new System.Drawing.Size(100, 22);
            this.textBoxToplam.TabIndex = 9;
            this.textBoxToplam.TextChanged += new System.EventHandler(this.textBoxToplam_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sipariş Ver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.siparisver);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 76);
            this.label4.TabIndex = 12;
            this.label4.Text = "PİZZA SİPARİŞ EKRANI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PİZZA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxToplam);
            this.Controls.Add(this.textBoxadet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxMalzemeler);
            this.Controls.Add(this.radioKalinKenar);
            this.Controls.Add(this.radioInceKenar);
            this.Controls.Add(this.listBoxPizza);
            this.Controls.Add(this.comboBoxEbat);
            this.Controls.Add(this.label1);
            this.Name = "PİZZA";
            this.Text = "PİZZA";
            this.Load += new System.EventHandler(this.PİZZA_Load);
            this.groupBoxMalzemeler.ResumeLayout(false);
            this.groupBoxMalzemeler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEbat;
        private System.Windows.Forms.ListBox listBoxPizza;
        private System.Windows.Forms.RadioButton radioInceKenar;
        private System.Windows.Forms.RadioButton radioKalinKenar;
        private System.Windows.Forms.GroupBox groupBoxMalzemeler;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxadet;
        private System.Windows.Forms.TextBox textBoxToplam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}

