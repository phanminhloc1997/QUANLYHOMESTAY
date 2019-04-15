using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QUANLYHT
{
    public class KiemTra
    {
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public bool KiemTra_Password(string pass)
        {
            if (pass.Length >= 5 && pass.Length <= 20 && pass != "")
            {
                return true;
            }
            return false;
        }

        private string cpass;

        public string Cpass
        {
            get { return cpass; }
            set { cpass = value; }
        }

        public bool KiemTra_CPassword(string pass, string cpass)
        {
            if (pass == cpass)
            {
                return true;
            }
            return false;
        }
        //

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public bool KiemTra_Username(string username)
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
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public bool KiemTra_Email(string email)
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
