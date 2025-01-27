bool esBisiesto(int anno) //Esta es la función pedida que devuelve un booleano que determina si el año es bisiesto o no
{

    if(anno < 1582) //Hasta este año no se usaba el calendario gregoriano
    {
        if(anno % 4 == 0)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    else
    {
        if(((anno % 400 == 0) || ((anno % 4 == 0) && !(anno % 100 == 0))))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

while(true)
{
    try
    {
        Console.WriteLine("Deme un año para ver si es Bisiesto o no según el calendario gregoriano: ");
        int año = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El año {año} {(esBisiesto(año) ? "es Bisiesto" : "no es Bisiesto")}");
        break;
    }
    catch(Exception ex)
    {
        Console.WriteLine("Hubo un error al convertir el año, " + ex.Message);
        continue;
    }
}

