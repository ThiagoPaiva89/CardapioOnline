using CardapioOnline.Dto;
using CardapioOnline.Entities;
using CardapioOnline.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

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
        public List<MenuItens> PegarMenuTodos()
        {
            return _menuService.PegarMenuService();
        }

        [HttpGet("id")]
        public MenuItens PegarMenuPorId(int id)
        {
            return _menuService.PegarMenuPorId(id);
        }

        [HttpPut]
        public void AtualizarMenuItem(int id, [FromBody] MenuItens menuItem)
        {
            _menuService.AtualizarMenuItemPorId(id, menuItem);
        }

    }
}
