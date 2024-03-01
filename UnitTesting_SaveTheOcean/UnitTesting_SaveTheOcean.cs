using SaveTheOcean;

namespace UnitTesting_SaveTheOcean
{
    [TestClass]
    public class UnitTesting_SaveTheOcean
    {
        [TestMethod]
        public void TestMethod_ValidateOption_Correct()
        {
            // Arrange
            int option = 1;
            int min = 1;
            int max = 2;

            bool expected = true;
            // Act
            bool result = MethodsUtilities.ValidateOption(option, min, max);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod_ValidateOption_Incorrect()
        {
            // Arrange
            int option = 3;
            int min = 1;
            int max = 2;

            bool expected = false;
            // Act
            bool result = MethodsUtilities.ValidateOption(option, min, max);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod_RandomNum()
        {
            // Arrange
            int min = 1;
            int max = 2;

            int expected = 1;
            // Act
            int result = MethodsUtilities.RandomNum(min, max);
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod_RandomNum2()
        {
            // Arrange
            int min = 0;
            int max = 11;
            int expectedmin = 0;
            int expectedmax = 10;
            // Act
            int result = MethodsUtilities.RandomNum(min, max);
            // Assert
            Assert.IsTrue(result >= expectedmin && result <= expectedmax);
        }

        [TestMethod]
        public void TestMethod_RandomNum_OverWriting()
        {
            // Arrange
            int max = 1;
            int expected = 0;
            // Act
            int result = MethodsUtilities.RandomNum(max);
            // Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestMethod_RandomNum_OverWriting2()
        {
            // Arrange
            int max = 11;
            int expectedmin = 0;
            int expectedmax = 10;
            // Act
            int result = MethodsUtilities.RandomNum(max);
            // Assert
            Assert.IsTrue(result >= expectedmin && result <= expectedmax);
        }

        [TestMethod]
        public void TestMethod_GetRandomSuperfamily()
        {
            // Arrange
            string[] superfamily = { "Tortuga marina", "Au marina", "Cetaceo" };
            bool expectedFound = false; 
            int iteration = 0;
            // Act
            string superfamilyString = MethodsUtilities.GetRandomSuperfamily();
            // Assert
            while (!expectedFound && iteration < superfamily.Length)
            {
                if (superfamilyString == superfamily[iteration])
                {
                    expectedFound = true;
                }
                iteration++;
            }
            
            Assert.IsTrue(expectedFound);
        }

        [TestMethod]
        public void TestMethod_GetAnimalBySuperfamily()
        {
            // Arrange
            string superfamily = "Tortuga marina";
            string expected = "SeaTurtle";
            // Act
            AAnimal? result = MethodsUtilities.GetAnimalBySuperfamily(superfamily);
            // Assert
            Assert.AreEqual(expected, result.GetType().Name);
        }

        [TestMethod]
        public void TestMethod_GetAnimalBySuperfamily2()
        {
            // Arrange
            string superfamily = "Au marina";
            string expected = "SeaBird";
            // Act
            AAnimal? result = MethodsUtilities.GetAnimalBySuperfamily(superfamily);
            // Assert
            Assert.AreEqual(expected, result.GetType().Name);
        }

        [TestMethod]
        public void TestMethod_GetAnimalBySuperfamily3()
        {
            // Arrange
            string superfamily = "Cetaceo";
            string expected = "Cetaceans";
            // Act
            AAnimal? result = MethodsUtilities.GetAnimalBySuperfamily(superfamily);
            // Assert
            Assert.AreEqual(expected, result.GetType().Name);
        }

        [TestMethod]
        public void TestMethod_PrintInfoData()
        {
            // Arrange
            Rescued rescued = new Rescued(new SeaTurtle());
            rescued.Number = "RES145";
            rescued.Date = "2021-05-12";
            rescued.Animal.Superfamily = "Tortuga marina";
            rescued.Superfamily = "Tortuga marina";
            rescued.Animal.GradeAfectation = 50;
            rescued.Location = "Mar Mediterráneo";
            StringWriter sw = new();
            Console.SetOut(sw);
            string expected = "+-------------------------------------------------------------+\r\n" +
                            "|                       RESCAT                                |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "| # Rescat | Data rescat | Superfamília   | GA | Localització |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "|  RES145  | 2021-05-12 | Tortuga marina | 50 | Mar Mediterráneo |\r\n" +
                            "+-------------------------------------------------------------+";

            // Act
            MethodsUtilities.PrintInfoData(rescued);


            // Assert
            Assert.AreEqual(expected, sw.ToString().Trim());

        }

        [TestMethod]
        public void TestMethod_PrintInfoDataSheet()
        {
            // Arrange
            Rescued rescued = new Rescued(new SeaTurtle());
            rescued.Animal.Name = "Donatello";
            rescued.Animal.Superfamily = "Tortuga marina";
            rescued.Animal.Specie = "Tortuga tonta";
            rescued.Animal.WeightAprox = 120.0;
            StringWriter sw = new();
            Console.SetOut(sw);
            string expected = "+-------------------------------------------------------------+\r\n" +
                            "|                       FITXA                                 |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "| # Nom  | Superfamília   | Espècie       | Pes aproximat     |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "| Donatello | Tortuga marina | Tortuga tonta | 120,0          kg |\r\n" +
                            "+-------------------------------------------------------------+";
            // Act
            MethodsUtilities.PrintInfoDataSheet(rescued);

            // Assert
            Assert.AreEqual(expected, sw.ToString().Trim());
        }
    }
}