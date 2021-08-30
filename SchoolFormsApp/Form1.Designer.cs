
namespace SchoolFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.Label();
            this.txtTwitter = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBoxTwitter = new System.Windows.Forms.TextBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.btnTeach = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(66, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 32);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "School Name";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(66, 80);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(98, 32);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "Address";
            // 
            // txtCity
            // 
            this.txtCity.AutoSize = true;
            this.txtCity.Location = new System.Drawing.Point(66, 125);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(55, 32);
            this.txtCity.TabIndex = 2;
            this.txtCity.Text = "City";
            // 
            // txtState
            // 
            this.txtState.AutoSize = true;
            this.txtState.Location = new System.Drawing.Point(66, 171);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(67, 32);
            this.txtState.TabIndex = 3;
            this.txtState.Text = "State";
            // 
            // txtZip
            // 
            this.txtZip.AutoSize = true;
            this.txtZip.Location = new System.Drawing.Point(66, 216);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(48, 32);
            this.txtZip.TabIndex = 4;
            this.txtZip.Text = "Zip";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoSize = true;
            this.txtPhoneNumber.Location = new System.Drawing.Point(66, 261);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(177, 32);
            this.txtPhoneNumber.TabIndex = 5;
            this.txtPhoneNumber.Text = "Phone Number";
            // 
            // txtTwitter
            // 
            this.txtTwitter.AutoSize = true;
            this.txtTwitter.Location = new System.Drawing.Point(66, 306);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(86, 32);
            this.txtTwitter.TabIndex = 6;
            this.txtTwitter.Text = "Twitter";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(249, 28);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(186, 39);
            this.txtBoxName.TabIndex = 7;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(249, 73);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(186, 39);
            this.txtBoxAddress.TabIndex = 8;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(249, 118);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(186, 39);
            this.txtBoxCity.TabIndex = 9;
            // 
            // txtBoxState
            // 
            this.txtBoxState.Location = new System.Drawing.Point(249, 164);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.Size = new System.Drawing.Size(186, 39);
            this.txtBoxState.TabIndex = 10;
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Location = new System.Drawing.Point(249, 209);
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(186, 39);
            this.txtBoxZip.TabIndex = 11;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(249, 253);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(186, 39);
            this.txtBoxPhoneNumber.TabIndex = 12;
            // 
            // txtBoxTwitter
            // 
            this.txtBoxTwitter.Location = new System.Drawing.Point(249, 298);
            this.txtBoxTwitter.Name = "txtBoxTwitter";
            this.txtBoxTwitter.Size = new System.Drawing.Size(186, 39);
            this.txtBoxTwitter.TabIndex = 13;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(253, 358);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(150, 46);
            this.TestButton.TabIndex = 14;
            this.TestButton.Text = "Push to test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // btnTeach
            // 
            this.btnTeach.Location = new System.Drawing.Point(249, 421);
            this.btnTeach.Name = "btnTeach";
            this.btnTeach.Size = new System.Drawing.Size(259, 46);
            this.btnTeach.TabIndex = 15;
            this.btnTeach.Text = "Test Teacher Here";
            this.btnTeach.UseVisualStyleBackColor = true;
            this.btnTeach.Click += new System.EventHandler(this.btnTeach_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(249, 486);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(259, 46);
            this.btnStudent.TabIndex = 16;
            this.btnStudent.Text = "Test Student Here";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 589);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnTeach);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.txtBoxTwitter);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.txtBoxZip);
            this.Controls.Add(this.txtBoxState);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtTwitter);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.Label txtCity;
        private System.Windows.Forms.Label txtState;
        private System.Windows.Forms.Label txtZip;
        private System.Windows.Forms.Label txtPhoneNumber;
        private System.Windows.Forms.Label txtTwitter;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxTwitter;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button btnTeach;
        private System.Windows.Forms.Button btnStudent;
    }
}

