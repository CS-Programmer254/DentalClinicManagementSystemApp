namespace DentalClinicManagementSystemApp
{
    partial class Splashscreen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(56, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADVANCE CARE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(67, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "DENTAL CLINIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(21, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Management System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(25, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "copyright@2023PaulStanley";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.countLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(110, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 69);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(58, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "%";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.Color.White;
            this.countLabel.Location = new System.Drawing.Point(28, 19);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(24, 28);
            this.countLabel.TabIndex = 0;
            this.countLabel.Text = "0";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 53);
            this.panel2.TabIndex = 5;
            // 
            // splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
    }
}