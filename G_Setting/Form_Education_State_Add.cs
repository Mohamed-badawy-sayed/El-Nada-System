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

namespace FWD.G_Setting
{
    public partial class Form_Education_State_Add : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_Educational_Status tb_Educational_Status = new TB_Educational_Status();
        public Form_Education_State_Add()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Educational_Status.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridSplitContainer1Grid.DataSource = dbContext.TB_Educational_Status.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toise.Toast_Wrong toast_Wrong = new Toise.Toast_Wrong();

            var rs = MessageBox.Show("تاكد من البيانات", "هل متاكد من ان البيانات صحيحة ؟ّ! لا يمكنك الحذف او التعديل ", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {

                try
                {
                    if (Edit_Text_1.Text == "" )
                    {
                        ToastWaring.Lable_Text.Text = "اضف الحالة التعليمة";
                        ToastWaring.Show();
                    }
                    else
                    {
                        tb_Educational_Status.Educational_Status_Name = Edit_Text_1.Text;

                        DataBase.TB_Educational_Status.Add(tb_Educational_Status);
                        DataBase.SaveChanges();


                        ToastDone.Lable_Text.Text = "تمت الاضافة";
                        ToastDone.Show();
                        this.Close();
                    }
                }
                catch
                {
                    toast_Wrong.Lable_Text.Text = "حدث خطأ";
                    toast_Wrong.Show();

                }

            }
        }
    }
}
