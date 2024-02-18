using CorrectionGestionBourget;

internal class Program
{
    private static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("##################");
        Console.WriteLine("# Gestion Bourget#");
        Console.WriteLine("##################");
        Console.WriteLine();
        Console.WriteLine("1. Saisir un emplacement");
        Console.WriteLine("2. Saisir une entreprise");
        Console.WriteLine("3. Saisir un contact");
        Console.WriteLine("4. Afficher tous les exposants");
        Console.WriteLine("5. Quitter");
    }
    private static void Main(string[] args)
    {
        // Variables
        bool running = true;
        List<Company> companies = new List<Company>();
        List<Location> availableLocations = new List<Location>();
        while(running)
        {
            DisplayMenu();
            try
            {
                int userInput = int.Parse(Console.ReadLine() ?? "0");
                switch (userInput)
                {
                    case 1:
                        Location newLocation = Location.LocationInputForm();
                        availableLocations.Add(newLocation);
                        break;
                    case 2:
                        Company newCompany = Company.CompanyInputForm(availableLocations);
                        companies.Add(newCompany);
                        availableLocations.Remove(newCompany.Location);
                        break;
                    case 3:
                        Contact newContact = Contact.ContactInputForm();
                        companies[Company.SelectCompany(companies)].AddContact(newContact);
                        break;
                    case 4:
                        companies.ForEach(company => company.DisplayCompany());
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Bye.");
                        running = false;
                        break;
                    default:
                        throw new Exception();
                }
                
            }catch (Exception ex)
            {
                Console.WriteLine("Saisie invalide, appuyer sur Entrée pour réessayer.");
                Console.ReadLine();
            }
        }
    }

    
}