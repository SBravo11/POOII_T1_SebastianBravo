using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_Validaciones_Empleado.Models
{
    public class Validaciones : ValidationAttribute
    {
        protected override ValidationResult IsValid(object fechaNac, ValidationContext validationContext)
        {
            DateTime fechaActual = DateTime.Now;
            DateTime fecha = Convert.ToDateTime(fechaNac);
            string mensaje = string.Empty;

            if (fechaActual.Year - fecha.Year < 3)
            {
                mensaje = "Edad minima 3 años";
                return new ValidationResult(mensaje);
            }

            return ValidationResult.Success;
        }



    }
}