namespace DevExpress
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kutuphaneDataSet11 = new DevExpress.KutuphaneDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colk_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colk_ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colk_sifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kullanıcı_GirisTableAdapter1 = new DevExpress.KutuphaneDataSet1TableAdapters.Kullanıcı_GirisTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.Datagridview1 = new System.Windows.Forms.DataGridView();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneDataSet10 = new DevExpress.KutuphaneDataSet10();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabloTableAdapter = new DevExpress.KutuphaneDataSet2TableAdapters.TabloTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.kitaplarTableAdapter = new DevExpress.KutuphaneDataSet10TableAdapters.KitaplarTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınEviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayıntarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temintarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Kullanıcı_Giris";
            this.gridControl1.DataSource = this.kutuphaneDataSet11;
            this.gridControl1.Location = new System.Drawing.Point(484, 155);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // kutuphaneDataSet11
            // 
            this.kutuphaneDataSet11.DataSetName = "KutuphaneDataSet1";
            this.kutuphaneDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colk_id,
            this.colk_ad,
            this.colk_sifre});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.SearchInPreview = true;
            // 
            // colk_id
            // 
            this.colk_id.FieldName = "k_id";
            this.colk_id.Name = "colk_id";
            this.colk_id.Visible = true;
            this.colk_id.VisibleIndex = 0;
            // 
            // colk_ad
            // 
            this.colk_ad.FieldName = "k_ad";
            this.colk_ad.Name = "colk_ad";
            this.colk_ad.Visible = true;
            this.colk_ad.VisibleIndex = 1;
            // 
            // colk_sifre
            // 
            this.colk_sifre.FieldName = "k_sifre";
            this.colk_sifre.Name = "colk_sifre";
            this.colk_sifre.Visible = true;
            this.colk_sifre.VisibleIndex = 2;
            // 
            // kullanıcı_GirisTableAdapter1
            // 
            this.kullanıcı_GirisTableAdapter1.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(448, 94);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(529, 94);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(466, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(466, 38);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 4;
            // 
            // Datagridview1
            // 
            this.Datagridview1.AutoGenerateColumns = false;
            this.Datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.barkodnoDataGridViewTextBoxColumn,
            this.kitapadDataGridViewTextBoxColumn,
            this.kitapyazarDataGridViewTextBoxColumn,
            this.yayınEviDataGridViewTextBoxColumn,
            this.yayıntarihiDataGridViewTextBoxColumn,
            this.kitapturDataGridViewTextBoxColumn,
            this.temintarihDataGridViewTextBoxColumn});
            this.Datagridview1.DataSource = this.kitaplarBindingSource;
            this.Datagridview1.Location = new System.Drawing.Point(15, 455);
            this.Datagridview1.Name = "Datagridview1";
            this.Datagridview1.Size = new System.Drawing.Size(400, 150);
            this.Datagridview1.TabIndex = 5;
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "Kitaplar";
            this.kitaplarBindingSource.DataSource = this.kutuphaneDataSet10;
            // 
            // kutuphaneDataSet10
            // 
            this.kutuphaneDataSet10.DataSetName = "KutuphaneDataSet10";
            this.kutuphaneDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            lineAnnotation1.Name = "sonuc";
            this.chart1.Annotations.Add(lineAnnotation1);
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.tabloBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(610, 27);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Age";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.XValueMember = "Kitap";
            series1.YValueMembers = "Sayı";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // tabloTableAdapter
            // 
            this.tabloTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.kitaplarBindingSource;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(15, 133);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(434, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barkodnoDataGridViewTextBoxColumn
            // 
            this.barkodnoDataGridViewTextBoxColumn.DataPropertyName = "Barkod_no";
            this.barkodnoDataGridViewTextBoxColumn.HeaderText = "Barkod_no";
            this.barkodnoDataGridViewTextBoxColumn.Name = "barkodnoDataGridViewTextBoxColumn";
            // 
            // kitapadDataGridViewTextBoxColumn
            // 
            this.kitapadDataGridViewTextBoxColumn.DataPropertyName = "Kitap_ad";
            this.kitapadDataGridViewTextBoxColumn.HeaderText = "Kitap_ad";
            this.kitapadDataGridViewTextBoxColumn.Name = "kitapadDataGridViewTextBoxColumn";
            // 
            // kitapyazarDataGridViewTextBoxColumn
            // 
            this.kitapyazarDataGridViewTextBoxColumn.DataPropertyName = "Kitap_yazar";
            this.kitapyazarDataGridViewTextBoxColumn.HeaderText = "Kitap_yazar";
            this.kitapyazarDataGridViewTextBoxColumn.Name = "kitapyazarDataGridViewTextBoxColumn";
            // 
            // yayınEviDataGridViewTextBoxColumn
            // 
            this.yayınEviDataGridViewTextBoxColumn.DataPropertyName = "YayınEvi";
            this.yayınEviDataGridViewTextBoxColumn.HeaderText = "YayınEvi";
            this.yayınEviDataGridViewTextBoxColumn.Name = "yayınEviDataGridViewTextBoxColumn";
            // 
            // yayıntarihiDataGridViewTextBoxColumn
            // 
            this.yayıntarihiDataGridViewTextBoxColumn.DataPropertyName = "Yayın_tarihi";
            this.yayıntarihiDataGridViewTextBoxColumn.HeaderText = "Yayın_tarihi";
            this.yayıntarihiDataGridViewTextBoxColumn.Name = "yayıntarihiDataGridViewTextBoxColumn";
            // 
            // kitapturDataGridViewTextBoxColumn
            // 
            this.kitapturDataGridViewTextBoxColumn.DataPropertyName = "Kitap_tur";
            this.kitapturDataGridViewTextBoxColumn.HeaderText = "Kitap_tur";
            this.kitapturDataGridViewTextBoxColumn.Name = "kitapturDataGridViewTextBoxColumn";
            // 
            // temintarihDataGridViewTextBoxColumn
            // 
            this.temintarihDataGridViewTextBoxColumn.DataPropertyName = "Temin_tarih";
            this.temintarihDataGridViewTextBoxColumn.HeaderText = "Temin_tarih";
            this.temintarihDataGridViewTextBoxColumn.Name = "temintarihDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 733);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Datagridview1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraGrid.GridControl gridControl1;
        private XtraGrid.Views.Grid.GridView gridView1;
        private KutuphaneDataSet1 kutuphaneDataSet11;
        private XtraGrid.Columns.GridColumn colk_id;
        private XtraGrid.Columns.GridColumn colk_ad;
        private XtraGrid.Columns.GridColumn colk_sifre;
        private KutuphaneDataSet1TableAdapters.Kullanıcı_GirisTableAdapter kullanıcı_GirisTableAdapter1;
        private XtraEditors.SimpleButton simpleButton1;
        private XtraEditors.SimpleButton simpleButton2;
        private XtraEditors.TextEdit textEdit1;
        private XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.DataGridView Datagridview1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource tabloBindingSource;
        private KutuphaneDataSet2TableAdapters.TabloTableAdapter tabloTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button3;
        private KutuphaneDataSet10 kutuphaneDataSet10;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private KutuphaneDataSet10TableAdapters.KitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınEviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayıntarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temintarihDataGridViewTextBoxColumn;
    }
}