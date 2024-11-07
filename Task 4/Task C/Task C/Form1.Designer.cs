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
            this.AddNameButton = new System.Windows.Forms.Button();
            this.AddEdgeButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ShowFriendsButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.RemoveTextBox = new System.Windows.Forms.TextBox();
            this.ShowFrierndsTextBox = new System.Windows.Forms.TextBox();
            this.DirectFriendsRadioButton = new System.Windows.Forms.RadioButton();
            this.IndirectFriendsRadioButton = new System.Windows.Forms.RadioButton();
            this.AllNetworkFriendsRadioButton = new System.Windows.Forms.RadioButton();
            this.Display = new System.Windows.Forms.ListBox();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RemoveLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FriendLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNameButton
            // 
            this.AddNameButton.Location = new System.Drawing.Point(81, 81);
            this.AddNameButton.Name = "AddNameButton";
            this.AddNameButton.Size = new System.Drawing.Size(132, 23);
            this.AddNameButton.TabIndex = 0;
            this.AddNameButton.Text = "Add Person";
            this.AddNameButton.UseVisualStyleBackColor = true;
            this.AddNameButton.Click += new System.EventHandler(this.AddNameButton_Click);
            // 
            // AddEdgeButton
            // 
            this.AddEdgeButton.Location = new System.Drawing.Point(81, 248);
            this.AddEdgeButton.Name = "AddEdgeButton";
            this.AddEdgeButton.Size = new System.Drawing.Size(132, 23);
            this.AddEdgeButton.TabIndex = 1;
            this.AddEdgeButton.Text = "Add Edge";
            this.AddEdgeButton.UseVisualStyleBackColor = true;
            this.AddEdgeButton.Click += new System.EventHandler(this.AddEdgeButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(83, 55);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(130, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(81, 192);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(132, 20);
            this.FromTextBox.TabIndex = 3;
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(81, 220);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(132, 20);
            this.ToTextBox.TabIndex = 4;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(81, 138);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(132, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ShowFriendsButton
            // 
            this.ShowFriendsButton.Location = new System.Drawing.Point(81, 400);
            this.ShowFriendsButton.Name = "ShowFriendsButton";
            this.ShowFriendsButton.Size = new System.Drawing.Size(132, 23);
            this.ShowFriendsButton.TabIndex = 6;
            this.ShowFriendsButton.Text = "Show Friends";
            this.ShowFriendsButton.UseVisualStyleBackColor = true;
            this.ShowFriendsButton.Click += new System.EventHandler(this.ShowFriendsButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(505, 376);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(103, 29);
            this.DisplayButton.TabIndex = 7;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // RemoveTextBox
            // 
            this.RemoveTextBox.Location = new System.Drawing.Point(81, 112);
            this.RemoveTextBox.Name = "RemoveTextBox";
            this.RemoveTextBox.Size = new System.Drawing.Size(132, 20);
            this.RemoveTextBox.TabIndex = 8;
            // 
            // ShowFrierndsTextBox
            // 
            this.ShowFrierndsTextBox.Location = new System.Drawing.Point(79, 297);
            this.ShowFrierndsTextBox.Name = "ShowFrierndsTextBox";
            this.ShowFrierndsTextBox.Size = new System.Drawing.Size(134, 20);
            this.ShowFrierndsTextBox.TabIndex = 9;
            // 
            // DirectFriendsRadioButton
            // 
            this.DirectFriendsRadioButton.AutoSize = true;
            this.DirectFriendsRadioButton.Location = new System.Drawing.Point(85, 323);
            this.DirectFriendsRadioButton.Name = "DirectFriendsRadioButton";
            this.DirectFriendsRadioButton.Size = new System.Drawing.Size(90, 17);
            this.DirectFriendsRadioButton.TabIndex = 10;
            this.DirectFriendsRadioButton.TabStop = true;
            this.DirectFriendsRadioButton.Text = "Direct Friends";
            this.DirectFriendsRadioButton.UseVisualStyleBackColor = true;
            // 
            // IndirectFriendsRadioButton
            // 
            this.IndirectFriendsRadioButton.AutoSize = true;
            this.IndirectFriendsRadioButton.Location = new System.Drawing.Point(85, 346);
            this.IndirectFriendsRadioButton.Name = "IndirectFriendsRadioButton";
            this.IndirectFriendsRadioButton.Size = new System.Drawing.Size(97, 17);
            this.IndirectFriendsRadioButton.TabIndex = 11;
            this.IndirectFriendsRadioButton.TabStop = true;
            this.IndirectFriendsRadioButton.Text = "Indirect Friends";
            this.IndirectFriendsRadioButton.UseVisualStyleBackColor = true;
            // 
            // AllNetworkFriendsRadioButton
            // 
            this.AllNetworkFriendsRadioButton.AutoSize = true;
            this.AllNetworkFriendsRadioButton.Location = new System.Drawing.Point(83, 371);
            this.AllNetworkFriendsRadioButton.Name = "AllNetworkFriendsRadioButton";
            this.AllNetworkFriendsRadioButton.Size = new System.Drawing.Size(149, 17);
            this.AllNetworkFriendsRadioButton.TabIndex = 12;
            this.AllNetworkFriendsRadioButton.TabStop = true;
            this.AllNetworkFriendsRadioButton.Text = "Direct and Indirect Friends";
            this.AllNetworkFriendsRadioButton.UseVisualStyleBackColor = true;
            // 
            // Display
            // 
            this.Display.FormattingEnabled = true;
            this.Display.Location = new System.Drawing.Point(303, 85);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(472, 277);
            this.Display.TabIndex = 13;
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Location = new System.Drawing.Point(303, 56);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(45, 13);
            this.PreviewLabel.TabIndex = 14;
            this.PreviewLabel.Text = "Preview";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(41, 59);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Name";
            // 
            // RemoveLabel
            // 
            this.RemoveLabel.AutoSize = true;
            this.RemoveLabel.Location = new System.Drawing.Point(42, 115);
            this.RemoveLabel.Name = "RemoveLabel";
            this.RemoveLabel.Size = new System.Drawing.Size(35, 13);
            this.RemoveLabel.TabIndex = 16;
            this.RemoveLabel.Text = "Name";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(43, 196);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(30, 13);
            this.FromLabel.TabIndex = 17;
            this.FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(50, 224);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 18;
            this.ToLabel.Text = "To";
            // 
            // FriendLabel
            // 
            this.FriendLabel.AutoSize = true;
            this.FriendLabel.Location = new System.Drawing.Point(39, 301);
            this.FriendLabel.Name = "FriendLabel";
            this.FriendLabel.Size = new System.Drawing.Size(36, 13);
            this.FriendLabel.TabIndex = 19;
            this.FriendLabel.Text = "Friend";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FriendLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.RemoveLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.AllNetworkFriendsRadioButton);
            this.Controls.Add(this.IndirectFriendsRadioButton);
            this.Controls.Add(this.DirectFriendsRadioButton);
            this.Controls.Add(this.ShowFrierndsTextBox);
            this.Controls.Add(this.RemoveTextBox);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.ShowFriendsButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AddEdgeButton);
            this.Controls.Add(this.AddNameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNameButton;
        private System.Windows.Forms.Button AddEdgeButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ShowFriendsButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.TextBox RemoveTextBox;
        private System.Windows.Forms.TextBox ShowFrierndsTextBox;
        private System.Windows.Forms.RadioButton DirectFriendsRadioButton;
        private System.Windows.Forms.RadioButton IndirectFriendsRadioButton;
        private System.Windows.Forms.RadioButton AllNetworkFriendsRadioButton;
        private System.Windows.Forms.ListBox Display;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label RemoveLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FriendLabel;
    }
}

