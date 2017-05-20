namespace goruntu_isleme
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.görüntüAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kırmızıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.döndürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tersÇevirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çözünürlükToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yakınlaştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzaklaştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parlaklığıArttırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parlaklığıAzaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrastArttırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrastAzaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görüntüAlToolStripMenuItem,
            this.renkDeğiştirToolStripMenuItem,
            this.döndürToolStripMenuItem,
            this.çözünürlükToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // görüntüAlToolStripMenuItem
            // 
            this.görüntüAlToolStripMenuItem.Name = "görüntüAlToolStripMenuItem";
            this.görüntüAlToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.görüntüAlToolStripMenuItem.Text = "Görüntü Al";
            this.görüntüAlToolStripMenuItem.Click += new System.EventHandler(this.görüntüAlToolStripMenuItem_Click);
            // 
            // renkDeğiştirToolStripMenuItem
            // 
            this.renkDeğiştirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kırmızıToolStripMenuItem,
            this.yeşilToolStripMenuItem,
            this.maviToolStripMenuItem,
            this.griToolStripMenuItem,
            this.negatifToolStripMenuItem});
            this.renkDeğiştirToolStripMenuItem.Name = "renkDeğiştirToolStripMenuItem";
            this.renkDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.renkDeğiştirToolStripMenuItem.Text = "Renk Değiştir";
            // 
            // kırmızıToolStripMenuItem
            // 
            this.kırmızıToolStripMenuItem.Name = "kırmızıToolStripMenuItem";
            this.kırmızıToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.kırmızıToolStripMenuItem.Text = "Kırmızı";
            this.kırmızıToolStripMenuItem.Click += new System.EventHandler(this.kırmızıToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.yeşilToolStripMenuItem.Text = "Yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.griToolStripMenuItem.Text = "Gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // negatifToolStripMenuItem
            // 
            this.negatifToolStripMenuItem.Name = "negatifToolStripMenuItem";
            this.negatifToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.negatifToolStripMenuItem.Text = "Negatif";
            this.negatifToolStripMenuItem.Click += new System.EventHandler(this.negatifToolStripMenuItem_Click);
            // 
            // döndürToolStripMenuItem
            // 
            this.döndürToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tersÇevirToolStripMenuItem,
            this.aynalaToolStripMenuItem,
            this.öteleToolStripMenuItem});
            this.döndürToolStripMenuItem.Name = "döndürToolStripMenuItem";
            this.döndürToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.döndürToolStripMenuItem.Text = "Döndür";
            // 
            // tersÇevirToolStripMenuItem
            // 
            this.tersÇevirToolStripMenuItem.Name = "tersÇevirToolStripMenuItem";
            this.tersÇevirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.tersÇevirToolStripMenuItem.Text = "Ters Çevir";
            this.tersÇevirToolStripMenuItem.Click += new System.EventHandler(this.tersÇevirToolStripMenuItem_Click);
            // 
            // aynalaToolStripMenuItem
            // 
            this.aynalaToolStripMenuItem.Name = "aynalaToolStripMenuItem";
            this.aynalaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.aynalaToolStripMenuItem.Text = "Aynala";
            this.aynalaToolStripMenuItem.Click += new System.EventHandler(this.aynalaToolStripMenuItem_Click);
            // 
            // öteleToolStripMenuItem
            // 
            this.öteleToolStripMenuItem.Name = "öteleToolStripMenuItem";
            this.öteleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.öteleToolStripMenuItem.Text = "Ötele";
            this.öteleToolStripMenuItem.Click += new System.EventHandler(this.öteleToolStripMenuItem_Click);
            // 
            // çözünürlükToolStripMenuItem
            // 
            this.çözünürlükToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yakınlaştırToolStripMenuItem,
            this.uzaklaştırToolStripMenuItem,
            this.parlaklığıArttırToolStripMenuItem,
            this.parlaklığıAzaltToolStripMenuItem,
            this.kontrastArttırToolStripMenuItem,
            this.kontrastAzaltToolStripMenuItem});
            this.çözünürlükToolStripMenuItem.Name = "çözünürlükToolStripMenuItem";
            this.çözünürlükToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.çözünürlükToolStripMenuItem.Text = "Çözünürlük";
            // 
            // yakınlaştırToolStripMenuItem
            // 
            this.yakınlaştırToolStripMenuItem.Name = "yakınlaştırToolStripMenuItem";
            this.yakınlaştırToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yakınlaştırToolStripMenuItem.Text = "Yakınlaştır";
            this.yakınlaştırToolStripMenuItem.Click += new System.EventHandler(this.yakınlaştırToolStripMenuItem_Click);
            // 
            // uzaklaştırToolStripMenuItem
            // 
            this.uzaklaştırToolStripMenuItem.Name = "uzaklaştırToolStripMenuItem";
            this.uzaklaştırToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uzaklaştırToolStripMenuItem.Text = "Uzaklaştır";
            this.uzaklaştırToolStripMenuItem.Click += new System.EventHandler(this.uzaklaştırToolStripMenuItem_Click);
            // 
            // parlaklığıArttırToolStripMenuItem
            // 
            this.parlaklığıArttırToolStripMenuItem.Name = "parlaklığıArttırToolStripMenuItem";
            this.parlaklığıArttırToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.parlaklığıArttırToolStripMenuItem.Text = "Parlaklığı Arttır";
            this.parlaklığıArttırToolStripMenuItem.Click += new System.EventHandler(this.parlaklığıArttırToolStripMenuItem_Click);
            // 
            // parlaklığıAzaltToolStripMenuItem
            // 
            this.parlaklığıAzaltToolStripMenuItem.Name = "parlaklığıAzaltToolStripMenuItem";
            this.parlaklığıAzaltToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.parlaklığıAzaltToolStripMenuItem.Text = "Parlaklığı Azalt";
            this.parlaklığıAzaltToolStripMenuItem.Click += new System.EventHandler(this.parlaklığıAzaltToolStripMenuItem_Click);
            // 
            // kontrastArttırToolStripMenuItem
            // 
            this.kontrastArttırToolStripMenuItem.Name = "kontrastArttırToolStripMenuItem";
            this.kontrastArttırToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kontrastArttırToolStripMenuItem.Text = "Kontrast Arttır";
            this.kontrastArttırToolStripMenuItem.Click += new System.EventHandler(this.kontrastArttırToolStripMenuItem_Click);
            // 
            // kontrastAzaltToolStripMenuItem
            // 
            this.kontrastAzaltToolStripMenuItem.Name = "kontrastAzaltToolStripMenuItem";
            this.kontrastAzaltToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kontrastAzaltToolStripMenuItem.Text = "Kontrast Azalt";
            this.kontrastAzaltToolStripMenuItem.Click += new System.EventHandler(this.kontrastAzaltToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(593, 5);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Kırmızı";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Yeşil";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Mavi";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(449, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 317);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem görüntüAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kırmızıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem döndürToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tersÇevirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öteleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çözünürlükToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yakınlaştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzaklaştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parlaklığıArttırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parlaklığıAzaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrastArttırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrastAzaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

