class Ejercicio7
{
    public static void Ejecutar()
    {
        const decimal TASA_IVA = 0.21m;
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MODULO DE FACTURACION ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioBase = 1500.50m;
        decimal impuestoCalculado = precioBase * TASA_IVA;
        decimal total = precioBase + impuestoCalculado;

        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
        Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        Console.WriteLine("\n--- MAS CALCULOS ---");

        decimal precioBase2 = 2000m;
        decimal impuesto2 = precioBase2 * TASA_IVA;
        decimal total2 = precioBase2 + impuesto2;
        Console.WriteLine("\nCompra 2");
        Console.WriteLine("Total: " + SIMBOLO_PESO + total2);
        Console.WriteLine("Operacion valida: " + (!MODO_PRUEBA));

        decimal precioBase3 = 999.99m;
        decimal impuesto3 = precioBase3 * TASA_IVA;
        decimal total3 = precioBase3 + impuesto3;
        Console.WriteLine("\nCompra 3");
        Console.WriteLine("Total: " + SIMBOLO_PESO + total3);
        Console.WriteLine("Operacion valida: " + (!MODO_PRUEBA));

        decimal precioBase4 = 5000m;
        decimal impuesto4 = precioBase4 * TASA_IVA;
        decimal total4 = precioBase4 + impuesto4;
        Console.WriteLine("\nCompra 4");
        Console.WriteLine("Total: " + SIMBOLO_PESO + total4);
        Console.WriteLine("Operacion valida: " + (!MODO_PRUEBA));

        decimal precioBase5 = 750m;
        decimal impuesto5 = precioBase5 * TASA_IVA;
        decimal total5 = precioBase5 + impuesto5;
        Console.WriteLine("\nCompra 5");
        Console.WriteLine("Total: " + SIMBOLO_PESO + total5);
        Console.WriteLine("Operacion valida: " + (!MODO_PRUEBA));

        decimal precioBase6 = 3200m;
        decimal impuesto6 = precioBase6 * TASA_IVA;
        decimal total6 = precioBase6 + impuesto6;
        Console.WriteLine("\nCompra 6");
        Console.WriteLine("Total: " + SIMBOLO_PESO + total6);
        Console.WriteLine("Operacion valida: " + (!MODO_PRUEBA));

        Console.ReadLine();
    }
}
