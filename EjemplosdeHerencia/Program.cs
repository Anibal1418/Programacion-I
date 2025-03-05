/*Aquí vamos a ver ejemplos en código de las clases que hemos realizado hasta ahora, para ver su funcionalidad y si
están bien escritas y programadas.*/
public class Program
{
    public static void Main(String[] args)
    {
        //Herencia Simple o Singular con una Interfaz IEntidad
        Entidad Zombie = new Entidad("Zombie", "No Muerto", 20, 5);
        Entidad Jugador = new Entidad("Player", "Humano", 30, 10);
        Jugador.Atacar(Zombie);

        //Herencia Jerárquica con Animales
        Animal desconocido = new Animal("Desconocido", 4);
        Perro Poppy = new Perro("Poppy", 7, "Husky");
        Gato Whiskers = new Gato("Whiskers", 3, "Blanco");
        desconocido.Sonido();
        Poppy.Sonido();
        Whiskers.Sonido();

        //Herencia Jerárquica con clase abstracta
        //AFigura figura = new AFigura(""); no se puede crear una instancia
        Circulo circulo = new Circulo("Rojo");
        Triangulo triangulo = new Triangulo("Verde");
        circulo.Dibujar();
        triangulo.Dibujar();

        //Herencia múltiple con Interfaces
        Doctor Johnson = new Doctor("Jhonson", 53, "Odontología", 20);
        Console.WriteLine(Johnson.Carrera);

        //Herencia Multinivel con clases Básicas
        A primero = new A(5);
        B segundo = new B(10, 56.89m);
        C tercero = new C(15, 924.78m, 'C');
        primero.HazAlgo();
        segundo.HazOtraCosa();
        tercero.HazOtroOtraCosa();
    }
}
