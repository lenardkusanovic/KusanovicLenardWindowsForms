using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KusanovicLenardRichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // poziv funkcije SaveFile() za spremanje sadržaja richTextBox-a
            // u dokumentu, uz navodjenje točno određenog mjesta
            richTextBox1.SaveFile(@"C:Tempproba.rtf");
            MessageBox.Show("Tekst spremljen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // poziv funkcije LoadFile() za učitavanje tekst dokumenta
            // u richTextBox
            richTextBox1.LoadFile(@"C:Tempproba.rtf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // poziv funkije Clear() za brisanje sadržaja richTextBox-a
            richTextBox1.Clear();

        }
    }
}
