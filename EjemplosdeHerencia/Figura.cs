/*Ahora vamos con el ejemplo de una clase abstractas en el área de geometría llamada "Figura", de las que van a heredar
las clases triángulo y círculo. Las clases abstractas funcionan como una clase base cuyos métodos se pueden 
override en sus clases hijas:*/
public abstract class AFigura
{
    public string Color { get; set; }
    public abstract char Dibujar();

    public AFigura (string color)
    {
        this.Color = color;
    }
}

public class Circulo : AFigura
{
    public Circulo (string color) : base (color) {}
    public override char Dibujar ()
    {
        return '◯';
    }
}

public class Triangulo : AFigura
{
    public Triangulo (string color) : base (color) {}
    public override char Dibujar()
    {
        return '△';
    }
}

/*Básicamente, cada clase debe implementar las funciones de la clase abstracta obligatoriamente, a diferencia de
una clase madre no abstracta la cual no obliga implementación, y a diferencia de una interfaz ya que las clases
hijas de una clase abstracta pueden añadir incluso más funciones sobre las predeterminadas.*/
