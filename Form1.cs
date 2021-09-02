using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel_1._1
{
    public partial class frmExempel1_1 : Form
    {

        /* Gjord av Tobias Lindberg 2021-08-30 */
        public frmExempel1_1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            //Omvandla till int
            int tal1 = ParseToInt(tbxTal1.Text);
            int tal2 = ParseToInt(tbxTal2.Text);

            //Addera
            int summa = tal1 + tal2;

            //Omvandla summan till sträng och visa svaret
            tbxSumma.Text = summa.ToString();
        }

        private int ParseToInt(string text)
        {
            int tal = 0;

            //Börja med värdet av entalet
            int positionsvärde = 1;
            
            //"Parsa" texten och beräkna tal
            for(int i = text.Length-1; i >= 0; i--)
            {
                int teckenvärde = text[i] - 48;
                tal += teckenvärde * positionsvärde;
                positionsvärde *= 10;
            }

            return tal;
        }
    }


}
