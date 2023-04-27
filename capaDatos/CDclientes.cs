using capaEntidad;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace capaDatos
{
    public class CDclientes
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MysqlConn"].ConnectionString);
      
        public void probarConnexion()
        {

            try
            {
                conn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("problema" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
       

      

        public DataSet listatCliente()
        {
            string qry = "SELECT idCliente, nombre, apellido, foto FROM clientes" ;
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter DA= new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            DA.Fill(dt, "tbl");

            return dt;

        }

        public void crearCliente( CEclientes cl)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_crearCliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom", cl.nombreC);
                cmd.Parameters.AddWithValue("@ape", cl.apellidoC);
                cmd.Parameters.AddWithValue("@foto", cl.foto);
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Completado exitoso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al insertar datos" + ex);
            }
            finally
            {
                conn.Close();
            }

        }
        

        public void ActualizarCliente(CEclientes cl)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarCliente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", cl.id);
                cmd.Parameters.AddWithValue("@nom", cl.nombreC);
                cmd.Parameters.AddWithValue("@ape", cl.apellidoC);
                cmd.Parameters.AddWithValue("@foto", cl.foto);
                if(conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar datos" + ex);

            }
            finally
            {
                conn.Close();
            }
        }

        public void EliminarCliente(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_eliminarCliente", conn);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado ");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al Eliminar datos" + ex);
                
            }
            finally
            {
                conn.Close();
            }
        }
        

    }
}