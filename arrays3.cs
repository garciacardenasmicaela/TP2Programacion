namespace TP2ProgramacionIII
{
    internal class arrays3
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Seleccione un ejercicio del 1 al 5:");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    int[] edades = { 15, 22, 30, 18, 25 };
                    Console.WriteLine("Ejercicio 1");
                    for (int i = 0; i < edades.Length; i++)
                    {
                        Console.WriteLine("Indice " + i + ": " + edades[i]);
                    }
                    break;

                case 2:
                    int[] numeros = { 5, 10, 15, 20 };
                    Console.WriteLine("Ejercicio 2");
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        Console.WriteLine("Indice " + i + ": " + numeros[i]);
                    }
                    break;

                case 3:
                    int[] sueldos = { 1000, 2000, 3000 };
                    Console.WriteLine("Ejercicio 3");
                    for (int i = 0; i < sueldos.Length; i++)
                    {
                        Console.WriteLine("Indice " + i + ": " + sueldos[i]);
                    }
                    break;

                case 4:
                    int[] notas = { 6, 7, 8, 9, 10 };
                    Console.WriteLine("Ejercicio 4");
                    for (int i = 0; i < notas.Length; i++)
                    {
                        Console.WriteLine("Indice " + i + ": " + notas[i]);
                    }
                    break;

                case 5:
                    int[] puntos = { 100, 200, 300, 400 };
                    Console.WriteLine("Ejercicio 5");
                    for (int i = 0; i < puntos.Length; i++)
                    {
                        Console.WriteLine("Indice " + i + ": " + puntos[i]);
                    }
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

            Console.ReadLine();
        }
    }
}