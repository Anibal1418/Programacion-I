/*Ahora vamos a probar herencia múltiple, esto es cuando una clase hereda de múltiples clases madre al mismo tiempo.
Aquí utilizaremos el ejemplos de un Doctor, el cual es tanto una Persona como un Profesional. por lo que heredará características de ambos.*/

//C# no soporta herencia múltiple de clases debido a su complejidad y ambigüedad, pero sí lo permite cuando se hereda de varias interfaces.
public interface IPersona
{
    string Nombre { get; }
    int Edad { get; }
}

public interface IProfesional
{
    string Carrera { get; }
    int AñosEnCarrera { get; }
}

public class Doctor : IPersona, IProfesional
{
    
    public string Nombre { get; }
    public int Edad { get; }
    public string Carrera { get; }
    public int AñosEnCarrera { get; }
    
    public Doctor (string nombre, int edad, string carrera, int anosEnCarrera)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.AñosEnCarrera = anosEnCarrera;
        this.Carrera = carrera; //puede ser odontologia, medicina, psicologia, etc.
    }
}

//con todas las interfaces implementadas, obligando al doctor a ser implementado tanto como una persona como un profesional
//pudimos acabar la clase Doctor con pulcridad y le podemos añadir cualquier función y dato extra que creamos válido
