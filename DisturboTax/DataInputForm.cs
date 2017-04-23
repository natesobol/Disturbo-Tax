// Form: DataInputForm

using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DisturboTax
{
    public struct user
    {
        public String name;
        public String address;
        public String state;
        public String city;
        public String zipcode;
        public String ssn;
        public int exemptions;
        public taxable taxableItems;
    }

    public struct taxable
    {
        public decimal earnings;
        public decimal taxWithheld;
        public decimal excise;
        public decimal realEstate;
        public decimal medicalExpense;
        public decimal gains;
        public decimal loss;
    }

    public struct recordTemplate
    {
        public decimal taxBalance;
        public String ssn;
        public String name;
    }

    public partial class DataInputForm : Form
    {
        static user thisRecord = new user();

        public DataInputForm()
        {
            InitializeComponent();
        }

        public static user getUser()
        {
            return thisRecord;
        }

        private void DataInputForm_Load(object sender, EventArgs e)
        {
            createStateDropDown();
        }

        private void calcTax_Click(object sender, EventArgs e)
        {
            thisRecord.city = cityTextBox.Text;
            thisRecord.state = stateDropDown.Text;
            thisRecord.name = nameTextBox.Text;
            thisRecord.address = addressTextBox.Text;

            // Validates Data Entry
            try
            {
                if (inputValidation())
                {
                    thisRecord.exemptions = Convert.ToInt32(exemptionsTextBox.Text);
                    thisRecord.taxableItems.earnings = Convert.ToDecimal(grossEarningsTextBox.Text);
                    thisRecord.taxableItems.taxWithheld = Convert.ToDecimal(withheldTextBox.Text);
                    thisRecord.taxableItems.excise = Convert.ToDecimal(exciseTextBox.Text);
                    thisRecord.taxableItems.realEstate = Convert.ToDecimal(estateTextBox.Text);
                    thisRecord.taxableItems.medicalExpense = Convert.ToDecimal(medTextBox.Text);
                    thisRecord.taxableItems.gains = Convert.ToDecimal(gainsTextBox.Text);
                    thisRecord.taxableItems.loss = Convert.ToDecimal(lossTextBox.Text);
                    thisRecord.zipcode = zipTextBox.Text;
                    thisRecord.ssn = ssnTextBox.Text;
                    TaxCalculationForm display = new TaxCalculationForm();
                    display.ShowDialog();
                    clearInput(this);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An unknown exception has occured.", "Invalid Input");
            }
        }

        private void clearInput(Control thisForm)
        {
            foreach (Control i in thisForm.Controls)
            {
                if (i is TextBox)
                {
                    ((TextBox)i).Clear();
                }
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

        private void createStateDropDown()
        {
            String[] states =
            {
                    "AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA",
                    "HI","ID","IL","IN","IA","KS","KY","LA","ME","MD",
                    "MA","MI","MN","MS","MO","MT","NE","NV","NH","NJ",
                    "NM","NY","NC","ND","OH","OK","OR","PA","RI","SC",
                    "SD","TN","TX","UT","VT","VA","WA","WV","WI","WY"
            };

            for (int k = 0; k < 50; k++)
            {
                stateDropDown.Items.Add(states[k]);
            } 
        }

        private void restartEntry_Click(object sender, EventArgs e)
        {
            clearInput(this);
        }

        private void viewRecords_Click(object sender, EventArgs e)
        {
                RecordForm displayRecords = new RecordForm();
                displayRecords.ShowDialog();
        }

        private bool isStrLengthCorrect(TextBox textBox, String name, int length)
        {
            if (textBox.Text.Length != length)
            {
                MessageBox.Show(name + "must be " + length + " characters long.");
                textBox.Text = "";
                return false;
            }
            return true;
        }

        private bool isDecimal(TextBox textBox, String name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input in " + name + " field. Omit \"$\".", name + "Error");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
        }

        private bool isInRange(TextBox textBox, int min, int max)
        {
            int temp = Convert.ToInt32(textBox.Text);
            if (temp < min || temp > max)
            {
                MessageBox.Show("Value out of range. Accepted range: " + min + " to " + max + "."
                    , "Range Error");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool isInt(TextBox textBox, String name)
        {
            try
            {
                Convert.ToInt64(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Value in " + name + " field is invalid.", name + " Error");
                textBox.Text = "";
                textBox.Focus();
                return false;
            }
        }

        private bool isEmpty(TextBox textBox, String name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is empty.", name + " Empty Textbox");
                return false;
            }
            return true;
        }

        private bool isTextPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool isStateChosen(ComboBox stateDropDown, String name)
        {
            if (stateDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a " + name + ".", name + " Error");
                return false;
            }
            return true;
        }

        private bool inputValidation()
        {
            if (isEmpty(nameTextBox, "Name") && isEmpty(addressTextBox, "Address") && isEmpty(cityTextBox, "City") &&
            isEmpty(zipTextBox, "Zip Code") && isEmpty(ssnTextBox, "Social Security Number") && isEmpty(exemptionsTextBox, "Exemptions") &&
            isEmpty(grossEarningsTextBox, "Gross Earnings") && isEmpty(withheldTextBox, "Tax Withheld") &&
            isEmpty(gainsTextBox, "Capital Gains") && isEmpty(lossTextBox, "Capital Loss") &&
            isEmpty(exciseTextBox, "Excise Tax") && isEmpty(estateTextBox, "Real Estate Tax") &&
            isEmpty(medTextBox, "Med Expenses") && isStateChosen(stateDropDown, "State") &&
            isInt(ssnTextBox, "SSN") && isInt(zipTextBox, "Zip Code") &&
            isInt(exemptionsTextBox, "Exemptions") && isStrLengthCorrect(zipTextBox, "Zipcode", 5) &&
            isStrLengthCorrect(ssnTextBox, "SSN", 10) && isInRange(exemptionsTextBox, 0, 10) &&
            isDecimal(grossEarningsTextBox, "Gross Earnings") && isDecimal(withheldTextBox, "Tax Withheld") &&                  
            isDecimal(gainsTextBox, "Capital Gains") && isDecimal(lossTextBox, "Capital Loss") &&                  
            isDecimal(exciseTextBox, "Excise Tax") && isDecimal(estateTextBox, "Real Estate Tax") &&            
            isDecimal(medTextBox, "Med Expenses"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
