// using System.Linq;
// using API.Data;
// using API.Models;
// using Microsoft.AspNetCore.Mvc;

// namespace API.Controllers
// {
//     [ApiController]
//     [Route("api/FormasDePagamento")]
//     public class FormasDePagamentoController : ControllerBase
//     {
//         private readonly DataContext _context;

//         public FormasDePagamentoController(DataContext context)
//         {
//             _context = context;
//         }

//         //POST: api/formasDePagamento/create
//         [HttpPost]
//         [Route("create")]

//         public IActionResult Create([FromBody] FormasDePagamento formasDePagamento)
//         {
//             _context.FormasDePagamentos.Add(formasDePagamento);
//             _context.SaveChanges();
//             return Created("", formasDePagamento);
//         }


//         //GET: api/formasDePagamento/list
//          [HttpGet]
//         [Route("list")]
//         public IActionResult List() => Ok(_context.FormasDePagamentos.ToList());


//         //GET: api/pagamento/getbyid/1
//         [HttpGet]
//         [Route("getbyid/{id}")]
//         public IActionResult GetById([FromRoute] int id)
//         {
//             FormasDePagamento formasDePagamento = _context.FormasDePagamentos.Find(id);
//             if (formasDePagamento == null)
//             {
//                 return NotFound();
//             }
//             return Ok(formasDePagamento);
//         }


//         //DELETE: /api/pagamento/delete/bolacha
//         [HttpDelete]
//         [Route("delete/{id}")]
//         public IActionResult Delete([FromRoute] int id)
//         {
          
//             FormasDePagamento formasDePagamento = _context.FormasDePagamentos.FirstOrDefault(formasDePagamento => formasDePagamento.Id == id);

//             if (formasDePagamento == null)
//             {
//                 return NotFound();
//             }
//             _context.FormasDePagamentos.Remove(formasDePagamento);
//             _context.SaveChanges();
//             return Ok(_context.FormasDePagamentos.ToList());
//         }


//         //PUT: api/produto/update
//         [HttpPut]
//         [Route("update")]
//         public IActionResult Update([FromBody] FormasDePagamento formasDePagamento)
//         {
//             _context.FormasDePagamentos.Update(formasDePagamento);
//             _context.SaveChanges();
//             return Ok(formasDePagamento);
//         }

//     }
// }