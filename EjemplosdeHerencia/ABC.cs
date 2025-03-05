/*Ahora vamos a ver un ejemplo de herencia multinivel, este es un tipo de herencia donde una clase deriva de una clase madre,
pero al mismo tiempo esta clase derivdad es clase madre de otra clase derivada, haciendo una evolución lineal de clases.*/
//Aquí usaremos ejemplos simples de clases A B y C en orden alfabético cada una con funciones básicas con propósitos académicos

public class A 
{
    protected int Algo { get; set; } 
    //protected es un especificador de acceso que sirve para que las clases hijas de esta clase puedan acceder ese componente de la clase madre
    public A (int x)
    {
        this.Algo = x;
    }

    public void HazAlgo()
    {
        Console.WriteLine("Algo" + Algo);
    }
}

public class B : A
{
    protected decimal OtroAlgo { get; set; }

    public B (int x, decimal y) : base (x)
    {
        this.OtroAlgo = y;
    }
    public void HazOtraCosa()
    {
        Console.WriteLine("Otra Cosa" + Algo + OtroAlgo);
        HazAlgo();
    }
}

public class C : B
{
    protected char OtroOtroAlgo { get; set; }
    public C (int x, decimal y, char z) : base (x, y)
    {
        this.OtroOtroAlgo = z;
    }
    public void HazOtroOtraCosa()
    {
        Console.WriteLine("Otro de Otra Cosa" + OtroOtroAlgo + OtroAlgo + Algo);
        HazOtraCosa(); //Implícitamente llama también a la función HazAlgo()
    }
}
