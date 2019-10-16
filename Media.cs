using System;


namespace freetime_simulator
{
    class Media
    {
        public double length;

        public string saveText;
        public bool completed = false;

        public virtual void WriteMediaInfo()
        {

        }

        public virtual string GetMediaInfo()
        {
            return saveText;
        }
    }

    class Book : Media
    {
        public string name;
        private string author;
        public int pages;

        public override void WriteMediaInfo()
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

        public override string GetMediaInfo()
        {
            saveText = "Name of book: " + name + "\n" + "Name of Author: " + author + "\n" + "Nr of pages: " +
                Convert.ToString(pages) + "\n" + "Completed: " + Convert.ToSingle(completed) + "\n\n\n";

            return saveText;
        }
    }

    class Music : Media
    {
        private string name;
        private string artist;
        private bool twoSided;

        public override void WriteMediaInfo()
        {
            string answer;

            Console.WriteLine("Write the name of the record");
            name = Console.ReadLine();

            Console.WriteLine("Who made the record?");
            artist = Console.ReadLine();

            //TODO: This has to do something!
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

        public override string GetMediaInfo()
        {
            saveText = "Name of record: " + name + "\n" + "Name of Artist: " + artist + "\n" + "Minutes long: " +
                Convert.ToString(length) + "\n" + "Completed: " + Convert.ToSingle(completed) + "\n\n\n";

            return saveText;
        }
    }

    class Movie : Media
    {
        private string title;
        private string releaseDate;

        public override void WriteMediaInfo()
        {
            Console.WriteLine("Write the name of the movie");
            title = Console.ReadLine();

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

        public override string GetMediaInfo()
        {
            saveText = "Name of the movie: " + title + "\n" + "Release date: " + releaseDate + "\n" + "Minutes long: " +
                Convert.ToString(length) + "\n" + "Completed: " + Convert.ToSingle(completed) + "\n\n\n";

            return saveText;
        }
    }
}