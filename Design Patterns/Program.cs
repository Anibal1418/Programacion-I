/*Patrón de Diseño Creacional Singleton. Se utiliza para asegurar que solo se cree una sola instancia de una clase
que requiere control centralizado, como una base de datos, con acceso global. Normalmente se utiliza el método de 
inicialización vaga, donde la clase se inicializa en el programa solo donde es requirida.*/

//Esta es la clase Singleton, la cual normalmente sería una base de datos
class Singleton 
{
    //Tiene un constructor privado ya que no queremos que su implementación sea accedida por el usuario
    private Singleton()
    {

    }

    //Creamos una instancia estática y privada de la clase para asegurarnos que solo exista una y que no pueda ser
    //Directamte accedida en el público
    private static Singleton instance;

    //Este es el método público que se usa para acceder o crear la instancia de la clase, ya que es privada.
    public static Singleton getInstance()
    {
    // Check if an instance exists
    if (instance == null) {
        // If no instance exists, create one
        instance = new Singleton();
    }
    // Return the existing instance
    return instance;
    }
}

//Esa sería la implementación básica de una Singleton, con la creación de una sola instancia. Su única desventaja es que
//Si el desarrollador cambia la decisión de necesitar la clase como Singleton, pues va a requerir cambio significativo del código.

/*Ahora vamos con un Patrón de Diseño Estructural, el patrón Composite, básicamente te deja componer objetos en una estructura de árbol,
para representar jerarquías enteras. Esto permite que los clientes puedan usar tanto los objetos individualmente como en grupo. */

//El patrón se compone básicamente de una clase abstracta llamada Componente, y de sus hijos los compuestos u hojas. Los compuestos pueden tener más hijos, las hojas no.
public abstract class Componente
    {
        protected string nombre;

        // Constructor, con una variable simple de ejemplo
        public Componente(string nombre)
        {
            this.nombre = nombre;
        }

        //Funciones cualesquiera que tuviera una función como esta para que sus hijos las hereden
        public abstract void Añadir(Componente c);
        public abstract void Remover(Componente c);
        public abstract void Mostrar(int profundidad);
    }
    
    //La clase composite hereda de la componente, y puede seguir teniendo hijos en la estructura de árbol
    public class Composite : Componente
    {

        //Lista de los posibles hijos del componente
        List<Componente> children = new List<Componente>();
        // Constructor
        public Composite(string name)
            : base(name)
        {
        }

        //Overrides de las funciones básicas
        public override void Añadir(Componente component)
        {
            children.Add(component);
        }
        public override void Remover(Componente component)
        {
            children.Remove(component);
        }
        public override void Mostrar(int depth)
        {
            Console.WriteLine(new String('-', depth) + nombre);
            // Una forma de mostrar recursivamente los hijos del Composite
            foreach (Componente component in children)
            {
                component.Mostrar(depth + 2);
            }
        }
    }
    
    //E aquí la clase Hoja, la cual no puede tener hijos y marca el fin de la rama del árbol compuesto
    public class Leaf : Componente
    {
        // Constructor, no tiene lista de hijos, ya que no puede tener
        public Leaf(string name)
            : base(name)
        {
        }
        public override void Añadir(Componente c)
        {
            Console.WriteLine("No se puede añadir una hoja");
        }
        public override void Remover(Componente c)
        {
            Console.WriteLine("No se puede remover una hoja");
        }
        public override void Mostrar(int depth)
        {
            Console.WriteLine(new String('-', depth) + nombre);
        }
    }

//Y así es como se implementan un conjunto de clases para usar el patrón de diseño estructural de Composite

/*Ahora vamos a un patrón de diseño de comportamiento: el patrón de diseño de Comando. Este se usa para procesar una petición en un objeto
singular llamado comando, así se puede organizar una cadena de peticiones en una cola o pila de comandos que pueden ser resueltos separadamente.*/

//Primero comienza con una clase de interfaz, poniendo el estándar de todos los comandos, y dándoles la oportunidad de implementar la función Execute
//La cual debería resolver el comando.
public abstract class Command
    {
        //El Receiver procesa la petición y la guarda
        protected Receiver receiver;
        // Constructor
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        //Esta es la función que cambiará como cada comando se resuelve en cada hijo de la clase interfaz
        public abstract void Execute();
    }
   
   //Estas son las clases de comandos concretos, las cuales debem implementar las soluciones de cada petición, simples en concepto.
    public class ConcreteCommand : Command
    {
        // Constructor
        public ConcreteCommand(Receiver receiver) :
            base(receiver)
        {
        }
        public override void Execute()
        {
            receiver.Action();
        }
    }
  
  //ESta es la clase Receiver que se encarga de almacenar qué acción el usuario quiere que haga con esta petición
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
  
  //Esta clase básicamente existe para activar cada comando, llamando su función de ejecución, como si fuera un control remoto.
    public class Invoker
    {
        Command command;
        public void SetCommand(Command command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }

//Y así es como se implementaría un diseño de patrón de comportamiento, comando.
//Aquí una implementación simple de su lógica con una función Main
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear receiver, comando, e invoker
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            // Poner y ejecutar comando
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            // Esperar por el usuario
            Console.ReadKey();
        }
    }


