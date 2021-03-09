using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//FALTA VALIDAR LAS FECHAS

namespace interfazModernaONG
{
    public partial class Form_Beneficiarios_Beneficiarios_Informe : Form
    {
        public Form_Beneficiarios_Beneficiarios_Informe()
        {
            InitializeComponent();

            botonBeneficiarios.MouseEnter += OnMouseEnterbotonBeneficiarios;
            botonBeneficiarios.MouseLeave += OnMouseLeavebotonBeneficiarios;
            botonPoblacion.MouseEnter += OnMouseEnterbotonPoblacion;
            botonPoblacion.MouseLeave += OnMouseLeavebotonPoblacion;
        }

        #region Animacion de botones
        private void OnMouseEnterbotonBeneficiarios(object sender, EventArgs e)
        {
            botonBeneficiarios.Size = new Size(150,33);
            botonBeneficiarios.Text = "  Generar Informe";
        }
        private void OnMouseLeavebotonBeneficiarios(object sender, EventArgs e)
        {
            botonBeneficiarios.Size = new Size(140,33);
            botonBeneficiarios.Text = " Generar Informe";
        }
        private void OnMouseEnterbotonPoblacion(object sender, EventArgs e)
        {
            botonPoblacion.Size = new Size(150,33);
            botonPoblacion.Text = "  Generar Informe";
        }
        private void OnMouseLeavebotonPoblacion(object sender, EventArgs e)
        {
            botonPoblacion.Size = new Size(140,33);
            botonPoblacion.Text = " Generar Informe";
        }
        #endregion

        private void BotonBeneficiarios_Click(object sender, EventArgs e)
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
            r.ListaBeneficiarios(ruta,dateTimeDesdeBeneficiarios.Value.ToString("yyyy-MM-dd"),dateTimeHastaBeneficiarios.Value.ToString("yyyy-MM-dd"));
        }

        private void BotonPoblacion_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            string[] meses = { };
            string ruta = "";
            SaveFileDialog sdialog = new SaveFileDialog();
            sdialog.Filter = "Excel File|*.xlsx";
            sdialog.Title = "Guardar como documento de Excel";
            sdialog.ShowDialog();
            if (sdialog.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)sdialog.OpenFile();
                ruta = fs.Name;
                fs.Close();
            }
            DateTime fecha = DateTime.Now.AddMonths(-6);
            r.PoblacionAtendida(ruta, fecha.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"),"Nombre", meses);
        }
    }
}
