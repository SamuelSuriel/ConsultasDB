using Microsoft.Data.SqlClient;

namespace ConsultasDB.Forms
{
    public partial class frmConsultaBiblioteca : Form
    {
        public frmConsultaBiblioteca()
        {
            InitializeComponent();
        }

        private void frmConsultaBiblioteca_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text != "")
            {
                SqlConnection connetionString = new SqlConnection(@"server=SRSDELLI5; Database=BibliotecaDB; integrated security =True; TrustServerCertificate=True");
                connetionString.Open();

                int codigo = int.Parse(txtCodigo.Text);
                string query = "SELECT l.CodigoLibro, l.Titulo, l.CantidadPaginas, m.Materia " +
                                "FROM Libros l INNER JOIN Materias m on l.CodigoMateria = m.CodigoMateria " +
                                "WHERE CodigoLibro =" + codigo;

                SqlCommand comando = new SqlCommand(query, connetionString);
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    txtCodigoLibro.Text = registro["CodigoLibro"].ToString();
                    txtTitulo.Text = registro["Titulo"].ToString();
                    txtCantidadPaginas.Text = registro["CantidadPaginas"].ToString();
                    txtCodigoMateria.Text = registro["Materia"].ToString();
                }
                else
                {
                    MessageBox.Show("El código ingresado no existe!");
                }
                connetionString.Close();
            }
            else
            {
                MessageBox.Show("Ingrese un código para consultar!");
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCodigoLibro.Clear();
            txtTitulo.Clear();
            txtCantidadPaginas.Clear();
            txtCodigoMateria.Clear();
        }

        private void picbtnAbrirCrud_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUDLibrary cRUDLibrary = new CRUDLibrary();
            cRUDLibrary.Show();
        }
    }
}
