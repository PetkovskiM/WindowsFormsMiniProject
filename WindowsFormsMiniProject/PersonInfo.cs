using DemooLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMiniProject
{
    public partial class PersonInfo : Form, IAddAddress
    {
        BindingList<AdressModel> adresses = new BindingList<AdressModel>();
        public PersonInfo()
        {
            InitializeComponent();
            adressesList.DisplayMember = nameof(AdressModel.FullAddress);
            adressesList.DataSource = adresses;
        }

        private void addNewAdress_Click(object sender, EventArgs e)
        {
            AdressInfo adress = new AdressInfo(this);

            adress.Show();
        }

        public void SaveAddress(AdressModel adress)
        {
            adresses.Add(adress);
        }

        private void saveRecord_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Adresses = adresses.ToList(),
                IsActive = isActive.Checked
            };

            
        }
    }
}
