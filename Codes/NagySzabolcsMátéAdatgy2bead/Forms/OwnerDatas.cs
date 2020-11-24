using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NagySzabolcsMátéAdatgy2bead
{
    public partial class OwnerDatas : Form
    {
        public OwnerDatas(int ID)
        {
            InitializeComponent();
            Updatelb_Datas(ID);

        }

        private void Updatelb_Datas(int Id)
        {
            OwnerTableHandler ownerTableHandler = new OwnerTableHandler();
            foreach (Owners o in ownerTableHandler.Select())
            {
                if (o.OwnerId == Id)
                {
                    lbl_ownerid.Text = o.OwnerId.ToString();
                    lbl_familyname.Text = o.FamilyName;
                    lbl_surname.Text = o.Surname;
                    lbl_birthdate.Text = o.BirthDate.ToString("yyyy.MM.dd");
                    lbl_zipcode.Text = o.ZipCode;
                    lbl_city.Text = o.City;
                    lbl_address.Text = o.Address;
                    lbl_phonenumber.Text = o.PhoneNumber;
                    lbl_email.Text = o.Email;
                }

            }
        }
    }
}
