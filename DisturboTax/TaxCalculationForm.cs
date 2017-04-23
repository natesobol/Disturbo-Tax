using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisturboTax
{

    public partial class TaxCalculationForm : Form
    {
        private decimal income;
        private decimal deductions;
        private decimal reCalc;
        private decimal owedOrRefund;
        private decimal exciseTax;
        private decimal medTax;
        private decimal penalty;
        private decimal adjustedIncome;
        private decimal gainsTax;
        private decimal lossTax;
        private const int TAX_SIZE = 15;
        public static recordTemplate[] userArr = new recordTemplate[TAX_SIZE];
        private user createUser;
        public static int endIndex = 0;
        private decimal percentageOfTaxPaid;
        private bool isEntered;

        public TaxCalculationForm()
        {
            InitializeComponent();
        }

        private void TaxCalculation_Load(object sender, EventArgs e)
        {
            createUser = DataInputForm.getUser();
            isEntered = false;

            if (endIndex == 0)
            {
                viewButton.Enabled = false;
                initializeArray();
            }
            else
            {
                viewButton.Enabled = true;
            }

            taxCalc();
            setTextBox();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (endIndex < TAX_SIZE)
            {
                if (!isEntered)
                {
                    System.Windows.Forms.DialogResult saveDataPrompt;
                    saveDataPrompt = MessageBox.Show("Save Data before leaving?", "Save data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (saveDataPrompt == System.Windows.Forms.DialogResult.Yes)
                    {
                        isEntered = saveData();
                    }
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Cannot exceed " + TAX_SIZE + " tax records");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        { 
            isEntered = saveData();
            viewButton.Enabled = true;
            MessageBox.Show("Current Record has been saved!");
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

        private void viewButton_Click(object sender, EventArgs e)
        {
            RecordForm recordForm = new RecordForm();
            recordForm.ShowDialog();
        }

        private bool saveData()
        {
            if (endIndex < TAX_SIZE)
            {
                recordTemplate final = new recordTemplate();
                final.name = createUser.name;
                final.ssn = createUser.ssn;
                if (refundLabel.Text.Equals("Tax Owed:"))
                {
                    final.taxBalance = (-1m * owedOrRefund);
                }
                else
                {
                    final.taxBalance = owedOrRefund;
                }

                userArr[endIndex++] = final;
                sortUserArr();
            }
            if (endIndex > 0)
            {
                viewButton.Enabled = true;
            }
            else
            {
                viewButton.Enabled = false;
            }

            return true;
        }

        private void taxCalc()
        {
            decimal tax = 0;

            if (createUser.exemptions != 0)
            {
                deductions = (decimal)(createUser.exemptions * 1000.00);
            }

            if (createUser.taxableItems.realEstate != 0)
            {
                reCalc = percentageCalc(createUser.taxableItems.realEstate, 0.25);
            }

            if (createUser.taxableItems.excise != 0)
            {
                exciseTax = percentageCalc(createUser.taxableItems.excise, 0.25);
            }

            if (createUser.taxableItems.medicalExpense != 0)
            {
                medTax = percentageCalc(createUser.taxableItems.medicalExpense, 0.08);
            }

            if (createUser.taxableItems.gains != 0)
            {
                gainsTax = percentageCalc(createUser.taxableItems.gains, 0.15);
            }

            if (createUser.taxableItems.loss != 0)
            {
                lossTax = percentageCalc(createUser.taxableItems.loss, 0.15);
            }


            income = createUser.taxableItems.earnings - deductions - reCalc - exciseTax - medTax + gainsTax - lossTax; 
            

            if (adjustedIncome >= 30000)
            {
                tax += (adjustedIncome - 29999) * (28 / 100);
                adjustedIncome -= (adjustedIncome - 29999);
            }

            if (adjustedIncome >= 20000)
            {
                tax += (adjustedIncome - 19999) * (25 / 100);
                adjustedIncome -= (adjustedIncome - 19999);
            }

            if (adjustedIncome >= 10000)
            {
                tax += (adjustedIncome - 9999) * (20 / 100);
                adjustedIncome -= (adjustedIncome - 9999);
            }

            if (adjustedIncome >= 1000)
            {
                tax += (adjustedIncome - 999) * (15 / 100);
                adjustedIncome -= (adjustedIncome - 999);
            }

            if (adjustedIncome > 0)
            {
                tax += adjustedIncome * (10 / 100);
                adjustedIncome -= adjustedIncome;
            }

            adjustedIncome = tax;

            if (adjustedIncome <= 0)
            {
                percentageOfTaxPaid = 0.00m;
            }
            else
            {
                percentageOfTaxPaid = createUser.taxableItems.taxWithheld / adjustedIncome;
            }

            if (Math.Round(percentageOfTaxPaid, 2, MidpointRounding.AwayFromZero) < 0.90m)
            {
                penalty = (adjustedIncome - createUser.taxableItems.taxWithheld) * 0.10m;

            }
            else
            {
                penalty = 0.00m;

            }

            if (isRefund())
            {
                owedOrRefund = calcRefund();
                refundLabel.Text = "Refund:";
            }
            else
            {
                owedOrRefund = calcRefund();
                refundLabel.Text = "Tax Owed:";

            }
        }

        private void setTextBox()
        {
            withheldTextBox.Text = createUser.taxableItems.taxWithheld.ToString("c");
            incomeTextBox.Text = income.ToString("c");
            taxTextBox.Text = adjustedIncome.ToString("c");
            penaltyTextBox.Text = penalty.ToString("c");
            refundTextBox.Text = owedOrRefund.ToString("c");
        }

        private void initializeArray()
        {
            recordTemplate temp = new recordTemplate();
            temp.name = "";
            temp.ssn = "";
            temp.taxBalance = 0.00m;
            for (int i = 0; i < TAX_SIZE; i++)
            {
                userArr[i] = temp;
            }
        }

        private void sortUserArr()
        {
            int index = endIndex - 1;
            for (; index > 0; index--)
            {

                if (userArr[index].ssn.CompareTo(userArr[index - 1].ssn) == -1)
                {

                    recordTemplate temp = userArr[index];
                    userArr[index] = userArr[index - 1];
                    userArr[index - 1] = temp;
                }
            }
        }

        private decimal percentageCalc(decimal i, double percentage)
        {
            return (i * (decimal)percentage);
        }

        private decimal calcRefund()
        {
            decimal temp = createUser.taxableItems.taxWithheld - adjustedIncome;
            if (temp > 0m)
            {
                return temp;
            }
            else
            {

                return (adjustedIncome - createUser.taxableItems.taxWithheld) + penalty;
            }
        }

        private bool isRefund()
        {
            return createUser.taxableItems.taxWithheld > adjustedIncome;
        }

    }
}
