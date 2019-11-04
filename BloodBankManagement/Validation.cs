using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagement
{
    static class Validation
    {
        public static bool IsNullEmptyWhiteSpace(string check)
        {
            if (string.IsNullOrEmpty(check) || string.IsNullOrWhiteSpace(check))
                return false;
            else
                return true;
        }
        public static bool ValidateDonor(string Name,string BloodGroup,string Rh,string Email,string Phone)
        {
            if (IsNullEmptyWhiteSpace(Name) && IsNullEmptyWhiteSpace(BloodGroup) && IsNullEmptyWhiteSpace(Rh) && IsNullEmptyWhiteSpace(Email) && IsNullEmptyWhiteSpace(Phone))
                return true;
            else
                return false;
        }
    }
}
