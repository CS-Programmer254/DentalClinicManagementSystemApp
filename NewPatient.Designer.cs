namespace DentalClinicManagementSystemApp
{
    partial class NewPatientForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPatientName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbResidence = new System.Windows.Forms.TextBox();
            this.SavePatientBtn = new System.Windows.Forms.Button();
            this.ClearPatientBtn = new System.Windows.Forms.Button();
            this.cbInsurance = new System.Windows.Forms.ComboBox();
            this.cbFileNo = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(83, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient File No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(83, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(83, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(83, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telephone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(83, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Insurance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(83, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Area Of Residence:";
            // 
            // tbPatientName
            // 
            this.tbPatientName.Location = new System.Drawing.Point(295, 91);
            this.tbPatientName.Name = "tbPatientName";
            this.tbPatientName.Size = new System.Drawing.Size(331, 26);
            this.tbPatientName.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(295, 151);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(331, 26);
            this.tbEmail.TabIndex = 12;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(295, 203);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(331, 26);
            this.tbTelephone.TabIndex = 13;
            // 
            // tbResidence
            // 
            this.tbResidence.Location = new System.Drawing.Point(295, 362);
            this.tbResidence.Name = "tbResidence";
            this.tbResidence.Size = new System.Drawing.Size(331, 26);
            this.tbResidence.TabIndex = 15;
            // 
            // SavePatientBtn
            // 
            this.SavePatientBtn.BackColor = System.Drawing.Color.White;
            this.SavePatientBtn.FlatAppearance.BorderSize = 0;
            this.SavePatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SavePatientBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SavePatientBtn.Location = new System.Drawing.Point(317, 421);
            this.SavePatientBtn.Name = "SavePatientBtn";
            this.SavePatientBtn.Padding = new System.Windows.Forms.Padding(1);
            this.SavePatientBtn.Size = new System.Drawing.Size(75, 44);
            this.SavePatientBtn.TabIndex = 16;
            this.SavePatientBtn.Text = "Save";
            this.SavePatientBtn.UseVisualStyleBackColor = false;
            this.SavePatientBtn.Click += new System.EventHandler(this.SavePatientBtn_Click);
            // 
            // ClearPatientBtn
            // 
            this.ClearPatientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClearPatientBtn.FlatAppearance.BorderSize = 0;
            this.ClearPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearPatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ClearPatientBtn.ForeColor = System.Drawing.Color.White;
            this.ClearPatientBtn.Location = new System.Drawing.Point(535, 421);
            this.ClearPatientBtn.Name = "ClearPatientBtn";
            this.ClearPatientBtn.Padding = new System.Windows.Forms.Padding(1);
            this.ClearPatientBtn.Size = new System.Drawing.Size(75, 44);
            this.ClearPatientBtn.TabIndex = 17;
            this.ClearPatientBtn.Text = "Clear";
            this.ClearPatientBtn.UseVisualStyleBackColor = false;
            this.ClearPatientBtn.Click += new System.EventHandler(this.ClearPatientBtn_Click);
            // 
            // cbInsurance
            // 
            this.cbInsurance.FormattingEnabled = true;
            this.cbInsurance.Location = new System.Drawing.Point(295, 300);
            this.cbInsurance.Name = "cbInsurance";
            this.cbInsurance.Size = new System.Drawing.Size(331, 28);
            this.cbInsurance.TabIndex = 18;
            // 
            // cbFileNo
            // 
            this.cbFileNo.FormattingEnabled = true;
            this.cbFileNo.Location = new System.Drawing.Point(295, 45);
            this.cbFileNo.Name = "cbFileNo";
            this.cbFileNo.Size = new System.Drawing.Size(331, 28);
            this.cbFileNo.TabIndex = 19;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(295, 249);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(331, 28);
            this.cbGender.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(83, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Gender:";
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(754, 511);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbFileNo);
            this.Controls.Add(this.cbInsurance);
            this.Controls.Add(this.ClearPatientBtn);
            this.Controls.Add(this.SavePatientBtn);
            this.Controls.Add(this.tbResidence);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPatientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewPatientForm";
            this.Text = "New Patient Registration";
            this.Load += new System.EventHandler(this.NewPatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPatientName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbResidence;
        private System.Windows.Forms.Button SavePatientBtn;
        private System.Windows.Forms.Button ClearPatientBtn;
        private System.Windows.Forms.ComboBox cbInsurance;
        private System.Windows.Forms.ComboBox cbFileNo;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label7;
    }
}