class Program
{
    static void Main(string[] args)
    {
         int? edad=null;
        Console.WriteLine("Captura tu edad y presiona ¨Enter¨ ");
        string? edadCapturada = Console.ReadLine();
        if (edadCapturada is not null)
        {
            try 
            {
                edad = int.Parse(edadCapturada);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor Numerico");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Esa es una edad muy grande o muy pequeña, ingrese otra.");
            }
        } 
        if (edad >0 && edad is not null)
        Console.WriteLine($"Tu edad es {edad}");
        else
        Console.WriteLine($"No se capturo una edad Valida");
    }
}