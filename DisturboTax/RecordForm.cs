using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisturboTax
{
    public partial class RecordForm : Form
    {
        private int recordIndex = 0;
        recordTemplate[] rec;

        public RecordForm()
        {
            InitializeComponent();
        }

        private void TaxCalculationForm_Load(object sender, EventArgs e)
        {
            rec = TaxCalculationForm.userArr;
            currentRecord(rec[recordIndex]);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult clearRecord;
            clearRecord = MessageBox.Show("Delete Records?", "Deleting Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (clearRecord == System.Windows.Forms.DialogResult.Yes)
            {
                TaxCalculationForm.userArr = rec;
                recordIndex = 0;
                nameTextBox.Text = String.Empty;
                ssnTextBox.Text = String.Empty;
                RefundTextBox.Text = String.Empty;
            }
            else
            {
                Close();
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult exitPrompt;
            exitPrompt = MessageBox.Show("Are you sure you want to exit?", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Yes/No
            if (exitPrompt == System.Windows.Forms.DialogResult.Yes)
            {
                Close();

            }

            else
            {
                return;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            recordIndex++;
            currentRecord(rec[recordIndex]);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            recordIndex--;
            currentRecord(rec[recordIndex]);
        }

        private void currentRecord(recordTemplate user)
        {
            ssnTextBox.Text = user.ssn;
            nameTextBox.Text = user.name;
            
            decimal i;
            if (user.taxBalance < 0)
            {
                i = (-1m * user.taxBalance); RefundTextBox.Text = i.ToString("c");
            }
            else
            {
                RefundTextBox.Text = user.taxBalance.ToString("c");
            }

        }
      
    }
}
