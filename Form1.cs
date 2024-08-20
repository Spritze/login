using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Alexsander William Spritze
namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeFotosDosCarros = Directory.GetFiles(@"C:\Users\Alexsandre Spritzer\OneDrive\Área de Trabalho\Linguagem de Programação\carros");
            //foreach Para cada, substitui o swhitch case...
            foreach (string img in nomeFotosDosCarros) 
            {
                string[] separador = img.Split('\\');
                string[] nomeCarro = separador[7].Split('.');

                if (comboBox2.Text == nomeCarro[0]) 
                {
                    pictureBox2.ImageLocation = @"C:\\Users\\Alexsandre Spritzer\\OneDrive\\Área de Trabalho\\Linguagem de Programação\\carros\" + comboBox2.Text + ".jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;
            if(comboBox1.Text == "Ferrari") 
            { 
                comboBox2.Items.Clear();
                comboBox2.Items.Add("SF90");
                comboBox2.Items.Add("SP-8");
            }
            else if (comboBox1.Text == "BMW") 
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("BMW-iX3");
                comboBox2.Items.Add("BMW");
            }
            else if(comboBox1.Text == "Bentley") 
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Bentley Continental GT");
                comboBox2.Items.Add("Bentley flying spur");
            }
            else if (comboBox1.Text == "Audi") 
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Série M");
                comboBox2.Items.Add("A3 Sportback");
            }
            else if (comboBox1.Text == "Aston Martin") 
            { 
                comboBox2.Items.Clear();
                comboBox2.Items.Add("DB12");
                comboBox2.Items.Add("Valhalla");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
