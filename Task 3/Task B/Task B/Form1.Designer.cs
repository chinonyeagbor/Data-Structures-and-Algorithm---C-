namespace Task_B
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
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.EnrolledCheckBox = new System.Windows.Forms.CheckBox();
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(232, 51);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(232, 84);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(232, 117);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(232, 152);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(93, 53);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 4;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(93, 108);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(12, 57);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(58, 13);
            this.IdLabel.TabIndex = 7;
            this.IdLabel.Text = "Student ID";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(12, 111);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(75, 13);
            this.StudentNameLabel.TabIndex = 8;
            this.StudentNameLabel.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Student Enrolment App";
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Location = new System.Drawing.Point(12, 197);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(45, 13);
            this.PreviewLabel.TabIndex = 10;
            this.PreviewLabel.Text = "Preview";
            // 
            // EnrolledCheckBox
            // 
            this.EnrolledCheckBox.AutoSize = true;
            this.EnrolledCheckBox.Location = new System.Drawing.Point(93, 151);
            this.EnrolledCheckBox.Name = "EnrolledCheckBox";
            this.EnrolledCheckBox.Size = new System.Drawing.Size(64, 17);
            this.EnrolledCheckBox.TabIndex = 11;
            this.EnrolledCheckBox.Text = "Enrolled";
            this.EnrolledCheckBox.UseVisualStyleBackColor = true;
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.Location = new System.Drawing.Point(360, 51);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(317, 147);
            this.StudentsListBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 246);
            this.Controls.Add(this.StudentsListBox);
            this.Controls.Add(this.EnrolledCheckBox);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdTextBox);
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
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.CheckBox EnrolledCheckBox;
        private System.Windows.Forms.ListBox StudentsListBox;
    }
}

