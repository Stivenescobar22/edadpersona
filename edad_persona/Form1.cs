using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edad_persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Btncalcular_Click(object sender, EventArgs e)
        {

            string edad = txtedad.Text;

            int eddad = int.Parse(edad);

            if (eddad < 18){

                lblresp.Text = " Menor de Edad ";
                lblresp.Visible = true;


            } else {

                lblresp.Text = " Mayor de edad ";
                lblresp.Visible = true;


            }



        }
    }
}
