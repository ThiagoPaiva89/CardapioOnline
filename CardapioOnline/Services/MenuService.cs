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

        public string PegarMenuService()
        {
            return _menuRepositorie.PegarMenuRepositorie();
        }

    }
}
