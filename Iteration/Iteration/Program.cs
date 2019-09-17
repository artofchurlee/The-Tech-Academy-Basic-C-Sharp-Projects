using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {

        //ADDING USER'S INPUT INTO ARRAY
        //string[] onePiece = { "Luffy", "Zoro", "Nami", "Usopp", "Sanji", "Chopper", "Franky", "Robin", "Brooke" };
        //Console.WriteLine("Do you think Jinbei or Carrot will be the next Straw Hat member?");

        //Array.Resize(ref onePiece, onePiece.Length + 1);
        //onePiece[onePiece.Length - 1] = Console.ReadLine();


        //for (int i = 0; i < onePiece.Length; i++)
        //{
        //    Console.WriteLine(\nonePiece[i]);
        //}
        //Console.ReadLine();


        //int[] infLoop = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
        //INFINITE LOOP
        //for (int i = 0; i >= 0; i++)

        //FIXED LOOP
        //for (int i=0; i < infLoop.Length; i++)
        //{
        //    Console.WriteLine(infLoop[i]);
        //}
        //Console.ReadLine();


        //OPERATOR IS <
        //for (int j = 0; j < infLoop.Length; j++)
        //{
        //    Console.WriteLine("The number is :" + infLoop[j]);
        //}
        //Console.ReadLine();

        //OPERATOR IS <=
        //for (int k = 9; k <= 9; k--)
        //{
        //    Console.WriteLine("The number is :" + infLoop[k]);
        //}
        //Console.ReadLine();

        // SEARCH TEXT IN LIST
        //#6-8
        List<string> songs = new List<string>();
        songs.Add("I Forgot That You Existed");
        songs.Add("Cruel Summer");
        songs.Add("Lover");
        songs.Add("The Man");
        songs.Add("The Archer");
        songs.Add("I Think He Knows");
        songs.Add("Miss Americana & the Heartbreak Prince");
        songs.Add("Paper Rings");
        songs.Add("Cornelia Street");
        songs.Add("Death by a Thousand Cuts");
        songs.Add("London Boy");
        songs.Add("Soon You'll Get Better");
        songs.Add("False God");
        songs.Add("You Need to Calm Down");
        songs.Add("Afterglow");
        songs.Add("Me!");
        songs.Add("It's Nice to Have a Friend");
        songs.Add("Daylight");

        Console.WriteLine("Write a song name to see if it's in the new Taylor Swift album!");
        string searchKeyword = Console.ReadLine();
        bool sMatch = false;

        foreach (string song in songs)
        {
            if (song == searchKeyword)
            {
                Console.WriteLine(song);
                sMatch = true;
                break;
            }

        }
        if (!sMatch)
        {
            Console.WriteLine("That song is not in the album!");
        }



        Console.ReadLine();


        List<string> actors = new List<string>();
        actors.Add("Robert");
        actors.Add("Scarlett");
        actors.Add("Chris");
        actors.Add("Chris");
        actors.Add("Mark");
        actors.Add("Jeremy");
        actors.Add("Tom");
        actors.Add("Tom");
        actors.Add("Chris");
        actors.Add("Samuel");
        actors.Add("Elizabeth");
        actors.Add("Benedict");

        // #9-10
        Console.WriteLine("Name an actor from Avengers (just first name).");
        string[] actArray = actors.ToArray();
        string searchActor = Console.ReadLine();
        bool actMatch = false;
        for (int i = 0; i < actArray.Length; i++)
        {
            if (actArray[i] == searchActor)
            {
                Console.WriteLine(actArray[i] + ", " + i);
                actMatch = true;
            }
        }
        if (!actMatch)
        {
            Console.WriteLine("The actor you entered is not in Avengers.");
        }
        Console.ReadLine();


        //#11
        int counter = 0;
        bool alreadyExists = false;
        foreach (string actor in actors)
        {
            for (int j = 0; j < counter; j++)
            {
                if (actor == actors[j])
                {
                    alreadyExists = true;
                    Console.WriteLine(actor + " has already appeared");
                    break;
                }

            }
            if (!alreadyExists)
            {
                Console.WriteLine(actor + " has not appeared");
            }
            alreadyExists = false;
            counter++;
        }


        Console.ReadLine();






        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85) ;
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    if (names[j] == "Jesse")
        //    {
        //        Console.WriteLine(names[j]);
        //    }
        //}
        //Console.ReadLine();



    }
}

