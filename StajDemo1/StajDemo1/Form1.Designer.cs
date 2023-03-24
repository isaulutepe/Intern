namespace StajDemo1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.MinLabel = new System.Windows.Forms.Label();
            this.minLabelPay = new System.Windows.Forms.Label();
            this.MaxLabelPay = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.SelectedPay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HızlıEvet = new System.Windows.Forms.RadioButton();
            this.HızlıHayır = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TekeTekHayır = new System.Windows.Forms.RadioButton();
            this.TekeTekEvet = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RovansHayır = new System.Windows.Forms.RadioButton();
            this.RovansEvet = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.SelectedPay);
            this.groupBox1.Controls.Add(this.MaxLabelPay);
            this.groupBox1.Controls.Add(this.MaxLabel);
            this.groupBox1.Controls.Add(this.minLabelPay);
            this.groupBox1.Controls.Add(this.MinLabel);
            this.groupBox1.Controls.Add(this.hScrollBar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(98, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masa Özelliklerini Seç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bahis Aralığı:";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(197, 66);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(247, 21);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(159, 42);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(28, 16);
            this.MinLabel.TabIndex = 2;
            this.MinLabel.Text = "Min";
            // 
            // minLabelPay
            // 
            this.minLabelPay.AutoSize = true;
            this.minLabelPay.Location = new System.Drawing.Point(150, 71);
            this.minLabelPay.Name = "minLabelPay";
            this.minLabelPay.Size = new System.Drawing.Size(35, 16);
            this.minLabelPay.TabIndex = 3;
            this.minLabelPay.Text = "200$";
            // 
            // MaxLabelPay
            // 
            this.MaxLabelPay.AutoSize = true;
            this.MaxLabelPay.Location = new System.Drawing.Point(467, 71);
            this.MaxLabelPay.Name = "MaxLabelPay";
            this.MaxLabelPay.Size = new System.Drawing.Size(42, 16);
            this.MaxLabelPay.TabIndex = 5;
            this.MaxLabelPay.Text = "5000$";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(467, 42);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(28, 16);
            this.MaxLabel.TabIndex = 4;
            this.MaxLabel.Text = "Min";
            // 
            // SelectedPay
            // 
            this.SelectedPay.AutoSize = true;
            this.SelectedPay.Location = new System.Drawing.Point(307, 42);
            this.SelectedPay.Name = "SelectedPay";
            this.SelectedPay.Size = new System.Drawing.Size(35, 16);
            this.SelectedPay.TabIndex = 6;
            this.SelectedPay.Text = "200$";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HızlıHayır);
            this.groupBox2.Controls.Add(this.HızlıEvet);
            this.groupBox2.Location = new System.Drawing.Point(41, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 80);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı";
            // 
            // HızlıEvet
            // 
            this.HızlıEvet.AutoSize = true;
            this.HızlıEvet.Location = new System.Drawing.Point(6, 21);
            this.HızlıEvet.Name = "HızlıEvet";
            this.HızlıEvet.Size = new System.Drawing.Size(55, 20);
            this.HızlıEvet.TabIndex = 0;
            this.HızlıEvet.TabStop = true;
            this.HızlıEvet.Text = "Evet";
            this.HızlıEvet.UseVisualStyleBackColor = true;
            // 
            // HızlıHayır
            // 
            this.HızlıHayır.AutoSize = true;
            this.HızlıHayır.Location = new System.Drawing.Point(6, 47);
            this.HızlıHayır.Name = "HızlıHayır";
            this.HızlıHayır.Size = new System.Drawing.Size(60, 20);
            this.HızlıHayır.TabIndex = 9;
            this.HızlıHayır.TabStop = true;
            this.HızlıHayır.Text = "Hayır";
            this.HızlıHayır.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TekeTekHayır);
            this.groupBox3.Controls.Add(this.TekeTekEvet);
            this.groupBox3.Location = new System.Drawing.Point(222, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 80);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teke tek";
            // 
            // TekeTekHayır
            // 
            this.TekeTekHayır.AutoSize = true;
            this.TekeTekHayır.Location = new System.Drawing.Point(6, 47);
            this.TekeTekHayır.Name = "TekeTekHayır";
            this.TekeTekHayır.Size = new System.Drawing.Size(60, 20);
            this.TekeTekHayır.TabIndex = 9;
            this.TekeTekHayır.TabStop = true;
            this.TekeTekHayır.Text = "Hayır";
            this.TekeTekHayır.UseVisualStyleBackColor = true;
            // 
            // TekeTekEvet
            // 
            this.TekeTekEvet.AutoSize = true;
            this.TekeTekEvet.Location = new System.Drawing.Point(6, 21);
            this.TekeTekEvet.Name = "TekeTekEvet";
            this.TekeTekEvet.Size = new System.Drawing.Size(55, 20);
            this.TekeTekEvet.TabIndex = 0;
            this.TekeTekEvet.TabStop = true;
            this.TekeTekEvet.Text = "Evet";
            this.TekeTekEvet.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RovansHayır);
            this.groupBox4.Controls.Add(this.RovansEvet);
            this.groupBox4.Location = new System.Drawing.Point(395, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(125, 80);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rövanş";
            // 
            // RovansHayır
            // 
            this.RovansHayır.AutoSize = true;
            this.RovansHayır.Location = new System.Drawing.Point(6, 47);
            this.RovansHayır.Name = "RovansHayır";
            this.RovansHayır.Size = new System.Drawing.Size(60, 20);
            this.RovansHayır.TabIndex = 9;
            this.RovansHayır.TabStop = true;
            this.RovansHayır.Text = "Hayır";
            this.RovansHayır.UseVisualStyleBackColor = true;
            // 
            // RovansEvet
            // 
            this.RovansEvet.AutoSize = true;
            this.RovansEvet.Location = new System.Drawing.Point(6, 21);
            this.RovansEvet.Name = "RovansEvet";
            this.RovansEvet.Size = new System.Drawing.Size(55, 20);
            this.RovansEvet.TabIndex = 0;
            this.RovansEvet.TabStop = true;
            this.RovansEvet.Text = "Evet";
            this.RovansEvet.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 410);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaxLabelPay;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label minLabelPay;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label SelectedPay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RovansHayır;
        private System.Windows.Forms.RadioButton RovansEvet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton TekeTekHayır;
        private System.Windows.Forms.RadioButton TekeTekEvet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton HızlıHayır;
        private System.Windows.Forms.RadioButton HızlıEvet;
    }
}

