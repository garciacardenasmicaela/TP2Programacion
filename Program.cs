class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Elegí ejercicio (5-7): ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 5:
                Ejercicio5.Ejecutar();
                break;
            case 6:
                Ejercicio6.Ejecutar();
                break;
            //case 3:
            //    Ejercicio7.Ejecutar();
            //    break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}