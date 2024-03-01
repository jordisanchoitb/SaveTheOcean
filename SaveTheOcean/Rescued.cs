using System;

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
            this.Number = "RES" +  MethodsUtilities.RandomNum(1000).ToString("D3");
            this.Date = DateTime.Now.ToString("dd/MM/yyyy");
            this.Superfamily = superfamily;
            this.GradeAfectation = MethodsUtilities.RandomNum(1, 100);
            this.Location = Locations[MethodsUtilities.RandomNum(Locations.Length)];
        }
    }
}
