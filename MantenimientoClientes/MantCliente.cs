using capaEntidad;
using capaNegocio;
using System.Data;

namespace MantenimientoClientes
{
    public partial class MantCliente : Form
    {
        public MantCliente()
        {
            InitializeComponent();
        }

        CEclientes clienteEntidad= new CEclientes();
        CNcliente clienteNeg = new CNcliente();
        int idclient;
        bool existe;


        private void InsertarDatos()
        {

        }

        //Listar clientes
        private void listarDatos() { 
            DataSet ds =clienteNeg.listarCliente();
            dtaGridClientes.DataSource= ds.Tables["tbl"];
        }

        //limpiar los inputs
        private void LimpiarInputs()
        {
            txtApellidos.Text= string.Empty;    
            txtNombre.Text= string.Empty;   
        }

        //Evento guardar datos
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            bool resp;
           
            clienteEntidad.nombreC = txtNombre.Text;   
            clienteEntidad.apellidoC = txtApellidos.Text;
            clienteEntidad.foto = pxbox.ImageLocation;


            resp = clienteNeg.ValidacionesClientes(clienteEntidad);

            if(resp == false)
            {
                return;
            } 

            if (!existe)
            {
                clienteNeg.CrearCliente(clienteEntidad);
            }
            else
            {
                clienteEntidad.id = idclient;
                clienteNeg.CN_ActualizarCliente(clienteEntidad);
            }
            listarDatos();
            LimpiarInputs();
        }




        //Buttons para ir a la lista
        private void btnNavSlist_Click(object sender, EventArgs e)
        {
           panelViewCliente.Visible = true;

            
        }




        private void linkSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDfoto.FileName = string.Empty;
            if (fileDfoto.ShowDialog() == DialogResult.OK)
            {
                pxbox.Load(fileDfoto.FileName);
            }

            fileDfoto.FileName= string.Empty;

        }

        private void btnNavForm_Click(object sender, EventArgs e)
        {
            panelViewCliente.Visible = false;
        }

        private void MantCliente_Load(object sender, EventArgs e)
        {
            listarDatos();
        }

        private void dtaGridClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idclient = (int)dtaGridClientes.CurrentRow.Cells["idCliente"].Value;
           
            txtNombre.Text = dtaGridClientes.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellidos.Text = dtaGridClientes.CurrentRow.Cells["apellido"].Value.ToString();
            pxbox.Load(dtaGridClientes.CurrentRow.Cells["foto"].Value.ToString());
           
            if ((int)dtaGridClientes.CurrentRow.Cells["idCliente"].Value > 0)
            {
                existe = true;
                panelViewCliente.Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Eliminar el resgistro?","Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //clienteEntidad.id = idclient;
                MessageBox.Show(idclient +"");
                clienteNeg.CN_ElimnarCliente(idclient);
            }

            listarDatos();
        }
    }
}