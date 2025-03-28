class HamburguesaPremium : HamburguesaClassic
{
    public HamburguesaPremium(string pan = "Bollo", string carne = "Res", double precio = 400)
    {        
        m_pan = pan;
        m_carne = carne;
        m_precio = precio;
        m_precioOriginal = precio;
        ingredientesAdicionales = new string[2];
        ingredientesAdicionales[0] = "Papas";
        ingredientesAdicionales[1] = "Refresco";
        numeradorIngrediente = 2;
    }
}
