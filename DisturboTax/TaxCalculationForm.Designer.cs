namespace DisturboTax
{
    partial class TaxCalculationForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.withheldTextBox = new System.Windows.Forms.TextBox();
            this.penaltyTextBox = new System.Windows.Forms.TextBox();
            this.refundTextBox = new System.Windows.Forms.TextBox();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.withhelfLabel = new System.Windows.Forms.Label();
            this.penaltyLabel = new System.Windows.Forms.Label();
            this.refundLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(221, 39);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tax Calculation";
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Location = new System.Drawing.Point(154, 62);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(160, 20);
            this.incomeTextBox.TabIndex = 28;
            // 
            // withheldTextBox
            // 
            this.withheldTextBox.Location = new System.Drawing.Point(154, 114);
            this.withheldTextBox.Name = "withheldTextBox";
            this.withheldTextBox.Size = new System.Drawing.Size(160, 20);
            this.withheldTextBox.TabIndex = 30;
            // 
            // penaltyTextBox
            // 
            this.penaltyTextBox.Location = new System.Drawing.Point(154, 88);
            this.penaltyTextBox.Name = "penaltyTextBox";
            this.penaltyTextBox.Size = new System.Drawing.Size(160, 20);
            this.penaltyTextBox.TabIndex = 31;
            // 
            // refundTextBox
            // 
            this.refundTextBox.Location = new System.Drawing.Point(154, 166);
            this.refundTextBox.Name = "refundTextBox";
            this.refundTextBox.Size = new System.Drawing.Size(160, 20);
            this.refundTextBox.TabIndex = 32;
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Location = new System.Drawing.Point(16, 68);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(119, 13);
            this.incomeLabel.TabIndex = 34;
            this.incomeLabel.Text = "Adjusted Gross Income:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(16, 143);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(132, 13);
            this.taxLabel.TabIndex = 35;
            this.taxLabel.Text = "Amount of Calculated Tax:";
            // 
            // withhelfLabel
            // 
            this.withhelfLabel.AutoSize = true;
            this.withhelfLabel.Location = new System.Drawing.Point(16, 121);
            this.withhelfLabel.Name = "withhelfLabel";
            this.withhelfLabel.Size = new System.Drawing.Size(124, 13);
            this.withhelfLabel.TabIndex = 36;
            this.withhelfLabel.Text = "Amount of Tax Withheld:";
            // 
            // penaltyLabel
            // 
            this.penaltyLabel.AutoSize = true;
            this.penaltyLabel.Location = new System.Drawing.Point(16, 95);
            this.penaltyLabel.Name = "penaltyLabel";
            this.penaltyLabel.Size = new System.Drawing.Size(45, 13);
            this.penaltyLabel.TabIndex = 37;
            this.penaltyLabel.Text = "Penalty:";
            // 
            // refundLabel
            // 
            this.refundLabel.AutoSize = true;
            this.refundLabel.Location = new System.Drawing.Point(16, 173);
            this.refundLabel.Name = "refundLabel";
            this.refundLabel.Size = new System.Drawing.Size(59, 13);
            this.refundLabel.TabIndex = 38;
            this.refundLabel.Text = "Tax Owed:";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(11, 207);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(124, 20);
            this.viewButton.TabIndex = 41;
            this.viewButton.Text = "View Records";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(141, 207);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(126, 20);
            this.saveButton.TabIndex = 44;
            this.saveButton.Text = "Save Record";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(314, 233);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(73, 23);
            this.exitButton.TabIndex = 45;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(284, 207);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(103, 20);
            this.createButton.TabIndex = 46;
            this.createButton.Text = "Create Record";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(154, 140);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(160, 20);
            this.taxTextBox.TabIndex = 47;
            // 
            // TaxCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 266);
            this.ControlBox = false;
            this.Controls.Add(this.taxTextBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.refundLabel);
            this.Controls.Add(this.penaltyLabel);
            this.Controls.Add(this.withhelfLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.refundTextBox);
            this.Controls.Add(this.penaltyTextBox);
            this.Controls.Add(this.withheldTextBox);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(this.label14);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaxCalculationForm";
            this.Text = "Disturbo Tax";
            this.Load += new System.EventHandler(this.TaxCalculation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.TextBox withheldTextBox;
        private System.Windows.Forms.TextBox penaltyTextBox;
        private System.Windows.Forms.TextBox refundTextBox;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label withhelfLabel;
        private System.Windows.Forms.Label penaltyLabel;
        private System.Windows.Forms.Label refundLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox taxTextBox;
    }
}