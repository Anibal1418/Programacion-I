class Centralita
{
    private int conteo = 0;
    private double acumulado;
    public int getTotalLlamadas()
    {
        return conteo;
    }
    public double getTotalFacturado()
    {
        return acumulado;
    }

    public void registrarLlamada(Llamada in_param)
    {
        conteo += 1;
        acumulado += in_param.calcularPrecio();
        Console.WriteLine($"La siguiente llamada ha sido añadida a la centralita telefónica: \n{in_param.toString()}\n");
    }
}
