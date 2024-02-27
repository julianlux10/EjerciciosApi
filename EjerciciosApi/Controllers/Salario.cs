using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EjerciciosApi.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class SalarioController : ControllerBase
    {
        [HttpPost]
        public ActionResult<object> CalculoSueldo(DatosInicio datos)
        {
            if (datos != null && !string.IsNullOrEmpty(datos.Nombre) &&
                int.TryParse(datos.Hora, out int Hora) && Decimal.TryParse(datos.Valor, out decimal Valor))
            {
                if (Hora <= 0 || Valor <= 0)
                {
                    return BadRequest(new { error = "Parámetros no válidos" });
                }

                decimal Total = Hora * Valor;
                return Ok(new { total = Total });
            }

            return BadRequest(new { error = "Datos de entrada no válidos" });
        }
    }

    public class DatosInicio
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        [RegularExpression("[a-zA-Z ]+$", ErrorMessage = "No cumple con los parámetros mínimos")]
        [DefaultValue("Nombre del Empleado")]
        public string Nombre { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "Solo números positivos son aceptados")]
        [DefaultValue("Hora de trabajo")]
        public string Hora { get; set; }

        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})?$", ErrorMessage = "Solo números positivos para el valor")]
        [DefaultValue("Valor de trabajo")]
        public string Valor { get; set; }
    }
}
