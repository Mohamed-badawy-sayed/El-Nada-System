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

namespace FWD.G_Courses
{
    public partial class Form_Take_Courses_Add : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        Registered_Users_View registered_rsers_view = new Registered_Users_View();
        TB_Take_Course tb_take_course = new TB_Take_Course();

        public Form_Take_Courses_Add()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Course_info.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    edt_cat.Properties.DataSource = dbContext.TB_Course_info.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();

            try
            {
                int RRt = Convert.ToInt32(edt_code.Text);
                registered_rsers_view = DataBase.Registered_Users_View.Where(x => x.Registered_Users_ID == RRt).FirstOrDefault();
                edt_ssn_serch.Text = registered_rsers_view.Registered_Users_Ssn;
                Fill_labels_Data();

                ToastDone.LbTitelAlterBox.Text = "هذا الاسم موجود ";
                ToastDone.Show();

            }
            catch
            {
                ToastWaring.Lable_Text.Text = "هذا الاسم غير مسجل";
                ToastWaring.Show();
                //     cus_id = 1;
                //  Clear_Form();



                var rs = MessageBox.Show("هل تريد تسجيل حالة جديدة", "هذا الاسم غير موجود ", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    G_Registered_Users.Form_Registered_Users_Add form_registered_users_add = new G_Registered_Users.Form_Registered_Users_Add();
                    form_registered_users_add.Show();

                }


            }
        }



        private void Fill_labels_Data()
        {

            label_C_Inf_name.Text = registered_rsers_view.Registered_Users_Name;
            label_C_Inf_ssn.Text = registered_rsers_view.Registered_Users_Ssn;
            label_C_Inf_id.Text = registered_rsers_view.Registered_Users_ID.ToString();
            label_C_Inf_add.Text = registered_rsers_view.LOC_Name;
            label_C_Inf_add_2.Text = registered_rsers_view.LOC_Key;
            label_C_Inf_supp.Text = registered_rsers_view.SUPP_Name;
            label_C_Inf_rank.Text = registered_rsers_view.Rank_Name;

          ///  edt_res_name.Text = registered_rsers_view.Registered_Users_Name;



            // */
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();


            string ssnToSearch = edt_ssn_serch.Text;
            registered_rsers_view = DataBase.Registered_Users_View.FirstOrDefault(x => x.Registered_Users_Ssn == ssnToSearch);

            if (registered_rsers_view != null)
            {
                Fill_labels_Data();
                int yy = registered_rsers_view.Registered_Users_ID;
                edt_code.Text = registered_rsers_view.Registered_Users_ID.ToString();
                ToastDone.LbTitelAlterBox.Text = "هذا الاسم موجود ";
                ToastDone.Show();
            }
            else
            {

                ToastWaring.Lable_Text.Text = "هذا الاسم غير مسجل";
                ToastWaring.Show();

                var rs = MessageBox.Show("هل تريد تسجيل حالة جديدة", "هذا الاسم غير موجود ", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    G_Registered_Users.Form_Registered_Users_Add form_registered_users_add = new G_Registered_Users.Form_Registered_Users_Add();
                    form_registered_users_add.Show();

                }
            }



        }

        private void Form_Take_Courses_Add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_FWDDataSet2050.TB_Course_info' table. You can move, or remove it, as needed.
          //  this.tB_Course_infoTableAdapter.Fill(this.dB_FWDDataSet2050.TB_Course_info);

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            try { 
                tb_take_course.Take_Course_Course = Convert.ToInt32(edt_cat.EditValue);
                tb_take_course.Take_Course_Student = Convert.ToInt32(edt_code.Text);

                DataBase.TB_Take_Course.Add(tb_take_course);
                DataBase.SaveChanges();


                ToastDone.LbTitelAlterBox.Text = "تمت تسجيل التدريب";
                ToastDone.Show();
                this.Close();
            }
            catch
            {
                Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
                ToastWaring.Lable_Text.Text = "هذا الاسم غير مسجل";
                ToastWaring.Show();
            }
        }
    }
}
