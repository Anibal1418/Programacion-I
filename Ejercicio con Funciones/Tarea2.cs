private int anno;
public bool esBisiesto;

IdentificadorBisiesto(annoDado)
{
    anno = annoDado;
}

public static void main(String[] args)
{

    if(anno < 1582)
    {
        if(anno % 4 == 0)
        {
            esBisiesto = true;
        }

        else
        {
            esBisiesto = false;
        }
    }

    else
    {
        if(((anno % 400 == 0) || ((anno % 4 == 0) && !(anno % 100 == 0))))
        {
            esBisiesto = true;
        }
        else
        {
            esBisiesto = false;
        }
    }
}

IdentificadorBisiesto A2004 (2004);
Console.WriteLine(A2004.esBisiesto());
