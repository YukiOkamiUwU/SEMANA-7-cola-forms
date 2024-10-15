using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMANA_7
{
    public partial class Form1 : Form
    {
        Cola colita=new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//Encolar
        {
            lstbox.Items.Clear();
            colita.Encolar(int.Parse(txtnuevo.Text));
            txtnuevo.Clear();
            txtnuevo.Focus();
        }

        private void button3_Click(object sender, EventArgs e)//DESENCOLAR
        {
            colita.DesEncolar();
            lstbox.Items.Clear();
            colita.Listar(lstbox);
           
        }

        private void button1_Click(object sender, EventArgs e) //LISTAR
        {
            lstbox.Items.Clear();
            colita.Listar(lstbox);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool rpta= true;
            
            if (colita.Buscar(int.Parse(txtnuevo.Text))==rpta)
            {
                MessageBox.Show("Dato encontrado :D");
            }
            else { MessageBox.Show("DATO NO ENCONTRADO"); }
        }

        private void txtmodifica_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lstbox.Items.Clear();   
            colita.Modificar(int.Parse(txtnuevo.Text), int.Parse(txtmodifica.Text));
            colita.Listar(lstbox);
            txtmodifica.Clear();
            txtnuevo.Clear();
            txtnuevo.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            colita.Contar();
            lstbox.Items.Clear();
        }
    }
}
