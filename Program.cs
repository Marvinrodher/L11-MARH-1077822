using System.Threading;

class Program
{
    static void Main(string[] args)
    {

        int mo;
        double cantidad;

        Console.WriteLine("Todo a euros");
        Console.WriteLine("Si desea convertir a yenes escriba 1, si desea convertir a libras escriba 2 y si quiere a dolares escriba 3");
        mo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad total que quiere convertir a euros");
        cantidad = Convert.ToDouble(Console.ReadLine());

        if (mo>1 )
        {
            Console.WriteLine("esta moneda no existe");
        }
        else if (mo>3)
        {
            Console.WriteLine("esta moneda no existe");
        }
        else 
        {
            double resultado = aeuros (mo, cantidad);
            Console.WriteLine("su cantidad en euros es: " + resultado);
        }
    }
    static double aeuros (int mo, double cantidad)
    {
        if (mo == 1)
        {
            return cantidad * 0.009;
        }
        else if (mo == 2)
        {
            return cantidad * 1.22;
        }

        else  
        {
            return cantidad * 0.75;
        }
    }
}