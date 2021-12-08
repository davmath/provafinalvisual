using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace API.Controllers
{

    [ApiController]
    [Route("api/folhapagamento")]
    public class FolhaPagamentoController : ControllerBase
    {
        
        private readonly DataContext _context;
        public FolhaPagamentoController (DataContext context){
            _context = context;
        }

        [HttpPost]
        [Route("create")]

        public IActionResult Create([FromBody] FolhaPagamento folhaPagamento){
            folhaPagamento.Funcionario = _context.Funcionarios.Find(folhaPagamento.FuncionarioId);
            _context.FolhasPagamento.Add(folhaPagamento);
            _context.SaveChanges();
            return Created("", folhaPagamento);
        }
        
        //GET: api/folhapagamento/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() =>
            Ok(_context.FolhasPagamento
            .Include(p => p.Funcionario)
            .ToList());


        //GET: api/folhapagamento/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            FolhaPagamento folhaPagamento = _context.FolhasPagamento.Find(id);
            if (folhaPagamento == null)
            {
                return NotFound();
            }
            return Ok(folhaPagamento);
        }


    }
}