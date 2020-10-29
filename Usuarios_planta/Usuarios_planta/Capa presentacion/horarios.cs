using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Usuarios_planta.Capa_presentacion
{
    public partial class horarios : Form
    {

        MySqlConnection con = new MySqlConnection("server=;Uid=;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");


        Comandos cmds = new Comandos();


        public horarios()
        {
            InitializeComponent();
        }

        private void Btn_busqueda_Click(object sender, EventArgs e)
        {
            cmds.Informe_horario(dgv_informes, dtpinicio, dtpfinal, cmbEtapa);
        }
        private void BtnDescargar_Click(object sender, EventArgs e)
        {
            //Esta línea de código crea un archivo de texto para la exportación de datos.
            //StreamWriter file = new StreamWriter(@"C:\\Users\\BBVA\\Desktop\\Desarrollos CF Etapas\\" + "control_horarios.txt");
            StreamWriter file = new StreamWriter(@"D:\\horarios\\" + "control_horarios.txt");
            try
            {
                string sLine = "";
                //Este bucle for recorre cada fila de la tabla
                for (int r = 0; r <= dgv_informes.Rows.Count - 1; r++)
                {
                    //Este bucle for recorre cada columna y el número de fila
                    //se pasa desde el bucle for arriba.
                    for (int c = 0; c <= dgv_informes.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dgv_informes.Rows[r].Cells[c].Value;
                        if (c != dgv_informes.Columns.Count - 1)
                        {
                            //Una coma se agrega como delimitador de texto para
                            //para separar cada campo en el archivo de texto.
                            //Puede elegir otro carácter como delimitador, para este caso no se pone delimitador dado
                            //que el plano va toda la informacion pegada sin espacios ni caracteres.
                            sLine = sLine + "|";
                        }
                    }
                    //El texto exportado se escribe en el archivo de texto, una línea a la vez.
                    file.WriteLine(sLine);
                    sLine = "";
                }

                file.Close();
                MessageBox.Show("Ok archivo plano creado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        }

        private void horarios_Load(object sender, EventArgs e)
        {

        }
    }
}
