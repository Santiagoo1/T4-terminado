using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Persistencia_de_datos
{
    public partial class Form1 : Form
        
    {
        Lista lista { get; set; } = new Lista();
        public Form1()
        {
            InitializeComponent();
            Productos.DataSource = lista.DT;
            
        }
       
        private void productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.registrar(Nombreproducto.Text, System.Convert.ToInt32(Precioproducto.Text), System.Convert.ToInt32(CodigoProducto.Text));
           


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nombreproducto.Text = "";
            CodigoProducto.Text = "";
            Precioproducto.Text = "";
            
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
}
