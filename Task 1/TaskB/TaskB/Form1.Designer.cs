namespace TaskB
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
            this.CustomerInput = new System.Windows.Forms.TextBox();
            this.EnqueueButton = new System.Windows.Forms.Button();
            this.DequeueButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.QueueTotalLabel = new System.Windows.Forms.Label();
            this.Preview = new System.Windows.Forms.ListBox();
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomerInput
            // 
            this.CustomerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInput.Location = new System.Drawing.Point(38, 44);
            this.CustomerInput.Name = "CustomerInput";
            this.CustomerInput.Size = new System.Drawing.Size(202, 23);
            this.CustomerInput.TabIndex = 0;
            // 
            // EnqueueButton
            // 
            this.EnqueueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnqueueButton.Location = new System.Drawing.Point(36, 69);
            this.EnqueueButton.Name = "EnqueueButton";
            this.EnqueueButton.Size = new System.Drawing.Size(114, 32);
            this.EnqueueButton.TabIndex = 1;
            this.EnqueueButton.Text = "Add";
            this.EnqueueButton.UseVisualStyleBackColor = true;
            this.EnqueueButton.Click += new System.EventHandler(this.EnqueueButton_Click);
            // 
            // DequeueButton
            // 
            this.DequeueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DequeueButton.Location = new System.Drawing.Point(129, 69);
            this.DequeueButton.Name = "DequeueButton";
            this.DequeueButton.Size = new System.Drawing.Size(111, 32);
            this.DequeueButton.TabIndex = 2;
            this.DequeueButton.Text = "Remove";
            this.DequeueButton.UseVisualStyleBackColor = true;
            this.DequeueButton.Click += new System.EventHandler(this.DequeueButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(38, 220);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(202, 47);
            this.DisplayButton.TabIndex = 3;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // QueueTotalLabel
            // 
            this.QueueTotalLabel.AutoSize = true;
            this.QueueTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueTotalLabel.Location = new System.Drawing.Point(36, 270);
            this.QueueTotalLabel.Name = "QueueTotalLabel";
            this.QueueTotalLabel.Size = new System.Drawing.Size(66, 13);
            this.QueueTotalLabel.TabIndex = 4;
            this.QueueTotalLabel.Text = "Queue Total";
            this.QueueTotalLabel.Click += new System.EventHandler(this.QueueTotalLabel_Click);
            // 
            // Preview
            // 
            this.Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preview.FormattingEnabled = true;
            this.Preview.Location = new System.Drawing.Point(36, 107);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(202, 95);
            this.Preview.TabIndex = 5;
            // 
            // DisplayBox
            // 
            this.DisplayBox.Location = new System.Drawing.Point(38, 289);
            this.DisplayBox.Multiline = true;
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.Size = new System.Drawing.Size(202, 182);
            this.DisplayBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(368, 528);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.QueueTotalLabel);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.DequeueButton);
            this.Controls.Add(this.EnqueueButton);
            this.Controls.Add(this.CustomerInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerInput;
        private System.Windows.Forms.Button EnqueueButton;
        private System.Windows.Forms.Button DequeueButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label QueueTotalLabel;
        private System.Windows.Forms.ListBox Preview;
        private System.Windows.Forms.TextBox DisplayBox;
    }
}

