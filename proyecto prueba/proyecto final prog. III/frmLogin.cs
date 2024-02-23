using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proyecto_final_prog._III
{
    public partial class frmLogin : Form
    {
        //private Dictionary<string, string> users=new Dictionary<string, string>();
        private SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=Login;Integrated Security=True;");
        public frmLogin()
        {
            InitializeComponent();
            //agregar algunos usuarios de ejemplo al diccionario
            //users.Add("usuario 1","contraseña 1");
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //declaramos los textbox
            string usuario = txtUsuario.Text;
            string contraseña=txtContrasena.Text;

            connection.Open();

            // Consulta SQL para verificar las credenciales
            string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario=@Username AND Contraseña=@Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", usuario);
            command.Parameters.AddWithValue("@Password", contraseña);

            // Ejecutar la consulta y verificar el resultado
            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Inicio de sesión exitoso");
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }

            this.Hide();
            Form1 nuevoFormulario = new Form1();

            nuevoFormulario.ShowDialog();
            // Cerrar la conexión
            //connection.Close();
            this.Close();


        }
    }
}
