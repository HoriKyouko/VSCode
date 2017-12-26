using System;

class GasStation{
    private double distance;
    private string name;
    private double priceOfFuel;
    private double netGas;
    public GasStation(){
        this.distance = 0;
        this.name = "";
        this.priceOfFuel = 0.0;
        this.netGas = 0.0;
    }
    public double Distance{
        get{
            return distance;
        }
        set{
            distance = value;
        }
    }
    public string Name{
        get{
            return name;
        }
        set{
            name = value;
        }
    }
    public double PriceOfFuel{
        get{
            return priceOfFuel;
        }
        set{
            priceOfFuel = value;
        }
    }

    public double NetGas { get => netGas; set => netGas = value; }
}