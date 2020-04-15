namespace Solution
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /* <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param> */
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPhase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimerstep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVstart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXstart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnimate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timerAnimate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartPhase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPhase
            // 
            chartArea1.AxisX.LabelStyle.Format = "0.##";
            chartArea1.AxisY.LabelStyle.Format = "0.##";
            chartArea1.Name = "ChartArea1";
            this.chartPhase.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPhase.Legends.Add(legend1);
            this.chartPhase.Location = new System.Drawing.Point(12, 12);
            this.chartPhase.Name = "chartPhase";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Violet;
            series1.Legend = "Legend1";
            series1.LegendText = "Фазовый портрет";
            series1.Name = "Series1";
            this.chartPhase.Series.Add(series1);
            this.chartPhase.Size = new System.Drawing.Size(1124, 438);
            this.chartPhase.TabIndex = 0;
            this.chartPhase.Text = "chart1";
            this.chartPhase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartPhase_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtTimerstep);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStep);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDelta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVstart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtXstart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры задачи";
            // 
            // txtTimerstep
            // 
            this.txtTimerstep.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimerstep.Location = new System.Drawing.Point(303, 29);
            this.txtTimerstep.Name = "txtTimerstep";
            this.txtTimerstep.Size = new System.Drawing.Size(49, 22);
            this.txtTimerstep.TabIndex = 12;
            this.txtTimerstep.Text = "1";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(192, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Шаг таймера";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(137, 57);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(49, 22);
            this.txtStep.TabIndex = 10;
            this.txtStep.Text = "1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(99, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Δt:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDelta
            // 
            this.txtDelta.Location = new System.Drawing.Point(137, 29);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.Size = new System.Drawing.Size(49, 22);
            this.txtDelta.TabIndex = 8;
            this.txtDelta.Text = "0,1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(99, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "δ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVstart
            // 
            this.txtVstart.Location = new System.Drawing.Point(44, 56);
            this.txtVstart.Name = "txtVstart";
            this.txtVstart.Size = new System.Drawing.Size(49, 22);
            this.txtVstart.TabIndex = 6;
            this.txtVstart.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "x\':";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtXstart
            // 
            this.txtXstart.Location = new System.Drawing.Point(44, 28);
            this.txtXstart.Name = "txtXstart";
            this.txtXstart.Size = new System.Drawing.Size(49, 22);
            this.txtXstart.TabIndex = 4;
            this.txtXstart.Text = "2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "x:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnimate
            // 
            this.btnAnimate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAnimate.Location = new System.Drawing.Point(1024, 479);
            this.btnAnimate.Name = "btnAnimate";
            this.btnAnimate.Size = new System.Drawing.Size(112, 29);
            this.btnAnimate.TabIndex = 2;
            this.btnAnimate.Text = "Начать";
            this.btnAnimate.UseVisualStyleBackColor = false;
            this.btnAnimate.Click += new System.EventHandler(this.btnAnimate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.Location = new System.Drawing.Point(1024, 527);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 30);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timerAnimate
            // 
            this.timerAnimate.Tick += new System.EventHandler(this.timerAnimate_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 567);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAnimate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartPhase);
            this.Name = "Main";
            this.Text = "Лабараторная работа №1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPhase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnimate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXstart;
        private System.Windows.Forms.TextBox txtVstart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timerAnimate;
        private System.Windows.Forms.TextBox txtDelta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimerstep;
        private System.Windows.Forms.Label label5;
    }
}

