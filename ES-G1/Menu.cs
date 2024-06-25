using ES_G1.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ES_G1
{
    public class Menu
    {
        public static List<MenuModel> MenuItems { get; } = new List<MenuModel>
        {
            new MenuModel {name="1. Coca Cola", price = 2.50m},
            new MenuModel {name="2. Pepsi", price = 2.50m},
            new MenuModel {name="3. Sprite", price = 2.50m},
            new MenuModel {name="4. Fanta", price = 2.50m},
            new MenuModel {name="5. Margherita", price = 4.50m},
            new MenuModel {name="6. 4 formaggi", price = 6.50m},
            new MenuModel {name="7. Pizza fritta", price = 5.50m}

        };

    }
}
