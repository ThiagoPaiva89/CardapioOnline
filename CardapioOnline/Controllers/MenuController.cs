using CardapioOnline.Dto;
using CardapioOnline.Entities;
using CardapioOnline.Services;
using Microsoft.AspNetCore.Mvc;

namespace CardapioOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {

        private readonly MenuService _menuService;

        public MenuController(MenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpPost]
        public void SalvarMenuItem([FromBody] CreateRequest createRequest)
        {
            _menuService.SalvarMenuItem(createRequest);
        }

        [HttpGet]
        public IActionResult PegarMenuTodos()
        {

            var resposta = _menuService.PegarMenuService();

            if (resposta != null)
            {
                return Ok(resposta);
            }
            return BadRequest();
        }

        [HttpGet("id")]
        public MenuItens PegarMenuPorId(int id)
        {
            return _menuService.PegarMenuPorId(id);
        }

        [HttpPut]
        public IActionResult AtualizarMenuItem(int id, [FromBody] UpdateRequest item)
        {
            if (id != item.Id)
            {
                return BadRequest("Item não encontrado na base de dados");
            }
            var menuItem = new MenuItens()
            {
                Id = item.Id,
                Title = item.Title,
                Description = item.Description,
                Price = item.Price,
            };

            _menuService.AtualizarMenuItemPorId(id, menuItem);

            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeletarMenuItem(int id)
        {
            var menuItem = PegarMenuPorId(id);
            if (menuItem != null)
            {
                _menuService.DeletarMenuItem(id);
                return NoContent();
            }
            return NotFound("O item que deseja deletar não existe em nossa base de dados");
        }

    }
}
