using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class GestionUsuarioForm : Form
    {
        public GestionUsuarioForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            AltaUsuarioForm altaUsuarioForm = new AltaUsuarioForm();
            altaUsuarioForm.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuarioForm modificarUsuarioForm = new ModificarUsuarioForm();
            modificarUsuarioForm.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
