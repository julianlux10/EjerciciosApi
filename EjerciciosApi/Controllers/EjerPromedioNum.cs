using Microsoft.AspNetCore.Mvc;

namespace EjerciciosApi.Controllers
{
    public class Numeros
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Numero3 { get; set; }
    }

    [Route("api/[controller]")]
    public class EjerPromedioNum : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> VerificarPromedio([FromBody] Numeros numeros)
        {
            if (numeros == null || numeros.Numero1 <= 0 || numeros.Numero2 <= 0 || numeros.Numero3 <= 0)
            {
                return BadRequest("Se esperan tres números positivos mayores a cero.");
            }
            else
            {
                var total = (numeros.Numero1 + numeros.Numero2 + numeros.Numero3) / 3;

                var totalDecimales = total.ToString("0.00");

                return Ok($"El promedio total es {totalDecimales}.");
            }
        }
    }
}
