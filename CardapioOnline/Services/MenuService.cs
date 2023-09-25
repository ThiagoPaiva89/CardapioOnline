using CardapioOnline.Dto;
using CardapioOnline.Entities;
using CardapioOnline.Repositories;

namespace CardapioOnline.Services
{
    public class MenuService
    {
        private readonly MenuRepositorie _menuRepositorie;

        public MenuService(MenuRepositorie menuRepositorie)
        {
            _menuRepositorie = menuRepositorie;
        }

        public void SalvarMenuItem(CreateRequest createRequest)
        {
            var menuItem = new MenuItens();

            menuItem.Title = createRequest.Title;
            menuItem.Description = createRequest.Description;
            menuItem.Price = createRequest.Price;

            _menuRepositorie.SalvarMenuItem(menuItem);
        }
       
        public List<MenuItens> PegarMenuService()
        {
            return _menuRepositorie.PegarTodosMenuRepositorie();
        }

       public MenuItens PegarMenuPorId(int id)
        {
            return _menuRepositorie.PegarMenuPorId(id);
        }

        public void AtualizarMenuItemPorId(int id, MenuItens menuItens) 
        {
            var menuItemExistente = PegarMenuPorId(id);
            if (menuItemExistente != null)
            {
                _menuRepositorie.AtualizarMenuItem(menuItens);
            }
        }

    }
}
