using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace NagySzabolcsMátéAdatgy2bead
{
    public partial class ChangeOwnerDatas : Form
    {
        private Form1 helper;
        private string ID;
        public ChangeOwnerDatas(string id, Form1 form1)
        {
            InitializeComponent();
            Initialize_CbDatas();
            ID = id;
            helper = form1;

        }
        public void Initialize_CbDatas()
        {
            cb_Set.Items.Add("FamilyName");
            cb_Set.Items.Add("Surname");
            cb_Set.Items.Add("Zipcode");
            cb_Set.Items.Add("City");
            cb_Set.Items.Add("Address");
            cb_Set.Items.Add("Phonenumber");
            cb_Set.Items.Add("Email");
            cb_Set.SelectedItem = cb_Set.Items[0];
        }


        public void DataSet()
        {
            OwnerTableHandler ownerTableHandler = new OwnerTableHandler();
            foreach (Owners owners in ownerTableHandler.Select())
            {
                if (owners.OwnerId == ID)
                {
                    switch (cb_Set.SelectedIndex)
                    {
                        case 0:
                            ownerTableHandler.Update(ID,"familyName",tb_NewSet.Text, OracleDbType.Varchar2);
                            break;
                        case 1:
                            ownerTableHandler.Update(ID,"surName" ,tb_NewSet.Text, OracleDbType.Varchar2);
                            break;
                        case 2:
                            ownerTableHandler.Update(ID, "zipCode",  tb_NewSet.Text, OracleDbType.Varchar2);
                            break;
                        case 3:
                            ownerTableHandler.Update(ID, "city",  tb_NewSet.Text, OracleDbType.Varchar2);
                            break;
                        case 4:
                            ownerTableHandler.Update(ID, "address",  tb_NewSet.Text, OracleDbType.Varchar2);
                            break;
                        case 5:
                            ownerTableHandler.Update(ID, "phonenumber",  tb_NewSet.Text, OracleDbType.Varchar2);
                            break;
                        case 6:
                            ownerTableHandler.Update(ID, "email",  tb_NewSet.Text, OracleDbType.Varchar2);
                            break;
                        default:
                            break;
                    }
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet();
            MessageBox.Show("Siker");
            helper.UpdateDgv_table();
            this.Close();
        }
    }
}
