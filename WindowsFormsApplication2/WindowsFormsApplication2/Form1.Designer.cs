namespace WindowsFormsApplication3
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
            this.bpt1 = new System.Windows.Forms.RadioButton();
            this.bpt2 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dpt3 = new System.Windows.Forms.RadioButton();
            this.dpt2 = new System.Windows.Forms.RadioButton();
            this.dpt1 = new System.Windows.Forms.RadioButton();
            this.apt2 = new System.Windows.Forms.RadioButton();
            this.apt1 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cpt3 = new System.Windows.Forms.RadioButton();
            this.cpt2 = new System.Windows.Forms.RadioButton();
            this.cpt1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdCheck = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "สถานภาพของผู้ตอบแบบสอบถาม";
            // 
            // bpt1
            // 
            this.bpt1.AutoSize = true;
            this.bpt1.Location = new System.Drawing.Point(6, 29);
            this.bpt1.Name = "bpt1";
            this.bpt1.Size = new System.Drawing.Size(103, 17);
            this.bpt1.TabIndex = 12;
            this.bpt1.Text = "ต่ำกว่าปริญญาตรี";
            this.bpt1.UseVisualStyleBackColor = true;
            // 
            // bpt2
            // 
            this.bpt2.AutoSize = true;
            this.bpt2.Location = new System.Drawing.Point(6, 52);
            this.bpt2.Name = "bpt2";
            this.bpt2.Size = new System.Drawing.Size(73, 17);
            this.bpt2.TabIndex = 13;
            this.bpt2.TabStop = true;
            this.bpt2.Text = "ปริญญาตรี";
            this.bpt2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dpt3);
            this.groupBox6.Controls.Add(this.dpt2);
            this.groupBox6.Controls.Add(this.dpt1);
            this.groupBox6.Location = new System.Drawing.Point(83, 343);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(228, 134);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "4. ปฏิบัติหน้าที่ขนาดบริษัท";
            // 
            // dpt3
            // 
            this.dpt3.AutoSize = true;
            this.dpt3.Location = new System.Drawing.Point(6, 79);
            this.dpt3.Name = "dpt3";
            this.dpt3.Size = new System.Drawing.Size(191, 17);
            this.dpt3.TabIndex = 22;
            this.dpt3.TabStop = true;
            this.dpt3.Text = "ขนาดใหญ่ มีจำนวนมากกว่า 300 คน";
            this.dpt3.UseVisualStyleBackColor = true;
            // 
            // dpt2
            // 
            this.dpt2.AutoSize = true;
            this.dpt2.Location = new System.Drawing.Point(5, 56);
            this.dpt2.Name = "dpt2";
            this.dpt2.Size = new System.Drawing.Size(217, 17);
            this.dpt2.TabIndex = 21;
            this.dpt2.TabStop = true;
            this.dpt2.Text = "ขนาดกลาง มีจำนวนพนักงาน 120-300 คน";
            this.dpt2.UseVisualStyleBackColor = true;
            // 
            // dpt1
            // 
            this.dpt1.AutoSize = true;
            this.dpt1.Location = new System.Drawing.Point(5, 33);
            this.dpt1.Name = "dpt1";
            this.dpt1.Size = new System.Drawing.Size(189, 17);
            this.dpt1.TabIndex = 20;
            this.dpt1.TabStop = true;
            this.dpt1.Text = "ขนาดเล็ก มีจำนวนน้อยกว่า 120 คน";
            this.dpt1.UseVisualStyleBackColor = true;
            // 
            // apt2
            // 
            this.apt2.AutoSize = true;
            this.apt2.Location = new System.Drawing.Point(74, 21);
            this.apt2.Name = "apt2";
            this.apt2.Size = new System.Drawing.Size(79, 17);
            this.apt2.TabIndex = 8;
            this.apt2.TabStop = true;
            this.apt2.Text = "รองผู้จัดการ";
            this.apt2.UseVisualStyleBackColor = true;
            this.apt2.CheckedChanged += new System.EventHandler(this.apt2_CheckedChanged);
            // 
            // apt1
            // 
            this.apt1.AutoSize = true;
            this.apt1.Location = new System.Drawing.Point(6, 21);
            this.apt1.Name = "apt1";
            this.apt1.Size = new System.Drawing.Size(62, 17);
            this.apt1.TabIndex = 7;
            this.apt1.Text = "ผู้จัดการ";
            this.apt1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "สูงกว่าปริญญาตรี";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cpt3);
            this.groupBox5.Controls.Add(this.cpt2);
            this.groupBox5.Controls.Add(this.cpt1);
            this.groupBox5.Location = new System.Drawing.Point(83, 229);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(159, 108);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "3.ประสบการณ์การทำงาน";
            // 
            // cpt3
            // 
            this.cpt3.AutoSize = true;
            this.cpt3.Location = new System.Drawing.Point(6, 74);
            this.cpt3.Name = "cpt3";
            this.cpt3.Size = new System.Drawing.Size(86, 17);
            this.cpt3.TabIndex = 19;
            this.cpt3.TabStop = true;
            this.cpt3.Text = "มากกว่า 20 ปี";
            this.cpt3.UseVisualStyleBackColor = true;
            // 
            // cpt2
            // 
            this.cpt2.AutoSize = true;
            this.cpt2.Location = new System.Drawing.Point(6, 51);
            this.cpt2.Name = "cpt2";
            this.cpt2.Size = new System.Drawing.Size(67, 17);
            this.cpt2.TabIndex = 18;
            this.cpt2.TabStop = true;
            this.cpt2.Text = "10 - 20 ปี";
            this.cpt2.UseVisualStyleBackColor = true;
            // 
            // cpt1
            // 
            this.cpt1.AutoSize = true;
            this.cpt1.Location = new System.Drawing.Point(6, 28);
            this.cpt1.Name = "cpt1";
            this.cpt1.Size = new System.Drawing.Size(88, 17);
            this.cpt1.TabIndex = 17;
            this.cpt1.TabStop = true;
            this.cpt1.Text = "น้อยกว่า 10 ปี";
            this.cpt1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.apt2);
            this.groupBox3.Controls.Add(this.apt1);
            this.groupBox3.Location = new System.Drawing.Point(83, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 45);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1.ตำแหน่งในบริษัทที่ทำงานอยู่";
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(286, 251);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(100, 28);
            this.cmdCheck.TabIndex = 27;
            this.cmdCheck.Text = "เรียบร้อย";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.bpt1);
            this.groupBox4.Controls.Add(this.bpt2);
            this.groupBox4.Location = new System.Drawing.Point(83, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 118);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2.ระดับการศึกษา";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(159, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "เลขา";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(211, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "พนักงานทั่วไป";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdCheck);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bpt1;
        private System.Windows.Forms.RadioButton bpt2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton dpt3;
        private System.Windows.Forms.RadioButton dpt2;
        private System.Windows.Forms.RadioButton dpt1;
        private System.Windows.Forms.RadioButton apt2;
        private System.Windows.Forms.RadioButton apt1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton cpt3;
        private System.Windows.Forms.RadioButton cpt2;
        private System.Windows.Forms.RadioButton cpt1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

