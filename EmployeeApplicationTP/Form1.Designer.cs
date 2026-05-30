namespace EmployeeApplicationTP
{
    partial class frmComputeSalary
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
            this.firstnamebox = new System.Windows.Forms.TextBox();
            this.jobtitlebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastnamebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ratebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.computebtn = new System.Windows.Forms.Button();
            this.fnlbl = new System.Windows.Forms.Label();
            this.bslbl = new System.Windows.Forms.Label();
            this.lnlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name ";
            // 
            // firstnamebox
            // 
            this.firstnamebox.Location = new System.Drawing.Point(10, 43);
            this.firstnamebox.Name = "firstnamebox";
            this.firstnamebox.Size = new System.Drawing.Size(136, 20);
            this.firstnamebox.TabIndex = 1;
            // 
            // jobtitlebox
            // 
            this.jobtitlebox.Location = new System.Drawing.Point(154, 91);
            this.jobtitlebox.Name = "jobtitlebox";
            this.jobtitlebox.Size = new System.Drawing.Size(136, 20);
            this.jobtitlebox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job title";
            // 
            // departmentbox
            // 
            this.departmentbox.Location = new System.Drawing.Point(12, 91);
            this.departmentbox.Name = "departmentbox";
            this.departmentbox.Size = new System.Drawing.Size(136, 20);
            this.departmentbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department";
            // 
            // lastnamebox
            // 
            this.lastnamebox.Location = new System.Drawing.Point(154, 43);
            this.lastnamebox.Name = "lastnamebox";
            this.lastnamebox.Size = new System.Drawing.Size(136, 20);
            this.lastnamebox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last name";
            // 
            // ratebox
            // 
            this.ratebox.Location = new System.Drawing.Point(12, 176);
            this.ratebox.Name = "ratebox";
            this.ratebox.Size = new System.Drawing.Size(136, 20);
            this.ratebox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rate per hour";
            // 
            // totalbox
            // 
            this.totalbox.Location = new System.Drawing.Point(154, 176);
            this.totalbox.Name = "totalbox";
            this.totalbox.Size = new System.Drawing.Size(136, 20);
            this.totalbox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total hours worked";
            // 
            // computebtn
            // 
            this.computebtn.Location = new System.Drawing.Point(93, 226);
            this.computebtn.Name = "computebtn";
            this.computebtn.Size = new System.Drawing.Size(122, 30);
            this.computebtn.TabIndex = 12;
            this.computebtn.Text = "Compute salary";
            this.computebtn.UseVisualStyleBackColor = true;
            this.computebtn.Click += new System.EventHandler(this.computebtn_Click);
            // 
            // fnlbl
            // 
            this.fnlbl.AutoSize = true;
            this.fnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlbl.Location = new System.Drawing.Point(12, 322);
            this.fnlbl.Name = "fnlbl";
            this.fnlbl.Size = new System.Drawing.Size(75, 16);
            this.fnlbl.TabIndex = 13;
            this.fnlbl.Text = "First name: ";
            // 
            // bslbl
            // 
            this.bslbl.AutoSize = true;
            this.bslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bslbl.Location = new System.Drawing.Point(12, 362);
            this.bslbl.Name = "bslbl";
            this.bslbl.Size = new System.Drawing.Size(87, 16);
            this.bslbl.TabIndex = 14;
            this.bslbl.Text = "Basic salary: ";
            // 
            // lnlbl
            // 
            this.lnlbl.AutoSize = true;
            this.lnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlbl.Location = new System.Drawing.Point(12, 342);
            this.lnlbl.Name = "lnlbl";
            this.lnlbl.Size = new System.Drawing.Size(75, 16);
            this.lnlbl.TabIndex = 15;
            this.lnlbl.Text = "Last name: ";
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 413);
            this.Controls.Add(this.lnlbl);
            this.Controls.Add(this.bslbl);
            this.Controls.Add(this.fnlbl);
            this.Controls.Add(this.computebtn);
            this.Controls.Add(this.ratebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastnamebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.departmentbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jobtitlebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstnamebox);
            this.Controls.Add(this.label1);
            this.Name = "frmComputeSalary";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstnamebox;
        private System.Windows.Forms.TextBox jobtitlebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastnamebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ratebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button computebtn;
        private System.Windows.Forms.Label fnlbl;
        private System.Windows.Forms.Label bslbl;
        private System.Windows.Forms.Label lnlbl;
    }
}

