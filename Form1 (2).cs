using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_PIzza_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CboStarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //I've done this so I don't need to add code for every separate string in the combobox
            lstOrderreveiw.Items.Add(cboStarter.SelectedItem);//Adds Selected item from Combobox to Listbox

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {   //I have done this so I don't have to manually reset everything or reload the application
            ckbPineapple.Checked = false;//Unchecks the Checkbox
            ckbPeppers.Checked = false;//Unchecks the Checkbox
            ckbCheese.Checked = false;//Unchecks the Checkbox
            ckbSquid.Checked = false;//Unchecks the Checkbox
            ckbHam.Checked = false;//Unchecks the Checkbox
            ckbOlives.Checked = false;//Unchecks the Checkbox
            ckbPepperoni.Checked = false;//Unchecks the Checkbox
            ckbPufferfish.Checked = false;//Unchecks the Checkbox
            cboStarter.Text = String.Empty;//Empties combobox
            cboBase.Text = String.Empty;//Empties combobox
            cboSweet.Text = String.Empty;//Empties combobox
            lstOrderreveiw.Items.Clear();//Clears Listbox
            lblPrice.Text = ("");//Clears Label
        }

        // I've done this so I don't need to add code for every separate string in the combobox
        private void CboBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOrderreveiw.Items.Add(cboBase.SelectedItem);//Adds Selected item from Combobox to Listbox
        }

        private void CboSweet_SelectedIndexChanged(object sender, EventArgs e)
        //I've done this so I don't need to add code for every separate string in the combobox
        {
            lstOrderreveiw.Items.Add(cboSweet.SelectedItem);//Adds Selected item from Combobox to Listbox
        }

        private void CkbPineapple_CheckedChanged(object sender, EventArgs e)
            //I've done this so it acts as some sort of Data Validation
        {   
            if (ckbPineapple.Checked == true)//Checks if the checkbox is checked, before adding Pineapple to the listbox
            {
                lstOrderreveiw.Items.Add("Pineapple");//Adds item to listbox
            }
            
            else//Checks if the checkbox is unchecked, before removeing the item if its present in the listbox
            {
                lstOrderreveiw.Items.Remove("Pineapple");//Removes item from listbox
            }
        }

        private void CkbPeppers_CheckedChanged(object sender, EventArgs e)
        //I've done this so it acts as some sort of Data Validation
        {   //if the checkbox is checked, it will add Peppers to the listbox
            if (ckbPeppers.Checked == true)
            {
                lstOrderreveiw.Items.Add("Peppers");
            }
            //if the checkbox is unchecked, it will remove the text above if it is present in the listbox
            else
            {
                lstOrderreveiw.Items.Remove("Peppers");
            }
        }

        private void CkbCheese_CheckedChanged(object sender, EventArgs e)
        //I've done this so it acts as some sort of Data Validation
        {   //if the checkbox is checked, it will add Cheese to the listbox
            if (ckbCheese.Checked == true)
            {
                lstOrderreveiw.Items.Add("Cheese");
            }
            //if the checkbox is unchecked, it will remove the text above if it is present in the listbox
            else
            {
                lstOrderreveiw.Items.Remove("Cheese");
            }
        }

        private void CkbSquid_CheckedChanged(object sender, EventArgs e)
        //I've done this so it acts as some sort of Data Validation
        {   //if the checkbox is checked, it will add Squid to the listbox
            if (ckbSquid.Checked == true)
            {
                lstOrderreveiw.Items.Add("Squid");
            }
            //if the checkbox is unchecked, it will remove the text above if it is present in the listbox
            else
            {
                lstOrderreveiw.Items.Remove("Squid");
            }
        }

        private void CkbHam_CheckedChanged(object sender, EventArgs e)
        //I've done this so it acts as some sort of Data Validation
        {   //if the checkbox is checked, it will add Ham to the listbox
            if (ckbHam.Checked == true)
            {
                lstOrderreveiw.Items.Add("Ham");
            }
            //if the checkbox is unchecked, it will remove the text above if it is present in the listbox
            else
            {
                lstOrderreveiw.Items.Remove("Ham");
            }
        }

        private void CkbOlives_CheckedChanged(object sender, EventArgs e)
        //I've done this so it acts as some sort of Data Validation
        {   //if the checkbox is checked, it will add Olives to the listbox
            if (ckbOlives.Checked == true)
            {
                lstOrderreveiw.Items.Add("Black Olives");
            }
            //if the checkbox is unchecked, it will remove the text above if it is present in the listbox
            else
            {
                lstOrderreveiw.Items.Remove("Black Olives");
            }
        }

        private void CkbPepperoni_CheckedChanged(object sender, EventArgs e)
        //I've done this so it acts as some sort of Data Validation
        {   //if the checkbox is checked, it will add Pepperoni to the listbox
            if (ckbPepperoni.Checked == true)
            {
                lstOrderreveiw.Items.Add("Pepperoni");
            }
            //if the checkbox is unchecked, it will remove the text above if it is present in the listbox
            else
            {
                lstOrderreveiw.Items.Remove("Pepperoni");
            }
        }

        private void CkbPufferfish_CheckedChanged(object sender, EventArgs e)
        //I've done this so it acts as some sort of Data Validation
        {   //if the checkbox is checked, it will add Pufferfish to the listbox
            if (ckbPufferfish.Checked == true)
            {
                lstOrderreveiw.Items.Add("Pufferfish");
            }
            //if the checkbox is unchecked, it will remove the text above if it is present in the listbox
            else
            {
                lstOrderreveiw.Items.Remove("Pufferfish");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {   //I have done this because it's a fixed price for this application
            lblPrice.Text = ("Total Price: £15");
        }
    }
}
