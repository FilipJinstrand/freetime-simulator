using System;
using System.Collections.Generic;


namespace freetime_simulator
{
    class Experiment
    {
        int number;
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
        }

        private void RoomSetup(){
            Room room1 = new Room();
            room1.hasBookChair = false;
            room1.hasDvdPlayer = true;
            room1.hasTv = false;

            rooms.Add(room1);
        }

        private void MediaSetup(){
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

                pages = book.pages;

            }

            foreach (Media media in medias)
            {
                media.MediaInfo();
            }
        }

        private void ExperimentStart()
        {
            Random rand = new Random();
            time = rand.Next(60, 180);
            number++;


            // Stämmer inte!
            int speed = pages * 60;

            if (speed > time)
            {
                
            }
        }
    }
}