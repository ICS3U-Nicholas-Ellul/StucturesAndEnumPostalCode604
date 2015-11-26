/*
 * Created by: Nicholas Ellul
 * Created on: 25-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 6-03
 * This program lists all of your address details. It uses a 
 * perameter that refers to a perameter. Uses a structure as a mail address. Provinces are enum.
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

namespace OptionalPerameterWithStruct603
{
    public partial class AddressProgramForm : Form
    {
        CANPROVINCE selectedProvince;

        public enum CANPROVINCE
        {
            //PROVINCES
            BC,
            AL,
            MN,
            NB,
            NL,
            NS,
            ON,
            PE,
            QC,
            SK,
            //TERRITORIES
            YU,
            NT,
            NU

        }
        
        public struct MailingAddress
        {
            public string aptNumber;
            public string streetAddress;
            public string city;
            public CANPROVINCE province;
            public string postalCode;
        }

        
        public void AddressInfo(string funStreetAddress, string funCity, CANPROVINCE funProvince, string funPostalCode,string funAptNumber)
        {
            if(funAptNumber == "")
            {
               AddressInfo(funStreetAddress, funCity, funProvince, funPostalCode);
            }
            else
            {
            MessageBox.Show(funStreetAddress + ", " + funAptNumber + ", " + funCity + ", " + funProvince + ", " + funPostalCode,"Your Address");
            }
        }

        public void AddressInfo(string funStreetAddress, string funCity, CANPROVINCE funProvince, string funPostalCode)
        {
            MessageBox.Show(funStreetAddress + ", "  + funCity + ", " + funProvince + ", " + funPostalCode, "Your Address");
        }

    
        public AddressProgramForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //input
            MailingAddress mailToMe = new MailingAddress();

            mailToMe.aptNumber = this.txtAptNumber.Text;
            mailToMe.streetAddress = this.txtStreetAddress.Text;
            mailToMe.city = this.txtCity.Text;
            mailToMe.province = selectedProvince;
            mailToMe.postalCode = this.txtPostalCode.Text;

            //process
            AddressInfo(mailToMe.streetAddress, mailToMe.city, mailToMe.province, mailToMe.postalCode, mailToMe.aptNumber);
        }

        private void cboProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gets value from combo box
            string selectedItem;           
            selectedItem = Convert.ToString(this.cboProvinces.SelectedItem);
            selectedProvince = (CANPROVINCE)(Enum.Parse(typeof(CANPROVINCE), selectedItem));
            
        }

        private void AddressProgramForm_Load(object sender, EventArgs e)
        {
            //populate combo box with provinces
            foreach (CANPROVINCE prov in Enum.GetValues(typeof(CANPROVINCE)))
            {
                this.cboProvinces.Items.Add(prov);
            }
            this.cboProvinces.SelectedIndex = 0;
        }
    }
}
