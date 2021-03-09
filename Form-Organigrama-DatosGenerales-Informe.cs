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
    public partial class Form_Organigrama_DatosGenerales_Informe : Form
    {
        public Form_Organigrama_DatosGenerales_Informe()
        {
            InitializeComponent();

            botonBuscar.MouseEnter += OnMouseEnterbotonBuscar;
            botonBuscar.MouseLeave += OnMouseLeavebotonBuscar;

            botonInforme.MouseEnter += OnMouseEnterbotonInforme;
            botonInforme.MouseLeave += OnMouseLeavebotonInforme;
        }

        #region Animación de los botones
        private void OnMouseEnterbotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(95, 43);
            botonBuscar.Text = "    Buscar";
        }
        private void OnMouseLeavebotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(85, 33);
            botonBuscar.Text = "   Buscar";
        }
        private void OnMouseEnterbotonInforme(object sender, EventArgs e)
        {
            botonInforme.Size = new Size(150, 43);
            botonInforme.Text = "  Generar Informe";
        }
        private void OnMouseLeavebotonInforme(object sender, EventArgs e)
        {
            botonInforme.Size = new Size(140, 33);
            botonInforme.Text = " Generar Informe";
        }
        #endregion

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Persona registrada");
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

        private void BotonInforme_Click(object sender, EventArgs e)
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
            DateTime fecha = DateTime.Now.AddMonths(-5);
            int mes = fecha.Month;
            string[] meses = new string[6];
            int cont = 0;
            while(cont < 6)
            {
                meses[cont] = MonthName(mes);
                mes++;
                cont++;
            }
            r.PoblacionAtendida(ruta, fecha.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"),textBoxNombre.Text, meses);
        }
    }
}
