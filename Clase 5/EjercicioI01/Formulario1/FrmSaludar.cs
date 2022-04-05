using Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario1
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.txtApellido.Text) && !string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                FrmSaludo formSaludo = new FrmSaludo("¡Hola, Windows Forms!", $"Soy {this.txtNombre.Text} {this.txtApellido.Text} y mi materia favorita es {this.cmbMateriaFavorita.Text}.");
                formSaludo.ShowDialog();

            }else
            {
                MessageBox.Show($"Se debe completar los siguientes campos: \n{this.txtNombre.Name}\n{this.txtApellido.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSaludar_Load(object sender, EventArgs e)
        {
            this.cmbMateriaFavorita.Items.Add("Programacion I");
            this.cmbMateriaFavorita.Items.Add("Laboratorio I");
            this.cmbMateriaFavorita.SelectedIndex = 0; //Indice definido = 0
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblError.Visible = false;
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                this.lblError.Visible = true;
            }
        }
    }
}
