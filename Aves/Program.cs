class Program
{
    public static void Main(string[] args)
    {
        Paloma Henry = new Paloma("Henry", "Gris", 10, 5);
        Pinguino Rey = new Pinguino("Rey", "Negro-Blanco", 5, 29);
        Loro Luis = new Loro("Luis", "Rojo", "Verde", 15, 4);

        Henry.Volar();
        Rey.Nadar();
        Luis.Hablar();
    }
}
