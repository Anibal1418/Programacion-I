class Program
{
    public static void Main()
    {
        //Orden de hamburguesa clasica
        HamburguesaClassic orden01 = new HamburguesaClassic();
        orden01.AñadirIngrediente("Lechuga");
        orden01.AñadirIngrediente("Bacon");
        orden01.AñadirIngrediente("Queso");
        orden01.AñadirIngrediente("Pepinillo");
        orden01.AñadirIngrediente("Tomate"); //No deberia poder añadirse
        orden01.ImprimirHamburguesa();

        //Orden de hamburguesa vegana
        HamburguesaVegana orden02 = new HamburguesaVegana();
        orden02.AñadirIngrediente("Lechuga");
        orden02.AñadirIngrediente("Tomate");
        orden02.AñadirIngrediente("Pepinillo");
        orden02.AñadirIngrediente("Repollo");
        orden02.AñadirIngrediente("Cebolla");
        orden02.AñadirIngrediente("Mostaza");
        orden02.AñadirIngrediente("Lechuga"); //No debería poder añadirse
        orden02.ImprimirHamburguesa();

        //Orden de hamburguesa premium
        HamburguesaPremium orden03 = new HamburguesaPremium();
        orden03.AñadirIngrediente("Bacon"); //No debería poder añadirse
        orden03.ImprimirHamburguesa();
    }
}
