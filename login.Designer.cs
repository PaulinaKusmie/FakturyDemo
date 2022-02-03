
namespace WindowsFormsApp3
{
    partial class login
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
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.pcperson = new System.Windows.Forms.PictureBox();
            this.pchadlock = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnZalogujsie = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbWyjdz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcperson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pchadlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.Black;
            this.lblLogIn.Location = new System.Drawing.Point(87, 129);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(117, 45);
            this.lblLogIn.TabIndex = 1;
            this.lblLogIn.Text = "Login";
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaslo.ForeColor = System.Drawing.Color.Black;
            this.lblHaslo.Location = new System.Drawing.Point(87, 247);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(123, 45);
            this.lblHaslo.TabIndex = 2;
            this.lblHaslo.Text = "Haslo";
            // 
            // pcperson
            // 
            this.pcperson.Image = global::WindowsFormsApp3.Properties.Resources.man_in_suit_and_tie;
            this.pcperson.Location = new System.Drawing.Point(33, 177);
            this.pcperson.Name = "pcperson";
            this.pcperson.Size = new System.Drawing.Size(35, 43);
            this.pcperson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcperson.TabIndex = 4;
            this.pcperson.TabStop = false;
            // 
            // pchadlock
            // 
            this.pchadlock.Image = global::WindowsFormsApp3.Properties.Resources.padlock;
            this.pchadlock.Location = new System.Drawing.Point(33, 297);
            this.pchadlock.Name = "pchadlock";
            this.pchadlock.Size = new System.Drawing.Size(35, 43);
            this.pchadlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pchadlock.TabIndex = 3;
            this.pchadlock.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.Untitled_design2;
            this.pictureBox1.Location = new System.Drawing.Point(84, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnZalogujsie
            // 
            this.btnZalogujsie.BackColor = System.Drawing.Color.Tomato;
            this.btnZalogujsie.FlatAppearance.BorderSize = 0;
            this.btnZalogujsie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZalogujsie.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZalogujsie.ForeColor = System.Drawing.Color.White;
            this.btnZalogujsie.Location = new System.Drawing.Point(33, 366);
            this.btnZalogujsie.Name = "btnZalogujsie";
            this.btnZalogujsie.Size = new System.Drawing.Size(236, 51);
            this.btnZalogujsie.TabIndex = 5;
            this.btnZalogujsie.Text = "Zaloguj sie";
            this.btnZalogujsie.UseVisualStyleBackColor = false;
            this.btnZalogujsie.Click += new System.EventHandler(this.btnZalogujsie_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Location = new System.Drawing.Point(33, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Location = new System.Drawing.Point(33, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(74, 307);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 33);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(74, 192);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(195, 28);
            this.txtUsername.TabIndex = 9;
            // 
            // lbWyjdz
            // 
            this.lbWyjdz.AutoSize = true;
            this.lbWyjdz.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWyjdz.ForeColor = System.Drawing.Color.Tomato;
            this.lbWyjdz.Location = new System.Drawing.Point(127, 433);
            this.lbWyjdz.Name = "lbWyjdz";
            this.lbWyjdz.Size = new System.Drawing.Size(50, 18);
            this.lbWyjdz.TabIndex = 10;
            this.lbWyjdz.Text = "Wyjdz";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 474);
            this.Controls.Add(this.lbWyjdz);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnZalogujsie);
            this.Controls.Add(this.pcperson);
            this.Controls.Add(this.pchadlock);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcperson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pchadlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.PictureBox pchadlock;
        private System.Windows.Forms.PictureBox pcperson;
        private System.Windows.Forms.Button btnZalogujsie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbWyjdz;
    }
}