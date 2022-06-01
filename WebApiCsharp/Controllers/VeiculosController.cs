using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public string Popular()
        {
            listaVeiculos.Add(new Veiculos(1, "FORD FIESTA", "1.0 MPI PERSNNALITÉ SEDAN 4P", 2005, 2005,
                "Preto", 2, false, 25000, true));

            listaVeiculos.Add(new Veiculos(2, "KIA CERATO", "1.6 EX3 SEDAN 16V 4P A ", 2014, 2015,
              "Prata", 1, true, 35000, true));

            listaVeiculos.Add(new Veiculos(3, "FIAT TORO", "2.0 FREEDOM 16V 4P", 2022, 2022,
              "Vermelho", 3, true, 119590, true));

            return "populado";
        }

        // GET api/veiculos
        public string Get()
        {
            return JsonConvert.SerializeObject(listaVeiculos);
        }

        // GET api/veiculos/5
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(listaVeiculos.Find(x => x.Id.Equals(id)));
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
        public string Excluir(int id)
        {
            var veiculo = listaVeiculos.Single(x => x.Equals(id));
            listaVeiculos.Remove(veiculo);

            return "ok";
        }

        #endregion
    }
}
