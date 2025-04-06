namespace Figuras;

public class Circulo
{
    private double _radio;

    public Circulo (double _radio){
        this._radio = _radio;
    }

    public double GetArea(){
        double area = Math.PI * Math.Pow(_radio, 2); // Fórmula clásica
        return area;
    }
}
