using System;


namespace freetime_simulator
{
    class Person
    {
        public int readSpeed;
        public string name;

        public bool hasBook = false;
        public bool hasFilm = false;
        public bool hasMusic = false;

        public void PersonSetup()
        {
            Console.WriteLine("What's the persons name?");
            name = Console.ReadLine();

            bool reDo = true;
            while (reDo)
            {
                try
                {
                    Console.WriteLine("What's the persons reading speed?");
                    readSpeed = Convert.ToInt32(Console.ReadLine());
                    reDo = false;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e);

                    Console.WriteLine("\n\n\nYou have to write in numbers!");
                }
            }

            PersonBrought();
        }

        private void PersonBrought()
        {
            string answer;

            Console.WriteLine("Did the person bring a book? [Y] [N]");
            answer = Console.ReadLine();
            answer.ToLower();
            if (answer == "y")
            {
                hasBook = true;
            }

            Console.WriteLine("Did the person bring a film? [Y] [N]");
            answer = Console.ReadLine();
            answer.ToLower();
            if (answer == "y")
            {
                hasFilm = true;
            }

            Console.WriteLine("Did the person bring music? [Y] [N]");
            answer = Console.ReadLine();
            answer.ToLower();
            if (answer == "y")
            {
                hasMusic = true;
            }
        }
    }
}