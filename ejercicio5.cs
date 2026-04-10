class Ejercicio5
{
    public static void Ejecutar()
    {
            Console.WriteLine("--- BLOQUE 4: VALORES LÓGICOS (SÍ / NO) ---");

            bool cursoCompletado = true;

            Console.WriteLine("6. TIPO LÓGICO (bool):");
            Console.WriteLine("   Solo puede ser 'true' o 'false'.");
            Console.WriteLine("   ¿El curso está completado?: " + cursoCompletado);

            Console.WriteLine("\n--- EJERCICIOS CON BOOLEANOS ---");

            bool esMayorDeEdad = true;
            bool tieneDNI = true;
            Console.WriteLine("\n1. Puede entrar al boliche?");
            Console.WriteLine(esMayorDeEdad && tieneDNI);

            bool tieneDinero = true;
            bool tiendaAbierta = false;
            Console.WriteLine("\n2. Puede comprar?");
            Console.WriteLine(tieneDinero && tiendaAbierta);

            bool usuarioRegistrado = true;
            bool contraseñaCorrecta = false;
            Console.WriteLine("\n3. Puede iniciar sesion?");
            Console.WriteLine(usuarioRegistrado && contraseñaCorrecta);

            bool esFinDeSemana = true;
            bool terminoTareas = true;
            Console.WriteLine("\n4. Puede ver pelicula?");
            Console.WriteLine(esFinDeSemana || terminoTareas);

            bool buenClima = false;
            bool tieneEnergia = true;
            Console.WriteLine("\n5. Sale a correr?");
            Console.WriteLine(buenClima && tieneEnergia);

            bool esClienteFrecuente = true;
            bool compraMayorA10000 = false;
            Console.WriteLine("\n6. Aplica descuento?");
            Console.WriteLine(esClienteFrecuente || compraMayorA10000);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
}
