using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroBoludo
{
    public class Libro
    {   
        private string codigo;
        private string titulo;
        private string autor;

        //constructor vacio
        public Libro()
        {

        }
        //constructor con parametros
        public Libro(string codigo, string titulo, string autor)
        {
           this.codigo = codigo;
           this.titulo = titulo;
           this.autor = autor;
        }

        public string Codigo
        { 
            get { return codigo; } 
            set { codigo = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

    }
}
