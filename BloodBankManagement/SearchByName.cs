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
    public partial class SearchByName : Form
    {
        public Form1 frm;
        public SearchByName(Form1 _frm)
        {
            InitializeComponent();
            this.frm = _frm;
        }

        private void SearchByName_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (Validation.IsNullEmptyWhiteSpace(textBox1.Text))
                frm.dataGridViewDonors.DataSource = GetDataOps.GetDonnorsbyName(textBox1.Text);
            else
                MessageBox.Show("Enter name");
            
        }
              

      
    }
}
