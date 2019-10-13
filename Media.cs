using System;


namespace freetime_simulator
{
    class Media
    {
        public double length;

        public virtual void MediaInfo()
        {

        }
    }

    class Book : Media
    {
        public string name;
        private string author;
        public int pages;

        public override void MediaInfo()
        {
            Console.WriteLine("Write the name of book");
            name = Console.ReadLine();

            Console.WriteLine("Who made the book?");
            author = Console.ReadLine();

            bool reDo = true;
            while (reDo)
            {
                Console.WriteLine("How many pages does the book have?");
                try
                {
                    pages = Convert.ToInt32(Console.ReadLine());
                    reDo = false;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e);

                    Console.WriteLine("\n\n\nYou have to write in numbers!");

                }
            }
        }

    }

    class Music : Media
    {
        private string name;
        private string artist;
        private bool twoSided;

        public override void MediaInfo()
        {
            string answer;

            Console.WriteLine("Write the name of the record");
            name = Console.ReadLine();

            Console.WriteLine("Who made the record?");
            artist = Console.ReadLine();

            Console.WriteLine("Is it two sided? [Y] [N]");
            answer = Console.ReadLine();
            answer.ToLower();

            if (answer == "y")
            {
                twoSided = true;
            }

            Console.WriteLine("How long is the record? (in minutes)");
            length = Convert.ToDouble(Console.ReadLine());
        }

    }

    class Movie : Media
    {
        private string titel;
        private string releaseDate;

        public override void MediaInfo()
        {
            Console.WriteLine("Write the name of the movie");
            titel = Console.ReadLine();

            Console.WriteLine("When was the movie released? (month)");
            releaseDate = Console.ReadLine();

            bool reDo = true;
            while (reDo)
            {
                try
                {
                    Console.WriteLine("How long is the movie? (in minutes)");
                    length = Convert.ToDouble(Console.ReadLine());
                    reDo = false;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e);
                    
                    Console.WriteLine("\n\n\nYou have to write in numbers!");
                }
            }
        }
    }
}