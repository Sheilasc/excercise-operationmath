internal class Program
{
    private static void Main(string[] args)
    {
        int a = Leer("Ingrese Valor 1: ");
    int b = Leer("Ingrese Valor 2: ");

    //Sumar dos numeros
    int resultadoSuma = sumar (a,b);
    Console.WriteLine("El resultado de la suma de a + b es: "+resultadoSuma);
    
    //Restar dos numeros
    int resultadoResta = restar (a,b);
    Console.WriteLine("El resultado de la resta de a - b es: "+resultadoResta);

    //Multiplicar dos numeros
    int resultadoMultiplicacion = multiplicacion (a,b);
    Console.WriteLine("El resultado de la multiplicacion de a * b es: "+resultadoMultiplicacion);

    //Dividir dos numeros
    decimal resultadodivision = division (a,b);
    Console.WriteLine("El resultado de la division de a / b es: "+resultadodivision);
    }

    //Funcion Leer dos numeros
  public static int Leer(string mensaje)
  {
    Console.WriteLine(mensaje);
    string numeroComoString = Console.ReadLine();
    int valorInt = Int32.Parse(numeroComoString);
    return valorInt;
  }

  //Funcion Sumar dos numeros
  public static int sumar(int a, int b)
  {
    int sumatotal = (a + b);
    return sumatotal;
  }

  //Funcion Restar dos numeros
  public static int restar(int a, int b)
  {
    int restatotal = (a - b);
    return restatotal;
  }

  //Funcion Multiplicar dos numeros
  public static int multiplicacion(int a, int b)
  {
    int multiplicaciontotal = (a * b);
    return multiplicaciontotal;
  }

  //Funcion Dividir dos numeros
  public static decimal division(int a, int b)
  {
    decimal divisiontotal = (Convert.ToDecimal (a) / Convert.ToDecimal (b));
    return divisiontotal;
  }
}