using Colegio.RequestResponse;
using Microsoft.AspNetCore.Mvc;
namespace Colegio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        /*[HttpGet]
        public IActionResult listarPersonas()
        {
            return Ok();
        }*/
        [HttpGet()]
        public ActionResult<List<PersonaResponse>> listarPersona2()
        {
            List<PersonaResponse> resultado = new List<PersonaResponse>();
            /*for (int i = 0; i < 11; i++)
            {
                PersonaResponse tmp = new PersonaResponse();
                tmp.Nombre = $"Nombre {contador}";
                tmp.ApellidoPaterno = $"ApellidoPaterno {contador}";
                tmp.ApellidoMaterno = $"ApellidoMaterno {contador}";
                tmp.Direccion = $"Direccion {contador}";
                tmp.FechaNacimiento = DateTime.Now.AddYears(-(contador + 1) * 3);
                resultado.Add(tmp);
            }*/
            int contador = 0;
            /*while (contador < 11)
            {
                PersonaResponse tmp = new PersonaResponse();
                tmp.Nombre = $"Nombre {contador}";
                tmp.ApellidoPaterno = $"ApellidoPaterno {contador}";
                tmp.ApellidoMaterno = $"ApellidoMaterno {contador}";
                tmp.Direccion = $"Direccion {contador}";
                tmp.FechaNacimiento = DateTime.Now.AddYears(-(contador + 1) * 3);
                resultado.Add(tmp);
                contador++;
            }*/
            do
            {
                PersonaResponse tmp = new PersonaResponse();
                tmp.Nombre = $"Nombre {contador}";
                tmp.ApellidoPaterno = $"ApellidoPaterno {contador}";
                tmp.ApellidoMaterno = $"ApellidoMaterno {contador}";
                tmp.Direccion = $"Direccion {contador}";
                tmp.FechaNacimiento = DateTime.Now.AddYears(-(contador + 1) * 3);
                resultado.Add(tmp);
                contador++;
            } while (contador < 11);
            resultado.Add(new PersonaResponse() { Nombre = "Edgardo", ApellidoPaterno = "Huaricapcha", ApellidoMaterno = "berrocal", Direccion = "direccion", FechaNacimiento = DateTime.Now.AddYears(-18) });
            return Ok(resultado);
        }
    }
}