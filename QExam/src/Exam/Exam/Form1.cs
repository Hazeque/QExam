using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        int var;

        private void InfoMenuStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Нагилева О.М. \nВариант 2", "О программе");
        }

        private void FirstVar_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            ValueX.Visible = true;
            ValueY.Visible = true;
            CheckButton.Visible = true;
            var = 1;
            System.Diagnostics.Process.Start(@"web1.html");
        }

        private void SecondVar_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            ValueX.Visible = true;
            ValueY.Visible = true;
            CheckButton.Visible = true;
            var = 2;
            System.Diagnostics.Process.Start(@"web2.html");
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (var == 1)
            {
                double x = Convert.ToDouble(ValueX.Text);
                double y = Convert.ToDouble(ValueY.Text);
                if ((x == 2) && (y >= -5.5) && (y <= 5.5))
                {
                    StatusStrip.Text = "На границе";
                    MessageBox.Show("Точка находится на границе заштрихованной области");
                }
                else if ((x >= 2) && (x <= 6))
                {
                    if ((Math.Pow((x - 2), 2) + y * y) == 16)
                    {
                        StatusStrip.Text = "На границе";
                        MessageBox.Show("Точка находится на границе заштрихованной области");
                    }
                }
                 if ((x > 2) && (x < 6) && (y > -5.5) && (y < 5.5))
                {
                    StatusStrip.Text = "Принадлежит";
                    MessageBox.Show("Точка принадлежит к заштрихованной области");
                }
                else
                {
                    StatusStrip.Text = "Не принадлежит";
                    MessageBox.Show("Точка не принадлежит к заштрихованной области");
                }
            }
            if (var == 2)
            {
                double x = Convert.ToDouble(ValueX.Text);
                double y = Convert.ToDouble(ValueY.Text);
                if ((x * x + y * y == 1) && (x >= 0) && (x <= 1) && (y >= -1) && (y <= 0))
                {
                    StatusStrip.Text = "На границе";
                    MessageBox.Show("Точка находится на границе заштрихованной области");
                }
                else if ((x >= -1) && (x <= 0) && (y == -x))
                {
                    StatusStrip.Text = "На границе";
                    MessageBox.Show("Точка находится на границе заштрихованной области");
                }
                if ((x * x + y * y < 1) && (x > 0) && (x < 1) && (y > -1) && (y < 0))
                {
                    StatusStrip.Text = "Принадлежит";
                    MessageBox.Show("Точка принадлежит заштрихованной области");
                }
                else if ((x > -1) && (x < 0) && (y > 0) && (y < 1) && (y < -x))
                {
                    StatusStrip.Text = "Принадлежит";
                    MessageBox.Show("Точка принадлежит заштрихованной области");
                }
                else
                        {
                    StatusStrip.Text = "Не принадлежит";
                    MessageBox.Show("Точка не принадлежит к заштрихованной области");
                }
            }
        }

    }
}
