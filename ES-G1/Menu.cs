using ES_G1.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ES_G1
{
    public class Menu
    {
        public static List<MenuModel> MenuItems { get; } = new List<MenuModel>
        {
            new MenuModel {name="Coca Cola", price = 2.50m},
            new MenuModel {name="Pepsi", price = 2.50m},
            new MenuModel {name="Sprite", price = 2.50m},
            new MenuModel {name="Fanta", price = 2.50m},
            new MenuModel {name="Margherita", price = 4.50m},
            new MenuModel {name="4 formaggi", price = 6.50m},
            new MenuModel {name="Pizza fritta", price = 5.50m}

        };

    }
}
