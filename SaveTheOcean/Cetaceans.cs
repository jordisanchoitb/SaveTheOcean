using System;

namespace SaveTheOcean
{
    public class Cetaceans : AAnimal
    {
        public Cetaceans()
        {
            this.Species = ["Delfín mular", "Orca transeúntes", "Ballena de groenlandia", "Marsopas comun"];
            this.WeightSpecies = [300.0, 3810.0, 75000.0, 53.0];
            this.AnimalNames = ["Moby", "Luna", "Nereida", "Ondina", "Fluke"];
            this.NumSpecie = MethodsUtilities.RandomNum(Species.Length);
            this.Name = AnimalNames[MethodsUtilities.RandomNum(AnimalNames.Length)];
            this.Specie = Species[NumSpecie];
            this.Superfamily = "Cetáceo";
            this.WeightAprox = WeightSpecies[NumSpecie];
            this.GradeAfectation = MethodsUtilities.RandomNum(1,100);
        }

        public override int CalculateNewGradeAfectation(bool heal)
        {
            int x = heal ? 25 : 0;
            return (int)(this.GradeAfectation - Math.Log10(this.GradeAfectation) - x);
        }
    }
}
