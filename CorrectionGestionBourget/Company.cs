using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionGestionBourget
{
    internal class Company
    {
        private string siret;
        private string name;
        private Location location;
        private List<Contact> contacts;

        

        public string Siret { get => siret; set => siret = value; }
        public string Name { get => name; set => name = value; }
        internal Location Location { get => location; set => location = value; }
        internal List<Contact> Contacts { get => contacts; set => contacts = value; }
        public Company(string siret, string name, Location location)
        {
            this.siret = siret;
            this.name = name;
            this.location = location;
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public override string ToString()
        {
            return $"{name} (SIRET: {siret})";
        }

        public void DisplayCompany()
        {
            Console.WriteLine("##########################");
            Console.WriteLine(ToString());
            if(location != null)
            {
                location.DisplayLocation();
            }
            if (contacts.Count > 0)
            {
                Console.WriteLine("Contacts :");
                contacts.ForEach(contact => contact.DisplayContact());
            }
            Console.WriteLine("##########################");
            Console.WriteLine("");
        }

        public static Company CompanyInputForm(List<Location> availableLocations)
        {
            Console.Clear();
            Console.WriteLine("Saisir un nom");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine("Saisir un siret");
            string siret = Console.ReadLine() ?? "";
            Console.WriteLine("Choisir un emplacement disponible");
            availableLocations.ForEach(location => Console.WriteLine($"{availableLocations.IndexOf(location)} - {location.ToString()}"));
            Location selectedLocation = availableLocations[int.Parse(Console.ReadLine()??"0")];
            return new Company(siret, name, selectedLocation);
        }
        public static int SelectCompany(List<Company> companies)
        {
            Console.WriteLine("Sélectionner l'entreprise dans la liste ci-dessous");
            Console.WriteLine();
            companies.ForEach(company => Console.WriteLine($"{companies.IndexOf(company)} - {company.ToString()}"));
            return int.Parse(Console.ReadLine()??"0");

        }
    }
}
