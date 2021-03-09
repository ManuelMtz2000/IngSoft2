using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfazModernaONG
{
    public partial class Form_Organigrama_Directorio_Informe : Form
    {
        public Form_Organigrama_Directorio_Informe()
        {
            InitializeComponent();

            botonInforme.MouseEnter += OnMouseEnterbotonInforme;
            botonInforme.MouseLeave += OnMouseLeavebotonInforme;
        }

        #region Animación del botón
        private void OnMouseEnterbotonInforme(object sender, EventArgs e)
        {
            botonInforme.Size = new Size(150,33);
            botonInforme.Text = "  Generar Informe";
        }
        private void OnMouseLeavebotonInforme(object sender, EventArgs e)
        {
            botonInforme.Size = new Size(140, 33);
            botonInforme.Text = " Generar Informe";
        }
        #endregion

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
            r.Directorio(ruta,dateTimeDesde.Value.ToString("yyyy-MM-dd"),dateTimePicker1.Value.ToString("yyyy-MM-dd"));
        }
    }
}
