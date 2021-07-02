using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJRCBookStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void RefreshLV()
        {
            listView1.Items.Clear();
            if (comboBoxEnglish.SelectedIndex != -1)
            {
                AddEnglishLVItem();
            }
            if (comboBoxMath.SelectedIndex != -1)
            {
                AddMathLVItem();
            }
            if (comboBoxScience.SelectedIndex != -1)
            {
                AddScienceLVItem();
            }

        }
        

        private void comboBoxEnglish_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLV();
        }

        private void AddEnglishLVItem()
        {
            string[] arr = new string[4];

            arr[0] = cbEnglish.Text;
            arr[1] = comboBoxEnglish.Text;

            int selectedindex = comboBoxEnglish.SelectedIndex;
            double unitPrice = getUnitPrice(selectedindex);

            arr[2] = unitPrice.ToString();

            ListViewItem ITM = new ListViewItem(arr);
            listView1.Items.Add(ITM);
        }

        private void comboBoxMath_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLV();
        }

        private void AddMathLVItem()
        {
            string[] arr = new string[4];

            arr[0] = cbMath.Text;
            arr[1] = comboBoxMath.Text;

            int selectedindex = comboBoxMath.SelectedIndex;
            double unitPrice = getUnitPrice(selectedindex);

            arr[2] = unitPrice.ToString();

            ListViewItem ITM = new ListViewItem(arr);
            listView1.Items.Add(ITM);

        }

        private void comboBoxScience_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLV();
        }

        private void AddScienceLVItem()
        {
            string[] arr = new string[4];

            arr[0] = cbScience.Text;
            arr[1] = comboBoxScience.Text;

            int selectedindex = comboBoxScience.SelectedIndex;
            double unitPrice = getUnitPrice(selectedindex);

            arr[2] = unitPrice.ToString();


            ListViewItem ITM = new ListViewItem(arr);
            listView1.Items.Add(ITM);

        }

        private double getUnitPrice(int selectedindex)
        {
            if (selectedindex == 0)
            {
                return 150.00;
            }
            else if (selectedindex == 1)
            {
                return 200.00;
            }
            else if (selectedindex == 2)
            {
                return 250.00;
            }
            else
                return 0;

        }

        private void cbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnglish.Checked)
            {
                comboBoxEnglish.Enabled = true;
                tbQtyEnglish.Enabled = true; 

            }
            else
            {
                comboBoxEnglish.Enabled = false;
                tbQtyEnglish.Enabled = false;
                tbQtyEnglish.Text = String.Empty;
                comboBoxEnglish.SelectedIndex = -1;
                tbStEnglish.Text = String.Empty;
                tbAmount.Text = String.Empty;
            }
        }

        private void cbMath_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMath.Checked)
            {
                comboBoxMath.Enabled = true;
                tbQtyMath.Enabled = true;

            }
            else
            {
                comboBoxMath.Enabled = false;
                tbQtyMath.Enabled = false;
                tbQtyMath.Text = String.Empty;
                comboBoxMath.SelectedIndex = -1;
                tbStMath.Text = String.Empty;
                tbAmount.Text = String.Empty;
            }

        }


        private void cbScience_CheckedChanged(object sender, EventArgs e)
        {
            if (cbScience.Checked)
            {
                comboBoxScience.Enabled = true;
                tbQtyScience.Enabled = true;

            }
            else
            {
                comboBoxScience.Enabled = false;
                tbQtyScience.Enabled = false;
                tbQtyScience.Text = String.Empty;
                comboBoxScience.SelectedIndex = -1;
                tbStScience.Text = String.Empty;
                tbAmount.Text = String.Empty;
            }

        }







        private void tbQtyEnglish_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSummaryOrders_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbQtyScience_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            cbEnglish.Checked = false;
            comboBoxEnglish.Enabled = false;
            tbQtyEnglish.Enabled = false;
            tbQtyEnglish.Text = String.Empty;
            comboBoxEnglish.SelectedIndex = -1;
            tbStEnglish.Text = String.Empty;
            tbAmount.Text = String.Empty;

            cbMath.Checked = false;
            comboBoxMath.Enabled = false;
            tbQtyMath.Enabled = false;
            tbQtyMath.Text = String.Empty;
            comboBoxMath.SelectedIndex = -1;
            tbStMath.Text = String.Empty;
            tbAmount.Text = String.Empty;

            cbScience.Checked = false;
            comboBoxScience.Enabled = false;
            tbQtyScience.Enabled = false;
            tbQtyScience.Text = String.Empty;
            comboBoxScience.SelectedIndex = -1;
            tbStScience.Text = String.Empty;
            tbAmount.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            computeforTotals();
        }

        private void computeforTotals()
        {
                if (!CheckforInputs())
                {
                    return;
                }
                int selectedindex = 0;
                int qty = 0;

            double subTtlEng = 0;
            double subTtlMth = 0;
            double subTtlSci = 0;

                if (cbEnglish.Checked)
                {
                    selectedindex = comboBoxEnglish.SelectedIndex;
                    qty = Int32.Parse(tbQtyEnglish.Text);
                    subTtlEng = ComputeSubTotals(selectedindex, qty, tbStEnglish);
                }

                if (cbMath.Checked)
                {
                    selectedindex = comboBoxMath.SelectedIndex;
                    qty = Int32.Parse(tbQtyMath.Text);
                    subTtlMth = ComputeSubTotals(selectedindex, qty, tbStMath);
                }

                if (cbScience.Checked)
                {
                    selectedindex = comboBoxScience.SelectedIndex;
                    qty = Int32.Parse(tbQtyScience.Text);
                    subTtlSci = ComputeSubTotals(selectedindex, qty, tbStScience);
                }




                double totalAmmount = subTtlEng + subTtlMth + subTtlSci;
                tbAmount.Text = totalAmmount.ToString();
      
            /*
            if (comboBoxEnglish.SelectedIndex == -1 || comboBoxMath.SelectedIndex == -1 || comboBoxScience.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a value for each Level");
                return;
            }
            else
            {
                if(String.IsNullOrEmpty(tbQtyEnglish.Text)|| String.IsNullOrEmpty(tbQtyMath.Text) || String.IsNullOrEmpty(tbQtyScience.Text))
                {
                    MessageBox.Show("Quantity Text Field is null");
                    return;

                }
                int parsedValue;
                Boolean isTbTxtEngInt = int.TryParse(tbQtyEnglish.Text, out parsedValue);
                Boolean isTbTxtMathInt = int.TryParse(tbQtyMath.Text, out parsedValue);
                Boolean isTbTxtScienceInt = int.TryParse(tbQtyScience.Text, out parsedValue);
                if (!isTbTxtEngInt || !isTbTxtMathInt || !isTbTxtScienceInt)
                {
                    MessageBox.Show("This is an integer number only field");
                    return;
                }
            }
            */




        }



        private bool CheckforInputs()
        {

            bool firstCondition = false;
            bool secondCondition = false;

            bool istbEngNum = false;
            bool istbEngEmpty = false;
            bool istbMathNum = false;
            bool istbMathEmpty = false;
            bool istbScienceNum = false;
            bool istbScienceEmpty = false;

            if (cbEnglish.Checked)
            {
                istbEngNum = CheckIfQtyIsNum(tbQtyEnglish);
                istbEngEmpty =  CheckIfQtyIsEmpty(tbQtyEnglish);
            }
            if (cbMath.Checked)
            {
                istbMathNum = CheckIfQtyIsNum(tbQtyMath);
                istbMathEmpty =  CheckIfQtyIsEmpty(tbQtyMath);
            }
            if (cbScience.Checked)
            {
                
                istbScienceNum = CheckIfQtyIsNum(tbQtyScience);
                istbScienceEmpty = CheckIfQtyIsEmpty(tbQtyScience);
            }
            
            if (istbEngNum && cbEnglish.Checked) 
            {
                firstCondition = true;
            }

            else if (istbMathNum && cbMath.Checked) 
            {
                firstCondition = true;
            }

            else if (istbScienceNum && cbScience.Checked)
            {
                firstCondition = true;
            }
            else
            {
                firstCondition = false;
            }


            if (istbEngEmpty && cbEnglish.Checked)
            {
                secondCondition = true;
            }

            else if (istbMathEmpty && cbMath.Checked)
            {
                secondCondition = true;
            }

            else if (istbScienceEmpty && cbScience.Checked)
            {
                secondCondition = true;
            }
            else
            {
                secondCondition = false;
            }

          
            bool[] cond = new bool[2];
            cond[0] = firstCondition;
            cond[1] = secondCondition;

            if (cond[1] == true)
            {
                //MessageBox.Show("Quantity Text Field is empty, Please Input a number");
                MessageBox.Show("Quantity Text Field is empty, Please Input a number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cond[0] == true)
            {
                //MessageBox.Show("Please Input an Integer only in Quantity Text Boxes");
                MessageBox.Show("Please Input an Integer only in Quantity Text Boxes", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private bool CheckIfQtyIsNum(TextBox tb)
        {
            int parsedValue;
            Boolean isTbTxtInt = int.TryParse(tb.Text, out parsedValue);
            if (!(isTbTxtInt))
            {
                return true;
            }
            return false;
        }

        private bool CheckIfQtyIsEmpty(TextBox tb)
        {
            if (String.IsNullOrEmpty(tb.Text))
            {
                return true;
            }
            return false;
        }

        private double ComputeSubTotals(int selectedindex, int qty, TextBox tb)
        {
            double unitPrice = 0.0;
            unitPrice = getUnitPrice(selectedindex);
            double subTotal = (unitPrice * qty);
            tb.Text = subTotal.ToString();
            return subTotal;
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Quit the Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
