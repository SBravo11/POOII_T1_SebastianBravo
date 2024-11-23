using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebApplication_Validaciones_Empleado.Models;

namespace POOII_T1_SebastianBravo.Models
{
    public class Alumno
    {
        [Display(Name="Alumno Id")]
        public int Id { get; set; }
        [Display(Name="Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese el nombre")]
        public string Name { get; set; }
        [Display(Name="Apellido")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese el apellido")]
        public string LastName { get; set; }
        [Display(Name="DNI")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese DNI")]
        public string DNI { get; set; }
        [Display(Name="Dia de Registro")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese fecha de registro")]
        public DateTime RegisterDate { get; set; }
        [Display(Name="Fecha de Nacimiento")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese fecha nacimiento")]
        [Validaciones] 
        public DateTime Birthday { get; set; }
        [Display(Name="Telefono")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese el telefono")]
        public string Cellphone { get; set; }
        [Display(Name="Direccion")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese la direccion")]
        public string Address { get; set; }
    }
}