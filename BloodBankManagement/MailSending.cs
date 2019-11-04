using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement
{
    static class MailSending
    {
        public static void Send(List<Donor> Donors,string Body,string Message)
        {
            foreach (var item in Donors)
            {
                SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
                var mail = new MailMessage();
                mail.From = new MailAddress("#########"); //use your Address
                mail.To.Add(item.MailAdress);
                mail.Subject = Body;               
                mail.Body = Message;
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("####", "#####"); //Address and Password
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);              
            }
        }
        public static List<Donor> GetDonorsForInvite(string BloodGroup,string Rh)
        {
            List<Donor> Donors;
            using (var db = new BloodBankEntities1())
            {
                Donors = (from d in db.Donor
                          where d.BloodGroup == BloodGroup && d.RH == Rh
                          select d).ToList();
            }

            return Donors;
        }
    }
    
}
