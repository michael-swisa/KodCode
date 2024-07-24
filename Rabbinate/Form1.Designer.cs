namespace Rabbinate
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
            this.CBDayWeek = new System.Windows.Forms.ComboBox();
            this.CBDayMonth = new System.Windows.Forms.ComboBox();
            this.CBMonth = new System.Windows.Forms.ComboBox();
            this.CBYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBDayWeek
            // 
            this.CBDayWeek.FormattingEnabled = true;
            this.CBDayWeek.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "ששי"});
            this.CBDayWeek.Location = new System.Drawing.Point(667, 115);
            this.CBDayWeek.Name = "CBDayWeek";
            this.CBDayWeek.Size = new System.Drawing.Size(121, 24);
            this.CBDayWeek.TabIndex = 0;
            // 
            // CBDayMonth
            // 
            this.CBDayMonth.FormattingEnabled = true;
            this.CBDayMonth.Items.AddRange(new object[] {
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
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.CBDayMonth.Location = new System.Drawing.Point(493, 115);
            this.CBDayMonth.Name = "CBDayMonth";
            this.CBDayMonth.Size = new System.Drawing.Size(121, 24);
            this.CBDayMonth.TabIndex = 0;
            // 
            // CBMonth
            // 
            this.CBMonth.FormattingEnabled = true;
            this.CBMonth.Items.AddRange(new object[] {
            "תשרי",
            "מרחשון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר",
            "אדר הראשון",
            "אדר השני",
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב",
            "אלול"});
            this.CBMonth.Location = new System.Drawing.Point(297, 115);
            this.CBMonth.Name = "CBMonth";
            this.CBMonth.Size = new System.Drawing.Size(121, 24);
            this.CBMonth.TabIndex = 0;
            // 
            // CBYear
            // 
            this.CBYear.FormattingEnabled = true;
            this.CBYear.Items.AddRange(new object[] {
            "תשפ\'\'ד",
            "תשפ\'\'ה",
            "תשפ\'\'ו",
            "תשפ\'\'ז",
            "תשפ\'\'ח",
            "תשפ\'\'ט",
            "תש\'\'צ",
            "תשצ\'\'א",
            "תשצ\'\'ב",
            "תשצ\'\'ד"});
            this.CBYear.Location = new System.Drawing.Point(113, 115);
            this.CBYear.Name = "CBYear";
            this.CBYear.Size = new System.Drawing.Size(121, 24);
            this.CBYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "יום בשבוע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "יום בחודש";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "חודש";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "שנה";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(526, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 44);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "שמירה";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "בדיקת הפורמט של התאריך";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBYear);
            this.Controls.Add(this.CBMonth);
            this.Controls.Add(this.CBDayMonth);
            this.Controls.Add(this.CBDayWeek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBDayWeek;
        private System.Windows.Forms.ComboBox CBDayMonth;
        private System.Windows.Forms.ComboBox CBMonth;
        private System.Windows.Forms.ComboBox CBYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
    }
}

