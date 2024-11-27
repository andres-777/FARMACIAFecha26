using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Manejo_Formulario
    {
        public void Btn_Siguiente(Panel panel2,Panel panel3,Panel panel4,Button boton_Anterior, Button boton_Siguiente)
        {
            if (panel2.Visible == false && panel3.Visible == false && panel4.Visible == false)
            {
                panel2.Visible = true;
                boton_Anterior.Visible = true;
            }

            else if (panel2.Visible == true && panel3.Visible == false && panel4.Visible == false)
            {
                panel3.Visible = true;
            }

            else if (panel2.Visible == true && panel3.Visible == true && panel4.Visible == false)
            {
                panel4.Visible = true;
                boton_Siguiente.Visible = false;
            }
        }
        public void Btn_Anterior(Panel panel2, Panel panel3, Panel panel4, Button boton_Anterior, Button boton_Siguiente)
        {
            if (panel4.Visible == true && panel3.Visible == true && panel2.Visible == true)
            {
                panel4.Visible = false;
                boton_Siguiente.Visible = true;
            }

            else if (panel4.Visible == false && panel3.Visible == true && panel2.Visible == true)
            {
                panel3.Visible = false;
            }

            else if (panel4.Visible == false && panel3.Visible == false && panel2.Visible == true)
            {
                panel2.Visible = false;
                boton_Anterior.Visible = false;
            }
        }
    }

}
