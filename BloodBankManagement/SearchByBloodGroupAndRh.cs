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
    public partial class SearchByBloodGroupAndRh : Form
    {
        public Form1 frm;
        public SearchByBloodGroupAndRh(Form1 _frm)
        {
            InitializeComponent();
            this.frm = _frm;
        }

        private void SearchByBloodGroupAndRh_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (Validation.IsNullEmptyWhiteSpace(textBoxBloodGroup.Text) && Validation.IsNullEmptyWhiteSpace(textBoxRh.Text))
                frm.dataGridViewDonors.DataSource = GetDataOps.GetDonnorsbyGroupAndRh(textBoxBloodGroup.Text, textBoxRh.Text);
            else
                MessageBox.Show("Enter value of Blood Group or RH");
        }
    }
}
