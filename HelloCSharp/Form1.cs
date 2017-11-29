using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp
{
    public partial class FrameMain : Form
    {
        bool isAddingNewCustomer = false;
        private TextBox[] fields = new TextBox[6];

        int currentIndex = 0;

        public FrameMain()
        {
           InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("GUI has loaded()");

            fields[0] = fldFirstName;
            fields[1] = fldLastName;
            fields[2] = fldEmail;
            fields[3] = fldPhoneNo;
            fields[4] = fldRating;
            fields[5] = fldServicePro;

            Customer.setUpCustomers();
            updateView();

        }
        private void updateView()
        {
            String[] custData = Customer.getCustomer(currentIndex);

            //for(int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine("Current Customer: " + custData[i]);
            //}
            fields[0].Text = custData[0];
            fields[1].Text = custData[1];
            fields[2].Text = custData[2];
            fields[3].Text = custData[3];
            fields[4].Text = custData[4];
            fields[5].Text = custData[5];

            txtBoxReviews.Text = custData[6];

        }
        /// <summary>
        ///  Button Event Handlers 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (currentIndex < (Customer.getCustomerCount() - 1))
            {
                currentIndex++;
                updateView();
            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(currentIndex > 0)
            {
                currentIndex--;
                updateView();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            updateView();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentIndex = Customer.getCustomerCount() - 1;
            Console.WriteLine("Last index: " + currentIndex);
            updateView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String[] temp = new String[7]; 
            for (int i = 0; i < fields.Length; i++)
            {
                temp[i] = fields[i].Text;
            }
            temp[6] = txtBoxReviews.Text;
            if (isAddingNewCustomer)
            {
                Customer.addNewCustomer(temp);
                currentIndex = Customer.getCustomerCount() - 1;
                isAddingNewCustomer = false;
            }
            Customer.updateCustomer(temp, currentIndex);
            updateView();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            String[] meta = { "First Name", "Last Name", "Email", "Phone NO", "Rating", "Servie Provider" };
            for(int i = 0; i < fields.Length; i++)
            {
                fields[i].Text = meta[i];
            }
            isAddingNewCustomer = true;
            txtBoxReviews.Text = "Input Review Here: ";
        }
    }
}
