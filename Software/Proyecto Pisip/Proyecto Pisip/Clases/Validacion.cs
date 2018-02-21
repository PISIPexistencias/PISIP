using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pisip.Clases
{
    public class Validacion
    {
        public void sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    //permite escribir si es letra
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    //permite borrar la letra o retroceder
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    //permite espacios
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void soloNumero(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    //permite escribir si es letra
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    //permite borrar la letra o retroceder
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    //permite espacios
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    //permite escribir punto y comas
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
