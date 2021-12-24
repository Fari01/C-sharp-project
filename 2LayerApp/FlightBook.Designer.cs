
namespace _2LayerApp
{
    partial class FlightBook
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtEmp = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SourceBox = new System.Windows.Forms.ComboBox();
            this.DestinationBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.CodeBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Datebox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1234, 708);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 28);
            this.button4.TabIndex = 35;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.Exit);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 548);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 31);
            this.button3.TabIndex = 34;
            this.button3.Text = "Cancel ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteFunc);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 32;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InsertFunc);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(746, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 32);
            this.label6.TabIndex = 31;
            this.label6.Text = "Search by Code";
            // 
            // dtEmp
            // 
            this.dtEmp.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dtEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEmp.GridColor = System.Drawing.SystemColors.Control;
            this.dtEmp.Location = new System.Drawing.Point(797, 260);
            this.dtEmp.Name = "dtEmp";
            this.dtEmp.RowHeadersWidth = 51;
            this.dtEmp.RowTemplate.Height = 24;
            this.dtEmp.Size = new System.Drawing.Size(506, 410);
            this.dtEmp.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, -66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Room number";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(935, 34);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(264, 22);
            this.searchbox.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, -66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-62, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dateout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-62, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Datein";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 31);
            this.label7.TabIndex = 36;
            this.label7.Text = "Take off date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 31);
            this.label8.TabIndex = 37;
            this.label8.Text = "Destination";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(130, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 31);
            this.label9.TabIndex = 38;
            this.label9.Text = "Source";
            // 
            // SourceBox
            // 
            this.SourceBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.SourceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SourceBox.FormattingEnabled = true;
            this.SourceBox.Items.AddRange(new object[] {
            "China\t",
            "United States\t",
            "Germany",
            "United Kingdom\t",
            "France",
            "Russia\t",
            "Australia",
            "Canada\t",
            "South Korea\t",
            "Italy"});
            this.SourceBox.Location = new System.Drawing.Point(232, 401);
            this.SourceBox.Name = "SourceBox";
            this.SourceBox.Size = new System.Drawing.Size(201, 37);
            this.SourceBox.TabIndex = 40;
            // 
            // DestinationBox
            // 
            this.DestinationBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DestinationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationBox.ForeColor = System.Drawing.SystemColors.Window;
            this.DestinationBox.FormattingEnabled = true;
            this.DestinationBox.Items.AddRange(new object[] {
            "China\t",
            "United States\t",
            "Germany",
            "United Kingdom\t",
            "France",
            "Russia\t",
            "Australia",
            "Canada\t",
            "South Korea\t",
            "Italy"});
            this.DestinationBox.Location = new System.Drawing.Point(232, 344);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(201, 33);
            this.DestinationBox.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(978, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "All rooms booked till now";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(1020, 84);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(78, 28);
            this.search.TabIndex = 45;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.searchfuc);
            // 
            // CodeBox
            // 
            this.CodeBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CodeBox.FormattingEnabled = true;
            this.CodeBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.CodeBox.Location = new System.Drawing.Point(232, 275);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(201, 33);
            this.CodeBox.TabIndex = 46;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 34);
            this.button2.TabIndex = 47;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Reet);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Old English Text MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = global::_2LayerApp.Properties.Resources.hotel1;
            this.label10.Location = new System.Drawing.Point(201, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 40);
            this.label10.TabIndex = 49;
            this.label10.Text = "Book your ticket";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1150, 708);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 28);
            this.button5.TabIndex = 50;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.click);
            // 
            // Datebox
            // 
            this.Datebox.BackColor = System.Drawing.SystemColors.MenuText;
            this.Datebox.ForeColor = System.Drawing.SystemColors.Window;
            this.Datebox.Location = new System.Drawing.Point(232, 458);
            this.Datebox.Name = "Datebox";
            this.Datebox.Size = new System.Drawing.Size(201, 22);
            this.Datebox.TabIndex = 51;
            this.Datebox.Text = "dd-mm-yyyy";
            // 
            // FlightBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::_2LayerApp.Properties.Resources.istockphoto_1268257924_170667a4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 748);
            this.Controls.Add(this.Datebox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DestinationBox);
            this.Controls.Add(this.SourceBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FlightBook";
            this.Opacity = 0.85D;
            this.Text = "Flightbook";
            ((System.ComponentModel.ISupportInitialize)(this.dtEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SourceBox;
        private System.Windows.Forms.ComboBox DestinationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox CodeBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Datebox;
    }
}