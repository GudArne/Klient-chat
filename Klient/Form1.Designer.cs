namespace Klient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIp = new System.Windows.Forms.TextBox();
            this.lbxChat = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.tbxSkicka = new System.Windows.Forms.TextBox();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.lbxLogger = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serverns IP-adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHATRUM";
            // 
            // tbxIp
            // 
            this.tbxIp.Location = new System.Drawing.Point(118, 28);
            this.tbxIp.Name = "tbxIp";
            this.tbxIp.Size = new System.Drawing.Size(114, 20);
            this.tbxIp.TabIndex = 2;
            // 
            // lbxChat
            // 
            this.lbxChat.FormattingEnabled = true;
            this.lbxChat.Location = new System.Drawing.Point(19, 94);
            this.lbxChat.Name = "lbxChat";
            this.lbxChat.Size = new System.Drawing.Size(269, 199);
            this.lbxChat.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSkicka);
            this.groupBox1.Controls.Add(this.tbxSkicka);
            this.groupBox1.Location = new System.Drawing.Point(19, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utkorg";
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(7, 49);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(250, 23);
            this.btnSkicka.TabIndex = 1;
            this.btnSkicka.Text = "Sänd";
            this.btnSkicka.UseVisualStyleBackColor = true;
            this.btnSkicka.Click += new System.EventHandler(this.btnSkicka_Click);
            // 
            // tbxSkicka
            // 
            this.tbxSkicka.Location = new System.Drawing.Point(6, 20);
            this.tbxSkicka.Name = "tbxSkicka";
            this.tbxSkicka.Size = new System.Drawing.Size(251, 20);
            this.tbxSkicka.TabIndex = 0;
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(245, 23);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(56, 28);
            this.btnAnslut.TabIndex = 5;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // lbxLogger
            // 
            this.lbxLogger.FormattingEnabled = true;
            this.lbxLogger.Location = new System.Drawing.Point(366, 76);
            this.lbxLogger.Name = "lbxLogger";
            this.lbxLogger.Size = new System.Drawing.Size(234, 264);
            this.lbxLogger.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 395);
            this.Controls.Add(this.lbxLogger);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxChat);
            this.Controls.Add(this.tbxIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIp;
        private System.Windows.Forms.ListBox lbxChat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.TextBox tbxSkicka;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.ListBox lbxLogger;
    }
}

