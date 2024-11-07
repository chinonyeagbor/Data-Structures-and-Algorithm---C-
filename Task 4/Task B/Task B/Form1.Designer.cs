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
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.ListBox();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.AddEdgeButton = new System.Windows.Forms.Button();
            this.ShowFriendsButton = new System.Windows.Forms.Button();
            this.AddBbutton = new System.Windows.Forms.Button();
            this.FriendTextBox4 = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FromEdgeLabel = new System.Windows.Forms.Label();
            this.ToEdgeLabel = new System.Windows.Forms.Label();
            this.FriendLabel = new System.Windows.Forms.Label();
            this.DispalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Location = new System.Drawing.Point(22, 25);
            this.AddNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.AddNameTextBox.TabIndex = 0;
            // 
            // Display
            // 
            this.Display.FormattingEnabled = true;
            this.Display.Location = new System.Drawing.Point(19, 86);
            this.Display.Margin = new System.Windows.Forms.Padding(2);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(121, 186);
            this.Display.TabIndex = 1;
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(296, 90);
            this.FromTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(120, 20);
            this.FromTextBox.TabIndex = 2;
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(297, 127);
            this.ToTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(119, 20);
            this.ToTextBox.TabIndex = 3;
            // 
            // AddEdgeButton
            // 
            this.AddEdgeButton.Location = new System.Drawing.Point(297, 160);
            this.AddEdgeButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddEdgeButton.Name = "AddEdgeButton";
            this.AddEdgeButton.Size = new System.Drawing.Size(116, 26);
            this.AddEdgeButton.TabIndex = 4;
            this.AddEdgeButton.Text = "Add Edge";
            this.AddEdgeButton.UseVisualStyleBackColor = true;
            this.AddEdgeButton.Click += new System.EventHandler(this.AddEdgeButton_Click);
            // 
            // ShowFriendsButton
            // 
            this.ShowFriendsButton.Location = new System.Drawing.Point(299, 248);
            this.ShowFriendsButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowFriendsButton.Name = "ShowFriendsButton";
            this.ShowFriendsButton.Size = new System.Drawing.Size(118, 24);
            this.ShowFriendsButton.TabIndex = 5;
            this.ShowFriendsButton.Text = "Show Friends";
            this.ShowFriendsButton.UseVisualStyleBackColor = true;
            this.ShowFriendsButton.Click += new System.EventHandler(this.ShowFriendsButton_Click);
            // 
            // AddBbutton
            // 
            this.AddBbutton.Location = new System.Drawing.Point(19, 49);
            this.AddBbutton.Margin = new System.Windows.Forms.Padding(2);
            this.AddBbutton.Name = "AddBbutton";
            this.AddBbutton.Size = new System.Drawing.Size(121, 29);
            this.AddBbutton.TabIndex = 6;
            this.AddBbutton.Text = "Add Person";
            this.AddBbutton.UseVisualStyleBackColor = true;
            this.AddBbutton.Click += new System.EventHandler(this.AddBbutton_Click);
            // 
            // FriendTextBox4
            // 
            this.FriendTextBox4.Location = new System.Drawing.Point(299, 209);
            this.FriendTextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.FriendTextBox4.Name = "FriendTextBox4";
            this.FriendTextBox4.Size = new System.Drawing.Size(115, 20);
            this.FriendTextBox4.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(19, 5);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name";
            // 
            // FromEdgeLabel
            // 
            this.FromEdgeLabel.AutoSize = true;
            this.FromEdgeLabel.Location = new System.Drawing.Point(253, 90);
            this.FromEdgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FromEdgeLabel.Name = "FromEdgeLabel";
            this.FromEdgeLabel.Size = new System.Drawing.Size(30, 13);
            this.FromEdgeLabel.TabIndex = 9;
            this.FromEdgeLabel.Text = "From";
            // 
            // ToEdgeLabel
            // 
            this.ToEdgeLabel.AutoSize = true;
            this.ToEdgeLabel.Location = new System.Drawing.Point(253, 131);
            this.ToEdgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToEdgeLabel.Name = "ToEdgeLabel";
            this.ToEdgeLabel.Size = new System.Drawing.Size(20, 13);
            this.ToEdgeLabel.TabIndex = 10;
            this.ToEdgeLabel.Text = "To";
            // 
            // FriendLabel
            // 
            this.FriendLabel.AutoSize = true;
            this.FriendLabel.Location = new System.Drawing.Point(253, 212);
            this.FriendLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FriendLabel.Name = "FriendLabel";
            this.FriendLabel.Size = new System.Drawing.Size(36, 13);
            this.FriendLabel.TabIndex = 11;
            this.FriendLabel.Text = "Friend";
            // 
            // DispalButton
            // 
            this.DispalButton.Location = new System.Drawing.Point(292, 25);
            this.DispalButton.Name = "DispalButton";
            this.DispalButton.Size = new System.Drawing.Size(121, 38);
            this.DispalButton.TabIndex = 12;
            this.DispalButton.Text = "Display ";
            this.DispalButton.UseVisualStyleBackColor = true;
            this.DispalButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 292);
            this.Controls.Add(this.DispalButton);
            this.Controls.Add(this.FriendLabel);
            this.Controls.Add(this.ToEdgeLabel);
            this.Controls.Add(this.FromEdgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FriendTextBox4);
            this.Controls.Add(this.AddBbutton);
            this.Controls.Add(this.ShowFriendsButton);
            this.Controls.Add(this.AddEdgeButton);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.AddNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.ListBox Display;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Button AddEdgeButton;
        private System.Windows.Forms.Button ShowFriendsButton;
        private System.Windows.Forms.Button AddBbutton;
        private System.Windows.Forms.TextBox FriendTextBox4;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label FromEdgeLabel;
        private System.Windows.Forms.Label ToEdgeLabel;
        private System.Windows.Forms.Label FriendLabel;
        private System.Windows.Forms.Button DispalButton;
    }
}

