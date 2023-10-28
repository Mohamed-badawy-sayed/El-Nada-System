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
    public partial class Form_Cus_Home : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_CUST_Home tb_cust_home = new TB_CUST_Home();
        public Form_Cus_Home()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBE_LOC.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    edt_home_add.Properties.DataSource = dbContext.TBE_LOC.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e){

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            try
            {
                tb_cust_home.CUST_Home_AC = (edt_home_check_AC.Checked);
                tb_cust_home.CUST_Home_Botogaz = (edt_home_check_botogas.Checked);
                tb_cust_home.CUST_Home_Cooker = (edt_home_check_cook.Checked);
                tb_cust_home.CUST_Home_cooler = (edt_home_check_cooler.Checked);
                tb_cust_home.CUST_Home_Elec = (edt_home_check_elec.Checked);
                tb_cust_home.CUST_Home_Frizer = (edt_home_check_frizer.Checked);
                tb_cust_home.CUST_Home_Gas = (edt_home_check_gas.Checked);
                tb_cust_home.CUST_Home_TV = (edt_home_check_tv.Checked);
                tb_cust_home.CUST_Home_washing = (edt_home_check_washing.Checked);
                tb_cust_home.CUST_Home_Water = (edt_home_check_water.Checked);
                tb_cust_home.CUST_Home_WC = (edt_home_check_wc.Checked);

                tb_cust_home.CUST_Home_Add =Convert.ToInt32(edt_home_add.EditValue);
                tb_cust_home.CUST_Home_Add_Det = edt_home_add_det.Text;

                tb_cust_home.CUST_Home_Floor_Num = Convert.ToInt32(edt_home_num_floor.Text);
                tb_cust_home.CUST_Home_Room_Num = Convert.ToInt32(edt_home_num_floor.Text);

                tb_cust_home.CUST_Home_Struct_Type = edt_home_struct_type.Text;
                tb_cust_home.CUST_Home_Floor_Type = edt_home_floor_type.Text;
                tb_cust_home.CUST_Home_Ceil_Type = edt_home_ceil_type.Text;
                tb_cust_home.CUST_Home_Own = edt_home_own.Text;


                tb_cust_home.CUST_Home_PK = Class_main.myGlobalVariable;

                DataBase.TB_CUST_Home.Add(tb_cust_home);
                DataBase.SaveChanges();
                ToastDone.Lable_Text.Text = "تم تسجيل بيانات المنزل";
                ToastDone.Show();

                Btn_add.Enabled = false;

            }
            catch
            {
                ToastWaring.Lable_Text.Text = "حدث خطا فى الحفظ";
                ToastWaring.Show();
            }


        }

        private void Form_Cus_Home_Load(object sender, EventArgs e){
            

        }

        private void edt_supp_retion_Click(object sender, EventArgs e)
        {
            
        }

        private void panel_Form_Cus_Home_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
