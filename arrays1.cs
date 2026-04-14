
namespace TP2ProgramacionIII
{
    internal class arrays1
    {
        public static void Ejecutar()
        {
            Console.WriteLine("seleccione un ejercicio del 1 al 5:");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    int[] numeros1 = new int[3];
                    numeros1[0] = 10;
                    numeros1[1] = 20;
                    numeros1[2] = 30;
                    Console.WriteLine("Ejercicio 1");
                    Console.WriteLine(numeros1[0]);
                    Console.WriteLine(numeros1[1]);
                    Console.WriteLine(numeros1[2]);
                    break;
                case 2:
                    int[] numeros2 = new int[4];
                    numeros2[0] = 5;
                    numeros2[1] = 15;
                    numeros2[2] = 25;
                    numeros2[3] = 35;
                    Console.WriteLine("Ejercicio 2");
                    Console.WriteLine(numeros2[0]);
                    Console.WriteLine(numeros2[1]);
                    Console.WriteLine(numeros2[2]);
                    Console.WriteLine(numeros2[3]);
                    break;
                case 3:
                    int[] numeros3 = new int[2];
                    numeros3[0] = 100;
                    numeros3[1] = 200;
                    Console.WriteLine("Ejercicio 3");
                    Console.WriteLine(numeros3[0]);
                    Console.WriteLine(numeros3[1]);
                    break;
                case 4:
                    int[] numeros4 = new int[5];
                    numeros4[0] = 1;
                    numeros4[1] = 2;
                    numeros4[2] = 3;
                    numeros4[3] = 4;
                    numeros4[4] = 5;
                    Console.WriteLine("Ejercicio 4");
                    Console.WriteLine(numeros4[0]);
                    Console.WriteLine(numeros4[1]);
                    Console.WriteLine(numeros4[2]);
                    Console.WriteLine(numeros4[3]);
                    Console.WriteLine(numeros4[4]);
                    break;
                case 5:
                    int[] numeros5 = new int[3];
                    numeros5[0] = -10;
                    numeros5[1] = 0;
                    numeros5[2] = 10;
                    Console.WriteLine("Ejercicio 5");
                    Console.WriteLine(numeros5[0]);
                    Console.WriteLine(numeros5[1]);
                    Console.WriteLine(numeros5[2]);
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

            Console.ReadLine();
        }
    }
}