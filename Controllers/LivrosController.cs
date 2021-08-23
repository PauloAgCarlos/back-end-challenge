using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DrCashApp.Data;
using DrCashApp.Models;
using DrCashApp.Dtos;
using AutoMapper;
// using Microsoft.AspNetCore.JsonPatch;

namespace DrCashApp.Controllers
{

    [Route("/api/livros")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroRepo _repository;
        private readonly IMapper _mapper;

        public LivrosController(ILivroRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<LivroReadDto>> GetAllLivro()
        {
            var livroItems = _repository.GetAllLivros();

            return Ok(_mapper.Map<IEnumerable<LivroReadDto>>(livroItems));
        }

        [HttpGet("{id}", Name ="GetLivroById")]
        public ActionResult <LivroReadDto> GetLivroById(int id)
        {
            var livroItem = _repository.GetLivroById(id);
            if(livroItem != null)
            {
                return Ok(_mapper.Map<LivroReadDto>(livroItem));
            }

            return NotFound();

        }


        //POST api/livros
        [HttpPost]
        public ActionResult <LivroReadDto> CreateLivro(LivroCreateDto livrocreateDto)
        {
            var livroModel = _mapper.Map<Livro>(livrocreateDto);
            _repository.CreateLivro(livroModel);
            _repository.SaveChanges();

            var livroReadDto = _mapper.Map<LivroReadDto>(livroModel);

            return CreatedAtRoute(nameof(GetLivroById), new {Id = livroReadDto.Id}, livrocreateDto);
            // return Ok(livroReadDto);
        }



        //PUT api/livros/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateLivro(int id, LivroUpdateDto livroUpdateDto)
        {
            var livroModelFromRepo = _repository.GetLivroById(id);
            if(livroModelFromRepo == null)
            {
                return NotFound(); 
            }

            _mapper.Map(livroUpdateDto, livroModelFromRepo);

            _repository.UpdateLivro(livroModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

         
        // DELETE api/livros/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteLivro(int id)
        {
            var livroModelFromRepo = _repository.GetLivroById(id);
            if(livroModelFromRepo == null)
            {
                return NotFound(); 
            }


             _repository.DeleteLivro(livroModelFromRepo);

             _repository.SaveChanges();

             return NoContent();
        }
    }
}