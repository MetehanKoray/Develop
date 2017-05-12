namespace DevExpress
{
    partial class Form2
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.kutuphaneDataSet1 = new DevExpress.KutuphaneDataSet();
            this.kullanıcı_GirisTableAdapter1 = new DevExpress.KutuphaneDataSetTableAdapters.Kullanıcı_GirisTableAdapter();
            this.fieldkid1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldkad1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldksifre1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataMember = "Kullanıcı_Giris";
            this.pivotGridControl1.DataSource = this.kutuphaneDataSet1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldkid1,
            this.fieldkad1,
            this.fieldksifre1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(546, 338);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.Click += new System.EventHandler(this.pivotGridControl1_Click);
            // 
            // kutuphaneDataSet1
            // 
            this.kutuphaneDataSet1.DataSetName = "KutuphaneDataSet";
            this.kutuphaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanıcı_GirisTableAdapter1
            // 
            this.kullanıcı_GirisTableAdapter1.ClearBeforeFill = true;
            // 
            // fieldkid1
            // 
            this.fieldkid1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldkid1.AreaIndex = 0;
            this.fieldkid1.FieldName = "k_id";
            this.fieldkid1.Name = "fieldkid1";
            // 
            // fieldkad1
            // 
            this.fieldkad1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldkad1.AreaIndex = 1;
            this.fieldkad1.FieldName = "k_ad";
            this.fieldkad1.Name = "fieldkad1";
            // 
            // fieldksifre1
            // 
            this.fieldksifre1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldksifre1.AreaIndex = 2;
            this.fieldksifre1.FieldName = "k_sifre";
            this.fieldksifre1.Name = "fieldksifre1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 338);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraPivotGrid.PivotGridControl pivotGridControl1;
        private KutuphaneDataSet kutuphaneDataSet1;
        private KutuphaneDataSetTableAdapters.Kullanıcı_GirisTableAdapter kullanıcı_GirisTableAdapter1;
        private XtraPivotGrid.PivotGridField fieldkid1;
        private XtraPivotGrid.PivotGridField fieldkad1;
        private XtraPivotGrid.PivotGridField fieldksifre1;
    }
}