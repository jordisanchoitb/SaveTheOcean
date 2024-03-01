using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean
{
    public class SeaTurtle : AAnimal
    {
        public SeaTurtle()
        {
            this.Species = ["Tortuga tonta", "Tortuga laúd", "Tortuga verda"];
            this.WeightSpecies = [120.0, 500.0, 90.0];
            this.AnimalNames = ["Donatello", "Leonardo", "Michelangelo", "Raphael", "Shellby"];
            this.NumSpecie = Utilities.Utilities.RandomNum(Species.Length);
            this.Name = AnimalNames[Utilities.Utilities.RandomNum(AnimalNames.Length)];
            this.Specie = Species[NumSpecie];
            this.Superfamily = "Tortuga marina";
            this.WeightAprox = WeightSpecies[NumSpecie];
            this.GradeAfectation = Utilities.Utilities.RandomNum(1,100);
        }
        public override int CalculateNewGradeAfectation(bool heal)
        {
            int x = 5;
            return this.GradeAfectation - ((this.GradeAfectation - 2) * (2 * this.GradeAfectation + 3)) - x;
        }
    }
}
