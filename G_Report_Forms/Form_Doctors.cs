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
using DevExpress.XtraReports.UI;

namespace FWD.G_Report_Forms
{
    public partial class Form_Doctors : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_DOC tb_doc = new TB_DOC();
        Registered_Users_View registered_rsers_view = new Registered_Users_View();
        View_Doctor_report view_Doctor_Report = new View_Doctor_report();


        public Form_Doctors()
        {
            InitializeComponent();

            edt_doc_Date.DateTime = DateTime.Today;


            FWD.DB_FWDEntities dbContext1 = new FWD.DB_FWDEntities();
            dbContext1.View_Doctor_report.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext1.View_Doctor_report.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext2 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext2.TB_Doctor_Info.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    Edit_Doctor_name.Properties.DataSource = dbContext2.TB_Doctor_Info.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());



        }

        private void simpleButton2_Click(object sender, EventArgs e){


        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            UpDate_Data();
        }

        private void UpDate_Data()
        {
            DataBase = new DB_FWDEntities();
            gridControl1.DataSource = DataBase.View_Doctor_report.ToList();

            FWD.DB_FWDEntities dbContext1 = new FWD.DB_FWDEntities();
            dbContext1.View_Doctor_report.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext1.View_Doctor_report.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext2 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext2.TB_Doctor_Info.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                Edit_Doctor_name.Properties.DataSource = dbContext2.TB_Doctor_Info.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Reports.Doctor_Report_3 Report = new Reports.Doctor_Report_3();
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            view_Doctor_Report = DataBase.View_Doctor_report.Where(x => x.ID == id).FirstOrDefault();
           Report.DataSource = view_Doctor_Report;
           Report.ShowPreview();
         //   Report.ShowDesigner();

        }


        private void edt_doc_ssn_EditValueChanged(object sender, EventArgs e)
        {
           
        }


        private int AgeCalc(string x)
        {

            DateTime currentDate = DateTime.Today;
            DateTime dateOfBirth1 = SSN(x);
            int age1 = currentDate.Year - dateOfBirth1.Year;
            if (currentDate < dateOfBirth1.AddYears(age1)) age1--;
            return age1;
        }

        public DateTime SSN(string x)
        {
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            try
            {
                int birthYear = int.Parse(x.Substring(1, 2));
                int birthMonth = int.Parse(x.Substring(3, 2));
                int birthDay = int.Parse(x.Substring(5, 2));

                int century = int.Parse(x[0].ToString());
                if (century == 2)
                {
                    birthYear += 1900;
                }
                else if (century == 3)
                {
                    birthYear += 2000;
                }

                DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
                return birthDate;

            }
            catch
            {
                ToastWaring.Lable_Text.Text = "الرقم القومى غير صحيح";
                ToastWaring.Show();
                return DateTime.Now;
            }



        }

        public string Gender(string x)
        {
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            try
            {

                int G1 = int.Parse(x.Substring(12, 1));
                if (G1 % 2 == 0) return "انثي";
                else return "ذكر";
            }
            catch
            {
                ToastWaring.Lable_Text.Text = "الرقم القومى غير صحيح";
                ToastWaring.Show();
                return " ";
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();

            try
            {

           
                if (edt_doc_Date.Text == "" || edt_code.Text == "" || Edit_Doctor_name.Text == "")
                {
                    ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                    ToastWaring.Show();
                }
                else
                {
                    tb_doc.DOC_Name = Convert.ToInt32(Edit_Doctor_name.EditValue);
                    tb_doc.DOC_Patint = Convert.ToInt32(edt_code.Text);
                    tb_doc.DOC_Date = edt_doc_Date.DateTime;
                    tb_doc.DOC_Det = edt_doc_det.Text;
                    tb_doc.DOC_SSN= registered_rsers_view.Registered_Users_Ssn;

                    DataBase.TB_DOC.Add(tb_doc);
                    DataBase.SaveChanges();




                    ToastDone.LbTitelAlterBox.Text = "تمت الاضافة";
                    ToastDone.Show();

                    UpDate_Data();

                }
            }
            catch
            {
                ToastWaring.Lable_Text.Text = "هذا الاسم غير مسجل";
                ToastWaring.Show();
                //  cus_id = 1;
                Clear_Form();


            }
        }

        private void edt_doc_ssn_EditValueChanged_1(object sender, EventArgs e)
        {
          
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            var rs = MessageBox.Show("عملية حذف", "هل انت متاكد من عملية الحذف", MessageBoxButtons.YesNo);

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toast.Toast_Del ToastDel = new Toast.Toast_Del();


            try
            {
                if (rs == DialogResult.Yes)
                {
                    tb_doc = DataBase.TB_DOC.Where(x => x.ID == id).FirstOrDefault();
                    DataBase.Entry(tb_doc).State = EntityState.Deleted;
                    DataBase.SaveChanges();
                    UpDate_Data();
                    ToastDel.Show();
                }
            }
            catch
            {
                ToastWaring.Lable_Text.Text = "لا يوجد شئ لحذفة";
                ToastWaring.Show();
            }
        }

        private void edt_doc_Date_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_Doctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_FWDDataSet2086.TB_Doctor_Info' table. You can move, or remove it, as needed.
          //  this.tB_Doctor_InfoTableAdapter.Fill(this.dB_FWDDataSet2086.TB_Doctor_Info);
            edt_doc_Date.DateTime = DateTime.Today;

        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Fill_labels_Data()
        {

            try
            {
                label_C_Inf_name.Text = registered_rsers_view.Registered_Users_Name;
                label_C_Inf_ssn.Text = registered_rsers_view.Registered_Users_Ssn;
                label_C_Inf_id.Text = registered_rsers_view.Registered_Users_ID.ToString();
                label_C_Inf_add.Text = registered_rsers_view.LOC_Name;
                label_C_Inf_add_2.Text = registered_rsers_view.LOC_Key;
                label_C_Inf_supp.Text = registered_rsers_view.SUPP_Name;
                label_C_Inf_rank.Text = registered_rsers_view.Rank_Name;

            }
            catch
            {

            }


            // */
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();

            try
            {
                int RRt = Convert.ToInt32(edt_code.Text);
                registered_rsers_view = DataBase.Registered_Users_View.Where(x => x.Registered_Users_ID == RRt).FirstOrDefault();


                if (registered_rsers_view == null)
                {
                    ToastWaring.Lable_Text.Text = "هذا الاسم غير مسجل";
                    ToastWaring.Show();
                    //  cus_id = 1;
                    Clear_Form();
                }
                else
                {

               

                    Fill_labels_Data();

                
                    ToastDone.LbTitelAlterBox.Text = "هذا الاسم موجود ";
                    ToastDone.Show();
                }


            }
            catch
            {
                ToastWaring.Lable_Text.Text = "هذا الاسم غير مسجل";
                ToastWaring.Show();
              //  cus_id = 1;
                Clear_Form();

            }
        }



        private void Clear_Form(){
            label_C_Inf_name.Text = "";
            label_C_Inf_ssn.Text = "";
            label_C_Inf_id.Text = "";
            label_C_Inf_add.Text = "";
            label_C_Inf_add_2.Text = "";
            label_C_Inf_supp.Text = "";
            label_C_Inf_rank.Text = "";
             edt_code.Text = "";

        }

        private void Edit_Doctor_name_Click(object sender, EventArgs e){
       //     this.tB_Doctor_InfoTableAdapter.Fill(this.dB_FWDDataSet2086.TB_Doctor_Info);
            edt_doc_Date.DateTime = DateTime.Today;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            G_Registered_Users.Form_Search_Person form_Search_Person = new G_Registered_Users.Form_Search_Person();
            form_Search_Person.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void Edit_Doctor_name_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
