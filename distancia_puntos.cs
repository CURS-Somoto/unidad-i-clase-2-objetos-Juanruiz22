using System;

public class Punto
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }

    public Punto(double x, double y, double z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public decimal MedirDistancia(Punto destino)
    {
       
        return Math.Sqrt((destino.x - x) * (destino.x - x) + (destino.y - y) * (destino.y - y) + (destino.z - z) * (destino.z - z));
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Punto origen = new Punto(10.0, 20.0);
        Punto destino = new Punto(50.0, 60.0);

       
        var distancia = origen.MedirDistancia(destino);

    
        Console.WriteLine("La distancia entre los dos puntos es: {0}", distancia);
    }
}
