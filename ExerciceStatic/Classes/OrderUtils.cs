using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceStatic.Classes
{
    public static class OrderUtils
    {
        // Normalisation du nom : trim + première lettre en majuscule
        public static string NormalizeCustomerName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return string.Empty;

            name = name.Trim();
            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }

        // Validation du nom : non vide et >= 2 caractères
        public static bool IsValidCustomerName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Trim().Length >= 2;
        }
    }
}



