using ExerciceStatic.Classes;
using System;

Console.WriteLine("=== Tests Order ===");
Order order = new Order("Jean-bobby", 50m);
Order order2 = new Order("Zazie", 75m);
Order order3 = new Order("Marcel", 100m);
Order order4 = new Order("Toto", 120m);
Order order5 = new Order("Naruto", 200m);

Console.WriteLine($"\nCommandes créées : {Order.CreatedOrdersCount}");

order3.Cancel();
order5.Cancel();

Console.WriteLine($"Commandes annulées : {Order.CancelledOrdersCount}");

Console.WriteLine("=== Tests OrderUtils ===");


string name1 = "  aLEx ";
string normalized1 = OrderUtils.NormalizeCustomerName(name1);
Console.WriteLine(normalized1 == "Alex" ? "Test 1 OK" : "Test 1 ERREUR");


string name2 = "Marie";
bool isValid2 = OrderUtils.IsValidCustomerName(name2);
Console.WriteLine(isValid2 ? "Test 2 OK" : "Test 2 ERREUR");


string name3 = "A";
bool isValid3 = OrderUtils.IsValidCustomerName(name3);
Console.WriteLine(isValid3 ? "Test 3 OK" : "Test 3 ERREUR"); 


string name4 = "   ";
bool isValid4 = OrderUtils.IsValidCustomerName(name4);
Console.WriteLine(isValid4 ? "Test 4 OK" : "Test 4 ERREUR"); 
