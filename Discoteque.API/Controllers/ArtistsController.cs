using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Discoteque.Business.IServices;
using Microsoft.AspNetCore.Mvc;
using Discoteque.Data.Models;


namespace Discoteque.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistService _artistService;

        public ArtistsController(IArtistService artistService){
            _artistService = artistService;
        }

        [HttpGet]
        [Route("GetAllArtistAsync")]
        public async Task<IActionResult> GetAllArtistAsync()
        {
            var artists = await  _artistService.GetArtistAsync();
            return Ok(artists);

        }

        [HttpPost]
        [Route("CreateArtist")]
        public async Task<IActionResult> CreateArtist([FromBody] Artist artist)
        {
            if (artist == null)
            {
            return BadRequest("El campo de artista es = nulo");
            }
            var artists = await _artistService.CreateArtist(artist);
            return Ok(artists);
        }
    }
}
