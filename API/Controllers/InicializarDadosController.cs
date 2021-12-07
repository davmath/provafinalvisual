using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/inicializar")]
    public class InicializarDadosController : ControllerBase
    {
        private readonly DataContext _context;
        public InicializarDadosController(DataContext context)
        {
            _context = context;
        }

        //POST: api/inicializar/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create()
        {
            _context.Categorias.AddRange(new Categoria[]
                {
                    new Categoria { Id = 1, Nome = "Doce" },
                }
            );
            _context.Funcionarios.AddRange(new Funcionario[]
                {
                    new Funcionario { Id = 1, Nome = "David", Salario = 5025, Idade = 23, CategoriaId = 1 },
                    new Funcionario { Id = 2, Nome = "Matheus", Salario = 4510, Idade = 30, CategoriaId = 1 },
                    new Funcionario { Id = 3, Nome = "Rosa", Salario = 1880, Idade = 47, CategoriaId = 1 },
                }
            );
            _context.SaveChanges();
            return Ok(new { message = "Dados inicializados com sucesso!" });
        }
    }
}