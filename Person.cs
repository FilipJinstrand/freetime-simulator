using System;


namespace freetime_simulator
{
    class Person
    {
        public int readSpeed;
        string name;

        bool hasBook = false;
        bool hasFilm = false;
        bool hasMusic = false;

        public void PersonSetup()
        {
            Console.WriteLine("What's the persons name?");
            name = Console.ReadLine();

            Console.WriteLine("What's the persons reading speed?");
            readSpeed = Convert.ToInt32(Console.ReadLine());

            PersonBrought();
        }

        private void PersonBrought(){
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