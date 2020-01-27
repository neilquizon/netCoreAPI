using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netCoreAPI.Services;

namespace netCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotTodoController : ControllerBase
    {
        private readonly DataContext _context;

        public NotTodoController(DataContext context)
        {
            _context = context;
        }

        // GetAll() is automatically recognized as
        // http://localhost:<port #>/api/nottodo
        [HttpGet]
        public IEnumerable<NotToDo> GetAll()
        {
            return _context.NotToDos.ToList();
        }

        // GetById() is automatically recognized as
        // http://localhost:<port #>/api/nottodo/{id}

        // For example:
        // http://localhost:<port #>/api/nottodo/1

        [HttpGet("{id}", Name = "GetNotTodo")]
        public IActionResult GetById(long id)
        {
            var item = _context.NotToDos.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        /// <summary>
        /// Creates a TodoItem.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /NotTodo
        ///     {
        ///        "description": "Item1",
        ///        "isComplete": true,
        ///        "priority": 1,
        ///        "createdOn": "2020-01-01T00:00:00.0000001"
        ///     }
        /// </remarks> 
        /// <param name="nottodo"></param>
        /// 
        /// <returns>A newly created NotTodo Item</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is not saved</response>

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult Create([FromBody]NotToDo nottodo)
        {
            if (nottodo.Description == null || nottodo.Description == "")
            {
                return BadRequest();
            }
            _context.NotToDos.Add(nottodo);
            _context.SaveChanges();
            return CreatedAtRoute("GetNotTodo", new { id = nottodo.Id }, nottodo);

        }

        [HttpPut]
        [Route("MyEdit")] // Custom route
        public IActionResult GetByParams([FromBody]NotToDo nottodo)
        {
            var item = _context.NotToDos.Where(t => t.Id == nottodo.Id).FirstOrDefault();
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                item.IsComplete = nottodo.IsComplete;
                _context.SaveChanges();
            }
            return new ObjectResult(item);
        }




        [HttpDelete]
        [Route("MyDelete")] // Custom route
        public IActionResult MyDelete(long Id)
        {
            var item = _context.NotToDos.Where(t => t.Id == Id).FirstOrDefault();
            if (item == null)
            {
                return NotFound();
            }
            _context.NotToDos.Remove(item);
            _context.SaveChanges();
            return new ObjectResult(item);
        }
    }
}