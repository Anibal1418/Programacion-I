class Bus
{
    private string m_nombre { get; set; }
    private int m_numMaxPasajeros { get; set; }
    private int m_pasajerosAbordo { get; set; }
    private double m_ventasTotales { get; set; }
    private bool m_enRuta { get; set; } = false;

    public Bus(string nombre, int numMaxPasajeros)
    {
        m_nombre = nombre;
        m_numMaxPasajeros = numMaxPasajeros;
    }

    public void AñadirPasajeros(int pasajeros)
    {
        for (int i = 0; i < pasajeros; i++)
        {
            if(m_pasajerosAbordo >= m_numMaxPasajeros)
            {
                Console.WriteLine("El autobus ha llegado a su máxima capacidad, dejando pasajeros restantes...");
                break;
            }
            else
            {
                m_pasajerosAbordo += 1;
            }
        }
    }

    public void IniciarRuta(Ruta ruta)
    {
        Console.WriteLine($"El autobús {m_nombre} parte por la ruta {ruta.m_nombre} con una distancia de {ruta.m_distancia} millas y un precio total de {ruta.m_precioTotal} por pasajero. Disfruten el viaje.\n");
        m_ventasTotales += ruta.m_precioTotal * m_pasajerosAbordo;
        m_enRuta = true;
    }
    public void TerminarRuta()
    {
        if(m_enRuta == true)
        {
            Console.WriteLine("La ruta ha sido completada, desmontando pasajeros...\n");
            m_pasajerosAbordo = 0;
            m_enRuta = false;
        }
        else
        {
            Console.WriteLine("No hay ninguna ruta en proceso.");
        }
    }

    public void ImprimirBus()
    {
        Console.WriteLine($"Auto Bus {m_nombre} {m_pasajerosAbordo} Pasajeros Ventas {Convert.ToInt32(m_ventasTotales)} quedan {m_numMaxPasajeros - m_pasajerosAbordo} asientos disponibles");
    }
}
