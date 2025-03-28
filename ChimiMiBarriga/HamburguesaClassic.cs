class HamburguesaClassic
{
    protected string m_pan;
    protected string m_carne;
    protected double m_precio;
    protected double m_precioOriginal;
    protected string[] ingredientesAdicionales;
    protected int[] preciosAdicionales;
    protected int numeradorIngrediente = 0;

    public HamburguesaClassic(string pan = "Bollo", string carne = "Res", double precio = 250)
    {
        m_pan = pan;
        m_carne = carne;
        m_precio = precio;
        m_precioOriginal = precio;
        ingredientesAdicionales = new string[4];
        preciosAdicionales = new int[ingredientesAdicionales.Length];
    }

    public void AñadirIngrediente(string ingrediente)
    {
        int precioAdicional;
        if(numeradorIngrediente < ingredientesAdicionales.Length)
        {
            switch(ingrediente)
            {
                case "Lechuga":
                    precioAdicional = 50;
                    m_precio += precioAdicional;
                    break;
                case "Tomate":
                    precioAdicional = 13;
                    m_precio += precioAdicional;
                    break;
                case "Bacon":
                    precioAdicional = 100;
                    m_precio += precioAdicional;
                    break;
                case "Pepinillo":
                    precioAdicional = 75;
                    m_precio += precioAdicional;
                    break;
                default:
                    precioAdicional = 25;
                    m_precio += precioAdicional;
                    break;
            }
            ingredientesAdicionales[numeradorIngrediente] = ingrediente;
            preciosAdicionales[numeradorIngrediente] = precioAdicional;
            numeradorIngrediente += 1;
            Console.WriteLine($"Añadido el ingrediente \"{ingrediente}\" con un precio de {precioAdicional}.");
        }
        else
        {
            Console.WriteLine("No aceptamos más ingredientes en la Hamburguesa");
        }
    }

    public void ImprimirHamburguesa()
    {
        Console.WriteLine($"\nLa orden consiste de un pan {m_pan} y carne de {m_carne}, con un precio original de {m_precioOriginal} pesos y los siguientes ingredientes adicionales: ");
        for (int i = 0; i < numeradorIngrediente; ++i)
        {
            Console.Write($"{ingredientesAdicionales[i]} con un precio de {preciosAdicionales[i]} pesos, ");
        }
        Console.Write($"para un precio total de venta de {m_precio} pesos dominicanos.\n\n");
    }
}
