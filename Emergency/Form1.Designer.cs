﻿namespace Emergency
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
            this.label_PatientsName = new System.Windows.Forms.Label();
            this.label_Priority = new System.Windows.Forms.Label();
            this.textBox_PatientsName = new System.Windows.Forms.TextBox();
            this.textBox_Priority = new System.Windows.Forms.TextBox();
            this.button_AddPatient = new System.Windows.Forms.Button();
            this.button_CallPatient = new System.Windows.Forms.Button();
            this.textBox_nextPatient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_PatientsName
            // 
            this.label_PatientsName.AutoSize = true;
            this.label_PatientsName.Location = new System.Drawing.Point(26, 13);
            this.label_PatientsName.Name = "label_PatientsName";
            this.label_PatientsName.Size = new System.Drawing.Size(76, 13);
            this.label_PatientsName.TabIndex = 3;
            this.label_PatientsName.Text = "Patients Name";
            // 
            // label_Priority
            // 
            this.label_Priority.AutoSize = true;
            this.label_Priority.Location = new System.Drawing.Point(26, 40);
            this.label_Priority.Name = "label_Priority";
            this.label_Priority.Size = new System.Drawing.Size(62, 13);
            this.label_Priority.TabIndex = 1;
            this.label_Priority.Text = "Priority (1-5)";
            // 
            // textBox_PatientsName
            // 
            this.textBox_PatientsName.Location = new System.Drawing.Point(129, 10);
            this.textBox_PatientsName.Name = "textBox_PatientsName";
            this.textBox_PatientsName.Size = new System.Drawing.Size(251, 20);
            this.textBox_PatientsName.TabIndex = 0;
            this.textBox_PatientsName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_PatientName_Validating);
            // 
            // textBox_Priority
            // 
            this.textBox_Priority.Location = new System.Drawing.Point(129, 37);
            this.textBox_Priority.Name = "textBox_Priority";
            this.textBox_Priority.Size = new System.Drawing.Size(251, 20);
            this.textBox_Priority.TabIndex = 1;
            this.textBox_Priority.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Priority_KeyPress);
            this.textBox_Priority.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_PatientName_Validating);
            // 
            // button_AddPatient
            // 
            this.button_AddPatient.Location = new System.Drawing.Point(29, 96);
            this.button_AddPatient.Name = "button_AddPatient";
            this.button_AddPatient.Size = new System.Drawing.Size(175, 23);
            this.button_AddPatient.TabIndex = 2;
            this.button_AddPatient.Text = "Add Patient To Queue";
            this.button_AddPatient.UseVisualStyleBackColor = true;
            this.button_AddPatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_CallPatient
            // 
            this.button_CallPatient.Location = new System.Drawing.Point(210, 96);
            this.button_CallPatient.Name = "button_CallPatient";
            this.button_CallPatient.Size = new System.Drawing.Size(170, 23);
            this.button_CallPatient.TabIndex = 3;
            this.button_CallPatient.Text = "Call Next Patient";
            this.button_CallPatient.UseVisualStyleBackColor = true;
            this.button_CallPatient.Click += new System.EventHandler(this.button_CallPatient_Click);
            // 
            // textBox_nextPatient
            // 
            this.textBox_nextPatient.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_nextPatient.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_nextPatient.Location = new System.Drawing.Point(106, 134);
            this.textBox_nextPatient.Name = "textBox_nextPatient";
            this.textBox_nextPatient.ReadOnly = true;
            this.textBox_nextPatient.Size = new System.Drawing.Size(271, 20);
            this.textBox_nextPatient.TabIndex = 6;
            this.textBox_nextPatient.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Next Patient :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(32, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 202);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waiting Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Priority";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(84, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 143);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_nextPatient);
            this.Controls.Add(this.button_CallPatient);
            this.Controls.Add(this.button_AddPatient);
            this.Controls.Add(this.textBox_Priority);
            this.Controls.Add(this.textBox_PatientsName);
            this.Controls.Add(this.label_Priority);
            this.Controls.Add(this.label_PatientsName);
            this.MaximumSize = new System.Drawing.Size(434, 428);
            this.MinimumSize = new System.Drawing.Size(434, 428);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accident & Emergency";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PatientsName;
        private System.Windows.Forms.Label label_Priority;
        private System.Windows.Forms.TextBox textBox_PatientsName;
        private System.Windows.Forms.TextBox textBox_Priority;
        private System.Windows.Forms.Button button_AddPatient;
        private System.Windows.Forms.Button button_CallPatient;
        private System.Windows.Forms.TextBox textBox_nextPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

