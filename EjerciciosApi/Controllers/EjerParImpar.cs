using Microsoft.AspNetCore.Mvc;

namespace EjerciciosApi.Controllersq
{
    [Route("api/[controller]")]
    public class EjerParImparController : ControllerBase
    {
        [HttpGet("{numero}")]
        public ActionResult<string> VerificarParImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                return Ok($"El número {numero} es par.");
            }
            else
            {
                return Ok($"El número {numero} es impar.");
            }
        }
        [HttpDelete("{numero}")]
        public ActionResult<string> EliminarNumero(int numero)
        {
            return Ok($"Número {numero} eliminado correctamente.");
        }
        [HttpPut("{numero}")]
        public ActionResult<string> ActualizarNumero(int numero)
        {
            return Ok($"Número {numero} actualizado correctamente.");
        }
    }
}



       

