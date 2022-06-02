using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiCsharp.Models;

namespace WebApiCsharp.Controllers
{
    public class VeiculosController : ApiController
    {

        public static List<Veiculos> listaVeiculos = new List<Veiculos>();

        #region Métodos 

        [HttpGet]
        [Route("api/veiculos/popular")]
        public JObject Popular()
        {
            listaVeiculos.Add(new Veiculos(1, "FORD FIESTA", "1.0 MPI PERSNNALITÉ SEDAN 4P", 2005, 2005,
                "Preto", 2, false, 25000, true));

            listaVeiculos.Add(new Veiculos(2, "KIA CERATO", "1.6 EX3 SEDAN 16V 4P A ", 2014, 2015,
              "Prata", 1, true, 35000, true));

            listaVeiculos.Add(new Veiculos(3, "FIAT TORO", "2.0 FREEDOM 16V 4P", 2022, 2022,
              "Vermelho", 3, true, 119590, true));

            var resultado = JObject.Parse("{resultado: \"populado\"}");
            return resultado;
        }

        // GET api/veiculos
        public List<Veiculos> Get()
        {
            return listaVeiculos;
        }

        // GET api/veiculos/5
        public Veiculos Get(int id)
        {
            return listaVeiculos.Find(x => x.Id.Equals(id));
        }

        // POST api/veiculos
        public void Post([FromBody] string value)
        {
        }

        // PUT api/veiculos/5
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpGet]
        [Route("api/veiculos/excluir/{id}")]
        public JObject Excluir(int id)
        {
            var veiculo = listaVeiculos.Single(x => x.Id.Equals(id));
            listaVeiculos.Remove(veiculo);

            var resultado = JObject.Parse("{resultado: \"ok\"}");
            return resultado;
        }

        #endregion
    }
}
