using System;
using System.Numerics;
using System.Linq;
void Adivina()
{   
    const int Oportunidades = 4;
    int numeroCPU, numeroUsuario;
    byte Intentos=0, BanderaControl;
    string linea;
    Random ran = new Random();

    numeroCPU = Convert.ToInt32(ran.Next(1,20));




    do
    {
        Console.WriteLine("Hola estoy pensando en un número, cual crees que es?: ");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());

        if (numeroUsuario == numeroCPU)
        {
            Console.WriteLine("Yes adivinaste.");
        }
        else
        {
            if (numeroUsuario < numeroCPU)
            {
                Console.WriteLine("El número que ingresaste es menor, porfavor ingresa otro");
            }
            else
            {
                Console.WriteLine("El número que ingresaste es mayor, porfavor ingresa otro");
            }
        }
        Intentos++;
    } while (Intentos <= Oportunidades);
}

void buscaMayor()
{
    int mayor = 0, menor = 0;
    int numero = 0;
    Random rand = new Random();

    for (int i = 0; i < 5; i++)
    {
        numero = rand.Next(100);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor = numero;
        }

    }
    Console.WriteLine("El número mayor es:" + mayor);
}

void buscaMenor()
{
    int menor = 0;
    int numero = 0;
    Random rand = new Random();

    for (int i = 0; i < 5; i++)
    {
        numero = rand.Next(100);
        Console.WriteLine(numero);
        if (numero < menor)
        {
            menor = numero;
        }
    }

    Console.WriteLine("El número menor es:" + menor);
}

void arreglos()
{
    int[] notas = new int[15];
    Random rnd = new Random();
    Console.WriteLine("Cargando información");
    for (int i = 0; i < notas.Length; i++)
    {
        notas[i] = rnd.Next(100);
    }

    Console.WriteLine("Desplegando información");

    for (int i = 0; i< notas.Length; i++)
    {
        int mayor = 0, menor = 100;
        Console.WriteLine(notas[i]);

        if (notas[i] > mayor)
        {
            mayor = notas[i];
        }

        if (notas[i] < menor)
        {
            menor = notas[i];
        }
    }

    Console.WriteLine((notas.Sum) / (notas.Length));

}

void nombres()
{
    String[] nombre = new string[6];
    nombre[0] = "Jairo";
    nombre[1] = "Brandon";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";
    nombre[5] = "Juan";
    nombre[6] = "Pablo";
    nombre[7] = "Carlos";
    nombre[8] = "Pedro";
    nombre[9] = "Manuel";

    for (int i = 0; i < nombre.Length;i++)
    {
        Console.WriteLine(i+": " + nombre[i]);
    }
    Random rnd = new Random();

    string GanadorPrimerPremio, GanadorSegundoPremio;

    do
    {
        GanadorPrimerPremio = nombre[rnd.Next(0, 9)];
        GanadorSegundoPremio = nombre[rnd.Next(0, 9)];

    } while (GanadorPrimerPremio == GanadorSegundoPremio);

    Console.WriteLine(GanadorPrimerPremio);
    Console.WriteLine(GanadorSegundoPremio);

    Console.WriteLine("Ganador primer premio: " + GanadorPrimerPremio);
    Console.WriteLine("Ganador segundo premio: " + GanadorSegundoPremio);
}