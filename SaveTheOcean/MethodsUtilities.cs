using System;

namespace SaveTheOcean
{
    public static class MethodsUtilities
    {
        /// <summary>
        /// Retorna un booleà indicant si el número usuari està entre min i max (inclosos)
        /// </summary>
        /// <param name="usernumber">Numero introduit per l'usuari</param>
        /// <param name="min">Num min per verificar (inclos)</param>
        /// <param name="max">Num max per verificar (inclos)</param>
        /// <returns></returns>
        public static bool ValidateOption(int usernumber, int min, int max)
        {
            return !(usernumber >= min && usernumber <= max);
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
        /// Retorna un número aleatori entre 0 i max
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
        public static AAnimal? ObtenerAnimalPorSuperfamilia(string superfamily)
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
    }
}
