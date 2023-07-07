
namespace extra_clase
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_primert = new System.Windows.Forms.Button();
            this.grafica_datos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_segundot = new System.Windows.Forms.Button();
            this.btn_tercert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafica_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_primert
            // 
            this.btn_primert.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_primert.Location = new System.Drawing.Point(71, 239);
            this.btn_primert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_primert.Name = "btn_primert";
            this.btn_primert.Size = new System.Drawing.Size(110, 42);
            this.btn_primert.TabIndex = 0;
            this.btn_primert.Text = "Primer trimestre";
            this.btn_primert.UseVisualStyleBackColor = true;
            this.btn_primert.Click += new System.EventHandler(this.button1_Click);
            // 
            // grafica_datos
            // 
            chartArea1.Name = "ChartArea1";
            this.grafica_datos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica_datos.Legends.Add(legend1);
            this.grafica_datos.Location = new System.Drawing.Point(163, 23);
            this.grafica_datos.Margin = new System.Windows.Forms.Padding(2);
            this.grafica_datos.Name = "grafica_datos";
            this.grafica_datos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafica_datos.Series.Add(series1);
            this.grafica_datos.Size = new System.Drawing.Size(200, 195);
            this.grafica_datos.TabIndex = 1;
            this.grafica_datos.Text = "Grafica_barras";
            // 
            // btn_segundot
            // 
            this.btn_segundot.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_segundot.Location = new System.Drawing.Point(220, 239);
            this.btn_segundot.Margin = new System.Windows.Forms.Padding(2);
            this.btn_segundot.Name = "btn_segundot";
            this.btn_segundot.Size = new System.Drawing.Size(110, 42);
            this.btn_segundot.TabIndex = 2;
            this.btn_segundot.Text = "Segundo Trimestre";
            this.btn_segundot.UseVisualStyleBackColor = true;
            this.btn_segundot.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_tercert
            // 
            this.btn_tercert.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tercert.Location = new System.Drawing.Point(352, 239);
            this.btn_tercert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tercert.Name = "btn_tercert";
            this.btn_tercert.Size = new System.Drawing.Size(110, 42);
            this.btn_tercert.TabIndex = 3;
            this.btn_tercert.Text = "Tercer Trimestre";
            this.btn_tercert.UseVisualStyleBackColor = true;
            this.btn_tercert.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 345);
            this.Controls.Add(this.btn_tercert);
            this.Controls.Add(this.btn_segundot);
            this.Controls.Add(this.grafica_datos);
            this.Controls.Add(this.btn_primert);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafica_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_primert;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica_datos;
        private System.Windows.Forms.Button btn_segundot;
        private System.Windows.Forms.Button btn_tercert;
    }
}

