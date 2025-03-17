class Llamada
{
    protected string numOrigen;
    protected string numDestino;
    protected double duracion;

    protected Llamada(string in_param1, string in_param2, double in_param3)
    {
        numOrigen = in_param1;
        numDestino = in_param2;
        duracion = in_param3;
    }

    public string getNumOrigen() { return numOrigen; }
    public string getNumDestino() { return numDestino; }
    public double getDuracion() { return duracion; }
    public virtual double calcularPrecio() { return 0;}
    public virtual string toString() { return ""; }
}

class LlamadaProvincial : Llamada
{
    private double precio1;
    private double precio2;
    private double precio3;
    private int franja;
    public LlamadaProvincial(string in_param1, string in_param2, int in_param3, int in_param4)
    : base(in_param1, in_param2, in_param3)
    {
        franja = in_param4;
    }

    public override double calcularPrecio()
    {
        switch(franja)
        {
            case 1:
                precio1 = duracion * 0.20;
                return precio1;
            case 2:
                precio2 = duracion * 0.25;
                return precio2;
            case 3:
                precio3 = duracion * 0.30;
                return precio3;
            default:
                Console.WriteLine("El sistema actual no soporta la franja de entrada");
                return 0;
        }
    }
    public override string toString()
    {
        switch(franja)
        {
            case 1:
            return $"El numero {numOrigen} llama al numero {numDestino} a traves de la franja {franja} con una duracion de {duracion} segundos y un precio de {precio1} pesos.";
            case 2:
            return $"El numero {numOrigen} llama al numero {numDestino} a traves de la franja {franja} con una duracion de {duracion} segundos y un precio de {precio2} pesos.";
            case 3:
            return $"El numero {numOrigen} llama al numero {numDestino} a traves de la franja {franja} con una duracion de {duracion} segundos y un precio de {precio3} pesos.";
            default:
            return "Su llamada no corresponde a ninguna franja en nuestro sistema.";
        }
    }
}

class LlamadaLocal: Llamada
{
    private double precio;
    public LlamadaLocal(string in_param1, string in_param2, int in_param3)
    : base(in_param1, in_param2, in_param3) {}
    public override double calcularPrecio()
    {
        precio = duracion * 0.15;
        return precio;
    }
    public override string toString()
    {
        return $"El numero {numOrigen} llama al numero {numDestino} con una duracion de {duracion} segundos y un precio de {precio} pesos.";
    }
}
