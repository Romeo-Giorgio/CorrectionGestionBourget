using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionGestionBourget
{
    internal class Location
    {
        private string hall;
        private int parcel;
        private int surface;

        public string Hall { get => hall; set => hall = value; }
        public int Parcel { get => parcel; set => parcel = value; }
        public int Surface { get => surface; set => surface = value; }
        public Location(string hall, int parcel, int surface)
        {
            this.hall = hall;
            this.parcel = parcel;
            this.surface = surface;
        }

        public override string ToString()
        {
            return $"Hall {hall} - Parcelle {parcel} : {surface} m²";
        }
        public void DisplayLocation()
            {
                Console.WriteLine(ToString());
        }
        public static Location LocationInputForm()
        {
            Console.Clear();
            Console.WriteLine("######################");
            Console.WriteLine("# Nouvel Emplacement #");
            Console.WriteLine("######################");
            Console.WriteLine();
            Console.WriteLine("Saisir un hall");
            string hall = Console.ReadLine()??"";
            Console.WriteLine("Saisir une parcelle");
            int parcel = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Saisir une surface");
            int surface = int.Parse(Console.ReadLine() ?? "0");
            return new Location(hall, parcel, surface);
;        }
    }
}
