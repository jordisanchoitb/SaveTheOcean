using System;

namespace SaveTheOcean
{
    public class Rescued
    {
        public string? Number { get; set; }
        public string? Date { get; set; }
        public string? Superfamily { get; set; }
        public AAnimal Animal { get; set; }
        public string? Location { get; set; }
        public static string[] Locations { get; set; } = { "Mar Mediterráneo", "Mar Rojo", "Mar del Norte", "Mar del Sur" };

        public Rescued(AAnimal animal)
        {
            this.Number = "RES" +  MethodsUtilities.RandomNum(1000).ToString("D3");
            this.Date = DateTime.Now.ToString("dd/MM/yyyy");
            this.Animal = animal;
            this.Superfamily = animal.Superfamily;
            this.Location = Locations[MethodsUtilities.RandomNum(Locations.Length)];
        }
    }
}
