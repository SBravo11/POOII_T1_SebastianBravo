using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace POOII_T1_SebastianBravo.Models
{
    public class Alumno
    {
        [Display(Name="Alumno Id")]public int Id { get; set; }
        [Display(Name="Nombre")]public string Name { get; set; }
        [Display(Name="Apellido")]public string LastName { get; set; }
        [Display(Name="DNI")]public string DNI { get; set; }
        [Display(Name="Dia de Registro")]public DateTime RegisterDate { get; set; }
        [Display(Name="Fecha de Nacimiento")]public DateTime Birthday { get; set; }
        [Display(Name="Telefono")]public string Cellphone { get; set; }
        [Display(Name="Direccion")]public string Address { get; set; }
    }
}