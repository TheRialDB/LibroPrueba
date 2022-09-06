using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroBoludo
{
    public partial class FormLibroBoludo : Form
    {
        List<Libro> listLibro = new List<Libro>();
        List<string> listaCodigos = new List<string>();

        int libroVocal = 0;
        int libroCons = 0; 
        int libroNum = 0;

        const string ERROR_CODIGO_EXISTE = "Código existente, ingrese uno nuevo.";

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

            //var libro = new Libro()
            //{
            //    Codigo = txtCode.Text,
            //    Titulo = txtTitle.Text,
            //    Autor = txtAuthor.Text,
            //};

            if (listaCodigos.Contains(libro.Codigo))
            {
                MessageBox.Show(ERROR_CODIGO_EXISTE);
            }
            else
            {
                listaCodigos.Add(libro.Codigo);
                listLibro.Add(libro);

                dgvBook.DataSource = null;
                dgvBook.DataSource = listLibro;

                var titulo = libro.Titulo.ToLower();

                if (Regex.IsMatch(titulo, @"^[a,e,i,o,u]"))
                {
                    libroVocal++;
                }
                else if (Regex.IsMatch(titulo, @"^\d"))
                {
                    libroNum++;
                }
                else
                {
                    libroCons++;
                }

                lblVocales.Text = libroVocal.ToString();
                lblNumeros.Text = libroNum.ToString();
                lblConso.Text = libroCons.ToString();
            }

            
        }
    }
}
