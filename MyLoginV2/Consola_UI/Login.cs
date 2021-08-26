using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consola_UI
{
    public partial class frmLogin : Form
    {
        Domain.LoginDomain objD = new Domain.LoginDomain();
        BLL.LoginBLL objB = new BLL.LoginBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            objD.usu1 = txtusuario.Text;
            objD.pass1 = txtpassword.Text;

            dt = objB.N_Login(objD);

            if(dt.Rows.Count > 0)
            {
                objD.usu1 = dt.Rows[0][0].ToString();
                objD.pass1 = dt.Rows[0][1].ToString();
                MessageBox.Show("Mensaje", "Bienvenido al Sistema: " + objD.usu1);

                this.Hide(); //Luego de loguearme oculto el formulario login

                frmPrincipal principal = new frmPrincipal();
                principal.Show();

            }
            else
            {
                MessageBox.Show("Mensaje", "Usiario/Contraseña incorrecta");
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
