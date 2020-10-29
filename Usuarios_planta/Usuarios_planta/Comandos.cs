using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Usuarios_planta
{
    class Comandos
    {
        MySqlConnection con = new MySqlConnection("server=;Uid=;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");


        public void Entrada(TextBox Txtidentificacion, TextBox TxtNombre, TextBox TxtEtapa, Label lblfecha_actual, Label lblHora, TextBox Txtobservaciones)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Entrada", con);
            MySqlTransaction myTrans; // Iniciar una transacción local 
            myTrans = con.BeginTransaction(); // Debe asignar tanto el objeto de transacción como la conexión // al objeto de Comando para una transacción local pendiente 
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Identificacion", Txtidentificacion.Text);
                cmd.Parameters.AddWithValue("@_Nombre", TxtNombre.Text);
                cmd.Parameters.AddWithValue("@_Etapa", TxtEtapa.Text);
                cmd.Parameters.AddWithValue("@_Fecha", lblfecha_actual.Text);
                cmd.Parameters.AddWithValue("@_Entrada", lblHora.Text);
                cmd.Parameters.AddWithValue("@_Observaciones", Txtobservaciones.Text); 
                cmd.ExecuteNonQuery();
                myTrans.Commit();
                MessageBox.Show("Información Registrada");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());    
            }
            finally
            {
                con.Close();
            }
        }

        public void Break1(TextBox Txtidentificacion,Label lblfecha_actual, Label lblHora)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("break1", con);
            MySqlTransaction myTrans; // Iniciar una transacción local 
            myTrans = con.BeginTransaction(); // Debe asignar tanto el objeto de transacción como la conexión // al objeto de Comando para una transacción local pendiente 
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Identificacion", Txtidentificacion.Text);
                cmd.Parameters.AddWithValue("@_Fecha", lblfecha_actual.Text);
                cmd.Parameters.AddWithValue("@_Salida_Break", lblHora.Text);
                cmd.ExecuteNonQuery();
                myTrans.Commit();
                MessageBox.Show("Información Registrada");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void Break2(TextBox Txtidentificacion, Label lblfecha_actual, Label lblHora)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("break2", con);
            MySqlTransaction myTrans; // Iniciar una transacción local 
            myTrans = con.BeginTransaction(); // Debe asignar tanto el objeto de transacción como la conexión // al objeto de Comando para una transacción local pendiente 
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Identificacion", Txtidentificacion.Text);
                cmd.Parameters.AddWithValue("@_Fecha", lblfecha_actual.Text);
                cmd.Parameters.AddWithValue("@_Entrada_Break", lblHora.Text);
                cmd.ExecuteNonQuery();
                myTrans.Commit();
                MessageBox.Show("Información Registrada");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void Almuerzo1(TextBox Txtidentificacion, Label lblfecha_actual, Label lblHora)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("almuerzo1", con);
            MySqlTransaction myTrans; // Iniciar una transacción local 
            myTrans = con.BeginTransaction(); // Debe asignar tanto el objeto de transacción como la conexión // al objeto de Comando para una transacción local pendiente 
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Identificacion", Txtidentificacion.Text);
                cmd.Parameters.AddWithValue("@_Fecha", lblfecha_actual.Text);
                cmd.Parameters.AddWithValue("@_Salida_Almuerzo", lblHora.Text);
                cmd.ExecuteNonQuery();
                myTrans.Commit();
                MessageBox.Show("Información Registrada");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public void Almuerzo2(TextBox Txtidentificacion, Label lblfecha_actual, Label lblHora)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("almuerzo2", con);
            MySqlTransaction myTrans; // Iniciar una transacción local 
            myTrans = con.BeginTransaction(); // Debe asignar tanto el objeto de transacción como la conexión // al objeto de Comando para una transacción local pendiente 
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Identificacion", Txtidentificacion.Text);
                cmd.Parameters.AddWithValue("@_Fecha", lblfecha_actual.Text);
                cmd.Parameters.AddWithValue("@_Entrada_Almuerzo", lblHora.Text);
                cmd.ExecuteNonQuery();
                myTrans.Commit();
                MessageBox.Show("Información Registrada");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void Salida(TextBox Txtidentificacion, Label lblfecha_actual, Label lblHora)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("salida", con);
            MySqlTransaction myTrans; // Iniciar una transacción local 
            myTrans = con.BeginTransaction(); // Debe asignar tanto el objeto de transacción como la conexión // al objeto de Comando para una transacción local pendiente 
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Identificacion", Txtidentificacion.Text);
                cmd.Parameters.AddWithValue("@_Fecha", lblfecha_actual.Text);
                cmd.Parameters.AddWithValue("@_Salida", lblHora.Text);
                cmd.ExecuteNonQuery();
                myTrans.Commit();
                MessageBox.Show("Información Registrada");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void Informe_horario(DataGridView dgv_informes, DateTimePicker dtpinicio, DateTimePicker dtpfinal, ComboBox cmbEtapa)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("Informe_horario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_fecha_inicio", dtpinicio.Text);
                cmd.Parameters.AddWithValue("@_fecha_final", dtpfinal.Text);
                cmd.Parameters.AddWithValue("@_Etapa", cmbEtapa.Text);
                MySqlDataAdapter registro = new MySqlDataAdapter(cmd);
                registro.Fill(dt);
                dgv_informes.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("", ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
