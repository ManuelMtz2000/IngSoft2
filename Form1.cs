using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace interfazModernaONG
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            disenioInicial();

            //animaciones de transición de los botones de los submenús Organigrama y Finanzas
            botonFinanzasIngresos.MouseEnter += OnMouseEnterbotonFinanzasIngresos;
            botonFinanzasIngresos.MouseLeave += OnMouseLeavebotonFinanzasIngresos;

            botonFinanzasEgresos.MouseEnter += OnMouseEnterbotonFinanzasEgresos;
            botonFinanzasEgresos.MouseLeave += OnMouseLeavebotonFinanzasEgresos;

            botonOrganigramaDatosGenerales.MouseEnter += OnMouseEnterbotonOrganigramaDatosGenerales;
            botonOrganigramaDatosGenerales.MouseLeave += OnMouseLeavebotonOrganigramaDatosGenerales;

            botonOrgranigramaPersonal.MouseEnter += OnMouseEnterbotonOrgranigramaPersonal;
            botonOrgranigramaPersonal.MouseLeave += OnMouseLeavebotonOrgranigramaPersonal;

            botonOrganigramaDirectorio.MouseEnter += OnMouseEnterbotonOrganigramaDirectorio;
            botonOrganigramaDirectorio.MouseLeave += OnMouseLeavebotonOrganigramaDirectorio;
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
        }

        //Función para cargar la vista inicial del programa (que páneles aparecerán al arrancar la app)
        private void disenioInicial()
        {
            botonOrganigrama.TextColor = Color.FromArgb(12, 65, 131);
            botonOrganigrama.ButtonColor = Color.FromArgb(255, 255, 255);

            //Se ocultan los submenús
            panelSuperiorFinanzas.Visible = false;
            panelSuperiorServicios.Visible = false;
            panelSuperiorBeneficiarios.Visible = false;

            //Se ocultan las opciones de los submenús
            panelSubMenuPersonal.Visible = false;
            panelSubmenuDirectorio.Visible = false;

            panelSubMenuBeneficiarios.Visible = false;

            panelSubMenuServicios.Visible = false;

            panelSubMenuIngresos.Visible = false;
            panelSubMenuEgresos.Visible = false;

            //Se cambia el color de los botones que estarán activos desde el principio
            botonDatosGeneralesVer.TextColor = Color.FromArgb(12, 65, 131);
            botonDatosGeneralesVer.ButtonColor = Color.FromArgb(255, 255, 255);
            botonPersonalVer.TextColor = Color.FromArgb(12, 65, 131);
            botonPersonalVer.ButtonColor = Color.FromArgb(255, 255, 255);
            botonDirectorioVer.TextColor = Color.FromArgb(12, 65, 131);
            botonDirectorioVer.ButtonColor = Color.FromArgb(255, 255, 255);
            botonBeneficiariosVer.TextColor = Color.FromArgb(12, 65, 131);
            botonBeneficiariosVer.ButtonColor = Color.FromArgb(255, 255, 255);
            botonServiciosVer.TextColor = Color.FromArgb(12, 65, 131);
            botonServiciosVer.ButtonColor = Color.FromArgb(255, 255, 255);
            botonIngresosVer.TextColor = Color.FromArgb(12, 65, 131);
            botonIngresosVer.ButtonColor = Color.FromArgb(255, 255, 255);
            botonEgresosVer.TextColor = Color.FromArgb(12, 65, 131);
            botonEgresosVer.ButtonColor = Color.FromArgb(255, 255, 255);

            //Abrir el form de ver información general
            abrirPanelEventos(new Form_Organigrama_DatosGenerales_Ver());
        }

        // Función para ocultar todos los páneles de botones superiores (los submenús)
        private void ocultarSubMenus()
        {
            if(panelSuperiorFinanzas.Visible == true)
            {
                panelSuperiorFinanzas.Visible = false;
            }
            if (panelSuperiorServicios.Visible == true)
            {
                panelSuperiorServicios.Visible = false;
            }
            if (panelSuperiorBeneficiarios.Visible == true)
            {
                panelSuperiorBeneficiarios.Visible = false;
            }
            if (panelSuperiorOrganigrama.Visible == true)
            {
                panelSuperiorOrganigrama.Visible = false;
            }
        }

        //función que oculta todas las opciones de los submenús (los botones del pánel gris)
        private void ocultarOpcionesSubmenus()
        {
            if(panelSubMenuDatosGenerales.Visible == true)
            {
                panelSubMenuDatosGenerales.Visible = false;
            }
            if(panelSubMenuPersonal.Visible == true)
            {
                panelSubMenuPersonal.Visible = false;
            }
            if(panelSubmenuDirectorio.Visible == true)
            {
                panelSubmenuDirectorio.Visible = false;
            }
            if(panelSubMenuBeneficiarios.Visible == true)
            {
                panelSubMenuBeneficiarios.Visible = false;
            }
            if(panelSubMenuServicios.Visible == true)
            {
                panelSubMenuServicios.Visible = false;
            }
            if(panelSubMenuIngresos.Visible == true)
            {
                panelSubMenuIngresos.Visible = false;
            }
            if(panelSubMenuEgresos.Visible == true)
            {
                panelSubMenuEgresos.Visible = false;
            }
        }

        // Función que muestra un submenú
        private void mostrarSubmenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                ocultarSubMenus();
                subMenu.Visible = false;
            }
        }

        // Función que devuelve a su color original (texto blanco y botón naranja) a los botones
        // del menú lateral izquierdo
        private void desactivarBotonesPrincipales()
        {
            botonOrganigrama.TextColor = Color.FromArgb(255, 255, 255);
            botonOrganigrama.ButtonColor = Color.FromArgb(254, 128, 0);

            botonBeneficiarios.TextColor = Color.FromArgb(255, 255, 255);
            botonBeneficiarios.ButtonColor = Color.FromArgb(254, 128, 0);

            botonServicios.TextColor = Color.FromArgb(255, 255, 255);
            botonServicios.ButtonColor = Color.FromArgb(254, 128, 0);

            botonFinanzas.TextColor = Color.FromArgb(255, 255, 255);
            botonFinanzas.ButtonColor = Color.FromArgb(254, 128, 0);
        }

        //Función que abre en la parte central la información requerida dependiendo del botón seleccionado
        private Form activeForm = null;
        private void abrirPanelEventos(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEventos.Controls.Add(childForm);
            panelEventos.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

#region Botones del menú principal (lateral izquierdo)
        private void BotonOrganigrama_Click(object sender, EventArgs e)
        {
            if(botonOrganigrama.ButtonColor != Color.FromArgb(255, 255, 255))
            {
                desactivarBotonesPrincipales();

                botonOrganigrama.TextColor = Color.FromArgb(12, 65, 131);
                botonOrganigrama.ButtonColor = Color.FromArgb(255, 255, 255);

                mostrarSubmenus(panelSuperiorOrganigrama);

                //Mostrar el menú de opciones dependiendo de cual fue el último submenú seleccionado
                Point pos1 = new Point(-9,12);
                Point pos2 = new Point(-9, 52);
                Point pos3 = new Point(-9, 92);
                if(botonOrganigramaDatosGenerales.Location == pos1)
                {
                    ocultarOpcionesSubmenus();
                    panelSubMenuDatosGenerales.Visible = true;

                    // Abrir el panel del menú principal dependiendo de la opción que sa haya
                    // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
                    if (botonDatosGeneralesVer.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_DatosGenerales_Ver());
                    else if (botonDatosGeneralesModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_DatosGenerales_Modificar());
                    else if (botonDatosGeneralesInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_DatosGenerales_Informe());
                }
                else if(botonOrgranigramaPersonal.Location == pos2)
                {
                    ocultarOpcionesSubmenus();
                    panelSubMenuPersonal.Visible = true;

                    // Abrir el panel del menú principal dependiendo de la opción que sa haya
                    // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
                    if (botonPersonalVer.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_Personal_Ver());
                    else if (botonPersonalAlta.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_Personal_Alta());
                    else if (botonPersonalBaja.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_Personal_Baja());
                    else if (botonPersonalModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_Personal_Modificar());
                    else if (botonPersonalInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_Personal_Informe());
                }
                else if(botonOrganigramaDirectorio.Location == pos3)
                {
                    ocultarOpcionesSubmenus();
                    panelSubmenuDirectorio.Visible = true;

                    // Abrir el panel del menú principal dependiendo de la opción que sa haya
                    // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
                    if (botonDirectorioVer.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_Directorio_Ver());
                    else if (botonDirectorioAlta.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_Directorio_Alta());
                    else if (botonDirectorioBaja.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_Directorio_Baja());
                    else if (botonDirectorioModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_Directorio_Modificar());
                    else if (botonDirectorioInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Organigrama_Directorio_Informe());
                }
            }
        }

        private void BotonBeneficiarios_Click(object sender, EventArgs e)
        {
            if(botonBeneficiarios.ButtonColor != Color.FromArgb(255, 255, 255))
            {
                desactivarBotonesPrincipales();

                botonBeneficiarios.TextColor = Color.FromArgb(12, 65, 131);
                botonBeneficiarios.ButtonColor = Color.FromArgb(255, 255, 255);

                mostrarSubmenus(panelSuperiorBeneficiarios);

                ocultarOpcionesSubmenus();
                panelSubMenuBeneficiarios.Visible = true;

                // Abrir el panel del menú principal dependiendo de la opción que sa haya
                // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
                if (botonBeneficiariosVer.ButtonColor == Color.FromArgb(255, 255, 255))
                    abrirPanelEventos(new Form_Beneficiarios_Beneficiarios_Ver());
                else if (botonBeneficiariosAlta.ButtonColor == Color.FromArgb(255, 255, 255))
                    abrirPanelEventos(new Form_Beneficiarios_Beneficiarios_Alta());
                else if (botonBeneficiariosBaja.ButtonColor == Color.FromArgb(255, 255, 255))
                    abrirPanelEventos(new Form_Beneficiarios_Beneficiarios_Baja());
                else if (botonBeneficiariosModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                    abrirPanelEventos(new Form_Beneficiarios_Beneficiarios_Modificar());
                else if (botonBeneficiariosInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                    abrirPanelEventos(new Form_Beneficiarios_Beneficiarios_Informe());
            }
        }

        private void BotonServicios_Click(object sender, EventArgs e)
        {
            if (botonServicios.ButtonColor != Color.FromArgb(255, 255, 255))
            {
                desactivarBotonesPrincipales();

                botonServicios.TextColor = Color.FromArgb(12, 65, 131);
                botonServicios.ButtonColor = Color.FromArgb(255, 255, 255);

                mostrarSubmenus(panelSuperiorServicios);

                ocultarOpcionesSubmenus();
                panelSubMenuServicios.Visible = true;

                // Abrir el panel del menú principal dependiendo de la opción que sa haya
                // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
                if (botonServiciosVer.ButtonColor == Color.FromArgb(255, 255, 255))
                    abrirPanelEventos(new Form_Servicios_Servicios_Ver());
                else if (botonServiciosAgregar.ButtonColor == Color.FromArgb(255, 255, 255))
                    abrirPanelEventos(new Form_Servicios_Servicios_Agregar());
                else if (botonServiciosEliminar.ButtonColor == Color.FromArgb(255, 255, 255))
                    abrirPanelEventos(new Form_Servicios_Servicios_Eliminar());
                else if (botonServiciosModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                    abrirPanelEventos(new Form_Servicios_Servicios_Modificar());
                else if (botonServiciosInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                    abrirPanelEventos(new Form_Servicios_Servicios_Informe());
            }
        }

        private void BotonFinanzas_Click(object sender, EventArgs e)
        {
            if (botonFinanzas.ButtonColor != Color.FromArgb(255, 255, 255))
            {
                desactivarBotonesPrincipales();

                botonFinanzas.TextColor = Color.FromArgb(12, 65, 131);
                botonFinanzas.ButtonColor = Color.FromArgb(255, 255, 255);

                mostrarSubmenus(panelSuperiorFinanzas);

                //Mostrar el menú de opciones dependiendo de cual fue el último submenú seleccionado
                Point pos = new Point(-9,31);
                Point pos2 = new Point(-9, 70);
                if(botonFinanzasIngresos.Location == pos)
                {
                    ocultarOpcionesSubmenus();
                    panelSubMenuIngresos.Visible = true;

                    // Abrir el panel del menú principal dependiendo de la opción que sa haya
                    // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
                    if (botonIngresosVer.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Finanzas_Ingresos_Ver());
                    else if (botonIngresosAgregar.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Finanzas_Ingresos_Agregar());
                    else if (botonIngresosEliminar.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Finanzas_Ingresos_Eliminar());
                    else if (botonIngresosModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Finanzas_Ingresos_Modificar());
                    else if (botonIngresosInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Finanzas_Ingresos_Informe());
                }
                else if(botonFinanzasEgresos.Location == pos2)
                {
                    ocultarOpcionesSubmenus();
                    panelSubMenuEgresos.Visible = true;

                    // Abrir el panel del menú principal dependiendo de la opción que sa haya
                    // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
                    if (botonEgresosVer.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Finanzas_Egresos_Ver());
                    else if (botonEgresosAgregar.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Finanzas_Egresos_Agregar());
                    else if (botonEgresosEliminar.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Finanzas_Egresos_Eliminar());
                    else if (botonEgresosModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Finanzas_Egresos_Modificar());
                    else if (botonEgresosInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                        abrirPanelEventos(new Form_Finanzas_Egresos_Informe());
                }
            }
        }

        #endregion

        #region Botones del submenú de Organigrama
        private void BotonOrganigramaDirectorio_Click(object sender, EventArgs e)
        {
            // Mostrar boton seleccionado
            botonOrganigramaDirectorio.Location = new Point(-9,92);
            botonOrganigramaDirectorio.Text = "    Directorio";

            // Ocultar otros botones del panel
            botonOrganigramaDatosGenerales.Location = new Point(-110, 12);
            botonOrganigramaDatosGenerales.Text = "  Datos Generales       ▶";
            botonOrgranigramaPersonal.Location = new Point(-110, 52);
            botonOrgranigramaPersonal.Text = "    Personal               ▶";

            ocultarOpcionesSubmenus();
            panelSubmenuDirectorio.Visible = true;

            // Abrir el panel del menú principal dependiendo de la opción que sa haya
            // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
            if (botonDirectorioVer.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_Directorio_Ver());
            else if (botonDirectorioAlta.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_Directorio_Alta());
            else if (botonDirectorioBaja.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_Directorio_Baja());
            else if (botonDirectorioModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_Directorio_Modificar());
            else if (botonDirectorioInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_Directorio_Informe());
        }
        private void OnMouseEnterbotonOrganigramaDirectorio(object sender, EventArgs e)
        {
            Point posicion = new Point(-110, 92);
            if (botonOrganigramaDirectorio.Location == posicion)
            {
                botonOrganigramaDirectorio.Location = new Point(-9, 92);
            }
        }
        private void OnMouseLeavebotonOrganigramaDirectorio(object sender, EventArgs e)
        {
            Point posicion = new Point(-9, 92);
            if (botonOrganigramaDirectorio.Location == posicion
                && botonOrganigramaDirectorio.Text == "    Directorio                ▶")
            {
                botonOrganigramaDirectorio.Location = new Point(-110, 92);
            }
        }
        private void BotonOrgranigramaPersonal_Click(object sender, EventArgs e)
        {
            // Mostrar boton seleccionado
            botonOrgranigramaPersonal.Location = new Point(-9, 52);
            botonOrgranigramaPersonal.Text = "    Personal";

            // Ocultar otros botones del panel
            botonOrganigramaDatosGenerales.Location = new Point(-110, 12);
            botonOrganigramaDatosGenerales.Text = "  Datos Generales       ▶";
            botonOrganigramaDirectorio.Location = new Point(-110, 92);
            botonOrganigramaDirectorio.Text = "    Directorio                ▶";

            ocultarOpcionesSubmenus();
            panelSubMenuPersonal.Visible = true;

            // Abrir el panel del menú principal dependiendo de la opción que sa haya
            // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
            if (botonPersonalVer.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_Personal_Ver());
            else if (botonPersonalAlta.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_Personal_Alta());
            else if (botonPersonalBaja.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_Personal_Baja());
            else if (botonPersonalModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_Personal_Modificar());
            else if (botonPersonalInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_Personal_Informe());
        }

        private void OnMouseEnterbotonOrgranigramaPersonal(object sender, EventArgs e)
        {
            Point posicion = new Point(-110, 52);
            if (botonOrgranigramaPersonal.Location == posicion)
            {
                botonOrgranigramaPersonal.Location = new Point(-9, 52);
            }
        }

        private void OnMouseLeavebotonOrgranigramaPersonal(object sender, EventArgs e)
        {
            Point posicion = new Point(-9, 52);
            if (botonOrgranigramaPersonal.Location == posicion
                && botonOrgranigramaPersonal.Text == "    Personal               ▶")
            {
                botonOrgranigramaPersonal.Location = new Point(-110, 52);
            }
        }
        private void BotonOrganigramaDatosGenerales_Click(object sender, EventArgs e)
        {
            // Mostrar boton seleccionado
            botonOrganigramaDatosGenerales.Location = new Point(-9, 12);
            botonOrganigramaDatosGenerales.Text = "    Datos Generales";

            //Ocultar los otros botones del panel
            botonOrgranigramaPersonal.Location = new Point(-110, 52);
            botonOrgranigramaPersonal.Text = "    Personal               ▶";
            botonOrganigramaDirectorio.Location = new Point(-110, 92);
            botonOrganigramaDirectorio.Text = "    Directorio                ▶";

            ocultarOpcionesSubmenus();
            panelSubMenuDatosGenerales.Visible = true;

            // Abrir el panel del menú principal dependiendo de la opción que sa haya
            // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
            if (botonDatosGeneralesVer.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_DatosGenerales_Ver());
            else if (botonDatosGeneralesModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_DatosGenerales_Modificar());
            else if (botonDatosGeneralesInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Organigrama_DatosGenerales_Informe());
        }

        private void OnMouseEnterbotonOrganigramaDatosGenerales(object sender, EventArgs e)
        {
            Point posicion = new Point(-110, 12);
            if (botonOrganigramaDatosGenerales.Location == posicion)
            {
                botonOrganigramaDatosGenerales.Location = new Point(-9, 12);
            }
        }

        private void OnMouseLeavebotonOrganigramaDatosGenerales(object sender, EventArgs e)
        {
            Point posicion = new Point(-9, 12);
            if (botonOrganigramaDatosGenerales.Location == posicion
                && botonOrganigramaDatosGenerales.Text == "  Datos Generales       ▶")
            {
                botonOrganigramaDatosGenerales.Location = new Point(-110, 12);
            }
        }

        #endregion

        #region Botones de la opción Datos generales del submenú Organigrama
        private void BotonDatosGeneralesVer_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonDatosGeneralesVer.TextColor = Color.FromArgb(12, 65, 131);
            botonDatosGeneralesVer.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonDatosGeneralesModificar.TextColor = Color.DimGray;
            botonDatosGeneralesModificar.ButtonColor = Color.Transparent;
            botonDatosGeneralesInforme.TextColor = Color.DimGray;
            botonDatosGeneralesInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_DatosGenerales_Ver());
        }
        private void BotonDatosGeneralesModificar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonDatosGeneralesModificar.TextColor = Color.FromArgb(12, 65, 131);
            botonDatosGeneralesModificar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonDatosGeneralesVer.TextColor = Color.DimGray;
            botonDatosGeneralesVer.ButtonColor = Color.Transparent;
            botonDatosGeneralesInforme.TextColor = Color.DimGray;
            botonDatosGeneralesInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_DatosGenerales_Modificar());
        }
        private void BotonDatosGeneralesInforme_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonDatosGeneralesInforme.TextColor = Color.FromArgb(12, 65, 131);
            botonDatosGeneralesInforme.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonDatosGeneralesVer.TextColor = Color.DimGray;
            botonDatosGeneralesVer.ButtonColor = Color.Transparent;
            botonDatosGeneralesModificar.TextColor = Color.DimGray;
            botonDatosGeneralesModificar.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_DatosGenerales_Informe());
        }
        #endregion

        #region Botones de la opción Personal del submenú Organigrama
        private void BotonPersonalVer_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonPersonalVer.TextColor = Color.FromArgb(12, 65, 131);
            botonPersonalVer.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonPersonalAlta.TextColor = Color.DimGray;
            botonPersonalAlta.ButtonColor = Color.Transparent;
            botonPersonalBaja.TextColor = Color.DimGray;
            botonPersonalBaja.ButtonColor = Color.Transparent;
            botonPersonalModificar.TextColor = Color.DimGray;
            botonPersonalModificar.ButtonColor = Color.Transparent;
            botonPersonalInforme.TextColor = Color.DimGray;
            botonPersonalInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_Personal_Ver());
        }
        private void BotonPersonalAlta_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonPersonalAlta.TextColor = Color.FromArgb(12, 65, 131);
            botonPersonalAlta.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonPersonalVer.TextColor = Color.DimGray;
            botonPersonalVer.ButtonColor = Color.Transparent;
            botonPersonalBaja.TextColor = Color.DimGray;
            botonPersonalBaja.ButtonColor = Color.Transparent;
            botonPersonalModificar.TextColor = Color.DimGray;
            botonPersonalModificar.ButtonColor = Color.Transparent;
            botonPersonalInforme.TextColor = Color.DimGray;
            botonPersonalInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_Personal_Alta());
        }
        private void BotonPersonalBaja_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonPersonalBaja.TextColor = Color.FromArgb(12, 65, 131);
            botonPersonalBaja.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonPersonalVer.TextColor = Color.DimGray;
            botonPersonalVer.ButtonColor = Color.Transparent;
            botonPersonalAlta.TextColor = Color.DimGray;
            botonPersonalAlta.ButtonColor = Color.Transparent;
            botonPersonalModificar.TextColor = Color.DimGray;
            botonPersonalModificar.ButtonColor = Color.Transparent;
            botonPersonalInforme.TextColor = Color.DimGray;
            botonPersonalInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_Personal_Baja());
        }
        private void BotonPersonalModificar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonPersonalModificar.TextColor = Color.FromArgb(12, 65, 131);
            botonPersonalModificar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonPersonalVer.TextColor = Color.DimGray;
            botonPersonalVer.ButtonColor = Color.Transparent;
            botonPersonalAlta.TextColor = Color.DimGray;
            botonPersonalAlta.ButtonColor = Color.Transparent;
            botonPersonalBaja.TextColor = Color.DimGray;
            botonPersonalBaja.ButtonColor = Color.Transparent;
            botonPersonalInforme.TextColor = Color.DimGray;
            botonPersonalInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_Personal_Modificar());
        }
        private void BotonPersonalInforme_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonPersonalInforme.TextColor = Color.FromArgb(12, 65, 131);
            botonPersonalInforme.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonPersonalVer.TextColor = Color.DimGray;
            botonPersonalVer.ButtonColor = Color.Transparent;
            botonPersonalAlta.TextColor = Color.DimGray;
            botonPersonalAlta.ButtonColor = Color.Transparent;
            botonPersonalBaja.TextColor = Color.DimGray;
            botonPersonalBaja.ButtonColor = Color.Transparent;
            botonPersonalModificar.TextColor = Color.DimGray;
            botonPersonalModificar.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_Personal_Informe());
        }
        #endregion

        #region Botones de la opción Directorio del submenú Organigrama
        private void BotonDirectorioVer_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonDirectorioVer.TextColor = Color.FromArgb(12, 65, 131);
            botonDirectorioVer.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonDirectorioAlta.TextColor = Color.DimGray;
            botonDirectorioAlta.ButtonColor = Color.Transparent;
            botonDirectorioBaja.TextColor = Color.DimGray;
            botonDirectorioBaja.ButtonColor = Color.Transparent;
            botonDirectorioModificar.TextColor = Color.DimGray;
            botonDirectorioModificar.ButtonColor = Color.Transparent;
            botonDirectorioInforme.TextColor = Color.DimGray;
            botonDirectorioInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_Directorio_Ver());
        }
        private void BotonDirectorioAlta_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonDirectorioAlta.TextColor = Color.FromArgb(12, 65, 131);
            botonDirectorioAlta.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonDirectorioVer.TextColor = Color.DimGray;
            botonDirectorioVer.ButtonColor = Color.Transparent;
            botonDirectorioBaja.TextColor = Color.DimGray;
            botonDirectorioBaja.ButtonColor = Color.Transparent;
            botonDirectorioModificar.TextColor = Color.DimGray;
            botonDirectorioModificar.ButtonColor = Color.Transparent;
            botonDirectorioInforme.TextColor = Color.DimGray;
            botonDirectorioInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_Directorio_Alta());
        }
        private void BotonDirectorioBaja_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonDirectorioBaja.TextColor = Color.FromArgb(12, 65, 131);
            botonDirectorioBaja.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonDirectorioVer.TextColor = Color.DimGray;
            botonDirectorioVer.ButtonColor = Color.Transparent;
            botonDirectorioAlta.TextColor = Color.DimGray;
            botonDirectorioAlta.ButtonColor = Color.Transparent;
            botonDirectorioModificar.TextColor = Color.DimGray;
            botonDirectorioModificar.ButtonColor = Color.Transparent;
            botonDirectorioInforme.TextColor = Color.DimGray;
            botonDirectorioInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_Directorio_Baja());
        }
        private void BotonDirectorioModificar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonDirectorioModificar.TextColor = Color.FromArgb(12, 65, 131);
            botonDirectorioModificar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonDirectorioVer.TextColor = Color.DimGray;
            botonDirectorioVer.ButtonColor = Color.Transparent;
            botonDirectorioAlta.TextColor = Color.DimGray;
            botonDirectorioAlta.ButtonColor = Color.Transparent;
            botonDirectorioBaja.TextColor = Color.DimGray;
            botonDirectorioBaja.ButtonColor = Color.Transparent;
            botonDirectorioInforme.TextColor = Color.DimGray;
            botonDirectorioInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_Directorio_Modificar());
        }
        private void BotonDirectorioInforme_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonDirectorioInforme.TextColor = Color.FromArgb(12, 65, 131);
            botonDirectorioInforme.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonDirectorioVer.TextColor = Color.DimGray;
            botonDirectorioVer.ButtonColor = Color.Transparent;
            botonDirectorioAlta.TextColor = Color.DimGray;
            botonDirectorioAlta.ButtonColor = Color.Transparent;
            botonDirectorioBaja.TextColor = Color.DimGray;
            botonDirectorioBaja.ButtonColor = Color.Transparent;
            botonDirectorioModificar.TextColor = Color.DimGray;
            botonDirectorioModificar.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Organigrama_Directorio_Informe());
        }
        #endregion

        #region Boton del submenú de Beneficiarios
        private void BotonBeneficiariosBeneficiarios_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Botones de la opción Beneficiarios del submenú Beneficiarios
        private void BotonBeneficiariosVer_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonBeneficiariosVer.TextColor = Color.FromArgb(12, 65, 131);
            botonBeneficiariosVer.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonBeneficiariosAlta.TextColor = Color.DimGray;
            botonBeneficiariosAlta.ButtonColor = Color.Transparent;
            botonBeneficiariosBaja.TextColor = Color.DimGray;
            botonBeneficiariosBaja.ButtonColor = Color.Transparent;
            botonBeneficiariosModificar.TextColor = Color.DimGray;
            botonBeneficiariosModificar.ButtonColor = Color.Transparent;
            botonBeneficiariosInforme.TextColor = Color.DimGray;
            botonBeneficiariosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Beneficiarios_Beneficiarios_Ver());
        }
        private void BotonBeneficiariosAlta_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonBeneficiariosAlta.TextColor = Color.FromArgb(12, 65, 131);
            botonBeneficiariosAlta.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonBeneficiariosVer.TextColor = Color.DimGray;
            botonBeneficiariosVer.ButtonColor = Color.Transparent;
            botonBeneficiariosBaja.TextColor = Color.DimGray;
            botonBeneficiariosBaja.ButtonColor = Color.Transparent;
            botonBeneficiariosModificar.TextColor = Color.DimGray;
            botonBeneficiariosModificar.ButtonColor = Color.Transparent;
            botonBeneficiariosInforme.TextColor = Color.DimGray;
            botonBeneficiariosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Beneficiarios_Beneficiarios_Alta());
        }
        private void BotonBeneficiariosBaja_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonBeneficiariosBaja.TextColor = Color.FromArgb(12, 65, 131);
            botonBeneficiariosBaja.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonBeneficiariosVer.TextColor = Color.DimGray;
            botonBeneficiariosVer.ButtonColor = Color.Transparent;
            botonBeneficiariosAlta.TextColor = Color.DimGray;
            botonBeneficiariosAlta.ButtonColor = Color.Transparent;
            botonBeneficiariosModificar.TextColor = Color.DimGray;
            botonBeneficiariosModificar.ButtonColor = Color.Transparent;
            botonBeneficiariosInforme.TextColor = Color.DimGray;
            botonBeneficiariosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Beneficiarios_Beneficiarios_Baja());
        }
        private void BotonBeneficiariosModificar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonBeneficiariosModificar.TextColor = Color.FromArgb(12, 65, 131);
            botonBeneficiariosModificar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonBeneficiariosVer.TextColor = Color.DimGray;
            botonBeneficiariosVer.ButtonColor = Color.Transparent;
            botonBeneficiariosAlta.TextColor = Color.DimGray;
            botonBeneficiariosAlta.ButtonColor = Color.Transparent;
            botonBeneficiariosBaja.TextColor = Color.DimGray;
            botonBeneficiariosBaja.ButtonColor = Color.Transparent;
            botonBeneficiariosInforme.TextColor = Color.DimGray;
            botonBeneficiariosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Beneficiarios_Beneficiarios_Modificar());
        }
        private void BotonBeneficiariosInforme_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonBeneficiariosInforme.TextColor = Color.FromArgb(12, 65, 131);
            botonBeneficiariosInforme.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonBeneficiariosVer.TextColor = Color.DimGray;
            botonBeneficiariosVer.ButtonColor = Color.Transparent;
            botonBeneficiariosAlta.TextColor = Color.DimGray;
            botonBeneficiariosAlta.ButtonColor = Color.Transparent;
            botonBeneficiariosBaja.TextColor = Color.DimGray;
            botonBeneficiariosBaja.ButtonColor = Color.Transparent;
            botonBeneficiariosModificar.TextColor = Color.DimGray;
            botonBeneficiariosModificar.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Beneficiarios_Beneficiarios_Informe());
        }
        #endregion

        #region Boton del submenú de Servicios
        private void BotonServiciosServicios_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Botones de la opción Servicios del submenú Servicios
        private void BotonServiciosVer_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonServiciosVer.TextColor = Color.FromArgb(12, 65, 131);
            botonServiciosVer.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonServiciosAgregar.TextColor = Color.DimGray;
            botonServiciosAgregar.ButtonColor = Color.Transparent;
            botonServiciosEliminar.TextColor = Color.DimGray;
            botonServiciosEliminar.ButtonColor = Color.Transparent;
            botonServiciosModificar.TextColor = Color.DimGray;
            botonServiciosModificar.ButtonColor = Color.Transparent;
            botonServiciosInforme.TextColor = Color.DimGray;
            botonServiciosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Servicios_Servicios_Ver());
        }
        private void BotonServiciosAgregar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonServiciosAgregar.TextColor = Color.FromArgb(12, 65, 131);
            botonServiciosAgregar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonServiciosVer.TextColor = Color.DimGray;
            botonServiciosVer.ButtonColor = Color.Transparent;
            botonServiciosEliminar.TextColor = Color.DimGray;
            botonServiciosEliminar.ButtonColor = Color.Transparent;
            botonServiciosModificar.TextColor = Color.DimGray;
            botonServiciosModificar.ButtonColor = Color.Transparent;
            botonServiciosInforme.TextColor = Color.DimGray;
            botonServiciosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Servicios_Servicios_Agregar());
        }
        private void BotonServiciosEliminar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonServiciosEliminar.TextColor = Color.FromArgb(12, 65, 131);
            botonServiciosEliminar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonServiciosVer.TextColor = Color.DimGray;
            botonServiciosVer.ButtonColor = Color.Transparent;
            botonServiciosAgregar.TextColor = Color.DimGray;
            botonServiciosAgregar.ButtonColor = Color.Transparent;
            botonServiciosModificar.TextColor = Color.DimGray;
            botonServiciosModificar.ButtonColor = Color.Transparent;
            botonServiciosInforme.TextColor = Color.DimGray;
            botonServiciosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Servicios_Servicios_Eliminar());
        }
        private void BotonServiciosModificar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonServiciosModificar.TextColor = Color.FromArgb(12, 65, 131);
            botonServiciosModificar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonServiciosVer.TextColor = Color.DimGray;
            botonServiciosVer.ButtonColor = Color.Transparent;
            botonServiciosAgregar.TextColor = Color.DimGray;
            botonServiciosAgregar.ButtonColor = Color.Transparent;
            botonServiciosEliminar.TextColor = Color.DimGray;
            botonServiciosEliminar.ButtonColor = Color.Transparent;
            botonServiciosInforme.TextColor = Color.DimGray;
            botonServiciosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Servicios_Servicios_Modificar());
        }
        private void BotonServiciosInforme_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonServiciosInforme.TextColor = Color.FromArgb(12, 65, 131);
            botonServiciosInforme.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonServiciosVer.TextColor = Color.DimGray;
            botonServiciosVer.ButtonColor = Color.Transparent;
            botonServiciosAgregar.TextColor = Color.DimGray;
            botonServiciosAgregar.ButtonColor = Color.Transparent;
            botonServiciosEliminar.TextColor = Color.DimGray;
            botonServiciosEliminar.ButtonColor = Color.Transparent;
            botonServiciosModificar.TextColor = Color.DimGray;
            botonServiciosModificar.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Servicios_Servicios_Informe());
        }
        #endregion

        #region Botones del submenú de Finanzas
        private void BotonFinanzasIngresos_Click(object sender, EventArgs e)
        {
            //Mostrar botón seleccionado
            botonFinanzasIngresos.Location = new Point(-9, 31);
            botonFinanzasIngresos.Text = "    Ingresos";

            //Ocultar otros botones del panel
            botonFinanzasEgresos.Location = new Point(-110, 70);
            botonFinanzasEgresos.Text = "    Egresos               ▶";

            ocultarOpcionesSubmenus();
            panelSubMenuIngresos.Visible = true;

            // Abrir el panel del menú principal dependiendo de la opción que sa haya
            // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
            if (botonIngresosVer.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Finanzas_Ingresos_Ver());
            else if (botonIngresosAgregar.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Finanzas_Ingresos_Agregar());
            else if (botonIngresosEliminar.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Finanzas_Ingresos_Eliminar());
            else if (botonIngresosModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Finanzas_Ingresos_Modificar());
            else if (botonIngresosInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Finanzas_Ingresos_Informe());
        }
        private void OnMouseEnterbotonFinanzasIngresos(object sender, EventArgs e)
        {
            Point posicion = new Point(-110, 31);
            if(botonFinanzasIngresos.Location == posicion)
            {
                botonFinanzasIngresos.Location = new Point(-9, 31);
            }
        }
        private void OnMouseLeavebotonFinanzasIngresos(object sender, EventArgs e)
        {
            Point posicion = new Point(-9, 31);
            if (botonFinanzasIngresos.Location == posicion
                && botonFinanzasIngresos.Text == "    Ingresos               ▶")
            {
                botonFinanzasIngresos.Location = new Point(-110, 31);
            }
        }
        private void BotonFinanzasEgresos_Click(object sender, EventArgs e)
        {
            //Mostrar botón seleccionado
            botonFinanzasEgresos.Location = new Point(-9, 70);
            botonFinanzasEgresos.Text = "    Egresos";

            //Ocultar otros botones del panel
            botonFinanzasIngresos.Location = new Point(-110, 31);
            botonFinanzasIngresos.Text = "    Ingresos               ▶";

            ocultarOpcionesSubmenus();
            panelSubMenuEgresos.Visible = true;

            // Abrir el panel del menú principal dependiendo de la opción que sa haya
            // seleccionado antes, sirve para guardar las selecciones anteriores en el menú
            if (botonEgresosVer.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Finanzas_Egresos_Ver());
            else if (botonEgresosAgregar.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Finanzas_Egresos_Agregar());
            else if (botonEgresosEliminar.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Finanzas_Egresos_Eliminar());
            else if (botonEgresosModificar.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Finanzas_Egresos_Modificar());
            else if (botonEgresosInforme.ButtonColor == Color.FromArgb(255, 255, 255))
                abrirPanelEventos(new Form_Finanzas_Egresos_Informe());
        }

        private void OnMouseEnterbotonFinanzasEgresos(object sender, EventArgs e)
        {
            Point posicion = new Point(-110, 70);
            if (botonFinanzasEgresos.Location == posicion)
            {
                botonFinanzasEgresos.Location = new Point(-9, 70);
            }
        }
        private void OnMouseLeavebotonFinanzasEgresos(object sender, EventArgs e)
        {
            Point posicion = new Point(-9, 70);
            if (botonFinanzasEgresos.Location == posicion
                && botonFinanzasEgresos.Text == "    Egresos               ▶")
            {
                botonFinanzasEgresos.Location = new Point(-110, 70);
            }
        }
        #endregion

        #region Botones de la opción Ingresos del submenú Finanzas
        private void BotonIngresosVer_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonIngresosVer.TextColor = Color.FromArgb(12, 65, 131);
            botonIngresosVer.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonIngresosAgregar.TextColor = Color.DimGray;
            botonIngresosAgregar.ButtonColor = Color.Transparent;
            botonIngresosEliminar.TextColor = Color.DimGray;
            botonIngresosEliminar.ButtonColor = Color.Transparent;
            botonIngresosModificar.TextColor = Color.DimGray;
            botonIngresosModificar.ButtonColor = Color.Transparent;
            botonIngresosInforme.TextColor = Color.DimGray;
            botonIngresosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Finanzas_Ingresos_Ver());
        }
        private void BotonIngresosAgregar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonIngresosAgregar.TextColor = Color.FromArgb(12, 65, 131);
            botonIngresosAgregar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonIngresosVer.TextColor = Color.DimGray;
            botonIngresosVer.ButtonColor = Color.Transparent;
            botonIngresosEliminar.TextColor = Color.DimGray;
            botonIngresosEliminar.ButtonColor = Color.Transparent;
            botonIngresosModificar.TextColor = Color.DimGray;
            botonIngresosModificar.ButtonColor = Color.Transparent;
            botonIngresosInforme.TextColor = Color.DimGray;
            botonIngresosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Finanzas_Ingresos_Agregar());
        }
        private void BotonIngresosEliminar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonIngresosEliminar.TextColor = Color.FromArgb(12, 65, 131);
            botonIngresosEliminar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonIngresosVer.TextColor = Color.DimGray;
            botonIngresosVer.ButtonColor = Color.Transparent;
            botonIngresosAgregar.TextColor = Color.DimGray;
            botonIngresosAgregar.ButtonColor = Color.Transparent;
            botonIngresosModificar.TextColor = Color.DimGray;
            botonIngresosModificar.ButtonColor = Color.Transparent;
            botonIngresosInforme.TextColor = Color.DimGray;
            botonIngresosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Finanzas_Ingresos_Eliminar());
        }
        private void BotonIngresosModificar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonIngresosModificar.TextColor = Color.FromArgb(12, 65, 131);
            botonIngresosModificar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonIngresosVer.TextColor = Color.DimGray;
            botonIngresosVer.ButtonColor = Color.Transparent;
            botonIngresosAgregar.TextColor = Color.DimGray;
            botonIngresosAgregar.ButtonColor = Color.Transparent;
            botonIngresosEliminar.TextColor = Color.DimGray;
            botonIngresosEliminar.ButtonColor = Color.Transparent;
            botonIngresosInforme.TextColor = Color.DimGray;
            botonIngresosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Finanzas_Ingresos_Modificar());
        }
        private void BotonIngresosInforme_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonIngresosInforme.TextColor = Color.FromArgb(12, 65, 131);
            botonIngresosInforme.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonIngresosVer.TextColor = Color.DimGray;
            botonIngresosVer.ButtonColor = Color.Transparent;
            botonIngresosAgregar.TextColor = Color.DimGray;
            botonIngresosAgregar.ButtonColor = Color.Transparent;
            botonIngresosEliminar.TextColor = Color.DimGray;
            botonIngresosEliminar.ButtonColor = Color.Transparent;
            botonIngresosModificar.TextColor = Color.DimGray;
            botonIngresosModificar.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Finanzas_Ingresos_Informe());
        }
        #endregion

        #region Botones de la opción Egresos del submenú Finanzas
        private void BotonEgresosVer_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonEgresosVer.TextColor = Color.FromArgb(12, 65, 131);
            botonEgresosVer.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonEgresosAgregar.TextColor = Color.DimGray;
            botonEgresosAgregar.ButtonColor = Color.Transparent;
            botonEgresosEliminar.TextColor = Color.DimGray;
            botonEgresosEliminar.ButtonColor = Color.Transparent;
            botonEgresosModificar.TextColor = Color.DimGray;
            botonEgresosModificar.ButtonColor = Color.Transparent;
            botonEgresosInforme.TextColor = Color.DimGray;
            botonEgresosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Finanzas_Egresos_Ver());
        }

        private void BotonEgresosAgregar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonEgresosAgregar.TextColor = Color.FromArgb(12, 65, 131);
            botonEgresosAgregar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonEgresosVer.TextColor = Color.DimGray;
            botonEgresosVer.ButtonColor = Color.Transparent;
            botonEgresosEliminar.TextColor = Color.DimGray;
            botonEgresosEliminar.ButtonColor = Color.Transparent;
            botonEgresosModificar.TextColor = Color.DimGray;
            botonEgresosModificar.ButtonColor = Color.Transparent;
            botonEgresosInforme.TextColor = Color.DimGray;
            botonEgresosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Finanzas_Egresos_Agregar());
        }

        private void BotonEgresosEliminar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonEgresosEliminar.TextColor = Color.FromArgb(12, 65, 131);
            botonEgresosEliminar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonEgresosVer.TextColor = Color.DimGray;
            botonEgresosVer.ButtonColor = Color.Transparent;
            botonEgresosAgregar.TextColor = Color.DimGray;
            botonEgresosAgregar.ButtonColor = Color.Transparent;
            botonEgresosModificar.TextColor = Color.DimGray;
            botonEgresosModificar.ButtonColor = Color.Transparent;
            botonEgresosInforme.TextColor = Color.DimGray;
            botonEgresosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Finanzas_Egresos_Eliminar());
        }

        private void BotonEgresosModificar_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonEgresosModificar.TextColor = Color.FromArgb(12, 65, 131);
            botonEgresosModificar.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonEgresosVer.TextColor = Color.DimGray;
            botonEgresosVer.ButtonColor = Color.Transparent;
            botonEgresosAgregar.TextColor = Color.DimGray;
            botonEgresosAgregar.ButtonColor = Color.Transparent;
            botonEgresosEliminar.TextColor = Color.DimGray;
            botonEgresosEliminar.ButtonColor = Color.Transparent;
            botonEgresosInforme.TextColor = Color.DimGray;
            botonEgresosInforme.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Finanzas_Egresos_Modificar());
        }

        private void BotonEgresosInforme_Click(object sender, EventArgs e)
        {
            //Cambiar color de botón seleccionado al color de selección
            botonEgresosInforme.TextColor = Color.FromArgb(12, 65, 131);
            botonEgresosInforme.ButtonColor = Color.FromArgb(255, 255, 255);

            //Cambiar el color de los demás botones del menú al color de deseleccionar
            botonEgresosVer.TextColor = Color.DimGray;
            botonEgresosVer.ButtonColor = Color.Transparent;
            botonEgresosAgregar.TextColor = Color.DimGray;
            botonEgresosAgregar.ButtonColor = Color.Transparent;
            botonEgresosEliminar.TextColor = Color.DimGray;
            botonEgresosEliminar.ButtonColor = Color.Transparent;
            botonEgresosModificar.TextColor = Color.DimGray;
            botonEgresosModificar.ButtonColor = Color.Transparent;

            abrirPanelEventos(new Form_Finanzas_Egresos_Informe());
        }
        #endregion
    }
}
