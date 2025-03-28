class HamburguesaVegana : HamburguesaClassic
{
    public HamburguesaVegana (string pan = "Integral", string carne = "Res Keto", double precio = 300)
    {
        m_pan = pan;
        m_carne = carne;
        m_precio = precio;
        m_precioOriginal = precio;
        ingredientesAdicionales = new string[6];
        preciosAdicionales = new int[ingredientesAdicionales.Length];
    }
}
