
namespace _2LayerApp
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
            this.Uname = new System.Windows.Forms.Label();
            this.Upass = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.Unamebox = new System.Windows.Forms.TextBox();
            this.Upassbox = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.reg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uname.ForeColor = System.Drawing.Color.Red;
            this.Uname.Location = new System.Drawing.Point(387, 190);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(145, 32);
            this.Uname.TabIndex = 0;
            this.Uname.Text = "Username";
            // 
            // Upass
            // 
            this.Upass.AutoSize = true;
            this.Upass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upass.ForeColor = System.Drawing.Color.Red;
            this.Upass.Location = new System.Drawing.Point(387, 260);
            this.Upass.Name = "Upass";
            this.Upass.Size = new System.Drawing.Size(139, 32);
            this.Upass.TabIndex = 1;
            this.Upass.Text = "Password";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Magneto", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Red;
            this.login.Location = new System.Drawing.Point(628, 75);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(182, 58);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Unamebox
            // 
            this.Unamebox.Location = new System.Drawing.Point(561, 200);
            this.Unamebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Unamebox.Name = "Unamebox";
            this.Unamebox.Size = new System.Drawing.Size(299, 22);
            this.Unamebox.TabIndex = 3;
            this.Unamebox.TextChanged += new System.EventHandler(this.Unamebox_TextChanged);
            // 
            // Upassbox
            // 
            this.Upassbox.Location = new System.Drawing.Point(561, 260);
            this.Upassbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Upassbox.Name = "Upassbox";
            this.Upassbox.Size = new System.Drawing.Size(299, 22);
            this.Upassbox.TabIndex = 4;
            this.Upassbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn.Location = new System.Drawing.Point(636, 343);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(105, 42);
            this.btn.TabIndex = 5;
            this.btn.Text = "Login";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.LoginClick);
            // 
            // reg
            // 
            this.reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.reg.Location = new System.Drawing.Point(896, 496);
            this.reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(108, 42);
            this.reg.TabIndex = 7;
            this.reg.Text = "Sign up";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.openregisterform);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(867, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Haven\'t signed up yet?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(380, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 11);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_2LayerApp.Properties.Resources.background_design_textures_115539707686gfbkav0i1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 569);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1032, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.Upassbox);
            this.Controls.Add(this.Unamebox);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Upass);
            this.Controls.Add(this.Uname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Uname;
        private System.Windows.Forms.Label Upass;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox Unamebox;
        private System.Windows.Forms.TextBox Upassbox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

