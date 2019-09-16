using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //STRING ARRAY
        string[] songName = { "Castle on the Hill", "Dive", "Shape of You", "Perfect", "Happier", "Barcelona", "Save Myself" };
        Console.WriteLine("Please select a number between 1 and 7 for an Ed Sheeran song recommendation!");
        int numEd = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.WriteLine(songName[numEd]);

        //INT ARRAY
        int[] intArray = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
        Console.WriteLine("Do you know the Fibonacci Sequence? Test your knowledge of the first 10 numbers.");
        int numFib = Convert.ToInt32(Console.ReadLine()) - 1;
        if (numFib > 9)
        {
            Console.WriteLine("Pick a better number.");
        }
        else
        {
            Console.WriteLine(intArray[numFib]);
        }
        
        Console.ReadLine();


        //STRING LIST
        List<string> stringList = new List<string>();
        stringList.Add("Home - Cavetown");
        stringList.Add("Somewhere Only We Know - Renee Dominique");
        stringList.Add("Just Us - Said the Sky");
        stringList.Add("Feel Good - Gryffin");
        stringList.Add("You and Me - James TW");
        stringList.Add("Inside Out - Camila Cabello");
        stringList.Add("Iris - Goo Goo Dolls");
        stringList.Add("Wonderwall - Oasis");
        stringList.Add("Barcelona - Ed Sheeran");
        stringList.Add("Lover - Taylor Swift");

        Console.WriteLine("Please pick a number between 1 and 10 for a good song recommendation");
        int numSong = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.WriteLine(stringList[numSong]);
        Console.ReadLine();







        //LIST ARRAY
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();





        //NUMBER ARRAYS
        //3 DIFFERENT WAYS TO CREATE THEM

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
        //Console.WriteLine(numArray1[3]);

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600 };
        //numArray2[5] = 650;


    }
}

