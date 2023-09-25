using CardapioOnline.Entities;

namespace CardapioOnline.Repositories
{
    public class MenuRepositorie
    {

        private static List<MenuItens> menuItens = new List<MenuItens>();

        public void SalvarMenuItem(MenuItens menuItem)
        {
            menuItem.Id = menuItens.Count() + 1;
            menuItens.Add(menuItem);
        }

        public List<MenuItens> PegarTodosMenuRepositorie()
        {
            return menuItens;
        }

        public MenuItens PegarMenuPorId(int id)
        {
            return menuItens.Where(w => w.Id == id).FirstOrDefault();
        }

        public void AtualizarMenuItem(MenuItens menuItem)
        {
            var menuItemExistente = menuItens.FirstOrDefault(f => f.Id == menuItem.Id);

            if (menuItemExistente != null)
            {
                menuItemExistente.Title = menuItem.Title;
                menuItemExistente.Description = menuItem.Description;
                menuItemExistente.Price = menuItem.Price;
                menuItemExistente.ImgUrl = menuItem.ImgUrl;
            }
        }

    }
}
