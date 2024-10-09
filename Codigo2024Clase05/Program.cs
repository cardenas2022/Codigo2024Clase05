//Bucle Do While
Console.WriteLine("Hello, World!");


void leerNota()
{
    int nota = 0;

	do
	{
		Console.Write("Ingresa una nota válida: ");
		nota = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine(nota < 0);
		Console.WriteLine(nota > 20);

	} while (nota < 0 || nota > 20);

	Console.WriteLine("La nota ingresada es: " + nota);
}
leerNota();

//CONSTRUIR UN MENU CON OPCIONES TIPO STRING
String opcion;

do
{
	//Mensaje en la consola
	Console.WriteLine("Ingresa una de las siguientes opciones:");

	Console.WriteLine("A) Mensaje de Bienvenida");
	Console.WriteLine("B) Mensaje de Despedida");
	Console.WriteLine("S) Salir");

	//Convertir la letra a mayúscula, así puedes ingresar letras minúsculas
	opcion = Console.ReadLine().ToUpper();

	switch (opcion)
	{
		case "A":
			Console.WriteLine("Bienvenido al Sistema");
			break;
        case "B":
            Console.WriteLine("Buenas noches. Hasta mañana");
            break;
		default:
            break;
    }
	Console.WriteLine("========================");
    Console.WriteLine("========================");

} while (opcion!="S");
Console.WriteLine("Saliste del Sistema");

/*1.- CREAR UN PROGRAMA QUE TENGA TRES OPCIONES DE MENÚ Y QUE TE PIDA EL SUELDO, EN BASE A LAS OPCIONES
SE APLICA DESCUENTOS:
1)5ta Categoría => Sueldo - Sueldo * 0.14
2)4ta Categoría => Sueldo - Sueldo * 0.08
3)Salir
*/

int opciones;
double sueldo;

do
{
    //Mensaje en la consola
    Console.WriteLine("Ingresa una de las siguientes opciones:");

    Console.WriteLine("1) 5ta Categoría");
    Console.WriteLine("2) 4ta Categoría");
    Console.WriteLine("3) Salir");

    opciones = Convert.ToInt32(Console.ReadLine());

    switch (opciones)
    {
        case 1:
            Console.WriteLine("Ingrese su sueldo:");
            sueldo = Convert.ToDouble(Console.ReadLine());
            sueldo = sueldo - sueldo * 0.14;
            Console.WriteLine("Su sueldo de 5ta categoría es: " + sueldo);
            break;

        case 2:
            Console.WriteLine("Ingrese su sueldo:");
            sueldo = Convert.ToDouble(Console.ReadLine());
            sueldo = sueldo - sueldo * 0.08;
            Console.WriteLine("Su sueldo de 4ta categoría es: " + sueldo);
            break;

        default:
            break;
    }
    Console.WriteLine("========================");
    Console.WriteLine("========================");

} while (opciones != 3);
Console.WriteLine("Saliste del Sistema");

//COLOCAMOS EL EJERCICIO DENTRO DE UN PROCEDIMIENTO O UNA FUNCIÓN
void ejemploMenu()
{
    int opciones;
    double sueldo;

    do
    {
        //Mensaje en la consola
        Console.WriteLine("Ingresa una de las siguientes opciones:");

        Console.WriteLine("1) 5ta Categoría");
        Console.WriteLine("2) 4ta Categoría");
        Console.WriteLine("3) Salir");

        opciones = Convert.ToInt32(Console.ReadLine());

        switch (opciones)
        {
            case 1:
                Console.WriteLine("Ingrese su sueldo:");
                sueldo = Convert.ToDouble(Console.ReadLine());
                sueldo = sueldo - sueldo * 0.14;
                Console.WriteLine("Su sueldo de 5ta categoría es: " + sueldo);
                break;

            case 2:
                Console.WriteLine("Ingrese su sueldo:");
                sueldo = Convert.ToDouble(Console.ReadLine());
                sueldo = sueldo - sueldo * 0.08;
                Console.WriteLine("Su sueldo de 4ta categoría es: " + sueldo);
                break;

            default:
                break;
        }
        Console.WriteLine("========================");
        Console.WriteLine("========================");

    } while (opciones != 3);
}
Console.WriteLine("Salir del Sistema");

//ARREGLOS
int calcularMayor3Notas(int nota1, int nota2, int nota3, int nota4)
{
    int mayor = nota1;

    if (nota2 > mayor)
    {
        mayor = nota2;
    }
    if (nota3 > mayor)
    {
        mayor = nota3;
    }
    if (nota4 > mayor)
    {
        mayor = nota4;
    }

    return mayor;
}

int nota1;
int nota2;
int nota3;
int nota4;
int mayor;

Console.WriteLine("Ingrese la nota 1:");
nota1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la nota 2:");
nota2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la nota 3:");
nota3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la nota 4:");
nota4 = Convert.ToInt32(Console.ReadLine());

//Mostrar la nota mayor
Console.WriteLine("La nota mayor es:");
Console.WriteLine(calcularMayor3Notas(nota1,nota2,nota3,nota4));

Console.Read();