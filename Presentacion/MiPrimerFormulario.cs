using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MiPrimerFormulario : Form
    {
        public MiPrimerFormulario()
        {
            InitializeComponent();
        }

        private void MiPrimerFormulario_Load(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //para limpiar
            txt_codigo.Text = "";
            txt_descripcion.Text = "";
            //para habilitar las casillas
            txt_codigo.Enabled = true;
            txt_descripcion.Enabled = true;
            //para hacer focus a txt_codigo
            txt_codigo.Focus();

        }
    }
}
