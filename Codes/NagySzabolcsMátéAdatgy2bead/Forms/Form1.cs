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
    public partial class Form1 : Form
    {
        private List<Owners> owners;
        public Form1()
        {
            InitializeComponent();
            Initializecb_OwnORAni();
            Initializedgv_table();
            UpdateDgv_table();
        }

        private void Initializecb_OwnORAni()
        {
            cb_OwnORAni.Items.Add("Owner");
            cb_OwnORAni.Items.Add("Animal");
            cb_OwnORAni.SelectedItem = cb_OwnORAni.Items[0];
        }

        private void btn_NewOwner_Click(object sender, EventArgs e)
        {
            NewOwner newOwner = new NewOwner(this);
            newOwner.ShowDialog();
        }

        private void cb_OwnORAni_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_OwnORAni.SelectedIndex == 0)
            {
                Initializedgv_table();
                UpdateDgv_table();
            }
            else
            {
                Initializedgv_table();
                UpdateDgv_table();
            }
        }

        private void Initializedgv_table()
        {
            dgv_table.Columns.Clear();
            dgv_table.Rows.Clear();
            dgv_table.AutoGenerateColumns = false;
            if (cb_OwnORAni.SelectedItem == cb_OwnORAni.Items[0])
            {
                dgv_table.Columns.Add("Id", "Id");
                dgv_table.Columns.Add("Fname", "Family name");
                dgv_table.Columns.Add("Sname", "Surname");
                dgv_table.Columns.Add("BirthDate", "Birth date");
            }
            else
            {
                dgv_table.Columns.Add("Id", "Id");
                dgv_table.Columns.Add("Animalname", "Animal name");
                dgv_table.Columns.Add("BirthDate", "Birth date");
                dgv_table.Columns.Add("Neme", "Gender");
                dgv_table.Columns.Add("Ivartalanitott", "Neutered");
            }

            DataGridViewButtonColumn dgvbcRead = new DataGridViewButtonColumn();
            dgvbcRead.Text = "View";
            dgvbcRead.Name = "Datas";
            dgvbcRead.UseColumnTextForButtonValue = true;
            dgv_table.Columns.Add(dgvbcRead);
            dgv_table.AutoResizeColumns();

            DataGridViewButtonColumn dgvbcSet = new DataGridViewButtonColumn();
            dgvbcSet.Text = "Change";
            dgvbcSet.Name = "Change";
            dgvbcSet.UseColumnTextForButtonValue = true;
            dgv_table.Columns.Add(dgvbcSet);
            dgv_table.AutoResizeColumns();

            DataGridViewButtonColumn dgvbcDelete = new DataGridViewButtonColumn();
            dgvbcDelete.Text = "Delete";
            dgvbcDelete.Name = "Delete";
            dgvbcDelete.UseColumnTextForButtonValue = true;
            dgv_table.Columns.Add(dgvbcDelete);
            dgv_table.AutoResizeColumns();

        }

        private void dgv_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            switch (dgv.Columns[e.ColumnIndex].Name)
            {
                case "Datas":
                    if (cb_OwnORAni.SelectedIndex == 0)
                    {
                       OwnerDatas ownerDatas = new OwnerDatas(dgv.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                        ownerDatas.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nem lett kidolgozva");
                    }

                    break;
                case "Change":
                    ChangeDatas(dgv.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    break;
                case "Delete":
                    DeleteDatas(dgv.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    break;
                default:
                    break;
            }
        }

        public void UpdateDgv_table()
        {
            dgv_table.Rows.Clear();
            if (cb_OwnORAni.SelectedIndex == 0)
            {
                OwnerTableHandler ownerTableHandler = new OwnerTableHandler();
                foreach (Owners o in ownerTableHandler.Select())
                {
                    dgv_table.Rows.Add(new object[]
                    {
                        o.OwnerId,
                        o.FamilyName,
                        o.Surname,
                        o.BirthDate.ToString("yyyy.MM.dd")
                    });
                }
            }
        }

        public void DeleteDatas(string number)
        {
            if (cb_OwnORAni.SelectedIndex == 0)
            {
                OwnerTableHandler ownerTableHandler = new OwnerTableHandler();
                string deletedrecordnumber = ownerTableHandler.Delete(number).ToString(); ////////////////6--------------------------------
                MessageBox.Show(deletedrecordnumber + "rekord sikeresen törölve!");
                owners = ownerTableHandler.Select();
                ownerTableHandler.Delete(number);
                Initializedgv_table();
                UpdateDgv_table();
            }
        }

        public void ChangeDatas(string id)
        {
            if (cb_OwnORAni.SelectedIndex == 0)
            {
                ChangeOwnerDatas set = new ChangeOwnerDatas(id, this);
                set.ShowDialog();
            }
        }
    }
}
