using ES_G1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Esercizio_1
{
    internal class Program
    {
        private List<MenuModel> ordine = new List<MenuModel>();
        private decimal totale = 0;

        public void menu()
        {
            Console.WriteLine("Menu:\n");
            // Assicurati che MenuItems sia accessibile qui. Potrebbe essere necessario aggiungere un riferimento o utilizzare un metodo pubblico da ES_G1.Menu per ottenere gli elementi del menu.
            var menuItems = ES_G1.Menu.MenuItems; // Accedi direttamente alla lista MenuItems definita in Menu.cs
            foreach (var item in menuItems)
            {
                Console.WriteLine($"{item.name} - {item.price}\n");
            }
            scegli(menuItems); // Passa menuItems a scegli
        }

        private void scegli(List<MenuModel> menuItems)
        {
            int scelta;
            do
            {
                Console.WriteLine("Inserisci il numero dell'elemento che vuoi ordinare (0 per completare l'ordine):");
                scelta = int.Parse(Console.ReadLine());
                if (scelta > 0 && scelta <= menuItems.Count)
                {
                    ordine.Add(menuItems[scelta - 1]); // Aggiunge l'elemento selezionato all'ordine
                }
                else if (scelta == 0)
                {
                    decimal somma = ordine.Sum(item => item.price);
                    Console.WriteLine($"Prezzo totale dell'ordine: {somma}");
                }
                else
                {
                    Console.WriteLine("Scelta non valida");
                }
            } while (scelta != 0);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.menu();
        }
    }
}
