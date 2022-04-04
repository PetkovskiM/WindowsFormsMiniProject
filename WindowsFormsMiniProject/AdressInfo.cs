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
    public partial class AdressInfo : Form
    {
        IAddAddress _parent;
        public AdressInfo(IAddAddress parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        private void saveRecord_Click(object sender, EventArgs e)
        {
            AdressModel address = new AdressModel
            {
                City = cityText.Text,
                ZipCode = zipCodeText.Text,
                State = stateText.Text,
                StreetAdress = streetAdressText.Text
            };
            
            _parent.SaveAddress(address);
            this.Close();
        }
    }
}
