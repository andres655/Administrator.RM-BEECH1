using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_Car
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //validadr Usuario y contraseña
            if (TxtUsuario.Text.Trim()=="admin" && TxtContraseña.Text.Trim()=="1234")
            {
                MessageBox.Show("Bienvenido!", "Bienvenida",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
