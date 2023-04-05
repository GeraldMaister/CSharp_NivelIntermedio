using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        //inicio de mis variable 

        // para saber si va actualizar o un nuevo registro
        int NestadoGuarda = 0;

        private void MiPrimerFormulario_Load(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //añade registro si tiene un 1
            NestadoGuarda = 1;
            //cuando entres a nuevo la lista se deshabilita
            lst_mantenimiento.Enabled = false;

            //para limpiar
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            //se habilita groupbox de mantenimiento y se quitan los botones principales.
            grb_mantenimiento.Enabled = true;
            txt_codigo.Enabled = Enabled;
            grb_botones_principales.Enabled = false;

            //comienza desde el txt de codigo, es el principal tag.
            txt_codigo.Focus();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //para limpiar los txts
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            //cuando canceles se habiliten los botones y se quite el groupbox mantenimiento.
            grb_mantenimiento.Enabled = false;
            grb_botones_principales.Enabled = true;

            //se habilita la lista de mantenimiento.
            lst_mantenimiento.Enabled = true;


        }



        private void btn_guardar_Click_1(object sender, EventArgs e)
        {

            string Registro;
            //este if para que tenga que poner 3 digitos en el codigo.
            if (txt_codigo.Text.Trim().Length != 3)
            {
                MessageBox.Show("Ingrese 3 digitos en el Codigo");
            }

            else
            {
                Registro = txt_codigo.Text.Trim() + " | " + txt_descripcion.Text.Trim();

                if (NestadoGuarda == 1)
                {
                    //nuevo registro
                    lst_mantenimiento.Items.Add(Registro);

                    lst_mantenimiento.Enabled = true;

                    MessageBox.Show("Datos guardados");


                    txt_codigo.Text = "";
                    txt_descripcion.Text = "";

                    grb_mantenimiento.Enabled = false;
                    grb_botones_principales.Enabled = true;

                }
                //actualizar registro
                else
                {
                    int ElementoSeccionado = lst_mantenimiento.SelectedIndex;

                    lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);

                    lst_mantenimiento.Items.Insert(ElementoSeccionado, Registro);



                    grb_mantenimiento.Enabled = false;
                    grb_botones_principales.Enabled = true;
                    lst_mantenimiento.Enabled = true;

                }




            }


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            


            if (MessageBox.Show("Desea eliminar el elemento seleccionado?", "Eliminar",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

               
                lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);

                MessageBox.Show("Elemento eliminado");


            }

            else
            {
                MessageBox.Show("No se elimino el elemento");
            }

            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;
            grb_botones_principales.Enabled = true;






          


        }

        private void lst_mantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_mantenimiento_Click(object sender, EventArgs e)
        {
            string TextoSeleccionado;
            int LongitudTexto;

            TextoSeleccionado= lst_mantenimiento.SelectedItem.ToString().Trim();
            LongitudTexto= TextoSeleccionado.Length;
            txt_codigo.Text = TextoSeleccionado.Substring(0,3);
            txt_descripcion.Text = TextoSeleccionado.Substring(6,LongitudTexto-6);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            NestadoGuarda = 2; //actualiza registro si tiene un 2

            grb_mantenimiento.Enabled = true;
            txt_codigo.Enabled = false;
            grb_botones_principales.Enabled = false;
            lst_mantenimiento.Enabled = false;

            txt_codigo.Focus();
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
