﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;


namespace FWD.G_Users
{
    public partial class Form_User_List : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        View_emploee_list view_Emploee_List = new View_emploee_list();
        TB_Emploee emp = new TB_Emploee();
        public Form_User_List()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.View_emploee_list.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.View_emploee_list.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            gridView1.CustomDrawCell += gridControl1_CustomDrawCell;
        }

        private void Form_User_List_Load(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Emploee_Roll_login_State")
            {
                string cellValue = e.CellValue.ToString();
                if (cellValue == "false")
                {
                    e.Appearance.BackColor = Color.OrangeRed;
                    e.Appearance.ForeColor = Color.White;
                }
                else
                {
                    e.Appearance.BackColor = Color.YellowGreen;
                    e.Appearance.ForeColor = Color.White;

                }
            }
        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            gridView1.CustomDrawCell += gridControl1_CustomDrawCell;
            DataBase = new DB_FWDEntities();
            gridControl1.DataSource = DataBase.View_emploee_list.ToList();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Emploee_ID"));
            var rs = MessageBox.Show("عملية حذف", "هل انت متاكد من عملية الحذف", MessageBoxButtons.YesNo);

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toast.Toast_Del ToastDel = new Toast.Toast_Del();


            try
            {
                if (rs == DialogResult.Yes)
                {
                    emp = DataBase.TB_Emploee.Where(x => x.Emploee_ID == id).FirstOrDefault();
                    DataBase.Entry(emp).State = EntityState.Deleted;
                    DataBase.SaveChanges();

                   DataBase = new DB_FWDEntities();
                   gridControl1.DataSource = DataBase.View_emploee_list.ToList();

                    ToastDel.Show();
                }
            }
            catch
            {
                ToastWaring.Lable_Text.Text = "لا يوجد شئ لحذفة";
                ToastWaring.Show();
            }
        }
    }
}
