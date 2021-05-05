using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Clear() {
            textBox1.Clear();
        }

        List<String> datos = new List<String>();
        void Cargar() {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < datos.Count; i++) {
                dataGridView1.Rows.Add(datos[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos.Add(textBox1.Text);
            Cargar();
            Clear();
        }
    }
}
