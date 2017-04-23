namespace DisturboTax
{
    partial class RecordForm
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
            this.refundLabel = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.RefundTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refundLabel
            // 
            this.refundLabel.AutoSize = true;
            this.refundLabel.Location = new System.Drawing.Point(12, 114);
            this.refundLabel.Name = "refundLabel";
            this.refundLabel.Size = new System.Drawing.Size(42, 13);
            this.refundLabel.TabIndex = 46;
            this.refundLabel.Text = "Refund";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(12, 88);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(120, 13);
            this.ssnLabel.TabIndex = 45;
            this.ssnLabel.Text = "Social Security Number:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 13);
            this.nameLabel.TabIndex = 44;
            this.nameLabel.Text = "Full Name:";
            // 
            // RefundTextBox
            // 
            this.RefundTextBox.Location = new System.Drawing.Point(150, 107);
            this.RefundTextBox.Name = "RefundTextBox";
            this.RefundTextBox.Size = new System.Drawing.Size(185, 20);
            this.RefundTextBox.TabIndex = 41;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(150, 81);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(185, 20);
            this.ssnTextBox.TabIndex = 40;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(150, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(185, 20);
            this.nameTextBox.TabIndex = 39;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(127, 139);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 21);
            this.clearButton.TabIndex = 48;
            this.clearButton.Text = "Clear Records";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(239, 139);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(106, 21);
            this.nextButton.TabIndex = 49;
            this.nextButton.Text = "Next Record";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(15, 139);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(106, 21);
            this.previousButton.TabIndex = 47;
            this.previousButton.Text = "Previous Record";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Location = new System.Drawing.Point(349, 163);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 24);
            this.exitButton.TabIndex = 50;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 39);
            this.label14.TabIndex = 51;
            this.label14.Text = "New Record";
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 194);
            this.ControlBox = false;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.refundLabel);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.RefundTextBox);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.nameTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordForm";
            this.Text = "Disturbo Tax";
            this.Load += new System.EventHandler(this.TaxCalculationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label refundLabel;
        private System.Windows.Forms.TextBox RefundTextBox;
    }
}