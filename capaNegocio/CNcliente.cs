using capaDatos;
using capaEntidad;
using System.Data;

namespace capaNegocio
{
    public class CNcliente
    {

        CDclientes clientes = new CDclientes(); 


        public bool ValidacionesClientes(CEclientes cl)
        {
            bool resp = true;

            if(cl.nombreC == string.Empty)
            {
                resp = false;
                MessageBox.Show("No campus Empty acepted");

            }

            if(cl.apellidoC == string.Empty)
            {
                resp = false;
                MessageBox.Show("No campus Empty acepted");
            }

            if (cl.foto == null)
            {
                resp = false;
                MessageBox.Show("No campus Empty acepted");
            }

            return resp;


        }

        public void Prueba()
        {
            
            clientes.probarConnexion();


        }

        //crear clientes
        
        public void CrearCliente(CEclientes cl)
        {
            clientes.crearCliente(cl);
        }

        public DataSet listarCliente()
        {
            
            return  clientes.listatCliente();
        }

        public void CN_ActualizarCliente(CEclientes cl)
        {
            clientes.ActualizarCliente(cl);

        }

        public void CN_ElimnarCliente(int id)
        {
            clientes.EliminarCliente(id);
        }

        

    }
}