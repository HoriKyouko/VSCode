using System;
using System.IO;
using System.Collections.Generic;
/*      
    What I need:
    1. Tuple of (x,y) where x is the start and y is the end.
    2. Need to build out functions for getting the data parsed
    from the file.

    The start is the city starting point and the end is the 
    city destination and it is inclusive so all numbers
    between x and y count as well.
    Each bus has a tuple to itself. Some buses go through the
    same cities and this is allowed.
    There are N buses so there should be n tuples.
    The next is the number of cities we want to track,
    followed by the number of that city.

    GOAL: Find how many buses run through the particular cities
    we are tracking.

    OUTPUT: "Case #Ti:" where i is the testcase.
*/
class GBus
{
    static void Main(string[] args)
    {
        /*List<Tuple<int, int>> test = new List<Tuple<int, int>>();
        test.Add(new Tuple<int, int>(4, 2));
        test.Insert(1, new Tuple<int, int>(1, 2));
        Tuple<int, int> tempTuple;
        tempTuple = test[1];
        int addition = tempTuple.Item1 + tempTuple.Item2;
        Console.WriteLine(addition);*/
        int testCases;
        int gBuses;
        List<Tuple<int,int>> tuples;
        int numOfCities;
        int[] citiesToVisit;

        TextReader reader = File.OpenText(path: "GBus.txt");
        string text = reader.ReadLine();

        testCases = parsedInt(text);

        Tuple<int, List<Tuple<int,int>>,int, int[]> tuple = dataFromFile(reader);
        gBuses = tuple.Item1;
        tuples = tuple.Item2;
        numOfCities = tuple.Item3;
        citiesToVisit = tuple.Item4;
        Console.WriteLine(testCases);
        Console.WriteLine(gBuses);
        Console.WriteLine(tuples.Count);
        Console.WriteLine(numOfCities);
        Console.WriteLine(citiesToVisit.Length);
    }

    private static Tuple<int, List<Tuple<int, int>>, int, int[]> dataFromFile(TextReader reader)
    {
        string text = reader.ReadLine();
        int gBuses = parsedInt(text);

        text = reader.ReadLine();
        string[] bits = text.Split(' ');
        List<Tuple<int, int>> tuples = new List<Tuple<int, int>>();
        
        for (int i = 0; i < gBuses*2; i+=2)
        {
            tuples.Add(new Tuple<int,int>(parsedInt(bits[i]), parsedInt(bits[i+1])));
        }

        text = reader.ReadLine();
        int numOfCities = parsedInt(text);

        int[] citiesToVisit = new int[numOfCities];
        for (int i = 0; i < numOfCities; i++)
        {
            text = reader.ReadLine();
            citiesToVisit[i] = parsedInt(text);
        }
        Tuple<int, List<Tuple<int, int>>, int, int[]> tempTuple = Tuple.Create(gBuses, tuples, numOfCities, citiesToVisit);
        return tempTuple;
    }

    public static int parsedInt(string text) => Int32.Parse(text);
}