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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QueueTotalLabel = new System.Windows.Forms.Label();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.Preview = new System.Windows.Forms.ListBox();
            this.EnqueueButton = new System.Windows.Forms.Button();
            this.DequeueButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.ReverseTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Reverse = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(55, 56);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(55, 95);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // QueueTotalLabel
            // 
            this.QueueTotalLabel.AutoSize = true;
            this.QueueTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueTotalLabel.Location = new System.Drawing.Point(12, 161);
            this.QueueTotalLabel.Name = "QueueTotalLabel";
            this.QueueTotalLabel.Size = new System.Drawing.Size(64, 13);
            this.QueueTotalLabel.TabIndex = 4;
            this.QueueTotalLabel.Text = "Queue Total";
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewLabel.Location = new System.Drawing.Point(12, 136);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(45, 13);
            this.PreviewLabel.TabIndex = 5;
            this.PreviewLabel.Text = "Preview";
            // 
            // Preview
            // 
            this.Preview.FormattingEnabled = true;
            this.Preview.Location = new System.Drawing.Point(21, 246);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(134, 160);
            this.Preview.TabIndex = 6;
            // 
            // EnqueueButton
            // 
            this.EnqueueButton.Location = new System.Drawing.Point(224, 56);
            this.EnqueueButton.Name = "EnqueueButton";
            this.EnqueueButton.Size = new System.Drawing.Size(75, 23);
            this.EnqueueButton.TabIndex = 7;
            this.EnqueueButton.Text = "Add";
            this.EnqueueButton.UseVisualStyleBackColor = true;
            this.EnqueueButton.Click += new System.EventHandler(this.EnqueueButton_Click);
            // 
            // DequeueButton
            // 
            this.DequeueButton.Location = new System.Drawing.Point(224, 92);
            this.DequeueButton.Name = "DequeueButton";
            this.DequeueButton.Size = new System.Drawing.Size(75, 23);
            this.DequeueButton.TabIndex = 8;
            this.DequeueButton.Text = "Remove";
            this.DequeueButton.UseVisualStyleBackColor = true;
            this.DequeueButton.Click += new System.EventHandler(this.DequeueButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(21, 217);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(134, 23);
            this.DisplayButton.TabIndex = 9;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(205, 217);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(120, 23);
            this.ReverseButton.TabIndex = 10;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // ReverseTextBox
            // 
            this.ReverseTextBox.Location = new System.Drawing.Point(205, 191);
            this.ReverseTextBox.Name = "ReverseTextBox";
            this.ReverseTextBox.Size = new System.Drawing.Size(120, 20);
            this.ReverseTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(41, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Circular Customer Queue App";
            // 
            // Reverse
            // 
            this.Reverse.FormattingEnabled = true;
            this.Reverse.Location = new System.Drawing.Point(205, 246);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(120, 160);
            this.Reverse.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReverseTextBox);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.DequeueButton);
            this.Controls.Add(this.EnqueueButton);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.QueueTotalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label QueueTotalLabel;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.ListBox Preview;
        private System.Windows.Forms.Button EnqueueButton;
        private System.Windows.Forms.Button DequeueButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.TextBox ReverseTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Reverse;
    }
}

