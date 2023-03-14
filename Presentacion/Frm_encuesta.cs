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
    public partial class Frm_encuesta : Form
    {
        public Frm_encuesta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            string Resultado;
            string ResultadoClase;

            Resultado = "";
            ResultadoClase = "";

            if (chk_vfp.Checked == true )
            {
                //Resultado= Resultado + chk_vfp.Text;
                //lo de arriba es lo mismo que de abajo pero resumido.
                Resultado += chk_vfp.Text + "\r\n";
            }

            if (chk_csharp.Checked == true)
            {
                Resultado += chk_csharp.Text + "\r\n";

            }

            if (chk_vbnet.Checked == true)
            {
                Resultado += chk_vbnet.Text + "\r\n";
            }

            if (chk_java.Checked == true)
            {
                Resultado += chk_java.Text + "\r\n";
            }

            //Evaluando proceso de seleccion del radio button
            if (rdb_presencial.Checked == true)
            {
                ResultadoClase = rdb_presencial.Text ;
            }
            else
            {
                ResultadoClase =  rdb_virtual.Text ;
            }
            txt_resultado.Text = Resultado +  "Las clases se impartiran de forma: " + ResultadoClase ;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_java_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
