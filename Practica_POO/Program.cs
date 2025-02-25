/*Desarrollar una clase llamada Motor que tenga:
 Dos atributos privados de tipo int. El primero se llama litros_de_aceite
y el segundo potencia.
 Un Constructor con un parámetro de tipo int para la potencia. Los
litros de aceite por defecto serán 0.
 Un getter para cada atributo.
 Un setter para cada atributo*/

class Motor
{
    private int m_litros_de_aceite;
    private int m_potencia;

    public Motor (int potencia)
    {
        m_potencia = potencia;
    }

    public int Get_litros () {return m_litros_de_aceite;}
    public int Get_potencia () {return m_potencia;}

    public void Set_litros (int litros_de_aceite) {m_litros_de_aceite = litros_de_aceite;}
    public void Set_potencia (int potencia) {m_potencia = potencia;}

}

/*Desarrollar una clase llamada Coche que tenga:
 Un atributo privado de tipo Motor, un atributo de tipo String para la
marca, otro de tipo String para el modelo y otro de tipo double para
guardar el precio acumulado de las averías.
 Un constructor con dos parámetros de tipo String que inicialicen la
marca y el modelo.
 Un getter para cada atributo
 Un método acumularAvería que incrementará el importe gastado en
averías*/

class Coche
{
    //variable aleatoria estatic para asignar numeros a Motores aleatoriamente
    private static Random numero_aleatorio = new Random();
    private Motor m_motor = new Motor(numero_aleatorio.Next(60, 100)); //se randomiza el numero de caballos por vehiculo
    private string m_marca;
    private string m_modelo;
    private double m_precio_acumulado;

    public Coche (string marca = "Daihatsu", string modelo = "Mira") //El Daihatsu Mira 600 sera el modelo default
    {
        m_marca = marca;
        m_modelo = modelo;
    }

    public Motor GetMotor() {return m_motor;}
    public string GetMarca() {return m_marca;}
    public string GetModelo() {return m_modelo;}
    public double GetPrecio_acumulado() {return m_precio_acumulado;}

    public void AcumularAvería(string averia, int precioAveria) 
    {
        m_precio_acumulado += precioAveria;

        if(averia == "aceite")
        {
            m_motor.Set_litros(m_motor.Get_litros() + 10);
        }
    }

}

/*Desarrollar una clase llamada Garaje que tenga:
 Tres atributos: un coche, un String con el nombre de la avería asociada
y el número de cochos que ha ido atendiendo.
 El garaje sólo podrá atender un coche en cada momento. Deberá
controlar esta premisa.
 Un método aceptarCoche que reciba un parámetro de tipo Coche y la
avería asociada. El garaje sólo podrá atender un coche en cada
momento. Si ya está atendiendo uno, deberá devolver un false.
 Un método devolverCoche que dejará al garaje en estado de aceptar
un nuevo coche.*/

class Garaje
{
    private Coche m_coche = new Coche();
    private string m_averia = "";
    private int m_numeroDeCochesAtendidos;

    private bool m_puedeAtenderOtroCoche = true;

    public bool AceptarCoche (Coche coche, string averia, int precioAveria)
    {
        if(m_puedeAtenderOtroCoche)
        {
            Console.WriteLine ($"Coche de marca {coche.GetMarca()} y modelo {coche.GetModelo()} está en proceso de reparación de la avería \"{averia}\" con precio de {precioAveria} dolares...\n");
            
            m_puedeAtenderOtroCoche = false;
            m_coche = coche;
            m_averia = averia;
            m_numeroDeCochesAtendidos += 1;

            coche.AcumularAvería(m_averia, precioAveria);

            return true;
        }
        else
        {
            Console.WriteLine ("El garaje no puede aceptar más coches ahora mismo...\n");
            return false;
        }
    }

    public void DevolverCoche() 
    {
        if(m_puedeAtenderOtroCoche)
        {
            Console.WriteLine("No hay coche para devolver en el Garaje...\n");
        }
        else
        {
            Console.WriteLine($"El coche {m_coche.GetMarca()} {m_coche.GetModelo()} ha sido reparado\n");
            m_puedeAtenderOtroCoche = true;
        }
    }

    public int GetCochesAtendidos() {return m_numeroDeCochesAtendidos;}
}

/*Desarrollar una clase PracticaPOO que en su método main:
 Cree un garaje
 Cree 2 coches
 El garaje irá atendiendo los coches y devolviéndolos, acumulando un
importe aleatorio (Math.random()) de la avería tratada.
 Si la avería del coche es "aceite" incrementar en 10 la cantidad de litros
de aceite.
 Los coches entrarán al menos 2 veces al garaje.
 Mostrar información de los coches al final del método main.*/

class PracticaPOO
{
    static void Main ()
    {
        Garaje garajeGeneral = new Garaje();

        Coche Daihatsu_Mira = new Coche();

        Coche Hyundai_Sonata = new Coche("Hyundai", "Sonata");

        Random precios = new Random(10);

        //primero acepta a su primer coche, el Sonata, y le aplica un precio entre 0 y 30, y con problema de aceite
        garajeGeneral.AceptarCoche(Hyundai_Sonata, "aceite", precios.Next(30));

        //si el Mira intenta entrar mientras que se atiende otro coche, no se lo permite
        garajeGeneral.AceptarCoche(Daihatsu_Mira, "aceite", precios.Next(30));

        //devuelve el coche que estaba atendiendo, en este caso, el Sonata
        garajeGeneral.DevolverCoche();

        //ahora si puede aceptar al Mira, el problema aceite sube los litros de aceite de su motor
        garajeGeneral.AceptarCoche(Daihatsu_Mira, "aceite", precios.Next(30));

        //devuelve el Mira
        garajeGeneral.DevolverCoche();

        //el mira vuelve pero con otro problema y otro precio diferente
        garajeGeneral.AceptarCoche(Daihatsu_Mira, "ruedas", precios.Next(50));

        //lo devuelve sin problema
        garajeGeneral.DevolverCoche();

        //ya que el Sonata esperó, el taller lo acepta sin problema para otro problema
        garajeGeneral.AceptarCoche(Hyundai_Sonata, "piezas", precios.Next(70));

        //devuelve el Sonata
        garajeGeneral.DevolverCoche();

        //si se intenta devolver otro coche, pero el taller esta vacío, el programa lo deja claro en un mensaje
        garajeGeneral.DevolverCoche();

        //imprimir informacion actual de los vehiculos
        Console.WriteLine($"INFORMACIÓN DEL PRIMER COCHE: \n\tModelo: {Daihatsu_Mira.GetModelo()} \n\tMarca: {Daihatsu_Mira.GetMarca()} \n\tPrecio Acumulado: {Daihatsu_Mira.GetPrecio_acumulado()} \n\tCaballos de Potencia: {Daihatsu_Mira.GetMotor().Get_potencia()} \n\tLitros de aceite: {Daihatsu_Mira.GetMotor().Get_litros()}.");
        Console.WriteLine($"\n----------------------------------------------\nINFORMACIÓN DEL SEGUNDO COCHE: \n\tModelo: {Hyundai_Sonata.GetModelo()} \n\tMarca: {Hyundai_Sonata.GetMarca()} \n\tPrecio Acumulado: {Hyundai_Sonata.GetPrecio_acumulado()} \n\tCaballos de Potencia: {Hyundai_Sonata.GetMotor().Get_potencia()} \n\tLitros de aceite: {Hyundai_Sonata.GetMotor().Get_litros()}.");
    
        Console.WriteLine($"\nNumero de coches total atendidos por el garaje: {garajeGeneral.GetCochesAtendidos()}.");
    }
}

