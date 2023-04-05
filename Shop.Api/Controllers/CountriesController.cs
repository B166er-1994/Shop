using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.API.Data;
using Shop.Shared.Entities;

namespace Shop.Api.Controllers
{
    [ApiController]
    [Route("/api/countries")]
    public class CountriesController:ControllerBase
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context) //inyeccion de dependencia del contexto de datos
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Countries.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> PostAsync(Country country)
        { 
            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
            return Ok(country);
        }
    }
}
