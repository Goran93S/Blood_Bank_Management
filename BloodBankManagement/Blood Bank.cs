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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodBankDataSet.Donor' table. You can move, or remove it, as needed.
            this.donorTableAdapter.Fill(this.bloodBankDataSet.Donor);



            
        }

        private void addDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDonor newForm = new AddDonor(this);
            newForm.Show();
        }

        private void searchByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SearchByName newForm = new SearchByName(this);
            newForm.Show();
        }
       
        private void dataGridViewDonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void searchByBloodGroupAndRHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByBloodGroupAndRh newForm = new SearchByBloodGroupAndRh(this);
            newForm.Show();
        }

        private void updateDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GetDataOps.DonorUpdateId = int.Parse(dataGridViewDonors.SelectedCells[0].Value.ToString());
                UpdateDonor newForm = new UpdateDonor(this);
                newForm.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("You must select Id of Donor or whole row");
            }
     

        }

        private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
                {
                GetDataOps.DonorUpdateId = int.Parse(dataGridViewDonors.SelectedCells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Deleting Donor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    GetDataOps.DeleteDonor(GetDataOps.DonorUpdateId);
                    dataGridViewDonors.DataSource = GetDataOps.GetAllDonnors();
                }

                else if (dialogResult == DialogResult.No)
                {

                }
            
            }
            catch(Exception)
            {
                MessageBox.Show("You must select Id of Donor or whole row");
            }
        }

        private void sendInviteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invite newForm = new Invite();
            newForm.Show();
        }

        private void listAllDonorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewDonors.DataSource=GetDataOps.GetAllDonnors();
        }

      
    }
}
