﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;


namespace FWD.G_Registered_Users
{
    public partial class Form_Registered_Users_Add : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        public int ID_1 = 0;
        TB_Registered_Users tb_registered_users = new TB_Registered_Users();
        public Form_Registered_Users_Add()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext1 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext1.TB_Social_State.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_per_social_state.Properties.DataSource = dbContext1.TB_Social_State.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


 /*
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext2 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
           dbContext2.TB_Health_Status.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_per_helth_type.Properties.DataSource = dbContext2.TB_Health_Status.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            */


            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext3 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext3.TB_Educational_Status.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_per_edu.Properties.DataSource = dbContext3.TB_Educational_Status.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());



            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext4 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext4.TBE_LOC.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_per_add.Properties.DataSource = dbContext4.TBE_LOC.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());



            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext5 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext5.TB_SUPP.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_supp_name.Properties.DataSource = dbContext5.TB_SUPP.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Rank.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_rank.Properties.DataSource = dbContext.TB_Rank.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());






            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext11 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext11.TBE_LOC.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_per_add.Properties.DataSource = dbContext11.TBE_LOC.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());




            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext22 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext22.TB_SUPP.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_supp_name.Properties.DataSource = dbContext22.TB_SUPP.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext33 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext33.TB_Educational_Status.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_per_edu.Properties.DataSource = dbContext33.TB_Educational_Status.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext

            /*
            FWD.DB_FWDEntities dbContext44 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext44.Registered_Users_Search.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_per_helth_type.Properties.DataSource = dbContext44.Registered_Users_Search.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            */
            // This line of code is generated by Data Source Configuration Wizard
        /*    // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext55 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext55.TB_Health_Status.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_per_helth_type.Properties.DataSource = dbContext55.TB_Health_Status.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

*/

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext88 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext88.TB_Rank.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_rank.Properties.DataSource = dbContext88.TB_Rank.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
          /*  FWD.DB_FWDEntities dbContextr = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContextr.TB_Health_Status.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                edt_per_helth_type.Properties.DataSource = dbContextr.TB_Health_Status.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext*/
            FWD.DB_FWDEntities dbContextAA = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContextAA.TB_Health_Status.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    edt_per_helth_type.Properties.DataSource = dbContextAA.TB_Health_Status.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();

            if (ID_1==0)
            {

                try
                {
                    if (!string.IsNullOrEmpty(edt_per_name.Text))
                    {
                        tb_registered_users.Registered_Users_Name = edt_per_name.Text;
                    }

                    if (edt_per_social_state.EditValue != null)
                    {
                        tb_registered_users.Registered_Users_so_st = Convert.ToInt32(edt_per_social_state.EditValue.ToString());
                    }

                    if (!string.IsNullOrEmpty(edt_per_ssn.Text))
                    {
                        tb_registered_users.Registered_Users_Ssn = edt_per_ssn.Text;
                    }

                    if (!string.IsNullOrEmpty(edt_hus_name.Text))
                    {
                        tb_registered_users.Registered_Users_Hus_Name = edt_hus_name.Text;
                    }

                    if (!string.IsNullOrEmpty(edt_hus_phone.Text))
                    {
                        tb_registered_users.Registered_Users_Hus_Phone = edt_hus_phone.Text;
                    }

                    if (!string.IsNullOrEmpty(edt_hus_ssn.Text))
                    {
                        tb_registered_users.Registered_Users_Hus_Ssn = edt_hus_ssn.Text;
                    }

                    if (!string.IsNullOrEmpty(edt_per_phone.Text))
                    {
                        tb_registered_users.Registered_Users_phone = edt_per_phone.Text;
                    }

                    if (Fsmily_num.EditValue != null)
                    {
                        tb_registered_users.Registered_Users_Fam_Num = Convert.ToInt32(Fsmily_num.EditValue.ToString());
                    }

                    if (edt_per_add.EditValue != null)
                    {
                        tb_registered_users.Registered_Users_Add = Convert.ToInt32(edt_per_add.EditValue.ToString());
                    }

                    if (!string.IsNullOrEmpty(edt_per_add_det.Text))
                    {
                        tb_registered_users.Registered_Users_Add_det = edt_per_add_det.Text;
                    }

                    if (!string.IsNullOrEmpty(edt_income_name.Text))
                    {
                        tb_registered_users.Registered_Users_incom_name = edt_income_name.Text;
                    }

                    if (edt_incode_val.EditValue != null)
                    {
                        tb_registered_users.Registered_Users_income_val = Convert.ToInt32(edt_incode_val.EditValue.ToString());
                    }

                    if (edt_supp_name.EditValue != null)
                    {
                        tb_registered_users.Registered_Users_Supp = Convert.ToInt32(edt_supp_name.EditValue.ToString());
                    }

                    if (edt_rank.EditValue != null)
                    {
                        tb_registered_users.Registered_Users_Rank = Convert.ToInt32(edt_rank.EditValue.ToString());
                    }
                    else
                    {
                        tb_registered_users.Registered_Users_Rank =4;

                    }

                    if (edt_per_helth_type.EditValue != null)
                    {
                        tb_registered_users.Registered_Users_Helth = Convert.ToInt32(edt_per_helth_type.EditValue.ToString());
                    }

                    if (!string.IsNullOrEmpty(edt_per_helth_det.Text))
                    {
                        tb_registered_users.Registered_Users_Helth_info = edt_per_helth_det.Text;
                    }

                    if (DateTime.TryParse(edt_per_bairth.Text, out DateTime birthDate))
                    {
                        tb_registered_users.Registered_Users_BairthDay = birthDate;
                    }


                    if (!string.IsNullOrEmpty(edt_per_helth_det.Text))
                    {
                        tb_registered_users.Registered_Users_Helth_info = edt_per_helth_det.Text;
                    }


                    DataBase.TB_Registered_Users.Add(tb_registered_users);
                        DataBase.SaveChanges();

                    ToastDone.LbTitelAlterBox.Text = "تمت عملية التسجيل";
                    ToastDone.Show();
                    Clear_Form();
                //    this.Close();

               }
                catch (DbUpdateException ex)
                {
                    var innerException = ex.InnerException;
                    if (innerException is System.Data.Entity.Core.UpdateException updateEx &&
                        updateEx.InnerException is SqlException sqlEx &&
                        (sqlEx.Number == 2627 || sqlEx.Number == 2601)) 
                    {
                        ToastWaring.Lable_Text.Font = new Font(ToastWaring.Lable_Text.Font.FontFamily, 18);
                        ToastWaring.Lable_Text.Text = "هذا الرقم القومى مسجل";
                        ToastWaring.Show();
                    }
                    else
                    {
                        ToastWaring.Lable_Text.Text = "An error occurred while updating the database.";
                        ToastWaring.Show();
                    }
                }
                catch (Exception ex)
                {
                    ToastWaring.Lable_Text.Text = "An error occurred: " + ex.Message;
                    ToastWaring.Show();
                }

            }
            else
            {


                try 
                {
                    tb_registered_users.Registered_Users_ID = ID_1; 
                    tb_registered_users.Registered_Users_Name = edt_per_name.Text;
                    tb_registered_users.Registered_Users_so_st = Convert.ToInt32(edt_per_social_state.EditValue);

                    tb_registered_users.Registered_Users_Ssn = edt_per_ssn.Text;

                    tb_registered_users.Registered_Users_Hus_Name = edt_hus_name.Text;
                    tb_registered_users.Registered_Users_Hus_Phone = edt_hus_phone.Text;
                    tb_registered_users.Registered_Users_Hus_Ssn = edt_hus_ssn.Text;
                    tb_registered_users.Registered_Users_phone = edt_per_phone.Text;
                    tb_registered_users.Registered_Users_Fam_Num = Convert.ToInt32(Fsmily_num.Text);
                    tb_registered_users.Registered_Users_Add = Convert.ToInt32(edt_per_add.EditValue);
                    tb_registered_users.Registered_Users_Add_det = edt_per_add_det.Text;
                    tb_registered_users.Registered_Users_incom_name = edt_income_name.Text;
                    tb_registered_users.Registered_Users_income_val = Convert.ToInt32(edt_incode_val.Text);
                    tb_registered_users.Registered_Users_Supp = Convert.ToInt32(edt_supp_name.EditValue);
                    tb_registered_users.Registered_Users_Rank = Convert.ToInt32(edt_rank.EditValue);
                    tb_registered_users.Registered_Users_Helth = Convert.ToInt32(edt_per_helth_type.EditValue);
                    tb_registered_users.Registered_Users_Helth_info = edt_per_helth_det.Text;

                    DataBase.Entry(tb_registered_users).State = System.Data.Entity.EntityState.Modified;
                    DataBase.SaveChanges();

                    ToastDone.LbTitelAlterBox.Text = "تمت التعديل ";

                    ToastDone.Show();
                    Clear_Form();
                    this.Close();

                }
                catch (DbUpdateException ex)
                {
                    var innerException = ex.InnerException;
                    if (innerException is System.Data.Entity.Core.UpdateException updateEx &&
                        updateEx.InnerException is SqlException sqlEx &&
                        (sqlEx.Number == 2627 || sqlEx.Number == 2601)) // Unique constraint violation
                    {
                        ToastWaring.Lable_Text.Font = new Font(ToastWaring.Lable_Text.Font.FontFamily, 18);
                        ToastWaring.Lable_Text.Text = "هذا الرقم القومى مسجل";
                        ToastWaring.Show();
                    }
                    else
                    {
                        ToastWaring.Lable_Text.Text = "An error occurred while updating the database.";
                        ToastWaring.Show();
                    }
                }
                catch (Exception ex)
                {
                    ToastWaring.Lable_Text.Text = "An error occurred: " + ex.Message;
                    ToastWaring.Show();
                }
            }

        }


        private void Clear_Form()
        {

            edt_per_name.Text = "";
            edt_per_social_state.Text = "";
            edt_per_ssn.Text = "";
            edt_hus_name.Text = "";
            edt_hus_phone.Text = "";
            edt_hus_ssn.Text = "";
            edt_per_phone.Text = "";
            Fsmily_num.Value = 0;
            edt_per_add.Text = "";
            edt_per_add_det.Text = "";
            edt_income_name.Text = "";
            edt_incode_val.Text = "";
            edt_supp_name.Text = "";
            edt_rank.Text = "";
            edt_per_helth_type.Text = "";
            edt_per_helth_det.Text = "";


        }

        private void Form_Registered_Users_Add_Load(object sender, EventArgs e)
        {
            Lood_f();

        }


         void Lood_f()
        {
            /*
            this.tB_RankTableAdapter.Fill(this.dB_FWDDataSet2049.TB_Rank);
            this.tB_SUPPTableAdapter.Fill(this.dB_FWDDataSet2048.TB_SUPP);
            this.tBE_LOCTableAdapter.Fill(this.dB_FWDDataSet2047.TBE_LOC);
            this.tB_Educational_StatusTableAdapter.Fill(this.dB_FWDDataSet2044.TB_Educational_Status);
            this.tB_Health_StatusTableAdapter.Fill(this.dB_FWDDataSet2042.TB_Health_Status);
            this.tB_Social_StateTableAdapter.Fill(this.dB_FWDDataSet2041.TB_Social_State);
            ***/
        }
    }
}
