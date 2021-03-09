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
    public partial class Form_Finanzas_Egresos_Informe : Form
    {
        public Form_Finanzas_Egresos_Informe()
        {
            InitializeComponent();

            botonInforme.MouseEnter += OnMouseEnterbotonInforme;
            botonInforme.MouseLeave += OnMouseLeavebotonInforme;
        }

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

        #region Animacion del boton
        private void OnMouseEnterbotonInforme(object sender, EventArgs e)
        {
            botonInforme.Size = new Size(150,33);
            botonInforme.Text = "  Generar Informe";
        }
        private void OnMouseLeavebotonInforme(object sender, EventArgs e)
        {
            botonInforme.Size = new Size(140,33);
            botonInforme.Text = " Generar Informe";
        }
        #endregion
        private void BotonInforme_Click(object sender, EventArgs e)
        {
            if(dateTimeDesdeIngresos.Value.Date <= dateTimeHastaIngresos.Value.Date)
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
            }
            else
            {
                MessageBox.Show("Fechas no validas.");
            }
        }
    }
}
