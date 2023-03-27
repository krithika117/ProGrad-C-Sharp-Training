namespace day_4_test

{
    class Question1
    {
        void iteration1()
        {
            try
            {
                Console.WriteLine("Welcome to the Mentalist Program");
                Console.WriteLine("Answer the following questions and get to know a breif idea about your personality.");
                Console.WriteLine("Note: Only type y/n for the answers");

                Console.WriteLine("Do you enjoy being the center of attention in a group?");
                string res = Console.ReadLine();

                Console.WriteLine("Are you often critical of others, even when they don't ask for your opinion?");
                string res1 = Console.ReadLine();

                Console.WriteLine("Do you like to plan everything out in advance, or do you prefer to take things as they come?");
                string res2 = Console.ReadLine();

                Console.WriteLine("Are you generally a trusting person, or do you have a hard time trusting others?");
                string res3 = Console.ReadLine();

                Console.WriteLine("Do you tend to hold grudges?");
                string res4 = Console.ReadLine();

                if (res1.Equals('y') && res4.Equals('y'))
                    Console.WriteLine("Personality A");
                else if (res2.Equals('y') && res4.Equals('y'))
                    Console.WriteLine("Personality B");
                else if (res3.Equals('n') || res.Equals('y'))
                    Console.WriteLine("Personality C");
                else if (res2.Equals('n') && res.Equals('y'))
                    Console.WriteLine("Personality D");
                else
                    Console.WriteLine("Unique Personality!");

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        void iteration2()
        {
            Console.WriteLine("\nWelcome to Level 2 of the personality test. \nPlease enter your birth month (e.g. January):");
            string month = Console.ReadLine().ToLower();
            string partner = "";
            switch (month)
            {
                case "january":
                    partner = "Mr. Bean";
                    Console.WriteLine("Your zodiac sign is Aquarius");
                    break;
                case "february":
                    partner = "Homer Simpson";
                    Console.WriteLine("Your zodiac sign is Pisces");
                    break;
                case "march":
                    partner = "Arthur Weasley";
                    Console.WriteLine("Your zodiac sign is Aries");
                    break;
                case "april":
                    partner = "Mitchell Pritchett";
                    Console.WriteLine("Your zodiac sign is Taurus");
                    break;
                case "may":
                    partner = "The Hatter";
                    Console.WriteLine("Your zodiac sign is Gemini");
                    break;
                case "june":
                    partner = "Walter White";
                    Console.WriteLine("Your zodiac sign is Cancer");
                    break;
                case "july":
                    partner = "Jesse Pinkman";
                    Console.WriteLine("Your zodiac sign is Leo");
                    break;
                case "august":
                    partner = "Severus Snape";
                    Console.WriteLine("Your zodiac sign is Virgo");
                    break;
                case "september":
                    partner = "Phil Dunphy";
                    Console.WriteLine("Your zodiac sign is Libra");
                    break;
                case "october":
                    partner = "Mrs. Chanandler Bong";
                    Console.WriteLine("Your zodiac sign is Scorpio");
                    break;
                case "november":
                    partner = "Lord Voldemort";
                    Console.WriteLine("Your zodiac sign is Sagittarius");
                    break;
                case "december":
                    partner = "Star Lord";
                    Console.WriteLine("Your zodiac sign is Capricorn");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            Console.WriteLine("Your zodiac sign's partner is: " + partner);

        }
        void iteration3()
        {
            Console.WriteLine("\nThe Calendar Man welcomes you! \nPlease enter your date of birth");
            String input = Console.ReadLine();
            DateTime birthday = DateTime.Parse(input);

            TimeSpan difference = (DateTime.Now - birthday);
            Console.WriteLine("You are " + difference + " days old.");
        }
        static void Main(string[] args)
        {
            Question1 programObject = new Question1();
            programObject.iteration1();
            programObject.iteration2();
            programObject.iteration3();
        }
    }
}