using _01_WebApiAutores.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _01_WebApiAutores.DTOs
{
    public class LibroCreacionDTO
    {
        [PrimeraLetraMayuscula]
        [StringLength(maximumLength: 120, ErrorMessage = "El campo {0} no debe tener más de {1} caracteres")]
        [Required]
        public string Titulo { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public List<int> AutoresIds { get; set; }
    }
}
