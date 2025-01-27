bool esBisiesto(int anno)
{

    if(anno < 1582)
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

Console.WriteLine("Deme un año para ver si es Bisiesto o no según el calendario moderno: ");
int año = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"El año {año} {(esBisiesto(año) ? "es Bisiesto" : "no es Bisiesto")}");
