using System;
using Utilities;

namespace SaveTheOcean
{
    public class SeaBird : AAnimal
    {
        public SeaBird()
        {
            this.Species = ["Gaviota de audouin", "Pardela cenicienta", "Alcatraz comu", "Cormoran gran"];
            this.WeightSpecies = [0.65, 1.0, 3.0, 4.0];
            this.AnimalNames = ["Albatros", "Marlin", "Oceana", "Skye", "Wave"];
            this.NumSpecie = Utilities.Utilities.RandomNum(Species.Length);
            this.Name = AnimalNames[Utilities.Utilities.RandomNum(AnimalNames.Length)];
            this.Specie = Species[NumSpecie];
            this.Superfamily = "Au marina";
            this.WeightAprox = WeightSpecies[NumSpecie];
            this.GradeAfectation = Utilities.Utilities.RandomNum(1,100);
        }
        public override int CalculateNewGradeAfectation(bool heal)
        {
            int x = heal ? 5 : 0;
            return (int)(GradeAfectation - (Math.Pow(GradeAfectation, 2) + x));
        }
    }
}
