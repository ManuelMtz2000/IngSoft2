using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace interfazModernaONG
{
    public partial class Form_Finanzas_Ingresos_Informe : Form
    {
        public Form_Finanzas_Ingresos_Informe()
        {
            InitializeComponent();

            botonInformeIngresos.MouseEnter += OnMouseEnterbotonInformeIngresos;
            botonInformeIngresos.MouseLeave += OnMouseLeavebotonInformeIngresos;
            botonInformeRecaudacion.MouseEnter += OnMouseEnterbotonInformeRecaudacion;
            botonInformeRecaudacion.MouseLeave += OnMouseLeavebotonInformeRecaudacion;
        }

        #region Animaciones de los botones
        private void OnMouseEnterbotonInformeIngresos(object sender, EventArgs e)
        {
            botonInformeIngresos.Size = new Size(150,33);
            botonInformeIngresos.Text = "  Generar Informe";
        }
        private void OnMouseLeavebotonInformeIngresos(object sender, EventArgs e)
        {
            botonInformeIngresos.Size = new Size(140,33);
            botonInformeIngresos.Text = " Generar Informe";
        }
        private void OnMouseEnterbotonInformeRecaudacion(object sender, EventArgs e)
        {
            botonInformeRecaudacion.Size = new Size(150, 33);
            botonInformeRecaudacion.Text = "  Generar Informe";
        }
        private void OnMouseLeavebotonInformeRecaudacion(object sender, EventArgs e)
        {
            botonInformeRecaudacion.Size = new Size(140, 33);
            botonInformeRecaudacion.Text = " Generar Informe";
        }
        #endregion

        public string MonthName(int month)
        {
            CultureInfo ci = new CultureInfo("es-MX");
            ci = new CultureInfo("es-MX");
            DateTimeFormatInfo dtinfo = ci.DateTimeFormat;
            var mes = dtinfo.GetMonthName(month);
            TextInfo textInfo = ci.TextInfo;
            string mayusMes = textInfo.ToTitleCase(mes);
            return mayusMes;
        }

        private void BotonInformeIngresos_Click(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateTimeDesdeIngresos.Value, dateTimeHastaIngresos.Value);
            if (res < 0 || res == 0)
            { 
                Reportes r = new Reportes();
                string ruta = "";
                SaveFileDialog sdialog = new SaveFileDialog();
                sdialog.Filter = "Excel File|*.xlsx";
                sdialog.Title = "Guardar como documento de Excel";
                sdialog.ShowDialog();
                if (sdialog.FileName != "")
                {
                    try
                    {
                        System.IO.FileStream fs =
                            (System.IO.FileStream)sdialog.OpenFile();
                        ruta = fs.Name;
                        fs.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error en el archivo.\nCompruebe que el archivo origen no este en ejecución.");
                    }
                }
                string[] meses = new string[6];
                string[] mesesd = new string[6];
                bool b = false;
                if (dateTimeHastaIngresos.Value.Month - dateTimeDesdeIngresos.Value.Month != 0)
                {
                    int mes = dateTimeDesdeIngresos.Value.Month;
                    int cont = 0;
                    if (dateTimeHastaIngresos.Value.Month - dateTimeDesdeIngresos.Value.Month <= 5)
                    {
                        while (mes <= dateTimeHastaIngresos.Value.Month)
                        {

                            meses[cont] = MonthName(mes);
                            mesesd[cont] = Convert.ToString(mes);
                            mes++;
                            cont++;
                        }
                        b = true;
                    }
                    else
                    {
                        MessageBox.Show("Error en la recopilación.\nUnicamente puede consultar datos en un intervalo de 6 meses.");
                    }
                }
                else
                {
                    meses[0] = MonthName(DateTime.Now.Month);
                    mesesd[0] = Convert.ToString(DateTime.Now.Month);
                }
                if (ruta != "" && b == true)
                {
                    r.IgEg(ruta, dateTimeDesdeIngresos.Value.ToString("yyyy-MM-dd"), dateTimeHastaIngresos.Value.ToString("yyyy-MM-dd"), meses, mesesd);
                }
            }
            else
            {
                MessageBox.Show("Fechas no validas.");
            }
        }

        private void BotonInformeRecaudacion_Click(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateTimeDesdeRecaudacion.Value, dateTimeHastaRecaudacion.Value);
            if (res < 0 || res == 0)
            {
                Reportes r = new Reportes();
                string ruta = "";
                SaveFileDialog sdialog = new SaveFileDialog();
                sdialog.Filter = "Excel File|*.xlsx";
                sdialog.Title = "Guardar como documento de Excel";
                sdialog.ShowDialog();
                if (sdialog.FileName != "")
                {
                    try
                    {
                        System.IO.FileStream fs =
                            (System.IO.FileStream)sdialog.OpenFile();
                        ruta = fs.Name;
                        fs.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error en el archivo.\nCompruebe que el archivo origen no este en ejecución.");
                    }
                }
                if (ruta != "")
                {
                    r.Recaudacion(ruta, dateTimeDesdeRecaudacion.Value.ToString("yyyy-MM-dd"), dateTimeHastaRecaudacion.Value.ToString("yyyy-MM-dd"));
                }
            }
            else
            {
                MessageBox.Show("Fechas no validas.");
            }
        }
    }
}
