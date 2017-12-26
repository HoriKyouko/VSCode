namespace GasApplication
{
    internal class Vehicle
    {
        private int mpg;
        private string model;
        private string manufacturer;
        private int year;
        
        public Vehicle()
        {
            this.mpg = 0;
            this.model = "";
            this.manufacturer = "";
            this.year = 1900;
        }

        public int Mpg { get => mpg; set => mpg = value; }
        public string Model { get => model; set => model = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public int Year { get => year; set => year = value; }
    }
}