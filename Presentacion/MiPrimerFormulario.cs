﻿using System;
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

        private void MiPrimerFormulario_Load(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //para limpiar
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = true;

            /*
            //para habilitar las casillas
            txt_codigo.Enabled = true;
            txt_descripcion.Enabled = true;

            //para que los botones aparezcan cuando se le de a nuevo
            btn_cancelar.Visible= true;
            btn_guardar.Visible= true;
            */
            grb_botones_principales.Enabled = false;
            /*
            btn_nuevo.Enabled = false;
            btn_reporte.Enabled = false;
            btn_salir.Enabled = false;
            btn_actualizar.Enabled = false; 
            */

            //para hacer focus a txt_codigo
            txt_codigo.Focus();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;
            grb_botones_principales.Enabled = true;

            /*btn_nuevo.Enabled = true;
            btn_reporte.Enabled = true;
            btn_salir.Enabled = true;
            btn_actualizar.Enabled = true;*/
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            string Registro;
            if (txt_codigo.Text.Trim().Length != 3)
            {
                MessageBox.Show("Ingrese 3 digitos en el Codigo");
            }

            else
            {
                Registro = txt_codigo.Text.Trim() + " | " + txt_descripcion.Text.Trim();
                lst_mantenimiento.Items.Add(Registro);

                MessageBox.Show("Datos guardados");


                txt_codigo.Text = "";
                txt_descripcion.Text = "";

                grb_mantenimiento.Enabled = false;
                grb_botones_principales.Enabled = true;


            }


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);

            MessageBox.Show("Elemento Eliminado");
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
    }
}
