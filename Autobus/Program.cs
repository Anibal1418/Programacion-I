class Program
{
    public static void Main()
    {
        Bus Plantinum = new Bus("Plantinum", 22);
        Bus Gold = new Bus("Gold", 15);

        Ruta Bonao = new Ruta("Bonao", 50, 20);
        Ruta PuntaCana = new Ruta("Punta Cana", 122, 10.9289617);

        Plantinum.AñadirPasajeros(5);
        Plantinum.IniciarRuta(Bonao);

        Gold.AñadirPasajeros(3);
        Gold.IniciarRuta(PuntaCana);

        Plantinum.ImprimirBus();
        Gold.ImprimirBus();
    }
}
