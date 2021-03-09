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
    public partial class Form_Servicios_Servicios_Modificar : Form
    {
        public Form_Servicios_Servicios_Modificar()
        {
            InitializeComponent();

            botonBuscar.MouseEnter += OnMouseEnterbotonBuscar;
            botonBuscar.MouseLeave += OnMouseLeavebotonBuscar;
            botonModificar.MouseEnter += OnMouseEnterbotonModificar;
            botonModificar.MouseLeave += OnMouseLeavebotonModificar;
        }
        #region Animaciones de los botones
        private void OnMouseEnterbotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(99,33);
            botonBuscar.Text = "    Buscar";
        }
        private void OnMouseLeavebotonBuscar(object sender, EventArgs e)
        {
            botonBuscar.Size = new Size(89, 33);
            botonBuscar.Text = "   Buscar";
        }
        private void OnMouseEnterbotonModificar(object sender, EventArgs e)
        {
            botonModificar.Size = new Size(99,33);
            botonModificar.Text = " Actualizar";
        }
        private void OnMouseLeavebotonModificar(object sender, EventArgs e)
        {
            botonModificar.Size = new Size(89,33);
            botonModificar.Text = "Actualizar";
        }
        #endregion
        private void BotonModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modificado");
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encontrado");
        }
    }
}
