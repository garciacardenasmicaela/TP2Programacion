using TP2ProgramacionIII;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Elegí ejercicio TP2 (5-6-7) /// ejercicios Arrays: (1-2-3) ");
        Console.WriteLine("Dentro de cada archivo se encuentran los 5 ejercicios/ejemplos correspondientes pedidos en clase");
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 5:
                Ejercicio5.Ejecutar();
                break;
            case 6:
                Ejercicio6.Ejecutar();
                break;
            case 7:
                Ejercicio7.Ejecutar();
                break;
            case 1:
                arrays1.Ejecutar();
                break;
            case 2:
                arrays2.Ejecutar();
                break;
            case 3:
                arrays3.Ejecutar();
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}