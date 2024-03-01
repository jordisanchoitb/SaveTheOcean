using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean
{
    public abstract class AAnimal
    {
        public string? Name { get; set; }
        public string? Specie { get; set; }
        public string? Superfamily { get; set; }
        public double WeightAprox { get; set; }
        public int GradeAfectation { get; set; }
        public string[]? Species { get; set; }
        public double[]? WeightSpecies { get; set; }
        public string[]? AnimalNames { get; set; }
        public int NumSpecie { get; set; }
        public abstract int CalculateNewGradeAfectation(bool heal);
    }
}
