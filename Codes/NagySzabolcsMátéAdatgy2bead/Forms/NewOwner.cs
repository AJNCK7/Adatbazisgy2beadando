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
    public partial class NewOwner : Form
    {
        private Form1 helper;
        private List<Owners> owners;
        public NewOwner(Form1 form1)
        {
            InitializeComponent();
            helper = form1;
            OwnerTableHandler ownerTableHandler = new OwnerTableHandler();
            owners = ownerTableHandler.Select();
        }

        private void btn_addnewowner_Click(object sender, EventArgs e)
        {
            try
            {
                Owners newo = new Owners();
                newo.OwnerId = owners.Count + 1;
                newo.FamilyName = tb_FN.Text;
                newo.Surname = tb_SN.Text;
                newo.BirthDate = dtp_BD.Value;
                newo.ZipCode = tb_ZC.Text;
                newo.City = tb_CT.Text;
                newo.Address = tb_AD.Text;
                newo.PhoneNumber = tb_PN.Text;
                newo.Email = tb_EM.Text;

                tb_FN.Clear();
                tb_SN.Clear();
                tb_ZC.Clear();
                tb_CT.Clear();
                tb_AD.Clear();
                tb_PN.Clear();
                tb_EM.Clear();

                OwnerTableHandler handler = new OwnerTableHandler();
                int insertedrownum = handler.Insert(newo);
                MessageBox.Show(insertedrownum + "sor sikeresen rögzítve");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            helper.UpdateDgv_table();
            
        }
    }
}
