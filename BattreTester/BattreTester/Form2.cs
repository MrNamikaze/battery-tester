using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void ShowingArray(string[] waktu, string[] amp, string[] volt, string[] temp)
        {
            for(int a = 0; a < waktu.Length; a++)
            {
                chart1.Series["Arus"].Points.AddXY(waktu[a], amp[a]);
                chart2.Series["Volt"].Points.AddXY(waktu[a], volt[a]);
                chart3.Series["Temp"].Points.AddXY(waktu[a], temp[a]);
            }
            chart1.SaveImage("C:\\Development\\image1.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            chart2.SaveImage("C:\\Development\\image2.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            chart3.SaveImage("C:\\Development\\image3.png", System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
        }
    }

    
}
