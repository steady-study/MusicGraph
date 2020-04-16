namespace MusicGraph
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            SeeSharpTools.JY.GUI.EasyChartSeries easyChartSeries1 = new SeeSharpTools.JY.GUI.EasyChartSeries();
            this.pb = new System.Windows.Forms.PictureBox();
            this.click = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.play = new System.Windows.Forms.Button();
            this.easyChart3 = new SeeSharpTools.JY.GUI.EasyChart();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Black;
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.Location = new System.Drawing.Point(23, 442);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(872, 87);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            // 
            // click
            // 
            this.click.Location = new System.Drawing.Point(488, 32);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(75, 23);
            this.click.TabIndex = 1;
            this.click.Text = "button1";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(569, 32);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 2;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // easyChart3
            // 
            this.easyChart3.AxisX.AutoScale = true;
            this.easyChart3.AxisX.InitWithScaleView = true;
            this.easyChart3.AxisX.LabelEnabled = false;
            this.easyChart3.AxisX.LabelFormat = "";
            this.easyChart3.AxisX.Maximum = 1001D;
            this.easyChart3.AxisX.Minimum = 0D;
            this.easyChart3.AxisX.Orientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart3.AxisX.Position = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Far;
            this.easyChart3.AxisX.Title = "";
            this.easyChart3.AxisX.ViewMaximum = 1001D;
            this.easyChart3.AxisX.ViewMinimum = 0D;
            this.easyChart3.AxisY.AutoScale = true;
            this.easyChart3.AxisY.InitWithScaleView = false;
            this.easyChart3.AxisY.LabelEnabled = false;
            this.easyChart3.AxisY.LabelFormat = "";
            this.easyChart3.AxisY.Maximum = 3.5D;
            this.easyChart3.AxisY.Minimum = 0D;
            this.easyChart3.AxisY.Orientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart3.AxisY.Position = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            this.easyChart3.AxisY.Title = "";
            this.easyChart3.AxisY.ViewMaximum = 3.5D;
            this.easyChart3.AxisY.ViewMinimum = 0D;
            this.easyChart3.AxisYMax = 3.5D;
            this.easyChart3.AxisYMin = 0D;
            this.easyChart3.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChart3.EasyChartBackColor = System.Drawing.Color.White;
            this.easyChart3.GradientStyle = SeeSharpTools.JY.GUI.EasyChart.EasyChartGradientStyle.None;
            this.easyChart3.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChart3.LegendVisible = true;
            easyChartSeries1.InterpolationStyle = SeeSharpTools.JY.GUI.EasyChartSeries.Interpolation.FastLine;
            easyChartSeries1.MarkerType = SeeSharpTools.JY.GUI.EasyChartSeries.PointStyle.None;
            easyChartSeries1.Width = SeeSharpTools.JY.GUI.EasyChartSeries.LineWidth.Thin;
            this.easyChart3.LineSeries.Add(easyChartSeries1);
            this.easyChart3.Location = new System.Drawing.Point(23, 161);
            this.easyChart3.MajorGridColor = System.Drawing.Color.Black;
            this.easyChart3.MajorGridEnabled = true;
            this.easyChart3.Margin = new System.Windows.Forms.Padding(2);
            this.easyChart3.MinorGridColor = System.Drawing.Color.Black;
            this.easyChart3.MinorGridEnabled = false;
            this.easyChart3.MinorGridType = SeeSharpTools.JY.GUI.EasyChart.GridStyle.Solid;
            this.easyChart3.Name = "easyChart3";
            this.easyChart3.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Navy,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.Black};
            this.easyChart3.SeriesNames = new string[] {
        "Series1",
        "Series2",
        "Series3",
        "Series4",
        "Series5",
        "Series6",
        "Series7",
        "Series8",
        "Series9",
        "Series10",
        "Series11",
        "Series12",
        "Series13",
        "Series14",
        "Series15",
        "Series16",
        "Series17",
        "Series18",
        "Series19",
        "Series20",
        "Series21",
        "Series22",
        "Series23",
        "Series24",
        "Series25",
        "Series26",
        "Series27",
        "Series28",
        "Series29",
        "Series30",
        "Series31",
        "Series32"};
            this.easyChart3.Size = new System.Drawing.Size(872, 254);
            this.easyChart3.TabIndex = 3;
            this.easyChart3.XAxisLogarithmic = false;
            this.easyChart3.XAxisTitle = "";
            this.easyChart3.XCursor.AutoInterval = true;
            this.easyChart3.XCursor.Color = System.Drawing.Color.Red;
            this.easyChart3.XCursor.Interval = 1D;
            this.easyChart3.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartCursor.CursorMode.Zoom;
            this.easyChart3.XCursor.Value = double.NaN;
            this.easyChart3.XTitleOrientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart3.XTitlePosition = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Far;
            this.easyChart3.YAutoEnable = true;
            this.easyChart3.YAxisLogarithmic = false;
            this.easyChart3.YAxisTitle = "";
            this.easyChart3.YCursor.AutoInterval = true;
            this.easyChart3.YCursor.Color = System.Drawing.Color.Red;
            this.easyChart3.YCursor.Interval = 0.001D;
            this.easyChart3.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartCursor.CursorMode.Disabled;
            this.easyChart3.YCursor.Value = double.NaN;
            this.easyChart3.YTitleOrientation = SeeSharpTools.JY.GUI.EasyChart.TitleOrientation.Auto;
            this.easyChart3.YTitlePosition = SeeSharpTools.JY.GUI.EasyChart.TitlePosition.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 560);
            this.Controls.Add(this.easyChart3);
            this.Controls.Add(this.play);
            this.Controls.Add(this.click);
            this.Controls.Add(this.pb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button play;
        private SeeSharpTools.JY.GUI.EasyChart easyChart3;
    }
}

