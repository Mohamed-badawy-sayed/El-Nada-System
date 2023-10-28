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

namespace FWD.G_Customers
{
    public partial class Form_Cus_Reserch : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_CUST_Resercher tb_cust_resercher = new TB_CUST_Resercher();
        public Form_Cus_Reserch()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext1 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext1.TB_RES.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_res_resercher.Properties.DataSource = dbContext1.TB_RES.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_SUPP.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    edt_res_supp.Properties.DataSource = dbContext.TB_SUPP.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Form_Cus_Reserch_Load(object sender, EventArgs e)
        {
 

        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();

            try
            {
                tb_cust_resercher.CUST_Resercher_Date = edt_res_date.DateTimeOffset.DateTime;
                tb_cust_resercher.CUST_Resercher_Deg = Convert.ToInt32(edt_res_deg.Text);
                tb_cust_resercher.CUST_Resercher_Direction = edt_res_dir.Text;
                tb_cust_resercher.CUST_Resercher_Name = Convert.ToInt32(edt_res_resercher.EditValue);
                tb_cust_resercher.CUST_Resercher_Supp = Convert.ToInt32(edt_res_supp.EditValue);
                tb_cust_resercher.CUST_Resercher_Opin = edt_res_opin.Text;
                tb_cust_resercher.CUST_Resercher_State = Convert.ToInt32( edt_res_state.EditValue);           
                tb_cust_resercher.CUST_Resercher_FK = Class_main.myGlobalVariable;           
                DataBase.TB_CUST_Resercher.Add(tb_cust_resercher);
                DataBase.SaveChanges();
                Button_Add.Enabled = false;

                ToastDone.Lable_Text.Text = "تم تسجيل هذا المتطلب";
                ToastDone.Show();
           //     UpDate_Data();

            }
            catch
            {
                ToastWaring.Lable_Text.Text = "حدث خطا فى الحفظ";
                ToastWaring.Show();
            }



        }

        private void edt_res_resercher_Click(object sender, EventArgs e)
        {
        }

        private void edt_res_resercher_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void edt_res_deg_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
