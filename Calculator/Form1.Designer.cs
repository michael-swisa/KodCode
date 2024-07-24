namespace Calculator
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDual = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnNkuda = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDifference = new System.Windows.Forms.Button();
            this.cmbOperater = new System.Windows.Forms.ComboBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.Location = new System.Drawing.Point(277, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(84, 32);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "result";
            this.lblResult.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEqual.Location = new System.Drawing.Point(3, 233);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(87, 65);
            this.btnEqual.TabIndex = 7;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(3, 3);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(87, 22);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.TextChanged += new System.EventHandler(this.txtNumber1_TextChanged);
            this.txtNumber1.Enter += new System.EventHandler(this.txtNumber1_Enter);
            // 
            // txtNumber2
            // 
            this.txtNumber2.ForeColor = System.Drawing.Color.Black;
            this.txtNumber2.Location = new System.Drawing.Point(186, 3);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(85, 22);
            this.txtNumber2.TabIndex = 2;
            this.txtNumber2.Enter += new System.EventHandler(this.txtNumber2_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtNumber2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDual, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNkuda, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEqual, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMinus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblResult, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDifference, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbOperater, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPlus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNumber1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(64, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 353);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDual
            // 
            this.btnDual.BackColor = System.Drawing.Color.Gold;
            this.btnDual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDual.Location = new System.Drawing.Point(277, 169);
            this.btnDual.Name = "btnDual";
            this.btnDual.Size = new System.Drawing.Size(75, 58);
            this.btnDual.TabIndex = 22;
            this.btnDual.Text = "*";
            this.btnDual.UseVisualStyleBackColor = false;
            this.btnDual.Click += new System.EventHandler(this.btnDual_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn1.Location = new System.Drawing.Point(3, 44);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(87, 53);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click_global);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn3.Location = new System.Drawing.Point(186, 44);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 53);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click_global);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn4.Location = new System.Drawing.Point(3, 103);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(87, 60);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click_global);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn5.Location = new System.Drawing.Point(96, 103);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(84, 60);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click_global);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn6.Location = new System.Drawing.Point(186, 103);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(85, 60);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click_global);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn7.Location = new System.Drawing.Point(3, 169);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(87, 58);
            this.btn7.TabIndex = 14;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click_global);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn8.Location = new System.Drawing.Point(96, 169);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(84, 58);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click_global);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn9.Location = new System.Drawing.Point(186, 169);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(85, 58);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click_global);
            // 
            // btnNkuda
            // 
            this.btnNkuda.BackColor = System.Drawing.Color.Gold;
            this.btnNkuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNkuda.Location = new System.Drawing.Point(186, 233);
            this.btnNkuda.Name = "btnNkuda";
            this.btnNkuda.Size = new System.Drawing.Size(85, 65);
            this.btnNkuda.TabIndex = 17;
            this.btnNkuda.Text = ".";
            this.btnNkuda.UseVisualStyleBackColor = false;
            this.btnNkuda.Click += new System.EventHandler(this.btnNkuda_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn0.Location = new System.Drawing.Point(96, 233);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(84, 65);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_Click_global);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn2.Location = new System.Drawing.Point(96, 44);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(84, 53);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click_global);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Gold;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMinus.Location = new System.Drawing.Point(277, 103);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 60);
            this.btnMinus.TabIndex = 20;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDifference
            // 
            this.btnDifference.BackColor = System.Drawing.Color.Gold;
            this.btnDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDifference.Location = new System.Drawing.Point(277, 233);
            this.btnDifference.Name = "btnDifference";
            this.btnDifference.Size = new System.Drawing.Size(75, 65);
            this.btnDifference.TabIndex = 21;
            this.btnDifference.Text = "/";
            this.btnDifference.UseVisualStyleBackColor = false;
            this.btnDifference.Click += new System.EventHandler(this.btnDifference_Click);
            // 
            // cmbOperater
            // 
            this.cmbOperater.FormattingEnabled = true;
            this.cmbOperater.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperater.Location = new System.Drawing.Point(96, 3);
            this.cmbOperater.Name = "cmbOperater";
            this.cmbOperater.Size = new System.Drawing.Size(84, 24);
            this.cmbOperater.TabIndex = 23;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Gold;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPlus.Location = new System.Drawing.Point(277, 44);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 53);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnNkuda;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDifference;
        private System.Windows.Forms.Button btnDual;
        private System.Windows.Forms.ComboBox cmbOperater;
    }
}

