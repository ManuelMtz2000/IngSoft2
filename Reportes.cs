using System;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using MySql.Data.MySqlClient;
using Microsoft.Win32.SafeHandles;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using System.Data;
using System.Drawing;

/*De aqui inclui un try catch para cada archivo de excel, así evitar problemas en los errores de creación de
los archivos, además ya cambie todos los archivos por copias del archivo base, falta hacer más pequeño el codigo
de los ingresos y egresos, además de los puntos marcados con comentarios en cada fucion*/

namespace interfazModernaONG
{
    class Reportes
    {
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = SAI; uid=root;");
        public Reportes() { }
        
        //ACABADO BENEFICIARIOSFALTA VALIDACION
        public void ListaBeneficiarios(string ruta,string d,string h)
        {
            try
            {
                SLDocument sl = new SLDocument("FORMATO INFORME SEMESTRAL ACTUALIZADO.xlsx", "LISTA BENEFICIARIOS");
                sl.DeleteWorksheet("DATOS GENERALES");
                sl.DeleteWorksheet("SERVICIOS");
                sl.DeleteWorksheet("PERSONAL");
                sl.DeleteWorksheet("RECAUDACION RECURSOS");
                sl.DeleteWorksheet("INGRESOS Y EGRESOS");
                sl.DeleteWorksheet("DIRECTORIO");
                sl.DeleteWorksheet("ANEXOS");
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT Fecha_B,Nombres_B,Apellido_1_B,Apellido_2_B,TIMESTAMPDIFF(YEAR,Fecha_Nacimiento_B,CURDATE()) AS EDAD,Nombre_Fam_Responsable_B,Domicilio_Fam_Responsable_B,Telefono_Fam_Responsable_B,Cuota_Mensual_B FROM beneficiarios WHERE Fecha_B BETWEEN '" + d+"' AND '"+h+"'",conexion);
                    conexion.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    if (reader.Read())
                    {
                        reader.Close();
                        int r = 7;
                        System.Data.DataTable table = new System.Data.DataTable();
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            sl.SetCellValue(r, 5, table.Rows[i]["Nombres_B"].ToString()+" "+table.Rows[i]["Apellido_1_B"].ToString()+" "+table.Rows[i]["Apellido_2_B"].ToString());
                            sl.SetCellValueNumeric(r, 8, table.Rows[i]["EDAD"].ToString());
                            sl.SetCellValue(r, 13, table.Rows[i]["Nombre_Fam_Responsable_B"].ToString());
                            sl.SetCellValue(r, 14, table.Rows[i]["Domicilio_Fam_Responsable_B"].ToString());
                            sl.SetCellValueNumeric(r, 17, table.Rows[i]["Telefono_Fam_Responsable_B"].ToString());
                            sl.SetCellValueNumeric(r, 18, table.Rows[i]["Cuota_Mensual_B"].ToString());
                            r++;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        MessageBox.Show("No");
                        conexion.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Error de conexion.");
                }
                sl.SaveAs(ruta);
                MessageBox.Show("Archivo creado con exito.");
            }
            catch
            {
                MessageBox.Show("Error en la generación de archivos.");
            }
        }

        //ACABADO  INGRESO-EGRESO FALTA OPTIMIZAR
        public void IgEg(string ruta,string d,string h,string[] m,string[] md)
        {
            try
            {
                string[] ingresos = {"Subsidio","Aportaciones (socios)","Cuotas de recuperación","Eventos o colectas","Donativos económicos","Donativos en especie",
                "Rendimientos de capital","Otros"};
                string[] egresos = { "Apoyos eco", "Medicinas", "Despensas", "Gastos por", "Insumos", "Gastos de ", "Inversione", "Acreedores" };
                SLDocument sl = new SLDocument("FORMATO INFORME SEMESTRAL ACTUALIZADO.xlsx", "INGRESOS Y EGRESOS");
                sl.DeleteWorksheet("DATOS GENERALES");
                sl.DeleteWorksheet("SERVICIOS");
                sl.DeleteWorksheet("PERSONAL");
                sl.DeleteWorksheet("RECAUDACION RECURSOS");
                sl.DeleteWorksheet("LISTA BENEFICIARIOS");
                sl.DeleteWorksheet("DIRECTORIO");
                sl.DeleteWorksheet("ANEXOS");
                try
                {
                    int cont = 0;
                    while(cont < m.Length)
                    {
                        sl.SetCellValue(cont + 6, 2, m[cont]);
                        sl.SetCellValue(cont + 17, 2, m[cont]);
                        cont++;
                    }
                    try
                    {
                        for (int i = 0; i < md.Length; i++)
                        {
                            for (int j = 0; j < ingresos.Length; j++)
                            {
                                MySqlCommand command = new MySqlCommand("SELECT SUM(Cantidad_Recivida_I) FROM ingresos WHERE MONTH(Fecha_I) = '" + md[i] + "' AND Tipo_I = '" + ingresos[j] + "'", conexion);
                                conexion.Open();
                                MySqlDataReader reader = command.ExecuteReader();
                                if (reader.Read())
                                {
                                    if (reader["SUM(Cantidad_Recivida_I)"] != DBNull.Value)
                                    {
                                        sl.SetCellValueNumeric(i + 6, j + 3, reader["SUM(Cantidad_Recivida_I)"].ToString());
                                    }
                                    else
                                    {
                                        sl.SetCellValueNumeric(i + 6, j + 3, "0");
                                    }
                                    reader.Close();
                                }
                                else
                                {
                                    sl.SetCellValueNumeric(i + 6, j + 3, "0");
                                    reader.Close();
                                }
                                conexion.Close();
                            }
                            for(int j = 0; j < egresos.Length; j++)
                            {
                                MySqlCommand command = new MySqlCommand("SELECT SUM(Cantidad_Intervenida_E) FROM egresos WHERE MONTH(Fecha_E) = '" + md[i] + "' AND Tipo_E = '" + egresos[j] + "'", conexion);
                                conexion.Open();
                                MySqlDataReader reader = command.ExecuteReader();
                                if (reader.Read())
                                {
                                    if (reader["SUM(Cantidad_Intervenida_E)"] != DBNull.Value)
                                    {
                                        sl.SetCellValueNumeric(i + 17, j + 3, reader["SUM(Cantidad_Intervenida_E)"].ToString());
                                    }
                                    else
                                    {
                                        sl.SetCellValueNumeric(i + 17, j + 3, "0");
                                    }
                                    reader.Close();
                                }
                                else
                                {
                                    sl.SetCellValueNumeric(i + 17, j + 3, "0");
                                    reader.Close();
                                }
                                conexion.Close();
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error de conexion.");
                    }
                }
                catch
                {
                    MessageBox.Show("Error de conexión.");
                }
                sl.SaveAs(ruta);
                MessageBox.Show("Archivo creado con exito.");
            }
            catch
            {
                MessageBox.Show("Error en el archivo.\nCompruebe que el archivo origen no este en ejecución.");
            }
        }
    
        //ACABADO RECAUDACION FALTA VALIDACION
        public void Recaudacion(string ruta,string d,string h)
        {
            try
            {
                //ABRE LA PLANTILLA Y BORRA HOJAS QUE NO SON NECESARIAS
                SLDocument sl = new SLDocument("FORMATO INFORME SEMESTRAL ACTUALIZADO.xlsx", "RECAUDACION RECURSOS");
                sl.DeleteWorksheet("DATOS GENERALES");
                sl.DeleteWorksheet("SERVICIOS");
                sl.DeleteWorksheet("PERSONAL");
                sl.DeleteWorksheet("LISTA BENEFICIARIOS");
                sl.DeleteWorksheet("INGRESOS Y EGRESOS");
                sl.DeleteWorksheet("DIRECTORIO");
                sl.DeleteWorksheet("ANEXOS");
                try
                {
                    int r = 6, c = 2;
                    MySqlCommand command = new MySqlCommand("SELECT Tipo_Evento_I,Fecha_I,Objetivo_Evento_I,Cantidad_Invertida_Evento_I,Cantidad_Recivida_I FROM ingresos WHERE Tipo_I = 'Eventos o colectas' AND Fecha_I BETWEEN '" + d+"' AND '"+h+"'", conexion);
                    conexion.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    if (reader.Read())
                    {
                        reader.Close();
                        adapter.SelectCommand = command;
                        System.Data.DataTable table = new System.Data.DataTable();
                        adapter.Fill(table);
                        sl.SetColumnWidth(4, 23.1);
                        for(int i = 0; i < table.Rows.Count; i++)
                        {
                            sl.SetCellValue(r, c, table.Rows[i]["Tipo_Evento_I"].ToString());
                            sl.SetCellValue(r, c+2, table.Rows[i]["Fecha_I"].ToString());
                            sl.SetCellValue(r, c+3, table.Rows[i]["Objetivo_Evento_I"].ToString());
                            sl.SetCellValueNumeric(r, c+5, table.Rows[i]["Cantidad_Invertida_Evento_I"].ToString());
                            sl.SetCellValueNumeric(r, c+7, table.Rows[i]["Cantidad_Recivida_I"].ToString());
                            r = r + 2;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        conexion.Close();
                        MessageBox.Show("No se encontro ningun elemento.");
                    }
                    MySqlCommand command1 = new MySqlCommand("SELECT Tipo_I, Nombre_Donante_I, Fecha_I, Donativo_Canalizado_I, Cantidad_Recivida_I FROM ingresos WHERE ((Tipo_I = 'Donativos económicos' OR Tipo_I = 'Donativos en especie') AND Fecha_I BETWEEN '" + d + "' AND '" + h + "')", conexion);
                    conexion.Open();
                    r = 23;
                    c = 1;
                    MySqlDataReader reader1 = command1.ExecuteReader();
                    if (reader1.Read())
                    {
                        reader1.Close();
                        adapter.SelectCommand = command1;
                        System.Data.DataTable table = new System.Data.DataTable();
                        adapter.Fill(table);
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            if (table.Rows[i]["Tipo_I"].ToString() == "Donativos económicos")
                            {
                                MessageBox.Show("Si encontre2");
                                sl.SetCellValue(r, c, "Economicos");
                            }
                            if (table.Rows[i]["Tipo_I"].ToString() == "Donativos en especie")
                            {
                                sl.SetCellValue(r, c, "En especie");
                            }
                            sl.SetCellValue(r, c + 1, table.Rows[i]["Nombre_Donante_I"].ToString());
                            sl.SetCellValue(r, c + 3, table.Rows[i]["Fecha_I"].ToString());
                            sl.SetCellValue(r, c + 4, table.Rows[i]["Donativo_Canalizado_I"].ToString());
                            sl.SetCellValueNumeric(r, c + 8, table.Rows[i]["Cantidad_Recivida_I"].ToString());
                            r = r + 2;
                        }
                        conexion.Close();
                        sl.SaveAs(ruta);
                        MessageBox.Show("Archivo creado con exito.");
                    }
                    else
                    {
                        conexion.Close();
                        MessageBox.Show("No se encontro ningun elemento.");
                    }
                }
                catch
                {
                    MessageBox.Show("Error de conexión.");
                }
            }
            catch
            {
                MessageBox.Show("Error en la generación de archivos.");
            }
        }

        public void PoblacionAtendida(string ruta,string d,string h,string n,string[] ms)
        {
            try
            {
                SLDocument sl = new SLDocument("FORMATO INFORME SEMESTRAL ACTUALIZADO.xlsx", "DATOS GENERALES");
                sl.DeleteWorksheet("LISTA DE BENEFICIARIOS");
                sl.DeleteWorksheet("SERVICIOS");
                sl.DeleteWorksheet("PERSONAL");
                sl.DeleteWorksheet("RECAUDACION RECURSOS");
                sl.DeleteWorksheet("INGRESOS Y EGRESOS");
                sl.DeleteWorksheet("DIRECTORIO");
                sl.DeleteWorksheet("ANEXOS");
                int cont = 0;
                while(cont < ms.Length)
                {
                    sl.SetCellValue(cont + 28, 2, ms[cont]);
                    cont++;
                }
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT * FROM datos_generales", conexion);
                    conexion.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if(reader.Read())
                    {
                        sl.SetCellValue("A11","Nombre de la Asociación Civil:  "+reader["Nombre_ONG"].ToString());
                        sl.SetCellValue("H11", "CLAVE UNICA: " + reader["Clave_Unica_ONG"].ToString());
                        sl.SetCellValue("A13", "Dirección:   " + reader["Direccion_ONG"].ToString());
                        sl.SetCellValueNumeric("I13", reader["Codigo_Postal_ONG"].ToString());

                        if(DateTime.Now.Month == 6)
                        {
                            sl.SetCellValue("B17", "Primero");
                        }
                        else
                        {
                            sl.SetCellValue("B17", "Segundo");
                        }
                        sl.SetCellValue("F17", "TEL: " + reader["Telefono_ONG"].ToString() + "                                                      CEL: " + reader["Celular_ONG"].ToString());
                        sl.SetCellValue("C17", "Semestre del año: " + DateTime.Now.Year.ToString());
                        sl.SetCellValue("F19", "Correo Electrónico: " + reader["Email_ONG"].ToString());
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en la extracción de datos, compruebe que sus parametros de busqueda sean correctos.");
                    }
                    conexion.Close();
                    string[] nombre = n.Split(' ');
                    if(nombre.Length > 3)
                    {
                        MySqlCommand command1 = new MySqlCommand("SELECT Cargo_P FROM personal WHERE Nombres_P = '" + nombre[0] + " " + nombre[1] + "' AND Apellido_1_P = '" + nombre[2] + "' AND Apellido_2_P = '" + nombre[3] + "'", conexion);
                        conexion.Open();
                        MySqlDataReader reader1 = command1.ExecuteReader();
                        if(reader1.Read())
                        {
                            sl.SetCellValue("A15", "Persona que Informa: " + n);
                            sl.SetCellValue("G15", "Cargo que Ocupa: " + reader1["Cargo_P"].ToString());
                            reader1.Close();
                        }
                        conexion.Close();
                    }
                    else
                    {
                        MySqlCommand command1 = new MySqlCommand("SELECT Cargo_P FROM personal WHERE Nombres_P = '" + nombre[0] + "' AND Apellido_1_P = '" + nombre[1] + "' AND Apellido_2_P = '" + nombre[2] + "'", conexion);
                        conexion.Open();
                        MySqlDataReader reader1 = command1.ExecuteReader();
                        if (reader1.Read())
                        {
                            sl.SetCellValue("A15", "Persona que Informa: " + n);
                            sl.SetCellValue("G15", "Cargo que Ocupa: " + reader1["Cargo_P"].ToString());
                            reader1.Close();
                        }
                        conexion.Close();
                    }
                    int mesAct = Convert.ToDateTime(d).Month, cont1 = 28;
                    string[] tipos = { "0", "1", "2" };
                    for (int i = mesAct; i <= Convert.ToDateTime(h).Month; i++)
                    {
                        for(int j = 0; j < 3; j++)
                        {
                            MySqlCommand command2 = new MySqlCommand("SELECT COUNT(Tipo_B) FROM beneficiarios WHERE Tipo_B = '"+tipos[j]+"' AND MONTH(Fecha_B) = '"+i.ToString()+"'", conexion);
                            conexion.Open();
                            MySqlDataReader reader1 = command2.ExecuteReader();
                            if(reader1.Read())
                            {
                                sl.SetCellValueNumeric(cont1, j + 3, reader1["COUNT(Tipo_B)"].ToString());
                                reader1.Close();
                            }
                            conexion.Close();
                        }
                        MySqlCommand command1 = new MySqlCommand ("SELECT MIN(YEAR(CURDATE())-YEAR(Fecha_Nacimiento_B)),MAX(YEAR(CURDATE())-YEAR(Fecha_Nacimiento_B)) FROM beneficiarios WHERE MONTH(Fecha_B) = '" + i.ToString()+"'", conexion);
                        conexion.Open();
                        MySqlDataReader reader2 = command1.ExecuteReader();
                        if(reader2.Read())
                        {
                            if (reader2["MIN(YEAR(CURDATE())-YEAR(Fecha_Nacimiento_B))"] != DBNull.Value)
                            {
                                sl.SetCellValueNumeric(cont1, 7, reader2["MIN(YEAR(CURDATE())-YEAR(Fecha_Nacimiento_B))"].ToString());
                                sl.SetCellValueNumeric(cont1, 6, reader2["MAX(YEAR(CURDATE())-YEAR(Fecha_Nacimiento_B))"].ToString());
                            }
                            else
                            {
                                sl.SetCellValueNumeric(cont1, 7,"0");
                                sl.SetCellValueNumeric(cont1, 6,"0");
                            }
                            reader2.Close();
                        }
                        conexion.Close();
                        MySqlCommand command3 = new MySqlCommand("SELECT COUNT(Sexo_B) FROM beneficiarios WHERE MONTH(Fecha_B) = '" + i.ToString() + "' AND Sexo_B = 'Hombre'", conexion);
                        conexion.Open();
                        MySqlDataReader reader3 = command3.ExecuteReader();
                        if(reader3.Read())
                        {
                            sl.SetCellValueNumeric(cont1, 8, reader3["COUNT(Sexo_B)"].ToString());
                            reader3.Close();
                        }
                        conexion.Close();
                        MySqlCommand command4 = new MySqlCommand("SELECT COUNT(Sexo_B) FROM beneficiarios WHERE MONTH(Fecha_B) = '" + i.ToString() + "' AND Sexo_B = 'Mujer'", conexion);
                        conexion.Open();
                        MySqlDataReader reader4 = command4.ExecuteReader();
                        if (reader4.Read())
                        {
                            sl.SetCellValueNumeric(cont1, 9, reader4["COUNT(Sexo_B)"].ToString());
                            reader4.Close();
                        }
                        conexion.Close();
                        string[] inter1 = { "0", "13", "19", "36", "60" };
                        string[] inter2 = { "12", "18", "35", "59", "120" };
                        int controlInter = 0;
                        while(controlInter < 5)
                        {
                            MySqlCommand command2 = new MySqlCommand("SELECT COUNT(YEAR(CURDATE())-YEAR(Fecha_Nacimiento_B)) AS EDAD FROM beneficiarios WHERE MONTH(Fecha_B) = '" + i.ToString() + "' AND YEAR(CURDATE())-YEAR(Fecha_Nacimiento_B) BETWEEN '" + inter1[controlInter] + "' AND '" + inter2[controlInter]+"'", conexion);
                            conexion.Open();
                            MySqlDataReader reader1 = command2.ExecuteReader();
                            if(reader1.Read())
                            {
                                sl.SetCellValueNumeric(cont1, controlInter + 10, reader1["EDAD"].ToString());
                                controlInter++;
                            }
                            conexion.Close();
                        }
                        cont1++;
                        //SUBTOTALES, TOTAL Y PROMEDIO MENSUAL
                        sl.SetCellValue("C34","= C28 + C29 + C30 + C31 + C32 + C33");
                        sl.SetCellValue("D34","= D28 + D29 + D30 + D31 + D32 + D33");
                        sl.SetCellValue("E34","= E28 + E29 + E30 + E31 + E32 + E33");
                        sl.SetCellValue("F34","= F28 + F29 + F30 + F31 + F32 + F33");
                        sl.SetCellValue("G34","= G28 + G29 + G30 + G31 + G32 + G33");
                        sl.SetCellValue("H34","= H28 + H29 + H30 + H31 + H32 + H33");
                        sl.SetCellValue("I34","= I28 + I29 + I30 + I31 + I32 + I33");
                        sl.SetCellValue("J34","= J28 + J29 + J30 + J31 + J32 + J33");
                        sl.SetCellValue("K34","= K28 + K29 + K30 + K31 + K32 + K33");
                        sl.SetCellValue("L34","= L28 + L29 + L30 + L31 + L32 + L33");
                        sl.SetCellValue("M34","= M28 + M29 + M30 + M31 + M32 + M33");
                        sl.SetCellValue("N34","= N28 + N29 + N30 + N31 + N32 + N33");
                        sl.SetCellValue("C35","= C34 + D34 + E34");
                        sl.SetCellValue("C36", "= C35 / 6");
                    }

                }
                catch
                {
                    MessageBox.Show("Error de conexion");
                }
                sl.SaveAs(ruta);
                MessageBox.Show("Archivo creado con exito.");
            }
            catch
            {
                MessageBox.Show("Error en la generación de archivos.");
            }
        }

        //ACABADO DIRECTORIO FALTA VALIDACION
        public void Directorio(string ruta,string d,string h)
        {
            try
            {
                //ABRE LA PLANTILLA Y BORRA LAS HOJAS NO REQUERIDAS
                SLDocument sl = new SLDocument("FORMATO INFORME SEMESTRAL ACTUALIZADO.xlsx", "DIRECTORIO");
                sl.DeleteWorksheet("DATOS GENERALES");
                sl.DeleteWorksheet("SERVICIOS");
                sl.DeleteWorksheet("PERSONAL");
                sl.DeleteWorksheet("RECAUDACION RECURSOS");
                sl.DeleteWorksheet("INGRESOS Y EGRESOS");
                sl.DeleteWorksheet("LISTA BENEFICIARIOS");
                sl.DeleteWorksheet("ANEXOS");
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT Fecha_D,Apellido_1_D,Apellido_2_D,Nombres_D,Cargo_D,Telefono_D,Email_D,Fecha_Baja_D FROM directorio WHERE Fecha_D BETWEEN '"+d+"' AND '"+h+"'", conexion);
                    conexion.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    if(reader.Read())
                    {
                        reader.Close();
                        int r = 5;
                        System.Data.DataTable table = new System.Data.DataTable();
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            sl.SetCellValue(r, 1, table.Rows[i]["Nombres_D"].ToString() + " " + table.Rows[i]["Apellido_1_D"].ToString() + " " + table.Rows[i]["Apellido_2_D"].ToString());
                            sl.SetCellValue(r, 2, table.Rows[i]["Cargo_D"].ToString());
                            sl.SetCellValue(r, 3, table.Rows[i]["Telefono_D"].ToString());
                            sl.SetCellValue(r, 4, table.Rows[i]["Email_D"].ToString());
                            r++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se enontro nada");
                    }
                    conexion.Close();
                }
                catch
                {
                    MessageBox.Show("Error de conexion.");
                }
                sl.SaveAs(ruta);
                MessageBox.Show("Archivo creado con exito.");
            }
            catch
            {
                MessageBox.Show("Error en la generación de archivos.");
            }
        }

        //EN PROGRESO
        public void Servicios(string ruta,string d,string h)
        {
            try
            {
                SLDocument sl = new SLDocument("FORMATO INFORME SEMESTRAL ACTUALIZADO.xlsx", "SERVICIOS");
                sl.DeleteWorksheet("DATOS GENERALES");
                sl.DeleteWorksheet("DIRECTORIO");
                sl.DeleteWorksheet("PERSONAL");
                sl.DeleteWorksheet("RECAUDACION RECURSOS");
                sl.DeleteWorksheet("INGRESOS Y EGRESOS");
                sl.DeleteWorksheet("LISTA BENEFICIARIOS");
                sl.DeleteWorksheet("ANEXOS");
                try
                {
                    int cont = 0;
                    //ARREGLOS PARA CADA SECCION DEL ARCHIVO EXCEL
                    string[] srv = { "Casa Hogar", "Guarderia", "Educacion Preescolar", "Educacion Básica", "Eduacion Abierta", "Educacion Especial", "Cursos",
                        "Talleres", "Conferencias"};
                    string[] srv2 = {"Servicios de Comedor", "Apoyos en Especie", "Apoyos Económicos", "Apoyo Legal", "Asesoría",
                        "Orientación", "Servicios Funerarios", "Servicios Paramédicos", "Emergencias médicas"};
                    string[] srv3 = {"Consulta Externa", "Hospitalización", "Cirugía Menor", "Cirugía Mayor", "Estudios Médicos Especializados",
                        "Análisis Clínicos", "Terapías", "Otros"};
                    //ARREGLOS AUXILIARES PARA TERAPIAS Y CONSULTAS EXTERNAS
                    string[] ce = { "Alopatía", "Homeopatía", "Medicina Alternativa", "Oftalmología", "Odontología" };
                    string[] te = { "Física", "Psicológica", "Lenguaje", "Individual", "Grupal", "Familiar", "Pareja" };
                    //BUCLE PARA PRIMER ARREGLO
                    while (srv.Length > cont)
                    {
                        //CAMBIA CADA ELEMENTO DEL ARREGLO DENTRO DEL QUERY MEDIANTE UN CONTADOR
                        MySqlCommand command = new MySqlCommand("SELECT COUNT(Tipo_S) FROM servicios WHERE Tipo_S = '" + srv[cont] + "' AND Fecha_S BETWEEN '" + d + "' AND '" + h + "'", conexion);
                        conexion.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            sl.SetCellValue(cont+7, 2, "__" + reader["COUNT(Tipo_S)"].ToString()+ "__ "+ srv[cont]);//ESCRIBIMOS NUMERO DE CONSULTAS HECHAS DEL TIPO INDICADO EN SU RESPECTIVA CELDA
                            reader.Close();
                            if (srv[cont] == "Cursos" || srv[cont] == "Talleres" || srv[cont] == "Conferencias")//SI ES ALGUNO DE ESTOS TRES TIPOS
                            {
                                conexion.Close();
                                MySqlCommand command1 = new MySqlCommand("SELECT SUM(Num_Beneficiarios_S) FROM servicios WHERE Tipo_S = '" + srv[cont] + "' AND Fecha_S BETWEEN '" + d + "' AND '" + h + "'", conexion);
                                //CREA UN NUEVO QUERY PARA AJUSTAR EL NUMERO DE BENEFICIARIOS CON RESPECTO AL TIPO
                                conexion.Open();
                                MySqlDataReader reader1 = command1.ExecuteReader();
                                if (reader1.Read())
                                {
                                    if (reader1["SUM(Num_Beneficiarios_S)"].ToString().Length > 0)
                                    {//SI EL VALOR ES ACEPTADO, ESCRIBE LA CANTIDAD EN SU RESPECTIVA CELDA
                                        sl.SetCellValue(cont + 7, 4, "Nº de Beneficiados _" + reader1["SUM(Num_Beneficiarios_S)"].ToString() + "_l__");
                                    }
                                    else//A PARTIR DE AQUI, SON VALORES PREDETERMINADOS DE 0 EN CASO DE QUE NO ENCUENTRE VALOR ALGUNO EN LA BASE DE DATOS
                                    {
                                        sl.SetCellValue(cont + 7, 4, "Nº de Beneficiados _0____");
                                    }
                                }
                                else
                                {
                                    sl.SetCellValue(cont + 7, 4, "Nº de Beneficiados _0____");
                                }
                                reader1.Close();
                            }
                        }
                        else
                        {
                            sl.SetCellValue(cont + 7, 2, "__0__ " + srv[cont]);
                            if (srv[cont] == "Cursos" || srv[cont] == "Talleres" || srv[cont] == "Conferencias")
                            {
                                sl.SetCellValue(cont + 7, 4, "Nº de Beneficiados _0____");
                            }
                        }//<--------------------------------- FIN DEL ARREGLO 1---------------------------------->
                        conexion.Close();
                        cont++;
                    }
                    cont = 0;
                    while (srv2.Length > cont)
                    {
                        MySqlCommand command = new MySqlCommand("SELECT COUNT(Tipo_S) FROM servicios WHERE Tipo_S = '" + srv2[cont] + "' AND Fecha_S BETWEEN '" + d + "' AND '" + h + "'", conexion);
                        conexion.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            sl.SetCellValue(cont + 6, 6, "__" + reader["COUNT(Tipo_S)"].ToString() + "__ " + srv2[cont]);//ESCRIBIMOS NUMERO DE CONSULTAS HECHAS DEL TIPO INDICADO EN SU RESPECTIVA CELDA
                            reader.Close();
                        }
                        else//A PARTIR DE AQUI, SON VALORES PREDETERMINADOS DE 0 EN CASO DE QUE NO ENCUENTRE VALOR ALGUNO EN LA BASE DE DATOS
                        {
                            sl.SetCellValue(cont + 6, 6, "__0__ " + srv2[cont]);
                            reader.Close();
                        }
                        conexion.Close();
                        cont++;
                    }//<--------------------------------- FIN DEL ARREGLO 2---------------------------------->
                    cont = 0;
                    while(srv3.Length > cont)
                    {
                        MySqlCommand command = new MySqlCommand("SELECT COUNT(Tipo_S) FROM servicios WHERE Tipo_S = '" + srv3[cont] + "' AND Fecha_S BETWEEN '" + d + "' AND '" + h + "'", conexion);
                        conexion.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            sl.SetCellValue(cont + 6, 9, "__" + reader["COUNT(Tipo_S)"].ToString() + "__ " + srv3[cont]);//ESCRIBIMOS NUMERO DE CONSULTAS HECHAS DEL TIPO INDICADO EN SU RESPECTIVA CELDA
                            reader.Close();
                            if (srv3[cont] == "Terapías")
                            {
                                conexion.Close();
                                int cont1 = 0;
                                while (te.Length > cont1)
                                {//ABAJO ES EL QUERY PARA CONTAR LOS TIPOS DE TERAPIAS
                                    MySqlCommand command2 = new MySqlCommand("SELECT COUNT(Especificar_Tipo_S) FROM servicios WHERE Tipo_S = '" + srv3[cont] + "' AND Especificar_Tipo_S = '" + te[cont1] + "' AND Fecha_S BETWEEN '" + d + "' AND '" + h + "'", conexion);
                                    conexion.Open();
                                    MySqlDataReader reader2 = command2.ExecuteReader();
                                    if (reader2.Read())
                                    {
                                        sl.SetCellValue(cont1 + 15, 11, "__" + reader2["COUNT(Especificar_Tipo_S)"].ToString() + "__");
                                        reader2.Close();
                                    }
                                    else
                                    {
                                        sl.SetCellValue(cont1 + 15, 11, "___0__");
                                        reader2.Close();
                                    }
                                    cont1++;
                                    conexion.Close();
                                }
                            }
                            else
                            {
                                conexion.Close();
                            }
                            if (srv3[cont] == "Consulta Externa")
                            {
                                conexion.Close();
                                int cont1 = 0, control = 16;
                                while (ce.Length > cont1)
                                {//ABAJO ES EL QUERY PARA CONTAR LOS TIPOS DE CONSULTA EXTERNA
                                    MySqlCommand command2 = new MySqlCommand("SELECT COUNT(Especificar_Tipo_S) FROM servicios WHERE Tipo_S = '" + srv3[cont] + "' AND Especificar_Tipo_S = '" + ce[cont1] + "' AND Fecha_S BETWEEN '" + d + "' AND '" + h + "'", conexion);
                                    conexion.Open();
                                    MySqlDataReader reader2 = command2.ExecuteReader();
                                    if (reader2.Read())
                                    {
                                        sl.SetCellValue(control, 7, "__" + reader2["COUNT(Especificar_Tipo_S)"].ToString() + "__");
                                        reader2.Close();
                                    }
                                    else
                                    {
                                        sl.SetCellValue(control, 7, "___0__");
                                        reader2.Close();
                                    }
                                    cont1++;
                                    control++;
                                    if (control == 19) { control = control + 1; }
                                    conexion.Close();
                                }
                            }
                            if(srv3[cont] == "Otros")
                            {
                                MySqlCommand command1 = new MySqlCommand("SELECT COUNT(Tipo_S) FROM servicios WHERE Tipo_S = 'Otros' AND Fecha_S BETWEEN '" + d + "' AND '" + h + "'", conexion);
                                conexion.Open();
                                MySqlDataReader reader1 = command1.ExecuteReader();
                                if(reader1.Read())
                                {
                                    sl.SetCellValueNumeric(23, 3, reader1["COUNT(Tipo_S)"].ToString());
                                    reader1.Close();
                                }
                                else
                                {
                                    reader1.Close();
                                }
                                conexion.Close();
                            }
                            else
                            {
                                conexion.Close();
                            }
                        }
                        else
                        {
                            sl.SetCellValue(cont + 6, 9, "__0__ " + srv3[cont]);
                            reader.Close();
                            conexion.Close();
                        }
                        conexion.Close();
                        cont++;
                    }//<--------------------------------- FIN DEL ARREGLO 3---------------------------------->
                }
                catch
                {
                    MessageBox.Show("Error de conexion.");
                }
                sl.SaveAs(ruta);
                MessageBox.Show("Archivo creado con exito.");
            }
            catch
            {
                MessageBox.Show("Error en la generación de archivos.");
            }
        }

        //ACABADO PERSONAL FALTA VALIDACION
        public void Personal(string ruta,string d,string h)
        {
            try
            {
                SLDocument sl = new SLDocument("FORMATO INFORME SEMESTRAL ACTUALIZADO.xlsx", "PERSONAL");
                sl.DeleteWorksheet("DATOS GENERALES");
                sl.DeleteWorksheet("DIRECTORIO");
                sl.DeleteWorksheet("SERVICIOS");
                sl.DeleteWorksheet("RECAUDACION RECURSOS");
                sl.DeleteWorksheet("INGRESOS Y EGRESOS");
                sl.DeleteWorksheet("LISTA BENEFICIARIOS");
                sl.DeleteWorksheet("ANEXOS");
                try
                {
                    MySqlCommand command = new MySqlCommand("SELECT Nombres_P,Apellido_1_P,Apellido_2_P,Cargo_P,Base_P,Eventual_P,Voluntario_P,Servicio_Social_P,Nombre_UNI_P,Carrera_Alumno_P,Num_Alum_Servicio_P,Estatus_P,Fecha_Baja_P FROM personal WHERE Fecha_P BETWEEN '" + d + "' AND '" + h + "'",conexion);
                    conexion.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    if(reader.Read())
                    {
                        int r = 5;
                        reader.Close();
                        System.Data.DataTable table = new System.Data.DataTable();
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        for(int i = 0; i < table.Rows.Count; i++)
                        {
                            if (table.Rows[i]["Nombre_UNI_P"] == System.DBNull.Value)
                            {
                                sl.SetCellValue(r, 1, table.Rows[i]["Nombres_P"].ToString() + " " + table.Rows[i]["Apellido_1_P"].ToString() + " " + table.Rows[i]["Apellido_2_P"]);
                                sl.SetCellValue(r, 2, table.Rows[i]["Cargo_P"].ToString());
                                if (table.Rows[i]["Base_p"].ToString() == "0")
                                {
                                    sl.SetCellValue(r, 3, "No");
                                }
                                else
                                {
                                    sl.SetCellValue(r, 3, "Si");
                                }
                                if(table.Rows[i]["Eventual_P"].ToString() == "0")
                                {
                                    sl.SetCellValue(r, 4, "No");
                                }
                                else
                                {
                                    sl.SetCellValue(r, 4, "Si");
                                }
                                if(table.Rows[i]["Voluntario_P"].ToString() == "0")
                                {
                                    sl.SetCellValue(r, 5, "No");
                                }
                                else
                                {
                                    sl.SetCellValue(r, 5, "Si");
                                }
                                if(table.Rows[i]["Servicio_Social_P"].ToString() == "0")
                                {
                                    sl.SetCellValue(r, 6, "No");
                                }
                                else
                                {
                                    sl.SetCellValue(r, 6, "Si");
                                }
                            }
                            else
                            {
                                sl.SetCellValue(r, 1, table.Rows[i]["Nombres_P"].ToString());
                                sl.SetCellValue(r, 2, table.Rows[i]["Cargo_P"].ToString());
                                sl.SetCellValue(r, 3, "No");
                                sl.SetCellValue(r, 4, "No");
                                sl.SetCellValue(r, 5, "No");
                                sl.SetCellValueNumeric(r, 6, table.Rows[i]["Servicio_Social_P"].ToString());
                            }
                            r++;
                                
                        }
                        conexion.Close();
                        sl.SaveAs(ruta);
                        MessageBox.Show("Archivo creado con exito.");
                    }
                    else
                    {
                        conexion.Close();
                        MessageBox.Show("No se encontraron elementos.");
                    }
                }
                catch
                {
                    MessageBox.Show("Error de conexion.");
                }
            }
            catch
            {
                MessageBox.Show("Error en la generación de archivos.");
            }
        }
    }
}
