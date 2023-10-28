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

namespace FWD.G_Customers
{
    public partial class Form_cus_print : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();

        TB_CUST_Person tb_cust_person = new TB_CUST_Person();
        //  TB_CUS_Family_Member tb_family = new TB_CUS_Family_Member();
        public Form_cus_print()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.View_CUST_Main_data_01.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.View_CUST_Main_data_01.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //  TB_CUS_Family_Member tb_family = new TB_CUS_Family_Member(); 
            Reports.XtraReport4 report = new Reports.XtraReport4();

            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CUST_Main_ID"));
            tb_cust_person = DataBase.TB_CUST_Person.Where(x => x.CUST_Main_ID == id).FirstOrDefault();
            report.DataSource = tb_cust_person;

            //   tb_family = DataBase.TB_CUS_Family_Member.Where(x => x.CUST_Family_Member_PK == id).ToList();
            //     tb_family = DataBase.TB_CUS_Family_Member.Where(x => x.CUST_Family_Member_PK == id).ToList();
            // report.DetailReport.DataSource = TB_CUS_Family_Member;
            //       List<TB_CUS_Family_Member> tb_family = DataBase.TB_CUS_Family_Member.Where(x => x.CUST_Family_Member_PK >0).ToList();


            //    report.DetailReport.DataSource = tb_family; 
            report.ShowPreview();
            //   report.ShowDesigner();
        }
        private int rr = 0;
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            rr++;
            if (rr > 5)
            {
                simpleButton2.Enabled = true;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            var rs = MessageBox.Show("عملية تعديل", "هل انت متاكد من عملية التعديل", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Reports.XtraReport4 report = new Reports.XtraReport4();
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CUST_Main_ID"));
                tb_cust_person = DataBase.TB_CUST_Person.Where(x => x.CUST_Main_ID == id).FirstOrDefault();
                report.DataSource = tb_cust_person;
                report.ShowDesigner();
            }
        }

        private void Form_cus_print_Load(object sender, EventArgs e)
        {

        }
    }
}
