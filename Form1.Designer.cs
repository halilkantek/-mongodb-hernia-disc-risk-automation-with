namespace proje
{
    partial class girisfrm
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
            this.kullanıcıbtn = new System.Windows.Forms.Button();
            this.adminbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullanıcıbtn
            // 
            this.kullanıcıbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıbtn.Location = new System.Drawing.Point(12, 107);
            this.kullanıcıbtn.Name = "kullanıcıbtn";
            this.kullanıcıbtn.Size = new System.Drawing.Size(176, 92);
            this.kullanıcıbtn.TabIndex = 0;
            this.kullanıcıbtn.Text = "Kullanıcı";
            this.kullanıcıbtn.UseVisualStyleBackColor = true;
            this.kullanıcıbtn.Click += new System.EventHandler(this.Kullanıcıbtn_Click);
            // 
            // adminbtn
            // 
            this.adminbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminbtn.Location = new System.Drawing.Point(12, 30);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(176, 71);
            this.adminbtn.TabIndex = 1;
            this.adminbtn.Text = "Yönetici";
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.Click += new System.EventHandler(this.Adminbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // girisfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 290);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.kullanıcıbtn);
            this.Name = "girisfrm";
            this.ShowIcon = false;
            this.Text = "ANASAYFA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kullanıcıbtn;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Button button1;
    }
}

