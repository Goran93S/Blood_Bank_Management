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
    public partial class Invite : Form
    {
        public Invite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Donor> Invite = new List<Donor>();
                Invite = MailSending.GetDonorsForInvite((string)comboBoxBloodGroup.SelectedItem, (string)comboBoxRh.SelectedItem);
                string CompleteMessage = textBoxMessage.Text + Environment.NewLine + "Please be there: " + DateTimePrint();
                MailSending.Send(Invite, textBoxTitle.Text, CompleteMessage);
                MessageBox.Show("Invites are sent!");
            }
            catch(Exception)
            {
                MessageBox.Show("Error! You can not send invite");
            }
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxTitle.Text + Environment.NewLine + textBoxMessage.Text + Environment.NewLine + DateTimePrint());
        }

        public string DateTimePrint()
        {
            return dateTimePicker1.Value.ToShortDateString() + " - " + dateTimePicker1.Value.ToShortTimeString();
        }
    }
}
