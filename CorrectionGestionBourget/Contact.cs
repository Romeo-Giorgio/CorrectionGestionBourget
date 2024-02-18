using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionGestionBourget
{
    internal class Contact
    {
        private string name;
        private string phone;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public Contact(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
        public override string ToString()
        {
            return $"{name} : {phone}";
        }

        public void DisplayContact()
        {
            Console.WriteLine(ToString());
        }
        
        public static Contact ContactInputForm()
        {
            Console.Clear();
            Console.WriteLine("###################");
            Console.WriteLine("# Nouveau Contact #");
            Console.WriteLine("###################");
            Console.WriteLine();
            Console.WriteLine("Saisir un nom");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine("Saisir un numéro de téléphone");
            string phone = Console.ReadLine() ?? "";
            return new Contact(name, phone);
        }
    }
}
