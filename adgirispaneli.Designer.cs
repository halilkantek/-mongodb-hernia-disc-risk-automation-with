namespace proje
{
    partial class adgirispaneli
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
            this.kadi_label = new System.Windows.Forms.Label();
            this.sifrelbl = new System.Windows.Forms.Label();
            this.kaditxtbox = new System.Windows.Forms.TextBox();
            this.sifretxtbox = new System.Windows.Forms.TextBox();
            this.grisbtn = new System.Windows.Forms.Button();
            this.geribtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kadi_label
            // 
            this.kadi_label.AutoSize = true;
            this.kadi_label.Location = new System.Drawing.Point(28, 88);
            this.kadi_label.Name = "kadi_label";
            this.kadi_label.Size = new System.Drawing.Size(84, 17);
            this.kadi_label.TabIndex = 0;
            this.kadi_label.Text = "Kullanıcı Adı";
            // 
            // sifrelbl
            // 
            this.sifrelbl.AutoSize = true;
            this.sifrelbl.Location = new System.Drawing.Point(75, 146);
            this.sifrelbl.Name = "sifrelbl";
            this.sifrelbl.Size = new System.Drawing.Size(37, 17);
            this.sifrelbl.TabIndex = 1;
            this.sifrelbl.Text = "Şifre";
            // 
            // kaditxtbox
            // 
            this.kaditxtbox.Location = new System.Drawing.Point(131, 88);
            this.kaditxtbox.Name = "kaditxtbox";
            this.kaditxtbox.Size = new System.Drawing.Size(123, 22);
            this.kaditxtbox.TabIndex = 2;
            this.kaditxtbox.TextChanged += new System.EventHandler(this.kaditxtbox_TextChanged);
            // 
            // sifretxtbox
            // 
            this.sifretxtbox.Location = new System.Drawing.Point(131, 141);
            this.sifretxtbox.Name = "sifretxtbox";
            this.sifretxtbox.Size = new System.Drawing.Size(123, 22);
            this.sifretxtbox.TabIndex = 3;
            this.sifretxtbox.UseSystemPasswordChar = true;
            // 
            // grisbtn
            // 
            this.grisbtn.Location = new System.Drawing.Point(131, 183);
            this.grisbtn.Name = "grisbtn";
            this.grisbtn.Size = new System.Drawing.Size(123, 30);
            this.grisbtn.TabIndex = 4;
            this.grisbtn.Text = "Giriş";
            this.grisbtn.UseVisualStyleBackColor = true;
            this.grisbtn.Click += new System.EventHandler(this.Grisbtn_Click);
            // 
            // geribtn
            // 
            this.geribtn.Location = new System.Drawing.Point(131, 240);
            this.geribtn.Name = "geribtn";
            this.geribtn.Size = new System.Drawing.Size(123, 30);
            this.geribtn.TabIndex = 5;
            this.geribtn.Text = "Geri";
            this.geribtn.UseVisualStyleBackColor = true;
            this.geribtn.Click += new System.EventHandler(this.Geribtn_Click);
            // 
            // adgirispaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 342);
            this.ControlBox = false;
            this.Controls.Add(this.geribtn);
            this.Controls.Add(this.grisbtn);
            this.Controls.Add(this.sifretxtbox);
            this.Controls.Add(this.kaditxtbox);
            this.Controls.Add(this.sifrelbl);
            this.Controls.Add(this.kadi_label);
            this.Name = "adgirispaneli";
            this.Text = "adgirispaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kadi_label;
        private System.Windows.Forms.Label sifrelbl;
        private System.Windows.Forms.TextBox kaditxtbox;
        private System.Windows.Forms.TextBox sifretxtbox;
        private System.Windows.Forms.Button grisbtn;
        private System.Windows.Forms.Button geribtn;
    }
}