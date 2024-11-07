namespace Task_C
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
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.StudentStatusButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StudentIdLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.DisplayNameButton = new System.Windows.Forms.Button();
            this.EnrolledCheckBox = new System.Windows.Forms.CheckBox();
            this.NotEnrolledCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(235, 53);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(235, 83);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(88, 23);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(235, 143);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(88, 23);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(235, 113);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(88, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // StudentStatusButton
            // 
            this.StudentStatusButton.Location = new System.Drawing.Point(235, 202);
            this.StudentStatusButton.Name = "StudentStatusButton";
            this.StudentStatusButton.Size = new System.Drawing.Size(88, 23);
            this.StudentStatusButton.TabIndex = 5;
            this.StudentStatusButton.Text = "Student Status";
            this.StudentStatusButton.UseVisualStyleBackColor = true;
            this.StudentStatusButton.Click += new System.EventHandler(this.StudentStatusButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(98, 59);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(98, 90);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // StudentIdLabel
            // 
            this.StudentIdLabel.AutoSize = true;
            this.StudentIdLabel.Location = new System.Drawing.Point(17, 66);
            this.StudentIdLabel.Name = "StudentIdLabel";
            this.StudentIdLabel.Size = new System.Drawing.Size(58, 13);
            this.StudentIdLabel.TabIndex = 9;
            this.StudentIdLabel.Text = "Student ID";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(17, 97);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(75, 13);
            this.StudentNameLabel.TabIndex = 10;
            this.StudentNameLabel.Text = "Student Name";
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Location = new System.Drawing.Point(17, 183);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(45, 13);
            this.PreviewLabel.TabIndex = 11;
            this.PreviewLabel.Text = "Preview";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Student Enrolment App";
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.Location = new System.Drawing.Point(329, 53);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(239, 173);
            this.StudentListBox.TabIndex = 13;
            // 
            // DisplayNameButton
            // 
            this.DisplayNameButton.Location = new System.Drawing.Point(235, 173);
            this.DisplayNameButton.Name = "DisplayNameButton";
            this.DisplayNameButton.Size = new System.Drawing.Size(88, 23);
            this.DisplayNameButton.TabIndex = 18;
            this.DisplayNameButton.Text = "Display Name";
            this.DisplayNameButton.UseVisualStyleBackColor = true;
            this.DisplayNameButton.Click += new System.EventHandler(this.DisplayNameButton_Click);
            // 
            // EnrolledCheckBox
            // 
            this.EnrolledCheckBox.AutoSize = true;
            this.EnrolledCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrolledCheckBox.Location = new System.Drawing.Point(98, 128);
            this.EnrolledCheckBox.Name = "EnrolledCheckBox";
            this.EnrolledCheckBox.Size = new System.Drawing.Size(64, 17);
            this.EnrolledCheckBox.TabIndex = 16;
            this.EnrolledCheckBox.Text = "Enrolled";
            this.EnrolledCheckBox.UseVisualStyleBackColor = true;
            // 
            // NotEnrolledCheckBox
            // 
            this.NotEnrolledCheckBox.AutoSize = true;
            this.NotEnrolledCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotEnrolledCheckBox.Location = new System.Drawing.Point(98, 151);
            this.NotEnrolledCheckBox.Name = "NotEnrolledCheckBox";
            this.NotEnrolledCheckBox.Size = new System.Drawing.Size(83, 17);
            this.NotEnrolledCheckBox.TabIndex = 17;
            this.NotEnrolledCheckBox.Text = "Not Enrolled";
            this.NotEnrolledCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 473);
            this.Controls.Add(this.DisplayNameButton);
            this.Controls.Add(this.NotEnrolledCheckBox);
            this.Controls.Add(this.EnrolledCheckBox);
            this.Controls.Add(this.StudentListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.StudentIdLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.StudentStatusButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button StudentStatusButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label StudentIdLabel;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.Button DisplayNameButton;
        private System.Windows.Forms.CheckBox EnrolledCheckBox;
        private System.Windows.Forms.CheckBox NotEnrolledCheckBox;
    }
}

