using ES_G1.Models;

namespace Esercizio_1
{
    internal class Program
    {
        private List<MenuModel> ordine = new List<MenuModel>();
        private decimal totale = 0;

        public void menu()
        {
            Console.WriteLine("Menu:\n");
            foreach (var item in ordine)
            {
                Console.WriteLine($"{item.name} - {item.price}\n");
            }
            
        }

        
        static void Main(string[] args)
        {
            
        }
    }
}
