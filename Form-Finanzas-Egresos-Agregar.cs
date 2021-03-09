using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Vml.Office;
using MySql.Data.MySqlClient;

namespace interfazModernaONG
{
    public partial class Form_Finanzas_Egresos_Agregar : Form
    {
        int cont = 1000000000;
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = sai; uid=root;");
        public Form_Finanzas_Egresos_Agregar()
        {
            InitializeComponent();
            cont = Contador();
            botonAgregar.MouseEnter += OnMouseEnterbotonAgregar;
            botonAgregar.MouseLeave += OnMouseLeavebotonAgregar;
        }

        private int Contador()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT MAX(Folio_E) FROM egresos", conexion);
                conexion.Open();
                var res = command.ExecuteScalar();
                if (res != null)
                {
                    string aux = Convert.ToString(res);
                    command.ExecuteNonQuery();
                    conexion.Close();
                    return Convert.ToInt32(aux);
                }
                conexion.Close();
            }
            catch
            {

            }
            return 1000000000;
        }

        #region Animacion del boton
        private void OnMouseEnterbotonAgregar(object sender, EventArgs e)
        {
            botonAgregar.Size = new Size(101,33);
            botonAgregar.Text = "   Agregar";
        }
        private void OnMouseLeavebotonAgregar(object sender, EventArgs e)
        {
            botonAgregar.Size = new Size(91,33);
            botonAgregar.Text = "  Agregar";
        }
        #endregion
        private bool ValidacionCampos()
        {
            bool v = false, v1 = false, v2 = false, v3 = false;
            decimal number;
            if (textBoxCantidad.TextLength > 0)
            {
                if (decimal.TryParse(textBoxCantidad.Text, out number))
                {
                    if (Convert.ToDouble(textBoxCantidad.Text) > 0)
                    {
                        v1 = true;
                    }
                }
            }
            if (!string.IsNullOrEmpty(comboBoxTipo.Text))
            {
                v2 = true;
            }
            if(dateTimeEgreso.Value.Date <= DateTime.Now.Date)
            {
                v3 = true;
            }
            if (v1 == true && v2 == true && v3 == true)
            {
                v = true;
            }
            return v;
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            if (ValidacionCampos())
            {
                cont++;
                try
                {
                    MySqlCommand insert = new MySqlCommand("INSERT INTO egresos(Folio_E,Fecha_E,Tipo_E,Cantidad_Intervenida_E,Observaciones_E) VALUES(@folio,@fecha,@tipo,@cantidad,@observaciones)", conexion);
                    conexion.Open();
                    insert.Parameters.AddWithValue("@folio", Convert.ToString(cont));
                    insert.Parameters.AddWithValue("@fecha", dateTimeEgreso.Value);
                    insert.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedItem.ToString());
                    insert.Parameters.AddWithValue("@cantidad", Convert.ToDouble(textBoxCantidad.Text));
                    insert.Parameters.AddWithValue("@observaciones", textBoxObservaciones.Text);
                    insert.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Operación realizada.");
                }
                catch
                {
                    MessageBox.Show("Error de conexion");
                }
            }
            else
            {
                MessageBox.Show("Error de formato.\nVerifique que esten llenos correctamente los campos necesarios.");
            }
        }
    }
}
