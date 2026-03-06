Console.WriteLine("Pedir números hasta qeu ingrese el 0");
int suma = 0;
int numero;
do
{

   Console.WriteLine("Ingrese un número: ");
    numero = int.Parse(Console.ReadLine());
    suma += numero;
} while (numero != 0);
Console.WriteLine("La suma total: " + suma);