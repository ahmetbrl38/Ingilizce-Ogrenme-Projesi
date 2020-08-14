namespace Ingilizce_Ogrenme
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblIng = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPas = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türkçesi nedir?";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "İngilizcesi:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(474, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Süre:";
            this.label3.UseWaitCursor = true;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSure.Location = new System.Drawing.Point(525, 39);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(45, 25);
            this.lblSure.TabIndex = 7;
            this.lblSure.Text = "120";
            this.lblSure.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(566, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "sn";
            this.label5.UseWaitCursor = true;
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKelime.Location = new System.Drawing.Point(544, 79);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(23, 25);
            this.lblKelime.TabIndex = 10;
            this.lblKelime.Text = "0";
            this.lblKelime.UseWaitCursor = true;
            this.lblKelime.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(474, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kelime:";
            this.label7.UseWaitCursor = true;
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCevap.Location = new System.Drawing.Point(506, 250);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(64, 25);
            this.lblCevap.TabIndex = 11;
            this.lblCevap.Text = "label4";
            this.lblCevap.UseWaitCursor = true;
            this.lblCevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblIng
            // 
            this.lblIng.AutoSize = true;
            this.lblIng.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIng.Location = new System.Drawing.Point(130, 39);
            this.lblIng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIng.Name = "lblIng";
            this.lblIng.Size = new System.Drawing.Size(22, 25);
            this.lblIng.TabIndex = 12;
            this.lblIng.Text = "x";
            this.lblIng.UseWaitCursor = true;
            this.lblIng.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 30);
            this.textBox1.TabIndex = 13;
            this.textBox1.UseWaitCursor = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPas
            // 
            this.btnPas.Location = new System.Drawing.Point(17, 224);
            this.btnPas.Name = "btnPas";
            this.btnPas.Size = new System.Drawing.Size(74, 35);
            this.btnPas.TabIndex = 14;
            this.btnPas.Text = "Pas";
            this.btnPas.UseVisualStyleBackColor = true;
            this.btnPas.UseWaitCursor = true;
            this.btnPas.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kalan Pas Hakkınız:";
            this.label8.UseWaitCursor = true;
            // 
            // lblPas
            // 
            this.lblPas.AutoSize = true;
            this.lblPas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPas.Location = new System.Drawing.Point(193, 262);
            this.lblPas.Name = "lblPas";
            this.lblPas.Size = new System.Drawing.Size(23, 25);
            this.lblPas.TabIndex = 16;
            this.lblPas.Text = "5";
            this.lblPas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPas.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(610, 296);
            this.Controls.Add(this.lblPas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIng);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İngilizce Öğren - v0.1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblIng;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPas;
    }
}

