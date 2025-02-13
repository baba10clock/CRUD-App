using CRUDApp.Interfaces;
using CRUDApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductCatalogue _catalogue;

        public ProductController(IProductCatalogue catalogue) => _catalogue = catalogue;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _catalogue.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _catalogue.GetByIdAsync(id);
            return product is not null ? Ok(product) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            await _catalogue.AddAsync(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Product product)
        {
            var updated = await _catalogue.UpdateAsync(id, product);
            return updated ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _catalogue.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
