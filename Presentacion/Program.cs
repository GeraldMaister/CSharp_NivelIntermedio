using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MiPrimerFormulario());

            /*Click derecho en presentacion, add, crear form.
             * Control+alt+x = para sacar el toolbox
             * El form que se va ejecutar primero colocarlo en el program.cs ej: Application.Run(new NOMBREFORM());
             * en propiedades, text = para cambiar el nombre del formulario.
             * backcolor: para cambiar el fondo
             * startposition: para poner default como quiere que empieze el tamaño.
             * windowstate: para indicarle que inicie maximizada, minimizada o normal.
             * forecolor: para cambiar el color del texto
             * Font: para cambiar la fuente del texto
             * IMG: para añadirle una imagen al boton o al cuerpo.
             * rayito que esta en las propiedades: sirve para poner acciones a los botones etc...ara 
             * click: para poner una funcion cucando se le de click
             * xt_descripcion.Text = ""; para que ponga lo que esta en la comilla.
             * txt_codigo.Select(); select para que el cursos se llama ahi cuando accione el click.
             * txt_codigo.focus(); este mejor, para que el cursos se llama ahi cuando accione el click
             * tabIndex: el orden de tabulacion que llevara.
             * Enable: sirve para habilidad y deshabilidad el textbox o boton etc...
             * MaxLength: para poner el maximo de caracteres permitidos.
             * Radio buttton: si seleccionas uno no sirve el otro.
             * "\r\n";" para colocar las cosas en columna.
             * propiedad visible: para que esten oculto o que aparezcan.
             * propiedad flatStyle: para dar estilo a los objeto.
             * contenedores: groupBox: 
             * listbox: para guaradr listas de elementos con: 
               string Registro;
               Registro = txt_codigo.Text + " " + txt_descripcion.Text;
               lst_mantenimiento.Items.Add(Registro);
             * Para eliminar: 
               lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItems);
             * MessageBox.Show("informacion"); sirve para que un cuadro de un msj.
             * 
             * 
             */
           
        }
    }
}
