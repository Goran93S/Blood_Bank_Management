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
    public partial class UpdateDonor : Form
    {
        public Form1 frm;
        public UpdateDonor(Form1 _frm)
        {
            InitializeComponent();
            this.frm = _frm;
            FillInfo();

        }
        private void UpdateDonor_Load(object sender, EventArgs e)
        {

        }
        public void FillInfo()
        {   if (GetDataOps.DonorUpdateId != 0)
            {
                textBoxName.Text = GetDataOps.GetDonorById(GetDataOps.DonorUpdateId).Name;
                textBoxBloodGroup.Text = GetDataOps.GetDonorById(GetDataOps.DonorUpdateId).BloodGroup.ToString();
                textBoxRh.Text = GetDataOps.GetDonorById(GetDataOps.DonorUpdateId).RH.ToString();
                textBoxMail.Text = GetDataOps.GetDonorById(GetDataOps.DonorUpdateId).MailAdress.ToString();
                textBoxPhone.Text = GetDataOps.GetDonorById(GetDataOps.DonorUpdateId).PhoneNumber.ToString();
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (Validation.ValidateDonor(textBoxName.Text, textBoxBloodGroup.Text, textBoxRh.Text, textBoxMail.Text, textBoxPhone.Text))
            {



                DialogResult dialogResult = MessageBox.Show("Do you want to Upate Donor?", "Updating Donor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GetDataOps.UpdateDonor(GetDataOps.DonorUpdateId, textBoxName.Text, textBoxBloodGroup.Text, textBoxRh.Text, textBoxMail.Text, textBoxPhone.Text);
                    frm.dataGridViewDonors.DataSource = GetDataOps.GetAllDonnors();

                }

                else if (dialogResult == DialogResult.No)
                {

                }

            }
            else
            MessageBox.Show("Error! Entries are not good");
        }
    }
}
