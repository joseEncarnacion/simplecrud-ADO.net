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


        private void InsertarDatos()
        {

        }

        private void listarDatos() { 
            DataSet ds =clienteNeg.listarCliente();
            dtaGridClientes.DataSource= ds.Tables["tbl"];
        }

        private void LimpiarInputs()
        {
            txtApellidos.Text= string.Empty;    
            txtNombre.Text= string.Empty;   
        }

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

            clienteNeg.CrearCliente(clienteEntidad);


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
            txtNombre.Text = dtaGridClientes.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellidos.Text = dtaGridClientes.CurrentRow.Cells["apellido"].Value.ToString();
            pxbox.Load(dtaGridClientes.CurrentRow.Cells["foto"].Value.ToString());  
            
        }
    }
}