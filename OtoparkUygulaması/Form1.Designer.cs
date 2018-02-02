namespace OtoparkUygulaması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnGiriş = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnHakkımızda = new System.Windows.Forms.Button();
            this.giristxt2 = new System.Windows.Forms.TextBox();
            this.giristxt1 = new System.Windows.Forms.TextBox();
            this.girislb2 = new System.Windows.Forms.Label();
            this.girislb1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGiriş
            // 
            this.BtnGiriş.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.BtnGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGiriş.Font = new System.Drawing.Font("Comic Sans MS", 9.25F);
            this.BtnGiriş.ForeColor = System.Drawing.Color.White;
            this.BtnGiriş.Location = new System.Drawing.Point(178, 143);
            this.BtnGiriş.Name = "BtnGiriş";
            this.BtnGiriş.Size = new System.Drawing.Size(106, 26);
            this.BtnGiriş.TabIndex = 0;
            this.BtnGiriş.Text = "Giriş";
            this.BtnGiriş.UseVisualStyleBackColor = false;
            this.BtnGiriş.Click += new System.EventHandler(this.BtnGiriş_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnHakkımızda);
            this.groupBox1.Controls.Add(this.giristxt2);
            this.groupBox1.Controls.Add(this.giristxt1);
            this.groupBox1.Controls.Add(this.girislb2);
            this.groupBox1.Controls.Add(this.girislb1);
            this.groupBox1.Controls.Add(this.BtnGiriş);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.25F);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // BtnHakkımızda
            // 
            this.BtnHakkımızda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.BtnHakkımızda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHakkımızda.Font = new System.Drawing.Font("Comic Sans MS", 9.25F);
            this.BtnHakkımızda.ForeColor = System.Drawing.Color.White;
            this.BtnHakkımızda.Location = new System.Drawing.Point(26, 143);
            this.BtnHakkımızda.Name = "BtnHakkımızda";
            this.BtnHakkımızda.Size = new System.Drawing.Size(106, 26);
            this.BtnHakkımızda.TabIndex = 5;
            this.BtnHakkımızda.Text = "Hakkımızda";
            this.BtnHakkımızda.UseVisualStyleBackColor = false;
            this.BtnHakkımızda.Click += new System.EventHandler(this.BtnHakkımızda_Click);
            // 
            // giristxt2
            // 
            this.giristxt2.Location = new System.Drawing.Point(118, 83);
            this.giristxt2.Name = "giristxt2";
            this.giristxt2.PasswordChar = '*';
            this.giristxt2.Size = new System.Drawing.Size(116, 25);
            this.giristxt2.TabIndex = 4;
            // 
            // giristxt1
            // 
            this.giristxt1.Location = new System.Drawing.Point(118, 42);
            this.giristxt1.Name = "giristxt1";
            this.giristxt1.Size = new System.Drawing.Size(116, 25);
            this.giristxt1.TabIndex = 3;
            // 
            // girislb2
            // 
            this.girislb2.AutoSize = true;
            this.girislb2.Location = new System.Drawing.Point(22, 87);
            this.girislb2.Name = "girislb2";
            this.girislb2.Size = new System.Drawing.Size(41, 18);
            this.girislb2.TabIndex = 2;
            this.girislb2.Text = "Şifre";
            // 
            // girislb1
            // 
            this.girislb1.AutoSize = true;
            this.girislb1.Location = new System.Drawing.Point(22, 45);
            this.girislb1.Name = "girislb1";
            this.girislb1.Size = new System.Drawing.Size(85, 18);
            this.girislb1.TabIndex = 1;
            this.girislb1.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 197);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGiriş;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnHakkımızda;
        private System.Windows.Forms.TextBox giristxt2;
        private System.Windows.Forms.TextBox giristxt1;
        private System.Windows.Forms.Label girislb2;
        private System.Windows.Forms.Label girislb1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

