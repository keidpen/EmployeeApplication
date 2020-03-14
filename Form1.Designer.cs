namespace EmployeeApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_fld = new System.Windows.Forms.TextBox();
            this.fn_fld = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ln_fld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pos_fld = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD EMPLOYEE";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(320, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 291);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 256);
            this.listBox1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(103, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "First Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(200, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Last Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(103, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(88, 256);
            this.listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            this.listBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(200, 29);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(88, 256);
            this.listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            this.listBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(297, 29);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(90, 256);
            this.listBox4.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(297, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Position";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID *";
            // 
            // id_fld
            // 
            this.id_fld.Location = new System.Drawing.Point(31, 107);
            this.id_fld.Name = "id_fld";
            this.id_fld.Size = new System.Drawing.Size(236, 22);
            this.id_fld.TabIndex = 3;
            // 
            // fn_fld
            // 
            this.fn_fld.Location = new System.Drawing.Point(31, 162);
            this.fn_fld.Name = "fn_fld";
            this.fn_fld.Size = new System.Drawing.Size(236, 22);
            this.fn_fld.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name *";
            // 
            // ln_fld
            // 
            this.ln_fld.Location = new System.Drawing.Point(31, 219);
            this.ln_fld.Name = "ln_fld";
            this.ln_fld.Size = new System.Drawing.Size(236, 22);
            this.ln_fld.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name *";
            // 
            // pos_fld
            // 
            this.pos_fld.Location = new System.Drawing.Point(31, 277);
            this.pos_fld.Name = "pos_fld";
            this.pos_fld.Size = new System.Drawing.Size(236, 22);
            this.pos_fld.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Position *";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(87, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Employee List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 379);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pos_fld);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ln_fld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fn_fld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_fld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_fld;
        private System.Windows.Forms.TextBox fn_fld;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ln_fld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pos_fld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label11;
    }
}

