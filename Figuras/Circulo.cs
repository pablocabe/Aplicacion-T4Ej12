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

public class Rectangulo
{
    private double _base;
    private double _altura;

    public Rectangulo (double _base, double _altura){
        this._base = _base;
        this._altura = _altura;
    }

    public double GetArea(){
        double area = _base * _altura;
        return area;
    }
}


