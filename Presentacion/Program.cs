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
             */
        }
    }
}
