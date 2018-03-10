using System;
using System.IO;
/*      
    What I need:
    1. Number of TestCases
    2. Number of GBuses
    3. Tuple of (x,y) where x is the start and y is the end.
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
        
        /*int testCases = Int32.Parse(args[0]);
        int gBuses = Int32.Parse(args[1]);
        int count = 2;
        int numOfCities;
        int[] cities = new int[gBuses*2];
        for(int i = 0; i < gBuses * 2; i++){
            cities[i] = Int32.Parse(args[count]);
            count++;
        }
        numOfCities = Int32.Parse(args[count+1]);*/

        TextReader reader = File.OpenText("PLACE TEXT FILE LOCATION HERE");
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
        }
    }
}