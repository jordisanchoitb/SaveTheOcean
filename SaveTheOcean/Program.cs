using Microsoft.VisualBasic.FileIO;
using System;

namespace SaveTheOcean
{
    public class GameProgram
    {
        public static void Main()
        {
            const string TITLE = "Save The Ocean!";
            const string WELCOME = "Benvingut al joc de rescat de la Fundació CRAM!";
            const string MENU = "Què vols fer?\n1. Jugar!\n2. Sortir";
            const string ERROR_OPTION = "Opció no vàlida. Introdueix un número entre {0} i {1}.";
            const string GOODBYE = "Adeu!";
            const string ENTER_NAME = "Genial! I el teu nom?";
            const string MENU2 = "Perfecte! Què vols ser?\n1. Tècnic (45 XP)\n2. Veterinari (80 XP)";
            const string MSG_112_RESCUED = "Hola, {0}! El 112 ha rebut una trucada d'avís d'un exemplar a rescatar.";
            const string MSG_INFODATA = "Les dades que ens han donat són les següents:";
            const string MSG_INFODATASHEET = "Aquí tens la seva fitxa, per a més informació:";
            const string MSG_TREATMENT = "{0} té un grau d'afectació (GA) del {1}%. Vols curar-lo (1) o traslladar-lo al centre (2)?";
            const string MSG_TREATMENT_EXIT = "El tractament aplicat ha reduït el GA fins al {0}%. Rescat èxit! {1}, de la espècie {2} ha estat reintroduït al medi natural.";
            const string MSG_TREATMENT_NOTEXIT = "El tractament aplicat ha reduït el GA fins al {0}%. L'exemplar {1}, de la espècie {2} requereix més atenció. Traslladant al CRAM.";
            const string MSG_XPAUGMENT = " La teva experiència ha augmentat en +{0}XP.";
            const string MSG_XPDECREASE = " La teva experiència s’ha reduït en -{0}XP.";
            const string MSG_EXPERIENTPOINTS = "Punts d'experiència totals: {0}";
            const string MSG_BYE = "Fins el proper rescat!";

            const int MIN_OPTION = 1, MAX_OPTION = 2, ONE=1, FIVE=5, FIFTY = 50, TWENTY = 20;


            int userOption, userRole, decisionTreatment, xpPlayer, newGradeAfectation;
            string namePlayer, superFamily;
            bool heal, errorSetOption = false;

            Console.WriteLine(TITLE);
            Console.WriteLine(WELCOME);
            Console.WriteLine(MENU);
            do
            {
                if (errorSetOption)
                {
                    Console.WriteLine(ERROR_OPTION, MIN_OPTION, MAX_OPTION); ;
                }
                userOption = Convert.ToInt32(Console.ReadLine());
                errorSetOption = true;
            } while (!MethodsUtilities.ValidateOption(userOption, MIN_OPTION, MAX_OPTION));

            if (userOption == 1)
            {
                Console.WriteLine(MENU2);
                errorSetOption = false;
                do
                {
                    if (errorSetOption)
                    {
                        Console.WriteLine(ERROR_OPTION, MIN_OPTION, MAX_OPTION); ;
                    }
                    userRole = Convert.ToInt32(Console.ReadLine());
                    errorSetOption = true;
                } while (!MethodsUtilities.ValidateOption(userRole, MIN_OPTION, MAX_OPTION));

                Console.WriteLine(ENTER_NAME);
                namePlayer = Console.ReadLine() ?? "Pepito";
                if (namePlayer.Length == 0)
                {
                    namePlayer = "Pepito";
                }
                xpPlayer = userRole == 1 ? 45 : 80;
                // Instancio el jugador
                Player player = new Player(namePlayer, xpPlayer);

                // Agafem un super família aleatòria a partir del mètode GetRandomSuperfamily
                superFamily = MethodsUtilities.GetRandomSuperfamily();

                // Instanciem un animal a rescata de la super família obtinguda anteriorment
                AAnimal animal = MethodsUtilities.GetAnimalBySuperfamily(superFamily) ?? new SeaTurtle();

                // Instanciem un rescat amb la super família obtinguda anteriorment
                Rescued rescued = new Rescued(animal);

                
                Console.WriteLine(MSG_112_RESCUED, player.Name);
                Console.WriteLine(MSG_INFODATA);
                Console.WriteLine();
                MethodsUtilities.PrintInfoData(rescued);
                Console.WriteLine();
                Console.WriteLine(MSG_INFODATASHEET);
                Console.WriteLine();
                MethodsUtilities.PrintInfoDataSheet(rescued);
                Console.WriteLine();
                Console.WriteLine(MSG_TREATMENT, rescued.Animal.Name, rescued.Animal.GradeAfectation);

                errorSetOption = false;
                do
                {
                    if (errorSetOption)
                    {
                        Console.WriteLine(ERROR_OPTION, MIN_OPTION, MAX_OPTION);
                    }
                    decisionTreatment = Convert.ToInt32(Console.ReadLine());
                    errorSetOption = true;
                } while (!MethodsUtilities.ValidateOption(decisionTreatment, MIN_OPTION, MAX_OPTION));

                heal = (decisionTreatment == ONE);
                newGradeAfectation = animal.CalculateNewGradeAfectation(heal);
                if (newGradeAfectation < FIVE)
                {
                    Console.Write(MSG_TREATMENT_EXIT, newGradeAfectation, rescued.Animal.Name, rescued.Animal.Specie);
                    Console.WriteLine(MSG_XPAUGMENT,FIFTY);
                    player.Experience += FIFTY;
                } else
                {
                    Console.Write(MSG_TREATMENT_NOTEXIT, newGradeAfectation, rescued.Animal.Name, rescued.Animal.Specie);
                    Console.WriteLine(MSG_XPDECREASE, TWENTY);
                    player.Experience -= TWENTY;
                }

                Console.WriteLine(MSG_EXPERIENTPOINTS, player.Experience);
                Console.WriteLine(MSG_BYE);

            } else
            {
                Console.WriteLine(GOODBYE);
            }
        }
    }
}
