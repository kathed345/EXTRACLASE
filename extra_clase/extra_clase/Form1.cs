using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace extra_clase
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grafica_datos.Series.Clear();

            // Crear  serie con los puntos de datos 
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Points.AddXY("Agua", 120);
            series.Points.AddXY("Luz", 85);
            series.Points.AddXY("Gas", 180);

            grafica_datos.Series.Add(series);

            // Actualizacion de grafica
            grafica_datos.Update();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grafica_datos.Series.Clear();

            // Crear  serie con los puntos de datos 
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Points.AddXY("Agua", 420);
            series.Points.AddXY("Luz", 105);
            series.Points.AddXY("Gas", 225);

        
            grafica_datos.Series.Add(series);

            // Actualizar grafica
            grafica_datos.Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grafica_datos.Series.Clear();
            // Crear  serie con los puntos de datos 
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Points.AddXY("Agua", 369);
            series.Points.AddXY("Luz", 90);
            series.Points.AddXY("Gas", 160);

           
            grafica_datos.Series.Add(series);

            grafica_datos.Update();
        }
    }
}
