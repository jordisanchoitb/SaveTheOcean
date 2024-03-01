using System;

namespace SaveTheOcean
{
    public static class MethodsUtilities
    {
        const string MSG_INFOLINE = "+-------------------------------------------------------------+";
        const string MSG_INFONAME_RES = "|                       RESCAT                                |";
        const string MSG_INFORES = "| # Rescat | Data rescat | Superfamília   | GA | Localització |";
        const string MSG_INFORES_STATS = "|  {0,-6}  | {1,-10} | {2,-14} | {3,-2} | {4,-12} |";
        const string MSG_INFONAME_SHEET = "|                       FITXA                                 |";
        const string MSG_INFOSHEET = "| # Nom  | Superfamília   | Espècie       | Pes aproximat     |";
        const string MSG_INFOSHEET_STATS = "| {0,-6} | {1,-14} | {2,-8} | {3,-15:F1}kg |";

        /// <summary>
        /// Retorna un booleà indicant si el número usuari està entre min i max (inclosos)
        /// </summary>
        /// <param name="usernumber">Numero introduit per l'usuari</param>
        /// <param name="min">Num min per verificar (inclos)</param>
        /// <param name="max">Num max per verificar (inclos)</param>
        /// <returns></returns>
        public static bool ValidateOption(int usernumber, int min, int max)
        {
            return usernumber >= min && usernumber <= max;
        }


        /// <summary>
        /// Retorna un número aleatori entre min (inclos) i max (excloit)
        /// </summary>
        /// <param name="min">Numero minimo entero</param>
        /// <param name="max">Numero maximo entero</param>
        /// <returns>int</returns>
        public static int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


        /// <summary>
        /// Retorna un número aleatori entre 0 i max (excloit)
        /// </summary>
        /// <param name="max">Numero Entero</param>
        /// <returns>int</returns>
        public static int RandomNum(int max)
        {
            Random random = new Random();
            return random.Next(max);
        }


        /// <summary>
        /// Retorna el nom d'una superfamilia aleatoria
        /// </summary>
        /// <returns>string</returns>
        public static string GetRandomSuperfamily()
        {
            string[] superfamily = { "Tortuga marina", "Au marina", "Cetaceo" };
            int index = RandomNum(superfamily.Length);
            return superfamily[index];
        }


        /// <summary>
        /// Retorna l'instància d'Animal corresponent a la superfamilia passada per paràmetre
        /// </summary>
        /// <param name="superfamily">nom superfamilia ("Tortuga marina", "Au marina", "Cetaceo")</param>
        /// <returns>AAnimal</returns>
        public static AAnimal? GetAnimalBySuperfamily(string superfamily)
        {
            switch (superfamily)
            {
                case "Tortuga marina":
                    return new SeaTurtle();
                case "Au marina":
                    return new SeaBird();
                case "Cetaceo":
                    return new Cetaceans();
                default:
                    return null;
            }
        }


        /// <summary>
        /// Imprimeix per consola les dades del rescat passat per paràmetre
        /// </summary>
        /// <param name="rescued">objecta Rescued</param>
        public static void PrintInfoData(Rescued rescued)
        {
            Console.WriteLine(MSG_INFOLINE);
            Console.WriteLine(MSG_INFONAME_RES);
            Console.WriteLine(MSG_INFOLINE);
            Console.WriteLine(MSG_INFORES);
            Console.WriteLine(MSG_INFOLINE);
            Console.WriteLine(MSG_INFORES_STATS, rescued.Number, rescued.Date, rescued.Superfamily, rescued.Animal.GradeAfectation, rescued.Location);
            Console.WriteLine(MSG_INFOLINE);
        }


        /// <summary>
        /// Imprimeix per consola les dades de la fitxa del rescat passat per paràmetre
        /// </summary>
        /// <param name="rescued">objecta Rescued</param>
        public static void PrintInfoDataSheet(Rescued rescued)
        {
            Console.WriteLine(MSG_INFOLINE);
            Console.WriteLine(MSG_INFONAME_SHEET);
            Console.WriteLine(MSG_INFOLINE);
            Console.WriteLine(MSG_INFOSHEET);
            Console.WriteLine(MSG_INFOLINE);
            Console.WriteLine(MSG_INFOSHEET_STATS, rescued.Animal.Name, rescued.Animal.Superfamily, rescued.Animal.Specie, rescued.Animal.WeightAprox);
            Console.WriteLine(MSG_INFOLINE);
        }
    }
}
