using Microsoft.AspNetCore.Mvc;

namespace EjerciciosApi.Controllersq
{
    [Route("api/[controller]")]
    public class EjerParImparController : ControllerBase
    {
        [HttpGet]
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
        [HttpDelete]
        public ActionResult<string> EliminarNumero(int numero)
        {
            if (numero % 2 == 0) 
            {
                return Ok($"Número {numero} que es PAR fué eliminado correctamente.");
            }
            else
            {
                return Ok($"Número {numero} que es IMPAR fué eliminado correctamente.");
            }
            
        }
        [HttpPut]
        public ActionResult<string> ActualizarNumero(int numero)
        {
            if(numero % 2 == 0)
            {
                return Ok($"Número {numero} que es PAR fué actualizado correctamente.");
            }
            else
            {
                return Ok($"Número {numero} que es IMPAR fué actualizado correctamente.");
            }
        }
    }
}
