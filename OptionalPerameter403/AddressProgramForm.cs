/*
 * Created by: Nicholas  Ellul
 * Created on: 1-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 4-03
 * This program lists all of your address details. It uses a perameter that refers to a perameter.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalPerameter403
{
    public partial class AddressProgramForm : Form
    {
        public void AddressInfo(string funStreetAddress, string funCity, string funProvince, string funPostalCode,string funAptNumber)
        {
            if(funAptNumber == "")
            {
               AddressInfo(funStreetAddress, funCity, funProvince, funPostalCode);
            }
            else
            {
            MessageBox.Show(funStreetAddress + ", " + funAptNumber + ", " + funCity + ", " + funProvince + ", " + funPostalCode);
            }
        }

        public void AddressInfo(string funStreetAddress, string funCity, string funProvince, string funPostalCode)
        {
            MessageBox.Show(funStreetAddress + ", "  + funCity + ", " + funProvince + ", " + funPostalCode);
        }


        public AddressProgramForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string aptNumber = this.txtAptNumber.Text;
            string streetAddress = this.txtStreetAddress.Text;
            string city = this.txtCity.Text;
            string province = this.txtProvince.Text;
            string postalCode = this.txtPostalCode.Text;

            AddressInfo(streetAddress, city, province, postalCode, aptNumber);
        }
    }
}
