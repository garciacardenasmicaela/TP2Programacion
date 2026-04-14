namespace TP2ProgramacionIII
{
    internal class arrays2
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Seleccione un ejercicio del 1 al 5:");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    string[] frutas = { "Manzana", "Banana", "Uva", "Naranja" };
                    Console.WriteLine("Ejercicio 1");
                    foreach (string f in frutas)
                    {
                        Console.WriteLine(f);
                    }
                    break;
                case 2:
                    string[] colores = { "Rojo", "Azul", "Verde" };
                    Console.WriteLine("Ejercicio 2");
                    foreach (string c in colores)
                    {
                        Console.WriteLine(c);
                    }
                    break;

                case 3:
                    string[] paises = { "Argentina", "Brasil", "Chile", "Peru" };
                    Console.WriteLine("Ejercicio 3");
                    foreach (string p in paises)
                    {
                        Console.WriteLine(p);
                    }
                    break;

                case 4:
                    string[] animales = { "Perro", "Gato", "Caballo" };
                    Console.WriteLine("Ejercicio 4");
                    foreach (string a in animales)
                    {
                        Console.WriteLine(a);
                    }
                    break;

                case 5:
                    string[] lenguajes = { "C#", "Java", "Python", "JavaScript" };
                    Console.WriteLine("Ejercicio 5");
                    foreach (string l in lenguajes)
                    {
                        Console.WriteLine(l);
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