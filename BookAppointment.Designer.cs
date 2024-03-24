namespace DentalClinicManagementSystemApp
{
    partial class BookAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAppointment));
            this.tbPatientName = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.cbDentist = new System.Windows.Forms.ComboBox();
            this.cbAppointmentTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDentalProcedure = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPatientName
            // 
            this.tbPatientName.Location = new System.Drawing.Point(195, 22);
            this.tbPatientName.Name = "tbPatientName";
            this.tbPatientName.Size = new System.Drawing.Size(290, 26);
            this.tbPatientName.TabIndex = 0;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(195, 123);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(290, 26);
            this.tbTelephone.TabIndex = 2;
            // 
            // cbDentist
            // 
            this.cbDentist.FormattingEnabled = true;
            this.cbDentist.Location = new System.Drawing.Point(195, 170);
            this.cbDentist.Name = "cbDentist";
            this.cbDentist.Size = new System.Drawing.Size(290, 28);
            this.cbDentist.TabIndex = 3;
            // 
            // cbAppointmentTime
            // 
            this.cbAppointmentTime.FormattingEnabled = true;
            this.cbAppointmentTime.Items.AddRange(new object[] {
            "08.00 a.m",
            "08.30 a.m",
            "09.00 a.m",
            "10.00 a.m",
            "10.30 a.m",
            "11.30 a.m",
            "12.00 p.m",
            "12.30 p.m",
            "1.00 p.m",
            "1.30 p.m",
            "2.00 p.m",
            "2.30 p.m",
            "3.00 p.m",
            "3.30 p.m",
            "4.00 p.m"});
            this.cbAppointmentTime.Location = new System.Drawing.Point(745, 73);
            this.cbAppointmentTime.Name = "cbAppointmentTime";
            this.cbAppointmentTime.Size = new System.Drawing.Size(263, 28);
            this.cbAppointmentTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dental Procedure:";
            // 
            // cbDentalProcedure
            // 
            this.cbDentalProcedure.FormattingEnabled = true;
            this.cbDentalProcedure.Location = new System.Drawing.Point(195, 73);
            this.cbDentalProcedure.Name = "cbDentalProcedure";
            this.cbDentalProcedure.Size = new System.Drawing.Size(290, 28);
            this.cbDentalProcedure.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Patient Telephone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select Dentist:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select Appointment Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Select Appointment Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAppointments);
            this.groupBox1.Location = new System.Drawing.Point(28, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 271);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recent Appointments";
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersWidth = 62;
            this.dataGridViewAppointments.RowTemplate.Height = 28;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(968, 230);
            this.dataGridViewAppointments.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(745, 167);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(263, 26);
            this.tbSearch.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search:";
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.White;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBook.Location = new System.Drawing.Point(28, 501);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 39);
            this.btnBook.TabIndex = 16;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit.Location = new System.Drawing.Point(195, 501);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 39);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(363, 501);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.BackColor = System.Drawing.Color.White;
            this.btnCancelAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAppointment.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelAppointment.Location = new System.Drawing.Point(513, 501);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(75, 39);
            this.btnCancelAppointment.TabIndex = 18;
            this.btnCancelAppointment.Text = "Cancel";
            this.btnCancelAppointment.UseVisualStyleBackColor = false;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.Lime;
            this.btnBack.Location = new System.Drawing.Point(789, 501);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(219, 38);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back To Dashboard";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbAppointmentDate
            // 
            this.cbAppointmentDate.Location = new System.Drawing.Point(745, 22);
            this.cbAppointmentDate.Name = "cbAppointmentDate";
            this.cbAppointmentDate.Size = new System.Drawing.Size(263, 26);
            this.cbAppointmentDate.TabIndex = 20;
            // 
            // BookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1037, 552);
            this.Controls.Add(this.cbAppointmentDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDentalProcedure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAppointmentTime);
            this.Controls.Add(this.cbDentist);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbPatientName);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Appointment";
            this.Load += new System.EventHandler(this.BookAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPatientName;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.ComboBox cbDentist;
        private System.Windows.Forms.ComboBox cbAppointmentTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDentalProcedure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker cbAppointmentDate;
    }
}