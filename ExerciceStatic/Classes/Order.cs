using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceStatic.Classes
{
 
       
        public class Order
    {
       
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public bool IsCancelled { get; private set; } = false;

       
        public static int CreatedOrdersCount { get; private set; } = 0;
        public static int CancelledOrdersCount { get; private set; } = 0;
        public static decimal TotalAmountCreated { get; private set; } = 0m;

      
        public Order(string customerName, decimal amount)
        {
            CustomerName = customerName;
            Amount = amount;

            CreatedOrdersCount++;
            TotalAmountCreated += amount;

          
            Console.WriteLine($"{CustomerName} a créé une commande de {Amount}");
            Console.WriteLine($"Somme totale des commandes créées : {TotalAmountCreated}");
        }

     
        public void Cancel()
        {
            if (!IsCancelled)
            {
                IsCancelled = true;
                CancelledOrdersCount++;

       
                Console.WriteLine($"La commande de {CustomerName} a été annulée");
            }
        }
    }
}

