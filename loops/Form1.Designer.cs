namespace loops
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.txtDongu = new System.Windows.Forms.TextBox();
            this.txtArtAz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonguMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWhile = new System.Windows.Forms.Button();
            this.rdArt = new System.Windows.Forms.RadioButton();
            this.rdAz = new System.Windows.Forms.RadioButton();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtValue.Location = new System.Drawing.Point(0, 0);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValue.Size = new System.Drawing.Size(251, 450);
            this.txtValue.TabIndex = 0;
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(274, 73);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(89, 20);
            this.txtSayi.TabIndex = 1;
            this.txtSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi_KeyPress);
            // 
            // txtDongu
            // 
            this.txtDongu.Location = new System.Drawing.Point(274, 332);
            this.txtDongu.Name = "txtDongu";
            this.txtDongu.Size = new System.Drawing.Size(88, 20);
            this.txtDongu.TabIndex = 2;
            // 
            // txtArtAz
            // 
            this.txtArtAz.Location = new System.Drawing.Point(440, 73);
            this.txtArtAz.Name = "txtArtAz";
            this.txtArtAz.Size = new System.Drawing.Size(120, 20);
            this.txtArtAz.TabIndex = 3;
            this.txtArtAz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArtAz_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sayıyı giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Döngü sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Artış veya Azalış Değeri: ";
            // 
            // txtDonguMax
            // 
            this.txtDonguMax.Location = new System.Drawing.Point(627, 73);
            this.txtDonguMax.Name = "txtDonguMax";
            this.txtDonguMax.Size = new System.Drawing.Size(141, 20);
            this.txtDonguMax.TabIndex = 8;
            this.txtDonguMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonguMax_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Döngü Kaçta Dursun?";
            // 
            // btnWhile
            // 
            this.btnWhile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhile.Location = new System.Drawing.Point(438, 178);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(122, 70);
            this.btnWhile.TabIndex = 10;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // rdArt
            // 
            this.rdArt.AutoSize = true;
            this.rdArt.Location = new System.Drawing.Point(274, 178);
            this.rdArt.Name = "rdArt";
            this.rdArt.Size = new System.Drawing.Size(88, 17);
            this.rdArt.TabIndex = 11;
            this.rdArt.TabStop = true;
            this.rdArt.Text = "Sayı artsın (+)";
            this.rdArt.UseVisualStyleBackColor = true;
            // 
            // rdAz
            // 
            this.rdAz.AutoSize = true;
            this.rdAz.Location = new System.Drawing.Point(274, 206);
            this.rdAz.Name = "rdAz";
            this.rdAz.Size = new System.Drawing.Size(92, 17);
            this.rdAz.TabIndex = 12;
            this.rdAz.TabStop = true;
            this.rdAz.Text = "Sayı azalsın (-)";
            this.rdAz.UseVisualStyleBackColor = true;
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoWhile.Location = new System.Drawing.Point(627, 178);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(122, 70);
            this.btnDoWhile.TabIndex = 13;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFor
            // 
            this.btnFor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFor.Location = new System.Drawing.Point(530, 316);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(122, 70);
            this.btnFor.TabIndex = 14;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.rdAz);
            this.Controls.Add(this.rdArt);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDonguMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArtAz);
            this.Controls.Add(this.txtDongu);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.txtValue);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loops";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.TextBox txtDongu;
        private System.Windows.Forms.TextBox txtArtAz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonguMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.RadioButton rdArt;
        private System.Windows.Forms.RadioButton rdAz;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnFor;
    }
}

