using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagySzabolcsMátéAdatgy2bead
{
    public class Owners
    {

        private int ownerid;
        public int OwnerId
        {
            set
            {
                ownerid = value;
            }
            get
            {
                return ownerid;
            }
        }

        private string familyName;
        public string FamilyName
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("A vezetéknév nem lehet null");
                }
                if (value.Length <= 0)
                {
                    throw new Exception("A vezetéknév legalább 1 karakter hosszúnak kell lenni");
                }
                if (value.Length > 60)
                {
                    throw new Exception("60 karakternél több nem lehet a családnév");
                }
                familyName = value;
            }

            get
            {
                return familyName;
            }
        }

        private string surname;
        public string Surname
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("A vezetéknév nem lehet null");
                }
                if (value.Length <= 0)
                {
                    throw new Exception("A vezetéknév legalább 1 karakter hosszúnak kell lenni");
                }
                if (value.Length > 60)
                {
                    throw new Exception("60 karakternél több nem lehet a keresztév");
                }
                surname = value;
            }

            get
            {
                return surname;
            }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("A születési dátum nem lehet null értékű");
                }
                if (value.Year < 1900)
                {
                    throw new Exception("A születési dátum nem lehet korábban mint 1900");
                }
                if (value.Year >= DateTime.Now.Year)
                {
                    throw new Exception("A születési idő nem lehet a jelenlegi idő");
                }
                birthDate = value;
            }

            get
            {
                return birthDate;
            }
        }

        public string szamok = "1234567890";
        private string zipCode;
        public string ZipCode
        {
            set
            {
                if (value.Length != 4)
                {
                    throw new Exception("Az irányítószámnak 4 számjegy hosszúnak kell lenni");
                }
                if (value[0] == 0)
                {
                    throw new Exception("Az irányítószám első számjegye nem lehet 0");
                }
                for (int i = 0; i < 4; i++)
                {
                    if (!szamok.Contains(value[i]))
                    {
                        throw new Exception("Az irányítószám csak számokat tartalmazhat(magyarországon)");
                    }
                }
                zipCode = value;
            }

            get
            {
                return zipCode;
            }
        }

        private string city;
        public string City
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("A város nem lehet null");
                }
                if (value.Length == 0)
                {
                    throw new Exception("A város nem lehet 0 hosszúságú");
                }
                if (value.Length > 200)
                {
                    throw new Exception("A város neve nem lehet hosszabb mint 200 karakter");
                }
                city = value;
            }

            get
            {
                return city;
            }
        }

        private string address;
        public string Address
        {
            set
            {
                if (value == null)
                {
                    throw new Exception("A lakcím nem lehet null");
                }
                if (value.Length == 0)
                {
                    throw new Exception("A lakcím nem lehet 0 hosszúságú");
                }
                if (value.Length > 200)
                {
                    throw new Exception("A cím nem lehet hosszabb mint 200 karakter");
                }
                address = value;
            }

            get
            {
                return address;
            }
        }

        public string betu = "qwertzuiopőúasdfghjkléáűíyxcvbnmöüó";
        private string phoneNumber;
        public string PhoneNumber
        {
            set
            {
                StringBuilder sb = new StringBuilder();
                if (value.Contains('-'))
                {

                    string[] tmp = value.Split('-');
                    foreach (string a in tmp)
                        sb.Append(a);
                    value = sb.ToString();

                }
                else if (value.Contains(' '))
                {

                    string[] tmp = value.Split(' ');
                    foreach (string a in tmp)
                        sb.Append(a);
                    value = sb.ToString();
                }
                if (value == null)
                    throw new Exception("A város értéke nem lehet null!");
                if ((value[0] + "" + value[1] + "" + value[2]).ToString() != "+36" || value.Length - 3 != 9)
                {
                    if ((value[0] + "" + value[1]).ToString() != "06" || value.Length - 2 != 9)
                        throw new Exception("A mobilszám formátuma +36NNNNNNNNN vagy 06NNNNNNNNN!");
                }
                phoneNumber = value;

            }
            get
            {
                return phoneNumber;
            }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private string email;
        public string Email
        {
            set
            {
                if (IsValidEmail(value) == false)
                {
                    throw new Exception("Az email cím formátuma nem megfelelő");
                }
                email = value;
                if (value.Length > 200)
                {
                    throw new Exception("Az email nem lehet hosszabb mint 200 karakter");
                }
            }
            get { return email; }
        }
    }
}
