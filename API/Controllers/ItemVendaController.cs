// using System;
// using System.Linq;
// using API.Data;
// using API.Models;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;

// namespace API.Controllers
// {
//     [ApiController]
//     [Route("api/item")]
//     public class ItemVendaController : ControllerBase
//     {
//         private readonly DataContext _context;
//         public ItemVendaController(DataContext context)
//         {
//             _context = context;
//         }

//         //POST: api/item/create
//         [HttpPost]
//         [Route("create")]
//         public IActionResult Create([FromBody] ItemVenda item)
//         {
//             if (String.IsNullOrEmpty(item.CarrinhoId))
//             {
//                 item.CarrinhoId = Guid.NewGuid().ToString();
//             }
//             item.Funcionario = _context.Funcionarios.Find(item.ProdutoId);
//             _context.ItensVenda.Add(item);
//             _context.SaveChanges();
//             return Created("", item);
//         }

//         // GET: api/item/getbycartid/XXXXX-XXXX-XXXXXXXXXXX
//         [HttpGet]
//         [Route("getbycartid/{cartid}")]
//         public IActionResult GetByCartId([FromRoute] string cartId)
//         {
//             return Ok(_context.ItensVenda
//                 .Include(item => item.Funcionario.Categoria)
//                 .Where(item => item.CarrinhoId == cartId).ToList());
//         }
//     }
// }