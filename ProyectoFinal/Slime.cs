public class Slime : Enemigo
{
    private string color;
    private int tamano;
    //1 == pequeno
    //2 == mediano
    //3 == grande
    private string? nombreTamano;
    public Slime(int size = 1, string colour = "Verde", int hp = 3, int dmg = 1, int ac = 2) : base(hp*size, dmg*size, ac*size)
    {
        color = colour;

        if(size > 3 || size < 0)
        {
            tamano = 3;
        }

        else
        {
            tamano = size;
        }

        switch(tamano)
        {
            case 1: 
                nombreTamano = "Pequeno";
                break;
            case 2:
                nombreTamano = "Mediano";
                break;
            case 3:
                nombreTamano = "Grande";
                break;
        }

        nombre = "Slime" + " " + color + " " + nombreTamano;
    }
    public string GetColor() { return color; }
    public int GetTamano() { return tamano; }
}
