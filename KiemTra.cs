using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QUANLYHT
{
    class KiemTra
    {
        static public bool KiemTra_Password(string pass)
        {
            if (pass.Length >= 5 && pass.Length <= 20 && pass != "")
            {
                return true;
            }
            return false;
        }
        static public bool KiemTra_CPassword(string pass, string cpass)
        {
            if (pass == cpass)
            {
                return true;
            }
            return false;
        }
        //
        static public bool KiemTra_Username(string username)
        {
            string kitu = @"^[a-zA-Z]{1}[a-zA-Z0-9\._\-]{0,23}[^.-]$";

            Regex kiemtra = new Regex(kitu, RegexOptions.Compiled);
            bool check = false;
            if (username == null)
            {
                check = false;
            }
            else
            {
                check = kiemtra.IsMatch(username);
            }
            return check;
        }
        //
        static public bool KiemTra_Occ(string occ)
        {
            string kitu = @"^[a-zA-Z][a-zA-Z ]*[a-zA-Z]$";
            Regex kiemtra = new Regex(kitu, RegexOptions.Compiled);
            bool check = false;
            if (occ == null)
            {
                check = false;
            }
            else
            {
                check = kiemtra.IsMatch(occ);
            }
            return check;
        }
        //
        static public bool KiemTra_Address(string add)
        {
            string kitu = @"^[a-zA-Z0-9][a-zA-Z0-9 ]*[a-zA-Z0-9]$";
            Regex kiemtra = new Regex(kitu, RegexOptions.Compiled);
            bool check = false;
            if (add == null)
            {
                check = false;
            }
            else
            {
                check = kiemtra.IsMatch(add);
            }
            return check;
        }
        //
        static public bool KiemTra_Email(string email)
        {
            string kitu = @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
                 (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";

            Regex kiemtra = new Regex(kitu, RegexOptions.IgnorePatternWhitespace);
            bool check = false;
            if (email == null)
            {
                check = false;
            }
            else
            {
                check = kiemtra.IsMatch(email);
            }
            return check;
        }
    }
}
