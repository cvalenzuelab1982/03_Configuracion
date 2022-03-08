using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_WebApiAutores.Entidades
{
    public class AutorLibro
    {
        //Cuando se trata de tabla intermedia, las llaves primarias son como unico identificador
        //que en este caso es LibroId y AutorId son llaves compuesta
        public int LibroId { get; set; }
        public int AutorId { get; set; }
        public int Orden { get; set; }
        public Libro Libro { get; set; }
        public Autor Autor { get; set; }
    }
}
