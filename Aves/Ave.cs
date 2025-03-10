abstract class Ave 
{
    protected string Color { get; set; } = "";
    protected string Nombre { get; set; } = "";
    protected double Velocidad { get; set; }
    protected double Peso { get; set; }
    virtual public void Volar() {Console.WriteLine("El ave vuela.");}
}

class Gallina : Ave
{
    public Gallina(string nombre, string color, double velocidad, double peso)
    {
        Color = color;
        Nombre = nombre;
        Velocidad = velocidad;
        Peso = peso;
    }
    override public void Volar() {Console.WriteLine("El gallo no logra volar.");}
}

class Pato : Ave
{
    public Pato (string nombre, string color, double velocidad, double peso)
    {
        Color = color;
        Nombre = nombre;
        Velocidad = velocidad;
        Peso = peso;
    } 

    override public void Volar() {Console.WriteLine("El pato no logra volar.");}
    public void Flotar() {Console.WriteLine("El pato flota");}
}

class Pinguino : Ave
{
    public Pinguino (string nombre, string color, double velocidad, double peso)
    {
        Color = color;
        Nombre = nombre;
        Velocidad = velocidad;
        Peso = peso;
    } 

    override public void Volar() {Console.WriteLine("El pinguino no logra volar.");}
    public void Nadar() {Console.WriteLine("El pinguino nada.");}
}

class Paloma : Ave
{
    public Paloma (string nombre, string color, double velocidad, double peso)
    {
        Color = color;
        Nombre = nombre;
        Velocidad = velocidad;
        Peso = peso;
    }

    public override void Volar(){Console.WriteLine("La paloma vuela");}
}

class Loro : Ave
{
    private string Color2 {get; set;} = "";
    public Loro (string nombre, string color, string color2, double velocidad, double peso)
    {
        Color = color;
        Color2 = color2;
        Nombre = nombre;
        Velocidad = velocidad;
        Peso = peso;
    } 

    public override void Volar(){Console.WriteLine("El loro vuela");}
    public void Hablar() {Console.WriteLine("El loro repite sus palabras.");}
}
