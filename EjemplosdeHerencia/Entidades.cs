/*En un videojuego, las entidades que uno controla o pelea deben seguir una plantilla rigurosa la cual no puede ser
quebrada, ya que si lo hace, el juego completo se rompe. Aquí es un decente ejemplo para usar una clase interfaz:*/

public interface IEntidad
{
    string Nombre { get; }
    string Descripcion { get; }
    int PV { get; } //puntos de vida
    int PA { get; } //puntos de ataque/habilidad
    public void Atacar(Entidad enemigo);
}

//ahora todas las clases que se hereden de esta interfaz deben seguir su plantilla rigurosamente
//una forma interesante de implementar una interfaz es hacer una clase madre con esa interfaz para evitar copiar y pegar
//ahora no hay que hacer tantos cambios si la clase interfaz es cambiada

public class Entidad : IEntidad
{
    public Entidad (string nombre, string descripcion, int pv, int pa)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        PV = pv;
        PA = pa;
    }
    public string Nombre { get; set;}
    public string Descripcion { get; set; }
    public int PV { get; set; } 
    public int PA { get; set; } 
    public void Atacar(Entidad enemigo)
    {
        enemigo.PV -= this.PA; //los puntos de vida del enemigo se reducen con los puntos de ataque de la entidad
        Console.WriteLine($"{this.Nombre} ataca a {enemigo.Nombre} por {this.PA} de daño, dejando al enemigo en {enemigo.PV} puntos de vida.");
    }
}

//ya que solo una clase hereda de la madre, esto puede ser considerado herencia simple
