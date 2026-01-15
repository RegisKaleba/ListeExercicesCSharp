using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceStatic.Classes
{
 
       
        public class Order
    {
        // --- Propriétés d'instance ---
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public bool IsCancelled { get; private set; } = false;

        // --- Propriétés statiques ---
        public static int CreatedOrdersCount { get; private set; } = 0;
        public static int CancelledOrdersCount { get; private set; } = 0;
        public static decimal TotalAmountCreated { get; private set; } = 0m;

        // --- Constructeur ---
        public Order(string customerName, decimal amount)
        {
            CustomerName = customerName;
            Amount = amount;

            CreatedOrdersCount++;
            TotalAmountCreated += amount;

            // Message automatique
            Console.WriteLine($"{CustomerName} a créé une commande de {Amount}");
        }

        // --- Annulation ---
        public void Cancel()
        {
            if (!IsCancelled)
            {
                IsCancelled = true;
                CancelledOrdersCount++;

                // Message automatique
                Console.WriteLine($"La commande de {CustomerName} a été annulée");
            }
        }
    }
}

