using System;

namespace struct_lek
{
    internal class Program
    {
        static void Main()
        {
            // Skapar en array av Katt-strukturer med tre element
            Katt[] kattArray = new Katt[3];

            // Tilldela värden till varje element i arrayen
            kattArray[0] = new Katt { Name = "Whiskers", Image = "whiskers.jpg", CutenessLevel = 10, AllergyInducingFur = false, LivesLeft = 9 };
            kattArray[1] = new Katt { Name = "Mittens", Image = "mittens.jpg", CutenessLevel = 8, AllergyInducingFur = true, LivesLeft = 7 };
            kattArray[2] = new Katt { Name = "Fluffy", Image = "fluffy.jpg", CutenessLevel = 9, AllergyInducingFur = false, LivesLeft = 8 };

            // Nu har du en array av Katt-strukturer med tre katter


            // Alternativ två 
            Katt[] kattArrayen = {
            new Katt { Name = "Whiskers", Image = "whiskers.jpg", CutenessLevel = 10, AllergyInducingFur = false, LivesLeft = 9 },
            new Katt { Name = "Mittens", Image = "mittens.jpg", CutenessLevel = 8, AllergyInducingFur = true, LivesLeft = 7 },
            new Katt { Name = "Fluffy", Image = "fluffy.jpg", CutenessLevel = 9, AllergyInducingFur = false, LivesLeft = 8 }
            };

            // Skriv ut arrayen av katter
            Console.WriteLine("Arrayen av katter:");
            foreach (var katt in kattArray)
            {
                Console.WriteLine(katt);
            }
            // Skriv ut arrayen av katter
            Console.WriteLine("\nArrayen av katter två:");
            foreach (var smakatt in kattArrayen)
            {
                Console.WriteLine(smakatt);
            }

            // Skapa en ny instans av Cat-structen och tilldela värden till dess fält
            Cat myCat = new Cat
            {
                Name = "Whiskers",
                Image = "whiskers.jpg",
                CutenessLevel = 10,
                AllergyInducingFur = false,
                LivesLeft = 9
            };

            // Skriv ut information om katten
            Console.WriteLine("\nFaktiska värden:");
            Console.WriteLine($"Name: {myCat.Name}");
            Console.WriteLine($"Image: {myCat.Image}");
            Console.WriteLine($"Cuteness Level: {myCat.CutenessLevel}");
            Console.WriteLine($"Allergy Inducing Fur: {myCat.AllergyInducingFur}");
            Console.WriteLine($"Lives Left: {myCat.LivesLeft}");
            Console.WriteLine($"Struct: {myCat}");
        }
    }

    // Klassen Cat definieras inom samma namespace som Program-klassen
    public struct Cat
    {
        public string Name;
        public string Image;
        public int CutenessLevel;
        public bool AllergyInducingFur;
        public int LivesLeft;

        public override string ToString()
        {
            return $"Name: {Name}, Image: {Image}, Cuteness Level: {CutenessLevel}, Allergy Inducing Fur: {AllergyInducingFur}, Lives Left: {LivesLeft}";
        }
    }

    // Klassen Katt definieras inom samma namespace som Program-klassen
    public struct Katt
    {
        public string Name;
        public string Image;
        public int CutenessLevel;
        public bool AllergyInducingFur;
        public int LivesLeft;

        public override string ToString()
        {
            return $"Name: {Name}, Image: {Image}, Cuteness Level: {CutenessLevel}, Allergy Inducing Fur: {AllergyInducingFur}, Lives Left: {LivesLeft}";
        }
    }
}
