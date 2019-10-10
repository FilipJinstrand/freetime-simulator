using System;
using System.Collections.Generic;


namespace freetime_simulator
{
    class Experiment
    {
        int number;
        int tries;

        public void ExperimentStart()
        {
            Person person = new Person();
            person.PersonSetup();

            RoomSetup();
            MediaSetup();
        }

        private void MediaSetup(){
            List<Media> medias = new List<Media>();
            Book book = new Book();
            Movie movie = new Movie();
            Music music = new Music();
            medias.Add(book);
            medias.Add(movie);
            medias.Add(music);

            foreach (Media media in medias)
            {
                media.MediaInfo();
            }
        }

        private void RoomSetup(){
            List<Room> rooms = new List<Room>();
            Room room1 = new Room();
            room1.hasBookChair = true;
            room1.hasDvdPlayer = true;
            room1.hasTv = true;

            rooms.Add(room1);
        }
    }
}