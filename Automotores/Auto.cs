namespace Automotores;

public class Auto
{
    private string _marca;
    private int _modelo;
    public Auto (string marca, int modelo){
        _marca = marca;
        _modelo = modelo;
    }
    public Auto(string marca){
        _marca = marca;
        _modelo = DateTime.Now.Year;
    }
    public Auto(){
        _marca = "Fiat";
        _modelo = DateTime.Now.Year;
    }
    public string GetDescripcion(){
        return $"Auto {_marca} {_modelo}";
    }
}
