namespace AmbienteTeste
{
    partial class dashboard
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.viewFinancas = new AmbienteTeste.viewFinancas();
            this.saldobancarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saldo_bancarioTableAdapter = new AmbienteTeste.viewFinancasTableAdapters.saldo_bancarioTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.viewFinancas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldobancarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewFinancas
            // 
            this.viewFinancas.DataSetName = "viewFinancas";
            this.viewFinancas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saldobancarioBindingSource
            // 
            this.saldobancarioBindingSource.DataMember = "saldo_bancario";
            this.saldobancarioBindingSource.DataSource = this.viewFinancas;
            // 
            // saldo_bancarioTableAdapter
            // 
            this.saldo_bancarioTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.saldobancarioBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Saldo";
            series1.XValueMember = "str_saldo_saldo";
            series1.YValueMembers = "dt_data_saldo";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(621, 438);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Finanças";
            this.chart1.Titles.Add(title1);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 441);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewFinancas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saldobancarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private viewFinancas viewFinancas;
        private System.Windows.Forms.BindingSource saldobancarioBindingSource;
        private viewFinancasTableAdapters.saldo_bancarioTableAdapter saldo_bancarioTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}