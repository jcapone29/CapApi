using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;
using DataAccess.Entities;
using System.Threading.Tasks;

namespace CapApi.Controllers
{
    [RoutePrefix("api/Potato")]
    public class PGAController : ApiController
    {
        private readonly PotatoService _pgaSerive;

        public PGAController()
        {
            _pgaSerive = new PotatoService();
        }

        [Route("getUser")]
        public async Task<IHttpActionResult> GetPotatos(string id)
        {

            return Ok(await _pgaSerive.GetPotatos(id));

        }

        [Route("createUser")]
        public async Task<IHttpActionResult> CreatePotato(Potato user)
        {

            return Ok(await _pgaSerive.CreatePotato(user));

        }

        [Route("getUser")]
        public async Task<IHttpActionResult> GetLeagues(Leagues league)
        {

            return Ok(await _pgaSerive.CreateLeague(league));

        }

        [Route("getUser")]
        public async Task<IHttpActionResult> GetPotatos(Leagues league)
        {

            return Ok(await _pgaSerive.GetLeagues(league));

        }

    }
}
