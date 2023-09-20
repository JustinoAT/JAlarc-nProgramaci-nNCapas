using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ML
{
    public class Usuario
    {
        [Required]
        public int IdUsuario { get; set; } //int
        [Required]
        [MinLength(4)]
        public string Nombre { get; set; } //varchar
        [MinLength(4)]
        [Required]
        [Display(Name="Apellido paterno")]
        public string ApellidoPaterno { get; set; }//varchar
        [MinLength(4)]
        [Required]
        [Display(Name = "Apellido materno")]
        public string ApellidoMaterno { get; set; }//varchar
        [Required]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; } //Date
        [Required]
        [MinLength(4)]
        public string UserName { get; set; }
        [Required]
        [MinLength(11)]
        public string Email { get; set; }
        [Required]
        [MinLength(4)]
        public string password { get; set; }
        [Required]
        [MinLength(1)]
        public string Sexo { get; set; }
        [Required]
        [StringLength(12)]
        [Phone]
        [MinLength(10)]
        public string Telefono { get; set; }
        [StringLength(12)]
        [Phone]
        [MinLength(10)]
        public string Celular { get; set; }
        [MinLength(18)]
        [MaxLength(18)]
        public string CURP { get; set; }
        public string Imagen { get; set; }
        [Required]
        public bool Status { get; set; }
        public List<object> Usuarios { get; set; }
        public ML.Direccion Direccion { get; set; }

        //Propiedad de navegacion
        public ML.Rol Rol { get; set; }
        





    }
}
 