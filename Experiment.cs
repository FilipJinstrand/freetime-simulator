using System;
using System.IO;
using System.Text;
using System.Collections.Generic;


namespace freetime_simulator
{
    class Experiment
    {
        public List<Room> rooms = new List<Room>();
        public Person person = new Person();
        public List<Media> medias = new List<Media>();

        public Book book;
        public Movie movie;
        public Music music;


        private int experimentNumber;
        private int tries;
        private double time, startTime;
        private int pages;
        private double recordLength;
        private double movieLength;
        private bool completed = false;

        public void ExperimentSetup()
        {
            person.PersonSetup();

            RoomSetup();
            MediaSetup();
            ExperimentStart();
            SaveExperiment();
        }

        private void RoomSetup()
        {
            Room room1 = new Room();
            room1.hasBookChair = true;
            room1.hasDvdPlayer = true;
            room1.hasTv = true;

            rooms.Add(room1);
        }

        private void MediaSetup()
        {
            book = new Book();
            movie = new Movie();
            music = new Music();


            foreach (Room room in rooms)
            {
                /*FIXME:
                    If hasBook = false
                    console writes (The room does not have a book chair)!
                */
                if (room.hasBookChair && person.hasBook)
                {
                    medias.Add(book);
                }
                else
                {
                    Console.WriteLine("The room does not have a book chair");
                }

                if (room.hasDvdPlayer && person.hasMusic)
                {
                    medias.Add(music);
                }
                else
                {
                    Console.WriteLine("The room does not have a music player");
                }

                if (room.hasTv && person.hasFilm)
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
                media.WriteMediaInfo();
            }

            pages = book.pages;
            recordLength = music.length;
            movieLength = movie.length;
        }

        private void ExperimentStart()
        {
            Random rand = new Random();
            time = rand.Next(60, 180);
            startTime = time;
            experimentNumber++;

            //FIXME: Om personen inte hinner klart boken så tas inte tiden bort!
            foreach (Room room in rooms)
            {
                if (room.hasBookChair && person.hasBook)
                {
                    int pagesRead = person.readSpeed * Convert.ToInt32(time);

                    if (pagesRead >= pages)
                    {
                        //FIXME: Oklart om detta stämmer!
                        time = time - (pages / person.readSpeed);
                        Console.WriteLine("The person made it through the book");
                        book.completed = true;
                    }
                    else
                    {
                        Console.WriteLine("The person did not finnish the book in time :(");
                    }
                }

                if (room.hasDvdPlayer && person.hasMusic)
                {
                    if (time >= recordLength)
                    {
                        time = time - recordLength;
                        Console.WriteLine("The person made it through the music record");
                        music.completed = true;
                    }
                    else
                    {
                        Console.WriteLine("The person did not finnish the record in time :(");

                    }
                }

                if (room.hasTv && person.hasFilm)
                {
                    if (time >= movieLength)
                    {
                        time = time - movieLength;
                        Console.WriteLine("The person made it through the movie!");
                        movie.completed = true;
                    }
                    else
                    {
                        Console.WriteLine("The person did not finnish the movie in time :(");
                    }
                }
            }
        }

        private void SaveExperiment()
        {
            //TODO: Find a way to save to this directory on other computers

            string path = @"C:\SKOLA\freetime-simulator\TestFile.txt";

            string personInfo = "Experiment nr: " + Convert.ToString(experimentNumber) + "\n" + "Person name: "
                + person.name + "\n" + "Person read speed: " + Convert.ToString(person.readSpeed) +
                " Pages / Minute\n" + "Time: " + Convert.ToString(startTime) + " minutes" + "\n\n\n";
            if (!File.Exists(path))
            {
                File.AppendAllText(path, personInfo);
                foreach (Media media in medias)
                {
                    File.AppendAllText(path, media.GetMediaInfo());
                }
            }
            else
            {
                File.AppendAllText(path, personInfo);
                foreach (Media media in medias)
                {
                    File.AppendAllText(path, media.GetMediaInfo());
                }
            }
        }
    }
}