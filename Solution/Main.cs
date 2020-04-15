using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solution
{
    public partial class Main : Form
    {
        double delta;
        double[] info;
        double dx, dVx;
        int timeStep;
        bool initiate = true, check;

        public Main()
        {
            InitializeComponent();

            info = new double[2];
        }

        private void Main_Load(object sender, EventArgs e)
        {
            /*
            chartPhase.ChartAreas[0].AxisX.Maximum = 3;
            chartPhase.ChartAreas[0].AxisY.Maximum = 3;
            chartPhase.ChartAreas[0].AxisX.Minimum = 0;
            chartPhase.ChartAreas[0].AxisY.Minimum = 0;

            
            chartPhase.Series[0].Points.AddXY(0, 0);
            chartPhase.Series[0].Points.AddXY(3, 3);
            */
            btnReset_Click(sender, e);
        }

        private void btnAnimate_Click(object sender, EventArgs e)
        {
            if (timerAnimate.Enabled)
            {
                timerAnimate.Enabled = false;
                btnAnimate.Text = "Продолжить";
                btnReset.Enabled = true;
            }
            else
            {
                if (initiate)
                {
                    Initiate();
                    initiate = false;
                }
                if(check)
                {
                    timerAnimate.Enabled = true;
                    btnAnimate.Text = "Остановить";
                    btnReset.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Нельзя задавать нулевые значения одновременно", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    initiate = true;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Initiate();

            initiate = true;
            btnAnimate.Text = "Начать";
        }

        private void Initiate()
        {
            info[0] = Convert.ToDouble(txtXstart.Text);
            info[1] = Convert.ToDouble(txtVstart.Text);
            delta = Convert.ToDouble(txtDelta.Text);
            timeStep = Convert.ToInt32(txtStep.Text);
            timerAnimate.Interval = Convert.ToInt32(txtTimerstep.Text) * 100;
            check = true;

            if (info[0] == 0 & info[1] == 0)
            {
                check = false;
            }

            chartPhase.Series[0].Points.Clear();
            chartPhase.ChartAreas[0].AxisX.Interval = 0.5;
            chartPhase.ChartAreas[0].AxisX.Interval = 0.5;
        }

        private double[] RungeKutt(double time)
        {
            //инициализируем положение и скорость тела
            dx = info[0];
            dVx = info[1];

            //считаем коэфициенты метода
            double k1x = Function(dx, dVx) * time;
            double k2x = Function(dx + dVx * time / 2, dVx + k1x / 2) * time;
            double k3x = Function(dx + dVx * time / 2 + k1x * time / 4, dVx + k2x / 2) * time;
            double k4x = Function(dx + dVx * time + k2x / 2, dVx + k3x) * time;

            //обновляем положение и скорость тела
            info[0] = dx + dVx * time + (k1x + k2x + k3x) * time / 6;
            info[1] = dVx + (k1x + 2 * k2x + 2 * k3x + k4x) / 6;

            return info;
        }

        private void timerAnimate_Tick(object sender, EventArgs e)
        {
            chartPhase.Series[0].Points.AddXY(info[0], info[1]);

            RungeKutt(timeStep);
        }

        private void chartPhase_MouseClick(object sender, MouseEventArgs e)
        {
            var res = chartPhase.HitTest(e.X, e.Y);
            if (res.Series != null)
                MessageBox.Show(res.Series.Points[res.PointIndex].YValues[0].ToString());
        }

        double Function(double dx, double dVx)
        {
            double answer = delta * dVx + Math.Sin(dx);
            return -1 * answer;
        }
    }
}
