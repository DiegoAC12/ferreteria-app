using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Invocar el metodo
            mostrarMensaje();
        }
        /*
         * Metodo mostrar mensaje
         */
        public void mostrarMensaje()
        {
            //Crear un objeto de la calse Car
            Car objcar = new Car();
            string msj = objcar.stop();
            LblMensaje.Text = msj;
        }
    }
}