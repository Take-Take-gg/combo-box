using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboalimentos.Items.Add("pazza");
            comboalimentos.Items.Add("abzta");
                
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboalimentos.SelectedIndex;
            label1.Text = indice.ToString();
            label2.Text = comboalimentos.Items[indice].ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            comboalimentos.Items.Add(BoxFood.Text);
        }
    }
}