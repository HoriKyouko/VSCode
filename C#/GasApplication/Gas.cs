using System;
using System.Collections.Generic;

namespace GasApplication{
    class Gas{
        static void Main(string[] args){
            // Create an instance of the persons vehicle and add their
            // vehicle information.
            Vehicle vehicle = new Vehicle();
            addVehicle(vehicle);
            // Get number of Gas Stations nearby.
            int numberOfGasStations = getNumberOfGasStations();
            // Create these stations as a LinkedList for easy storage.
            LinkedList<GasStation> list = new LinkedList<GasStation>();
            // Add the information for these stations.
            for(int i = 0; i < numberOfGasStations; i++)
                addNewGasStation(list);
            // By default payment is 20$
            double payment = 20.00;
            LinkedListNode<GasStation> node = list.First;
            for(int i = 0; i < numberOfGasStations; i++){
                // Amount of Gas we receive for the amount were going to pay.
                double gas = grossGas(payment, node);
                // gallons burned to get to gas station.
                double gasBurned = gasBurnedGettingToStation(node, vehicle);
                setNetFuel(node, gas, gasBurned);
                node = node.Next;
            }
            
            findBestStation(list);
        }

        private static void findBestStation(LinkedList<GasStation> list){
            GasStation station = new GasStation();
            LinkedListNode<GasStation> node = list.First;
            for(int i = 0; i < list.Count; i++){
                if(station.NetGas < node.Value.NetGas)
                    station = node.Value;
                node = node.Next;
            }
            Console.WriteLine("The Best station is: {0}\nwith the price: {1}" +
            "\nat a distance of: {2}\nyou get: {3} gas!",
            station.Name, station.PriceOfFuel, station.Distance, station.NetGas);
        }

        private static void setNetFuel(LinkedListNode<GasStation> node, double gas, double gasBurned){
            node.Value.NetGas = gas - gasBurned;
        }

        private static double grossGas(double payment, LinkedListNode<GasStation> node){
            double fuelCost = node.Value.PriceOfFuel;
            return (payment/fuelCost);
        }

        private static double gasBurnedGettingToStation(LinkedListNode<GasStation> node, Vehicle vehicle){
            double vehMPG = vehicle.Mpg;
            double statDist = node.Value.Distance;
            return (statDist/vehMPG);
        }

        private static void addVehicle(Vehicle vehicle){
            setManufacturer(vehicle);
            setModel(vehicle);
            setYear(vehicle);
            setMPG(vehicle);
        }

        private static void addNewGasStation(LinkedList<GasStation> list){
            GasStation station = new GasStation();
            setStationName(station);
            setDistanceToGasStation(station);
            setFuelPrice(station);
            list.AddFirst(station);
        }

        private static int getNumberOfGasStations(){
            Console.WriteLine(value: "Enter number of Stations: ");
            int value = Int32.Parse(Console.ReadLine());
            return value;
        }
        private static void setDistanceToGasStation(GasStation station){
            Console.WriteLine("Enter the distance to the Station: ");
            station.Distance = Double.Parse(Console.ReadLine());
        }
        private static void setFuelPrice(GasStation station){
            Console.WriteLine("Enter the price of the fuel: ");
            station.PriceOfFuel = Double.Parse(Console.ReadLine());
        }
        private static void setStationName(GasStation station){
            Console.WriteLine("Enter the name of the station: ");
            station.Name = Console.ReadLine();
        }
        private static void setMPG(Vehicle vehicle){
            Console.WriteLine("Enter your vehicles MPG: ");
            vehicle.Mpg = Int32.Parse(Console.ReadLine());
        }
        private static void setManufacturer(Vehicle vehicle){
            Console.WriteLine("Enter your vehicles Manufacturer: ");
            vehicle.Manufacturer = Console.ReadLine();
        }
        private static void setModel(Vehicle vehicle){
            Console.WriteLine("Enter your vehicles Model: ");
            vehicle.Model = Console.ReadLine();
        }
        private static void setYear(Vehicle vehicle){
            Console.WriteLine("Enter your vehicles Year: ");
            vehicle.Year = Int32.Parse(Console.ReadLine());
        }
    }
}