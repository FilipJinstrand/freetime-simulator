using System;
using System.Collections.Generic;


namespace freetime_simulator
{
    class Experiment
    {
        int experimentNumber;
        int tries;
        int time;
        public List<Room> rooms = new List<Room>();
        public Person person = new Person();

        int pages;


        public void ExperimentSetup()
        {
            person.PersonSetup();

            RoomSetup();
            MediaSetup();
            ExperimentStart();
        }

        private void RoomSetup()
        {
            Room room1 = new Room();
            room1.hasBookChair = true;
            room1.hasDvdPlayer = false;
            room1.hasTv = false;

            rooms.Add(room1);
        }

        private void MediaSetup()
        {
            List<Media> medias = new List<Media>();
            Book book = new Book();
            Movie movie = new Movie();
            Music music = new Music();


            foreach (Room room in rooms)
            {
                if (room.hasBookChair)
                {
                    medias.Add(book);
                }
                else
                {
                    Console.WriteLine("The room does not have a book chair");
                }

                if (room.hasDvdPlayer)
                {
                    medias.Add(music);
                }
                else
                {
                    Console.WriteLine("The room does not have a music player");
                }

                if (room.hasTv)
                {
                    medias.Add(movie);
                }
                else
                {
                    Console.WriteLine("The room does not have a TV");
                }
            }
            foreach (Media media in medias)
            {
                media.MediaInfo();
            }

            pages = book.pages;
        }

        private void ExperimentStart()
        {
            Random rand = new Random();
            time = rand.Next(60, 180);
            experimentNumber++;

            foreach (Room room in rooms)
            {
                if (room.hasBookChair && person.hasBook)
                {
                    int pagesRead = person.readSpeed * time;

                    if (pagesRead >= pages)
                    {
                        time = (pages / person.readSpeed);
                        System.Console.WriteLine("Personen läste klart boken!");
                    }
                    else
                    {
                        System.Console.WriteLine("Personen hann inte läsa klart boken :(");
                    }
                }

                if (room.hasDvdPlayer && person.hasMusic)
                {
                    
                }

                if (room.hasTv && person.hasFilm)
                {
                    
                }
            }
        }
    }
}