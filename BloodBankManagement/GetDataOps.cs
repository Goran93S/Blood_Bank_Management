using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement
{
    static class GetDataOps
    {
        public static int DonorUpdateId;
        public static List<Donor> GetAllDonnors()
        {
            using (var context = new BloodBankEntities1())
            {
                var _allDonors = (from d in context.Donor select d).ToList();

                return _allDonors;

            }
        }
        public static List<Donor> GetDonnorsbyGroupAndRh(string _bloodGroup,string _Rh)
        {
            using (var context = new BloodBankEntities1())
            {
                var _allDonors = (from d in context.Donor where d.BloodGroup==_bloodGroup && d.RH==_Rh select d).ToList();

                return _allDonors;

            }
        }
        public static List<Donor> GetDonnorsbyName(string searchString)
        {
            using (var context = new BloodBankEntities1())
            {
                var _allDonors = (from d in context.Donor
                                  where d.Name.Contains(searchString)
                                  select d).ToList();

                return _allDonors;

            }
        }
        public static Donor GetDonorById(int index)
        {
            Donor query;
            using (var db = new BloodBankEntities1())
            {
                query = (from c in db.Donor
                             where c.DonorId == index
                             select c).SingleOrDefault();
            }
            return query;
        }
        public static void AddDonor(Donor _new)
        {
            using (var db = new BloodBankEntities1())
            {
                db.Donor.Add(_new);
                db.SaveChanges();
            }
        }
        public static void UpdateDonor(int index,string Name,string BloodGroup,string Rh,string Email,string Phone)
        {
            using (var db = new BloodBankEntities1())
            {
                var query = (from c in db.Donor
                             where c.DonorId == index
                             select c).SingleOrDefault();

                query.Name = Name;
                query.BloodGroup = BloodGroup;
                query.RH = Rh;
                query.MailAdress = Email;
                query.PhoneNumber = Phone;

                db.SaveChanges();
            }

            
        }
        public static void DeleteDonor(int index)
        {
            using (var db = new BloodBankEntities1())
            {
                var query = (from c in db.Donor
                             where c.DonorId == index
                             select c).SingleOrDefault();
                db.Donor.Remove(query);
                db.SaveChanges();
            }
        }

    }
}
