namespace 加密通话姬
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myPri = new System.Windows.Forms.TextBox();
            this.myPub = new System.Windows.Forms.TextBox();
            this.herPub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genKey = new System.Windows.Forms.Button();
            this.enc = new System.Windows.Forms.Button();
            this.eText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEnced = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pText = new System.Windows.Forms.TextBox();
            this.textDeced = new System.Windows.Forms.TextBox();
            this.dec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myPri
            // 
            this.myPri.Location = new System.Drawing.Point(12, 114);
            this.myPri.Multiline = true;
            this.myPri.Name = "myPri";
            this.myPri.Size = new System.Drawing.Size(468, 101);
            this.myPri.TabIndex = 0;
            this.myPri.Visible = false;
            this.myPri.WordWrap = false;
            // 
            // myPub
            // 
            this.myPub.Location = new System.Drawing.Point(12, 43);
            this.myPub.Multiline = true;
            this.myPub.Name = "myPub";
            this.myPub.Size = new System.Drawing.Size(468, 43);
            this.myPub.TabIndex = 1;
            this.myPub.WordWrap = false;
            // 
            // herPub
            // 
            this.herPub.Location = new System.Drawing.Point(512, 41);
            this.herPub.Multiline = true;
            this.herPub.Name = "herPub";
            this.herPub.Size = new System.Drawing.Size(458, 45);
            this.herPub.TabIndex = 2;
            this.herPub.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "我的私钥";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "我的公钥";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "她的公钥";
            // 
            // genKey
            // 
            this.genKey.Location = new System.Drawing.Point(367, 6);
            this.genKey.Name = "genKey";
            this.genKey.Size = new System.Drawing.Size(113, 34);
            this.genKey.TabIndex = 4;
            this.genKey.Text = "生成密钥对";
            this.genKey.UseVisualStyleBackColor = true;
            this.genKey.Click += new System.EventHandler(this.genKey_Click);
            // 
            // enc
            // 
            this.enc.Location = new System.Drawing.Point(512, 379);
            this.enc.Name = "enc";
            this.enc.Size = new System.Drawing.Size(114, 38);
            this.enc.TabIndex = 5;
            this.enc.Text = "加密明文";
            this.enc.UseVisualStyleBackColor = true;
            this.enc.Click += new System.EventHandler(this.enc_Click);
            // 
            // eText
            // 
            this.eText.Location = new System.Drawing.Point(68, 221);
            this.eText.Multiline = true;
            this.eText.Name = "eText";
            this.eText.Size = new System.Drawing.Size(292, 39);
            this.eText.TabIndex = 6;
            this.eText.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "明文";
            // 
            // textEnced
            // 
            this.textEnced.Location = new System.Drawing.Point(632, 379);
            this.textEnced.Multiline = true;
            this.textEnced.Name = "textEnced";
            this.textEnced.Size = new System.Drawing.Size(338, 38);
            this.textEnced.TabIndex = 7;
            this.textEnced.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "密文";
            // 
            // pText
            // 
            this.pText.Location = new System.Drawing.Point(512, 114);
            this.pText.Multiline = true;
            this.pText.Name = "pText";
            this.pText.Size = new System.Drawing.Size(458, 259);
            this.pText.TabIndex = 8;
            // 
            // textDeced
            // 
            this.textDeced.Location = new System.Drawing.Point(12, 266);
            this.textDeced.Multiline = true;
            this.textDeced.Name = "textDeced";
            this.textDeced.Size = new System.Drawing.Size(468, 252);
            this.textDeced.TabIndex = 9;
            this.textDeced.WordWrap = false;
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(366, 221);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(114, 39);
            this.dec.TabIndex = 10;
            this.dec.Text = "解密密文";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(871, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 80);
            this.label6.TabIndex = 3;
            this.label6.Text = "双方交换公钥\r\n私钥始终私有\r\n公钥加密明文\r\n私钥解密密文";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.textDeced);
            this.Controls.Add(this.pText);
            this.Controls.Add(this.textEnced);
            this.Controls.Add(this.eText);
            this.Controls.Add(this.enc);
            this.Controls.Add(this.genKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.herPub);
            this.Controls.Add(this.myPub);
            this.Controls.Add(this.myPri);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA加密通话姬";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox myPri;
        private TextBox myPub;
        private TextBox herPub;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button genKey;
        private Button enc;
        private TextBox eText;
        private Label label4;
        private TextBox textEnced;
        private Label label5;
        private TextBox pText;
        private TextBox textDeced;
        private Button dec;
        private Label label6;
    }
}