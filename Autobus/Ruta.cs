class Ruta
{
    public string m_nombre { get; private set; }
    public double m_distancia { get; private set; }
    public double m_precioPorMilla { get; private set; }
    public double m_precioTotal { get; private set; }
    public Ruta(string nombre, double distancia, double precioPorMilla)
    {
        m_nombre = nombre;
        m_distancia = distancia;
        m_precioPorMilla = precioPorMilla;
        m_precioTotal = distancia*precioPorMilla;
    }


}
