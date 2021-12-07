// using System.Linq;
// using API.Data;
// using API.Models;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;

// namespace API.Controllers
// {
//     [ApiController]
//     [Route("api/venda")]
//     public class VendaController : ControllerBase
//     {
//         private readonly DataContext _context;
//         public VendaController(DataContext context)
//         {
//             _context = context;
//         }


//         //POST: api/venda/create
//         [HttpPost]
//         [Route("create")]
//         public IActionResult Create([FromBody] Venda venda)
//          {
//             venda.Funcionario = _context.Funcionarios.Find(venda.ProdutoId);
//             venda.ItemVenda = _context.ItensVenda.Find(venda.ItemVendaId);
//             // venda.FormasDePagamento = _context.FormasDePagamentos.Find(venda.FormasDePagamentoId);

//             _context.Vendas.Add(venda);
//             _context.SaveChanges();
//             return Created("", venda);
//         }


//         //GET: api/venda/list
//         //ALTERAR O MÉTODO PARA MOSTRAR TODOS OS DADOS DA VENDA E OS DADOS RELACIONADOS
//         [HttpGet]
//         [Route("list")]
//         public IActionResult List() => Ok 
//         (_context.Vendas
//         .Include( f => f.FormasDePagamento)
//         .ToList( ));
        
//         /*
//         {
//             return Ok(_context.Vendas.ToList());
//         }
//         */
//     }
// }