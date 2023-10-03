using ConsultasDB.Clases;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ConsultasDB.Forms
{
    public partial class CRUDLibrary : Form
    {
        CD_Conexion conexion = new CD_Conexion();
        CD_Libros CD_Libros = new CD_Libros();

        private string? idLibro = null;
        private bool EsEditar = false;
        public CRUDLibrary()
        {
            InitializeComponent();
        }

        private void CRUDLibrary_Load(object sender, EventArgs e)
        {
            MostrarBibioteca();
            LimpiarCampos();
            LlenarComboBox(cbMaterias, "Select * From Materias", "CodigoMateria", "Materia");
        }

        private void LlenarComboBox(ComboBox combo, string strSql, string id, string desc)
        {
            DataTable tabla = new DataTable();
            conexion.AbrirConexion();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conexion.Conexion);
            da.Fill(tabla);
            combo.ValueMember = id;
            combo.DisplayMember = desc;
            combo.DataSource = tabla;
            conexion.CerrarConexion();

        }

        private void MostrarBibioteca()
        {
            dgvBiblioteca.DataSource = CD_Libros.MostrarLibros();
            this.dgvBiblioteca.Columns["CodigoMateria"].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvBiblioteca.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtTituloIn.Text = dgvBiblioteca.CurrentRow.Cells["Titulo"].Value.ToString();
                txtCantidadPaginasIn.Text = dgvBiblioteca.CurrentRow.Cells["Páginas"].Value.ToString();
                cbMaterias.Text = dgvBiblioteca.CurrentRow.Cells["Materia"].Value.ToString();
                idLibro = dgvBiblioteca.CurrentRow.Cells["CodigoLibro"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una celda para editar!");


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {

                string Titulo = txtTituloIn.Text;
                string paginas = txtCantidadPaginasIn.Text;
                int idMateria = (int)cbMaterias.SelectedValue;

                if (EsEditar == false)
                {
                    try
                    {
                        CD_Libros.InsertarLibro(Titulo, Convert.ToInt32(paginas), idMateria);
                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        LimpiarCampos();
                        MostrarBibioteca();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo realizar la operación: " + ex);
                    }
                }
                if (EsEditar == true)
                {
                    try
                    {
                        int id = Convert.ToInt32(idLibro);
                        CD_Libros.EditarLibro(Convert.ToInt32(id), Titulo, Convert.ToInt32(paginas), idMateria);
                        MessageBox.Show("Se editó correctamente!");
                        LimpiarCampos();
                        MostrarBibioteca();
                        EsEditar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo realizar la operación: " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos!");
            }
        }

        private bool EsValido()
        {
            bool materia = cbMaterias.Text != "";
            bool titulo = txtTituloIn.Text != "";
            bool paginas = txtCantidadPaginasIn.Text != "";

            if (materia && titulo && paginas)
                return true;
            else
                return false;
        }

        private void LimpiarCampos()
        {
            txtTituloIn.Clear();
            txtCantidadPaginasIn.Clear();
            cbMaterias.SelectedValue = 0;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvBiblioteca.SelectedCells.Count > 0)
            {

                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idLibro = dgvBiblioteca.CurrentRow.Cells["CodigoLibro"].Value.ToString();

                    CD_Libros.EliminarLibro(Convert.ToInt32(idLibro));
                    MessageBox.Show("Se eliminó correctamente!");
                    MostrarBibioteca();
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");

        }

        private void picbtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
