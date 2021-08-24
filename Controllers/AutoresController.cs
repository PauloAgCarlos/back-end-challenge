using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DrCashApp.Data;
using DrCashApp.Models;
using DrCashApp.Dtos;
using AutoMapper;
// using Microsoft.AspNetCore.JsonPatch;

namespace DrCashApp.Controllers
{

    [Route("/api/autores")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private readonly IAutorRepo _repository;
        private readonly IMapper _mapper;

        public AutoresController(IAutorRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<AutorReadDto>> GetAllAutor()
        {
            var autorItems = _repository.GetAllAutores();

            return Ok(_mapper.Map<IEnumerable<AutorReadDto>>(autorItems));
        }

        [HttpGet("{id}", Name ="GetAutorById")]
        public ActionResult <AutorReadDto> GetAutorById(int id)
        {
            var autorItem = _repository.GetAutorById(id);
            if(autorItem != null)
            {
                return Ok(_mapper.Map<AutorReadDto>(autorItem));
            }

            return NotFound();

        }


        //POST api/autores
        [HttpPost]
        public ActionResult <AutorReadDto> CreateAutor(AutorCreateDto autorcreateDto)
        {
            var autorModel = _mapper.Map<Autor>(autorcreateDto);
            _repository.CreateAutor(autorModel);
            _repository.SaveChanges();

            var autorReadDto = _mapper.Map<AutorReadDto>(autorModel);

            return CreatedAtRoute(nameof(GetAutorById), new {Id = autorReadDto.Id}, autorcreateDto);
            // return Ok(autorReadDto);
        }



        //PUT api/autores/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAutor(int id, AutorUpdateDto autorUpdateDto)
        {
            var autorModelFromRepo = _repository.GetAutorById(id);
            if(autorModelFromRepo == null)
            {
                return NotFound(); 
            }

            _mapper.Map(autorUpdateDto, autorModelFromRepo);

            _repository.UpdateAutor(autorModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

         
        // DELETE api/autores/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAutor(int id)
        {
            var autorModelFromRepo = _repository.GetAutorById(id);
            if(autorModelFromRepo == null)
            {
                return NotFound(); 
            }


             _repository.DeleteAutor(autorModelFromRepo);

             _repository.SaveChanges();

             return NoContent();
        }
    }
}