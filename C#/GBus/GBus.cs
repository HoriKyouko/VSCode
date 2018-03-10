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
    static void Main(string[] args){

        List<Tuple<int, int>> test = new List<Tuple<int,int>>();
        test.Add(new Tuple<int, int>(4,2));
        test.Insert(1, new Tuple<int,int>(1,2));
        Tuple<int, int> tempTuple;
        tempTuple = test[1];
        int addition = tempTuple.Item1 + tempTuple.Item2;
        Console.WriteLine(addition);
        

        /*TextReader reader = File.OpenText("PLACE TEXT FILE LOCATION HERE");
        string text = reader.ReadLine();
        
        int testCases = Int32.Parse(text);
        text = reader.ReadLine();

        int gBuses = Int32.Parse(text);
        text = reader.ReadLine();
        
        string[] bits = text.Split(' ');
        
        int[] cities = new int[gBuses * 2];
        
        for(int i = 0; i < cities.Length; i++){
            cities[i] = Int32.Parse(bits[i]);
        }
        int numOfCities;
        text = reader.ReadLine();
        numOfCities = Int32.Parse(text);

        int[] citiesToVisit = new int[numOfCities];
        for(int i = 0; i < numOfCities; i++){
            text = reader.ReadLine();
            citiesToVisit[i] = Int32.Parse(text);
        }*/
    }
}