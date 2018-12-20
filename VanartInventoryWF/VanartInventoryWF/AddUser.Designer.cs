namespace VanartInventoryWF
{
    partial class AddUser
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.floorButton = new System.Windows.Forms.RadioButton();
            this.officeButton = new System.Windows.Forms.RadioButton();
            this.adminButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(78, 314);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(167, 49);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(205, 88);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(212, 31);
            this.firstNameBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(73, 91);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(116, 25);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(205, 151);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(212, 31);
            this.lastNameBox.TabIndex = 1;
            // 
            // floorButton
            // 
            this.floorButton.AutoSize = true;
            this.floorButton.Location = new System.Drawing.Point(168, 220);
            this.floorButton.Name = "floorButton";
            this.floorButton.Size = new System.Drawing.Size(92, 29);
            this.floorButton.TabIndex = 3;
            this.floorButton.TabStop = true;
            this.floorButton.Text = "Floor";
            this.floorButton.UseVisualStyleBackColor = true;
            // 
            // officeButton
            // 
            this.officeButton.AutoSize = true;
            this.officeButton.Location = new System.Drawing.Point(266, 220);
            this.officeButton.Name = "officeButton";
            this.officeButton.Size = new System.Drawing.Size(99, 29);
            this.officeButton.TabIndex = 4;
            this.officeButton.TabStop = true;
            this.officeButton.Text = "Office";
            this.officeButton.UseVisualStyleBackColor = true;
            // 
            // adminButton
            // 
            this.adminButton.AutoSize = true;
            this.adminButton.Location = new System.Drawing.Point(371, 220);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(103, 29);
            this.adminButton.TabIndex = 5;
            this.adminButton.TabStop = true;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rank:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(300, 314);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(167, 49);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 428);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.officeButton);
            this.Controls.Add(this.floorButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.addUserButton);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.RadioButton floorButton;
        private System.Windows.Forms.RadioButton officeButton;
        private System.Windows.Forms.RadioButton adminButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeButton;
    }
}