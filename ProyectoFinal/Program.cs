using System;
using System.Security.Cryptography.X509Certificates;
public class Program
{
    public static int enemigosAbatidos;
    public static int rondasSobrevividas;
    public static int userInput;
    public static void StartGame(int dificultad)
    {
        Console.WriteLine("Escriba su nombre de usuario: ");
        string? username = Console.ReadLine();

        if(username == null || username.Length == 0 || username.Trim() == "")
        {
            username = "Joerlyn";
        }

        Jugador jugador = new Jugador(username);

        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"Bienvenido al juego, {username}, estan son las reglas: \n\nUsted se enfrentará con tres tipos de mounstros.\n\nSlimes que se vuelven más fuertes mientras más grandes son.\n\nEsqueletos que pegan fuerte pero resisten poco.\n\nGuardianes que aguantan mucho pero pegan poco.");
        Console.WriteLine("\nSu objetivo es sobrevivir a hordas de enemigos y abatir a todos los que pueda, claro, sin perder su vida en el proceso, y para esto tiene las siguientes herramientas:\n\n1.Atacar, donde ataca cuerpo a cuerpo a un enemigo al tirar un dado de 20 lados, si lo que le sale en el dado es mayor que la armadura del enemigo, el ataque es un exito y el enemigo pierde vida, si no, el enemigo no coge daño. Con ambos resultados el enemigo va a intentar atacar para atrás");
        Console.WriteLine("\n2.Puede usar su habilidad, que es un ataque en área que afecta a todos los enemigos en una ronda, igualmente tirando un dado de 20 lados, pero los enemigos a los que el ataque falló podrán devolver un ataque gratis, mientras que aquellos que sí alcanzó no podrán atacar para atrás, al menos que sean un guardián...");
        Console.WriteLine("\n3. Puede intentar correr con un 50% de chance de una batalla, si logra correr pasa a la siguiente ronda sin matar a un enemigo, si falla en correr... recibirá un ataques de todos los enemigos cercanos. \n\nEntendió las reglas? (presione ENTER para continuar)");
        Console.ReadLine();

        Random enemigoRandom = new Random();
        Random tamanoRandom = new Random();

        for (int ronda = 0; ronda < 2*dificultad; ++ronda, ++rondasSobrevividas)
        {
            if(!jugador.EstaVivo())
            {
                break;
            }
            Enemigo[] enemigos = new Enemigo[dificultad];
            for (int i = 0; i < enemigos.Length; ++i)
            {
                switch (enemigoRandom.Next(1, 4))
                {
                    case 1:
                        enemigos[i] = new Slime(tamanoRandom.Next(1,4));
                        break;
                    case 2:
                        enemigos[i] = new Esqueleto();
                        break;
                    case 3:
                        enemigos[i] = new Guardian();
                        break;
                }

            }

            Console.Write("Se acercan los siguientes enemigos: ");
            foreach (Enemigo enemigo in enemigos)
            {
                Console.Write($"{enemigo.Nombre()}, ");
            }


            foreach (Enemigo enemigoCercano in enemigos)
            {
                bool logroCorrer = false;
                while(enemigoCercano.EstaVivo() && !logroCorrer && jugador.EstaVivo())
                {
                    Console.WriteLine($"\nEl enemigo enfrente suyo es {enemigoCercano.Nombre()}");
                    Console.WriteLine("¿Qué vas a hacer?\n1. Atacar\n2. Usar Habilidad\n3. Correr");
                    try
                    {
                        userInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Input inválido, intente de nuevo.");
                        continue;
                    }

                    switch (userInput)
                    {
                        case 1:
                            if (enemigoCercano is Esqueleto esqueleto)
                            {
                                jugador.Atacar(esqueleto);; // Specific to Skeleton
                            }
                            else if (enemigoCercano is Slime slime)
                            {
                                jugador.Atacar(slime);; // Specific to Slime
                            }
                            else if (enemigoCercano is Guardian guardian)
                            {
                                jugador.Atacar(guardian); // Specific to Guardian
                            }
                            break;
                        case 2:
                            jugador.Habilidad(enemigos);
                            break;
                        case 3:
                            if(jugador.LograCorrer())
                            {
                                logroCorrer = true;
                                break;
                            }
                            else
                            {
                                enemigoCercano.Atacar(jugador);
                                break;
                            }
                        default:
                            Console.WriteLine("Acción inválida, su personaje no hace nada");
                            enemigos[0].Atacar(jugador); 
                            break;
                    }

                    if(!enemigoCercano.EstaVivo())
                    {
                        enemigosAbatidos += 1;
                    }
                }
            }

            Console.WriteLine("Ha terminado exitosamente la ronda! Presione ENTER para continuar...");
            Console.ReadLine();
        }

        EndGame();
    }
    public static void EndGame()
    {
        Console.WriteLine("\n\nEl juego ha acabado, sus datos de la sesión han sido guardados en la base de datos");
        Console.WriteLine($"Bichos abatidos: {enemigosAbatidos}\nRondas Sobrevividas {rondasSobrevividas}");
        var inserter = new MySQLInserter();
        inserter.InsertGameData(enemigosAbatidos, rondasSobrevividas);
    }

    static void Main()
    {

        string? startInput;
        Console.WriteLine("Desea Empezar el juego (Y/N)?");
        while(true)
        {
            startInput = Console.ReadLine();
            if(startInput != null)
            {
                break;
            }
        }

        if (startInput.ToLower().StartsWith('y'))
        {
            Console.WriteLine("Elija dificultad (Facil = 1 / Media = 2 / Dificil = 3)");
            int difficulty;
            while(true)
            {
                try
                {
                    difficulty = Convert.ToInt32(Console.ReadLine());
                    if(difficulty >= 1 && difficulty <= 3)
                    {
                        break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Ocurrio un error: " + ex.Message);
                }

                Console.WriteLine("Use una de las dificultas permitidas, por favor.");
            }

            StartGame(difficulty);
        }
        else
        {
            EndGame();
        }
    }


}
