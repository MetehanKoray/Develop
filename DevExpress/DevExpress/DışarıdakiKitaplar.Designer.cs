namespace DevExpress
{
    partial class DışarıdakiKitaplar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DışarıdakiKitaplar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.kutuphaneDataSet3 = new DevExpress.KutuphaneDataSet3();
            this.mevcutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mevcutTableAdapter = new DevExpress.KutuphaneDataSet3TableAdapters.MevcutTableAdapter();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.kutuphaneDataSet4 = new DevExpress.KutuphaneDataSet4();
            this.v1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v1TableAdapter = new DevExpress.KutuphaneDataSet4TableAdapters.v1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mevcutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.v1BindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(624, 119);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "v1";
            series1.XValueMember = "uye_ad";
            series1.YValueMembers = "0";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // kutuphaneDataSet3
            // 
            this.kutuphaneDataSet3.DataSetName = "KutuphaneDataSet3";
            this.kutuphaneDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mevcutBindingSource
            // 
            this.mevcutBindingSource.DataMember = "Mevcut";
            this.mevcutBindingSource.DataSource = this.kutuphaneDataSet3;
            // 
            // mevcutTableAdapter
            // 
            this.mevcutTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton7
            // 
            this.simpleButton7.AutoSize = true;
            this.simpleButton7.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.Image")));
            this.simpleButton7.Location = new System.Drawing.Point(854, 43);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(70, 70);
            this.simpleButton7.TabIndex = 30;
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // kutuphaneDataSet4
            // 
            this.kutuphaneDataSet4.DataSetName = "KutuphaneDataSet4";
            this.kutuphaneDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v1BindingSource
            // 
            this.v1BindingSource.DataMember = "v1";
            this.v1BindingSource.DataSource = this.kutuphaneDataSet4;
            // 
            // v1TableAdapter
            // 
            this.v1TableAdapter.ClearBeforeFill = true;
            // 
            // DışarıdakiKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 431);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DışarıdakiKitaplar";
            this.Text = "DışarıdakiKitaplar";
            this.Load += new System.EventHandler(this.DışarıdakiKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mevcutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private KutuphaneDataSet3 kutuphaneDataSet3;
        private System.Windows.Forms.BindingSource mevcutBindingSource;
        private KutuphaneDataSet3TableAdapters.MevcutTableAdapter mevcutTableAdapter;
        private XtraEditors.SimpleButton simpleButton7;
        private KutuphaneDataSet4 kutuphaneDataSet4;
        private System.Windows.Forms.BindingSource v1BindingSource;
        private KutuphaneDataSet4TableAdapters.v1TableAdapter v1TableAdapter;
    }
}