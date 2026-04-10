class Ejercicio6
{
    public static void Ejecutar()
    {
        const string NOMBRE_APP = "GameMaster Pro";
        const string VERSION = "v1.0.2";
        const int EDAD_MINIMA = 18;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restriccion: Prohibida la venta a menores de " + EDAD_MINIMA + " anios.");

        const int EDAD_CLIENTE = 20;
        const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA;

        Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " anios...");
        Console.WriteLine("Edad minima: " + EDAD_MINIMA);
        Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);

        Console.WriteLine("\n--- MAS VERIFICACIONES ---");

        const int EDAD_CLIENTE_2 = 16;
        const bool PUEDE_INGRESAR_2 = EDAD_CLIENTE_2 >= EDAD_MINIMA;
        Console.WriteLine("\nCliente de " + EDAD_CLIENTE_2 + " anios");
        Console.WriteLine("Acceso permitido: " + PUEDE_INGRESAR_2);

        const int EDAD_CLIENTE_3 = 25;
        const bool PUEDE_INGRESAR_3 = EDAD_CLIENTE_3 >= EDAD_MINIMA;
        Console.WriteLine("\nCliente de " + EDAD_CLIENTE_3 + " anios");
        Console.WriteLine("Acceso permitido: " + PUEDE_INGRESAR_3);

        const int EDAD_CLIENTE_4 = 18;
        const bool PUEDE_INGRESAR_4 = EDAD_CLIENTE_4 >= EDAD_MINIMA;
        Console.WriteLine("\nCliente de " + EDAD_CLIENTE_4 + " anios");
        Console.WriteLine("Acceso permitido: " + PUEDE_INGRESAR_4);

        const int EDAD_CLIENTE_5 = 14;
        const bool PUEDE_INGRESAR_5 = EDAD_CLIENTE_5 >= EDAD_MINIMA;
        Console.WriteLine("\nCliente de " + EDAD_CLIENTE_5 + " anios");
        Console.WriteLine("Acceso permitido: " + PUEDE_INGRESAR_5);

        const int EDAD_CLIENTE_6 = 30;
        const bool PUEDE_INGRESAR_6 = EDAD_CLIENTE_6 >= EDAD_MINIMA;
        Console.WriteLine("\nCliente de " + EDAD_CLIENTE_6 + " anios");
        Console.WriteLine("Acceso permitido: " + PUEDE_INGRESAR_6);

        Console.ReadLine();
    }
}