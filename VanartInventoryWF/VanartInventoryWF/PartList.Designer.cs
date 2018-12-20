namespace VanartInventoryWF
{
    partial class PartList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewInfoButton = new System.Windows.Forms.Button();
            this.updateStockButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(912, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // viewInfoButton
            // 
            this.viewInfoButton.Location = new System.Drawing.Point(510, 492);
            this.viewInfoButton.Name = "viewInfoButton";
            this.viewInfoButton.Size = new System.Drawing.Size(258, 58);
            this.viewInfoButton.TabIndex = 1;
            this.viewInfoButton.Text = "View Part History";
            this.viewInfoButton.UseVisualStyleBackColor = true;
            this.viewInfoButton.Click += new System.EventHandler(this.viewInfoButton_Click);
            // 
            // updateStockButton
            // 
            this.updateStockButton.Location = new System.Drawing.Point(291, 493);
            this.updateStockButton.Name = "updateStockButton";
            this.updateStockButton.Size = new System.Drawing.Size(213, 57);
            this.updateStockButton.TabIndex = 2;
            this.updateStockButton.Text = "Update Stock";
            this.updateStockButton.UseVisualStyleBackColor = true;
            this.updateStockButton.Click += new System.EventHandler(this.updateStockButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(774, 493);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(150, 57);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 506);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Enter new stock here";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // PartList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.updateStockButton);
            this.Controls.Add(this.viewInfoButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PartList";
            this.Text = "Part List";
            this.Load += new System.EventHandler(this.PartList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewInfoButton;
        private System.Windows.Forms.Button updateStockButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}