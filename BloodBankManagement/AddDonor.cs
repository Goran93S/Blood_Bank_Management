using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagement
{
    public partial class AddDonor : Form
    {
        public Form1 frm;
        public AddDonor(Form1 _frm)
        {
            InitializeComponent();
            this.frm = _frm;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Validation.ValidateDonor(textBoxName.Text, textBoxBloodGroup.Text, textBoxRh.Text, textBoxMail.Text, textBoxPhone.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to add new Donor?", "Adding new Donor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var Donor = new Donor()
                    {
                        Name = textBoxName.Text,
                        BloodGroup = textBoxBloodGroup.Text,
                        RH = textBoxRh.Text,
                        MailAdress = textBoxMail.Text,
                        PhoneNumber = textBoxPhone.Text
                    };

                    GetDataOps.AddDonor(Donor);
                    frm.dataGridViewDonors.DataSource = GetDataOps.GetAllDonnors();


                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Error! Entries aren't good");
            }
        }

        private void AddDonor_Load(object sender, EventArgs e)
        {
          
           
        }

        private void AddDonor_Load_1(object sender, EventArgs e)
        {
          
        }
    }
}
