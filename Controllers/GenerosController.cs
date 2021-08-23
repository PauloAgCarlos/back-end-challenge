using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DrCashApp.Data;
using DrCashApp.Models;
using DrCashApp.Dtos;
using AutoMapper;
// using Microsoft.AspNetCore.JsonPatch;

namespace DrCashApp.Controllers
{

    [Route("/api/generos")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private readonly IGeneroRepo _repository;
        private readonly IMapper _mapper;

        public GenerosController(IGeneroRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<GeneroReadDto>> GetAllGenero()
        {
            var generoItems = _repository.GetAllGeneros();

            return Ok(_mapper.Map<IEnumerable<GeneroReadDto>>(generoItems));
        }

        [HttpGet("{id}", Name ="GetGeneroById")]
        public ActionResult <GeneroReadDto> GetGeneroById(int id)
        {
            var generoItem = _repository.GetGeneroById(id);
            if(generoItem != null)
            {
                return Ok(_mapper.Map<GeneroReadDto>(generoItem));
            }

            return NotFound();

        }


        //POST api/generos
        [HttpPost]
        public ActionResult <GeneroReadDto> CreateGenero(GeneroCreateDto generocreateDto)
        {
            var generoModel = _mapper.Map<Genero>(generocreateDto);
            _repository.CreateGenero(generoModel);
            _repository.SaveChanges();

            var generoReadDto = _mapper.Map<GeneroReadDto>(generoModel);

            return CreatedAtRoute(nameof(GetGeneroById), new {Id = generoReadDto.Id}, generocreateDto);
            // return Ok(generoReadDto);
        }



        //PUT api/generos/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateGenero(int id, GeneroUpdateDto generoUpdateDto)
        {
            var generoModelFromRepo = _repository.GetGeneroById(id);
            if(generoModelFromRepo == null)
            {
                return NotFound(); 
            }

            _mapper.Map(generoUpdateDto, generoModelFromRepo);

            _repository.UpdateGenero(generoModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

         
        // DELETE api/generos/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteGenero(int id)
        {
            var generoModelFromRepo = _repository.GetGeneroById(id);
            if(generoModelFromRepo == null)
            {
                return NotFound(); 
            }


             _repository.DeleteGenero(generoModelFromRepo);

             _repository.SaveChanges();

             return NoContent();
        }
    }
}