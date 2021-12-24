
namespace _2LayerApp
{
    partial class Dashboard
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
            this.dtEmployee = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Label();
            this.ttravel = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.tbudget = new System.Windows.Forms.TextBox();
            this.tpre = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndel = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtEmployee
            // 
            this.dtEmployee.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dtEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEmployee.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtEmployee.Location = new System.Drawing.Point(475, 293);
            this.dtEmployee.Name = "dtEmployee";
            this.dtEmployee.RowHeadersWidth = 51;
            this.dtEmployee.RowTemplate.Height = 24;
            this.dtEmployee.Size = new System.Drawing.Size(486, 421);
            this.dtEmployee.TabIndex = 0;
            this.dtEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEmployee_CellContentClick);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(507, 58);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(71, 25);
            this.search.TabIndex = 1;
            this.search.Text = "Offers";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // ttravel
            // 
            this.ttravel.Location = new System.Drawing.Point(597, 58);
            this.ttravel.Name = "ttravel";
            this.ttravel.Size = new System.Drawing.Size(233, 22);
            this.ttravel.TabIndex = 2;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(657, 117);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.ClickUser);
            // 
            // tbudget
            // 
            this.tbudget.Location = new System.Drawing.Point(1076, 160);
            this.tbudget.Name = "tbudget";
            this.tbudget.Size = new System.Drawing.Size(229, 22);
            this.tbudget.TabIndex = 5;
            // 
            // tpre
            // 
            this.tpre.Location = new System.Drawing.Point(1076, 117);
            this.tpre.Name = "tpre";
            this.tpre.Size = new System.Drawing.Size(229, 22);
            this.tpre.TabIndex = 6;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.address.Location = new System.Drawing.Point(994, 160);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(76, 24);
            this.address.TabIndex = 8;
            this.address.Text = "Budget";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(947, 116);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(123, 24);
            this.name.TabIndex = 9;
            this.name.Text = "Preferences";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(1072, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "according to your  choices";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(1080, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Make requests ";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(1145, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sent request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(1211, 670);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "Homepage";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.HomeFunction);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.Location = new System.Drawing.Point(1118, 670);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 44);
            this.button3.TabIndex = 23;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Exit);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_2LayerApp.Properties.Resources.Travel_makes_you_a_better_person2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 729);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Image = global::_2LayerApp.Properties.Resources.gettyimages_9331012841;
            this.btndel.Location = new System.Drawing.Point(1076, 211);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(91, 40);
            this.btndel.TabIndex = 11;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.DeleteFunchtion);
            // 
            // btnup
            // 
            this.btnup.BackgroundImage = global::_2LayerApp.Properties.Resources.gettyimages_9331012842;
            this.btnup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnup.Location = new System.Drawing.Point(1211, 211);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(94, 40);
            this.btnup.TabIndex = 10;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.UpdateClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(611, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Look up current offers";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1317, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.name);
            this.Controls.Add(this.address);
            this.Controls.Add(this.tpre);
            this.Controls.Add(this.tbudget);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.ttravel);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dtEmployee);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtEmployee;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox ttravel;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox tbudget;
        private System.Windows.Forms.TextBox tpre;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}