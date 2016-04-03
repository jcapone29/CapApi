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
        [HttpGet]
        public async Task<IHttpActionResult> GetUser([FromUri] Potato user)
        {

            return Ok(await _pgaSerive.GetPotato(user));

        }

        [Route("getPotatoList")]
        [HttpGet]
        public async Task<IHttpActionResult> GetUser()
        {

            return Ok(await _pgaSerive.GetLeaguePotato());

        }


        [Route("getUsers")]
        public async Task<IHttpActionResult> GetPotatos(string id)
        {

            return Ok(await _pgaSerive.GetPotatos(id));

        }

        [Route("createUser")]
        public async Task<IHttpActionResult> CreatePotato(Potato currentUser)
        {

            return Ok(await _pgaSerive.CreatePotato(currentUser));

        }

        [Route("postScore")]
        public async Task<IHttpActionResult> PostScore(Scores userScore)
        {

            return Ok(await _pgaSerive.AddScore(userScore));

        }

        [Route("getLeague")]
        public async Task<IHttpActionResult> GetLeagues(Leagues league)
        {

            return Ok(await _pgaSerive.CreateLeague(league));

        }

        [Route("getLeagueUser")]
        public async Task<IHttpActionResult> GetPotatos(Leagues league)
        {

            return Ok(await _pgaSerive.GetLeagues(league));

        }

        [Route("getStates")]
        public async Task<IEnumerable<string>> GetStates()
        {
            return await _pgaSerive.GetStates();
        }

        [Route("getCourseList")]
        public async Task<IEnumerable<Course>> GetCourseList(string state, string gender)
        {
            return await _pgaSerive.GetCourseList(state, gender);
        }
    }
}
