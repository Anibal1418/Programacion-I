/*Primero empezamos con un ejemplo de herencia simple, donde varias clases heredan de una clase madre.
Empezamos con una clase madre llamada Animal, esta tiene dos objetos y una función virtual la cual deberá ser
adaptada por todos sus hijos, en este caso, Perro y Gato. Animal podría considerarse una clase abstracta pero no es especificada.*/
public class Animal
{
    public Animal (string nombre, int edad)
    {
        this.Nombre = nombre;
        this.Edad = edad;
    }
    protected string Nombre {get; set;} //cada variable tiene el getter y setter predeterminado, ya que son privadas
    protected int Edad {get; set;}
    public virtual string Sonido()
    {
        return $"El animal {Nombre} hace un sonido";  
    }
}

public class Perro : Animal
{
    public Perro (string nombre, int edad, string raza) : base (nombre, edad) //delega al constructor principal estos parámetros
    {
        this.Raza = raza; //solo asigna las variables propias de esta clase
    }
    private string Raza {get; set;}
    public override string Sonido() //override de la función sonido
    {
        return $"{this.Nombre} hace Guau";
    }
}

public class Gato : Animal
{
    public Gato (string nombre, int edad, string colorDeOjos) : base (nombre, edad)
    {
        this.ColorDeOjos = colorDeOjos;
    }
    private string ColorDeOjos {get; set;}
    public override string Sonido()
    {
        return $"{this.Nombre} hace Miau";
    }
}
//Ya que más de una clase heredan de la clase principal o madre Animal, podríamos decir que esto es un caso de Herencia Jerárquica.
