using System;
using Utilities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SaveTheOcean
{
    public class Rescued
    {
        public string? Number { get; set; }
        public string? Date { get; set; }
        public string? Superfamily { get; set; }
        public int GradeAfectation { get; set; }
        public string? Location { get; set; }
        public static string[] Locations { get; set; } = { "Mar Mediterráneo", "Mar Rojo", "Mar del Norte", "Mar del Sur" };

        public Rescued(string superfamily)
        {
            this.Number = "RES" +  Utilities.Utilities.RandomNum(1000).ToString("D3");
            this.Date = DateTime.Now.ToString("dd/MM/yyyy");
            this.Superfamily = superfamily;
            this.GradeAfectation = Utilities.Utilities.RandomNum(1, 100);
            this.Location = Locations[Utilities.Utilities.RandomNum(Locations.Length)];
        }
    }
}
