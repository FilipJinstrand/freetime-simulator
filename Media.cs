using System;


namespace freetime_simulator
{
    class Media
    {
        public float length;

        public virtual void MediaInfo(){

        }
    }

    class Book : Media
    {
        private string name;
        private string author;
        private int pages;

        public override void MediaInfo(){
            Console.WriteLine("Write the name of book");
            name = Console.ReadLine();

            Console.WriteLine("Who made the book?");
            author = Console.ReadLine();

            Console.WriteLine("How many pages does the book have?");
            pages = Convert.ToInt32(Console.ReadLine());
        }

    }

    class Music : Media
    {
        private string name;
        private string artist;
        private bool twoSided;

        public override void MediaInfo(){
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
        }

    }

    class Movie : Media
    {
        private string titel;
        private int releaseDate;

        public override void MediaInfo(){
            Console.WriteLine("Write the name of the movie");
            titel = Console.ReadLine();

            Console.WriteLine("When was the movie released?");
            releaseDate = Convert.ToInt32(Console.ReadLine());
        }
    }
}