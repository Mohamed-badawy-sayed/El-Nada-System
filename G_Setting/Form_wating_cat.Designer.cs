﻿
namespace FWD.G_Setting
{
    partial class Form_wating_cat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_wating_cat));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridSplitContainer1Grid = new DevExpress.XtraGrid.GridControl();
            this.gridSplitContainer1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWL_Category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit_Text_1 = new DevExpress.XtraEditors.TextEdit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            this.gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Text_1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gridSplitContainer1);
            this.panel2.Controls.Add(this.Btn_Add);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Edit_Text_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 566);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridSplitContainer1.Grid = this.gridSplitContainer1Grid;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 308);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridSplitContainer1Grid);
            this.gridSplitContainer1.Panel1.Text = "Panel1";
            // 
            // gridSplitContainer1.Panel2
            // 
            this.gridSplitContainer1.Panel2.Text = "Panel2";
            this.gridSplitContainer1.Size = new System.Drawing.Size(605, 258);
            this.gridSplitContainer1.TabIndex = 80;
            // 
            // gridSplitContainer1Grid
            // 
            this.gridSplitContainer1Grid.DataSource = typeof(FWD.TB_WL_CAT);
            this.gridSplitContainer1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1Grid.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1Grid.MainView = this.gridSplitContainer1View;
            this.gridSplitContainer1Grid.Name = "gridSplitContainer1Grid";
            this.gridSplitContainer1Grid.Size = new System.Drawing.Size(605, 258);
            this.gridSplitContainer1Grid.TabIndex = 0;
            this.gridSplitContainer1Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSplitContainer1View});
            // 
            // gridSplitContainer1View
            // 
            this.gridSplitContainer1View.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 16F);
            this.gridSplitContainer1View.Appearance.FocusedRow.Options.UseFont = true;
            this.gridSplitContainer1View.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridSplitContainer1View.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridSplitContainer1View.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridSplitContainer1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 17F);
            this.gridSplitContainer1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridSplitContainer1View.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridSplitContainer1View.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridSplitContainer1View.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridSplitContainer1View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 16F);
            this.gridSplitContainer1View.Appearance.Row.Options.UseFont = true;
            this.gridSplitContainer1View.Appearance.Row.Options.UseTextOptions = true;
            this.gridSplitContainer1View.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridSplitContainer1View.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridSplitContainer1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWL_Category});
            this.gridSplitContainer1View.GridControl = this.gridSplitContainer1Grid;
            this.gridSplitContainer1View.Name = "gridSplitContainer1View";
            this.gridSplitContainer1View.OptionsView.ShowGroupPanel = false;
            // 
            // colWL_Category
            // 
            this.colWL_Category.Caption = "اسم الفئة";
            this.colWL_Category.FieldName = "WL_Category";
            this.colWL_Category.Name = "colWL_Category";
            this.colWL_Category.Visible = true;
            this.colWL_Category.VisibleIndex = 0;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Add.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Add.Appearance.Options.UseFont = true;
            this.Btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.ImageOptions.Image")));
            this.Btn_Add.Location = new System.Drawing.Point(133, 177);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(292, 43);
            this.Btn_Add.TabIndex = 9;
            this.Btn_Add.Text = "اضــافــة";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(99, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(423, 66);
            this.label9.TabIndex = 79;
            this.label9.Text = "اضافة فئة الى قائمة الانتظار";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 43);
            this.label2.TabIndex = 72;
            this.label2.Text = "اسم الفئة";
            // 
            // Edit_Text_1
            // 
            this.Edit_Text_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Edit_Text_1.EditValue = "";
            this.Edit_Text_1.Location = new System.Drawing.Point(56, 109);
            this.Edit_Text_1.Name = "Edit_Text_1";
            this.Edit_Text_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit_Text_1.Properties.Appearance.Options.UseFont = true;
            this.Edit_Text_1.Properties.Appearance.Options.UseTextOptions = true;
            this.Edit_Text_1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Edit_Text_1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Edit_Text_1.Size = new System.Drawing.Size(390, 40);
            this.Edit_Text_1.TabIndex = 1;
            // 
            // Form_wating_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 566);
            this.Controls.Add(this.panel2);
            this.Name = "Form_wating_cat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_wating_cat";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            this.gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Text_1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridSplitContainer1Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSplitContainer1View;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit Edit_Text_1;
        private DevExpress.XtraGrid.Columns.GridColumn colWL_Category;
    }
}