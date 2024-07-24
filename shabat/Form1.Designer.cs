namespace shabat
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
            this.txth = new System.Windows.Forms.TextBox();
            this.txtw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RH = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CAR = new System.Windows.Forms.RadioButton();
            this.RHR = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(34, 141);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(100, 22);
            this.txth.TabIndex = 0;
            // 
            // txtw
            // 
            this.txtw.Location = new System.Drawing.Point(34, 230);
            this.txtw.Name = "txtw";
            this.txtw.Size = new System.Drawing.Size(100, 22);
            this.txtw.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "בירור ההלכה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "גובה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "רוחב";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "מיקום";
            // 
            // RH
            // 
            this.RH.AutoSize = true;
            this.RH.Location = new System.Drawing.Point(32, 20);
            this.RH.Name = "RH";
            this.RH.Size = new System.Drawing.Size(95, 20);
            this.RH.TabIndex = 3;
            this.RH.TabStop = true;
            this.RH.Text = "רשות היחיד";
            this.RH.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CAR);
            this.panel1.Controls.Add(this.RHR);
            this.panel1.Controls.Add(this.RH);
            this.panel1.Location = new System.Drawing.Point(203, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 159);
            this.panel1.TabIndex = 4;
            // 
            // CAR
            // 
            this.CAR.AutoSize = true;
            this.CAR.Location = new System.Drawing.Point(32, 109);
            this.CAR.Name = "CAR";
            this.CAR.Size = new System.Drawing.Size(72, 20);
            this.CAR.TabIndex = 3;
            this.CAR.TabStop = true;
            this.CAR.Text = "כרמלית";
            this.CAR.UseVisualStyleBackColor = true;
            // 
            // RHR
            // 
            this.RHR.AutoSize = true;
            this.RHR.Location = new System.Drawing.Point(32, 67);
            this.RHR.Name = "RHR";
            this.RHR.Size = new System.Drawing.Size(97, 20);
            this.RHR.TabIndex = 3;
            this.RHR.TabStop = true;
            this.RHR.Text = "רשות הרבים";
            this.RHR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtw);
            this.Controls.Add(this.txth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.TextBox txtw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RHR;
        private System.Windows.Forms.RadioButton CAR;
    }
}

