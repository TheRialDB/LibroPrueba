using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroBoludo
{
    public partial class FormLibroBoludo : Form
    {
        List<Libro> listLibro = new List<Libro>();

        int libroVocal = 0;
        int libroCons = 0;

        public FormLibroBoludo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();

            libro.Codigo = txtCode.Text;
            libro.Titulo = txtTitle.Text;
            libro.Autor = txtAuthor.Text;

            //var libro2 = new Libro()
            //{
            //    Codigo = txtCode.Text,
            //    Titulo = txtTitle.Text,
            //    Autor = txtAuthor.Text,
            //};

            listLibro.Add(libro);

            dgvBook.DataSource = null;
            dgvBook.DataSource = listLibro;

            var titulo = libro.Titulo.ToLower();

            bool cond = titulo.StartsWith("a") || titulo.StartsWith("e")
                || titulo.StartsWith("i") || titulo.StartsWith("o") || titulo.StartsWith("u");

            if (cond)
            {
                libroVocal ++;
            }
            else
            {
                libroCons ++;
            }

            lblVocales.Text = libroVocal.ToString();
            lblConso.Text = libroCons.ToString();
        }
    }
}
