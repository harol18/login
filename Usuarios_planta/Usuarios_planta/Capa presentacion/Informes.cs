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
using System.Data.SqlClient;

namespace Usuarios_planta.Formularios
{
    public partial class Informes : Form
    {
        MySqlConnection con = new MySqlConnection("server=;Uid=;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");
        
        Comandos cmds = new Comandos();

        public Informes()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (cmbactividad.Text=="Entrada")
            {
                cmds.Entrada(Txtidentificacion, TxtNombre, TxtEtapa, lblfecha_actual, lblHora, Txtobservaciones);                
            }
            else if (cmbactividad.Text == "Salida - Break")
            {
                cmds.Break1(Txtidentificacion, lblfecha_actual, lblHora);
            }
            else if (cmbactividad.Text == "Entrada - Break")
            {
                cmds.Break2(Txtidentificacion, lblfecha_actual, lblHora);
            }
            else if (cmbactividad.Text == "Salida - Almuerzo")
            {
                cmds.Almuerzo1(Txtidentificacion, lblfecha_actual, lblHora);
            }
            else if (cmbactividad.Text == "Entrada - Almuerzo")
            {
                cmds.Almuerzo2(Txtidentificacion, lblfecha_actual, lblHora);
            }
            else if (cmbactividad.Text == "Salida")
            {
                cmds.Salida(Txtidentificacion, lblfecha_actual, lblHora);
            }
        }          

        private void Txtidentificacion_Validated(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM tf_usuarios WHERE Identificacion = @Identificacion ", con);
            comando.Parameters.AddWithValue("@Identificacion", Txtidentificacion.Text);
            con.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtNombre.Text = registro["Nombre"].ToString();
                TxtEtapa.Text = registro["Area"].ToString();
            }
            else
            {
                MessageBox.Show("Funcionario no se encuentra registrado en la base de datos");
                Txtidentificacion.Clear();
                TxtNombre.Clear();
                TxtEtapa.Clear();
                cmbactividad.Text = "";
                Txtobservaciones.Clear();
            }
            con.Close();
        }

        DateTime fecha = DateTime.Now;

        private void Informes_Load(object sender, EventArgs e)
        {
            lblfecha_actual.Text = fecha.ToString("dd/MM/yyyy");
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
