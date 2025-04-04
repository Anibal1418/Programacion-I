class Practica2
{
    public static void Main()
    {
        Centralita centralita = new Centralita();
        var inserter = new MySQLInserter();

        LlamadaLocal llamada1 = new LlamadaLocal("809-123-4567", "849-333-1234", 120);
        LlamadaProvincial llamadaP1 = new LlamadaProvincial("829-391-0654", "800-900-1000", 63, 3);
        LlamadaLocal llamada2 = new LlamadaLocal("829-098-7654","849-345-7890", 3647);
        LlamadaProvincial llamadaP2 = new LlamadaProvincial("809-342-5622", "840-3145-5224", 4590, 2);
        LlamadaLocal llamada3 = new LlamadaLocal("849-021-1434","849-332-7076", 12);
        LlamadaProvincial llamadaP3 = new LlamadaProvincial("709-342-5622", "845-231-5524", 367, 1);

        centralita.registrarLlamada(llamada1);
        centralita.registrarLlamada(llamada2);
        centralita.registrarLlamada(llamada3);
        centralita.registrarLlamada(llamadaP1);
        centralita.registrarLlamada(llamadaP2);
        centralita.registrarLlamada(llamadaP3);

        inserter.InsertLlamada(llamada1);
        inserter.InsertLlamada(llamada2);
        inserter.InsertLlamada(llamada3);
        inserter.InsertLlamada(llamadaP1);
        inserter.InsertLlamada(llamadaP2);
        inserter.InsertLlamada(llamadaP3);

        Console.WriteLine($"Al final de la jornada, la centralita registró {centralita.getTotalLlamadas()} llamadas con un total facturado de {centralita.getTotalFacturado()} pesos.");

    }
}
