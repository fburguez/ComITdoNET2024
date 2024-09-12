////using System.Diagnostics.CodeAnalysis;

////string nombre = "Facu";
////int edad = 18;
////double precio = 10.5;
////bool EstaNublado = true;
////char letra = 'B';
////DateTime datetime = DateTime.Now;
////DateOnly  fechasolo;
////TimeOnly  horasolo;


////const string saludo1 = "Buen dia";

////string saludo;

////if (EstaNublado == true)
////{
////    string apellido = "Burguez";
////    //saludo = "Hola " + nombre + ", hoy es un buen dia";
////    saludo = $"Hola {nombre.ToUpper()} {apellido} , hoy es un buen dia";
////}
////else
////{
////    saludo = "Hola " + nombre + ", hoy no es un buen dia";
////}

////Console.WriteLine(saludo);

////int nro1 = 10;
////int nro2 = 20;
////int suma = nro1 + nro2;
////Console.WriteLine(suma);

////int resta = nro1 - nro2;
////Console.WriteLine(resta);

////int producto = nro1 * nro2;
////Console.WriteLine(producto);

////nro1++;
////Console.WriteLine(nro1);

////nro2--;
////Console.WriteLine(nro2);

////nro1 = +100;
////Console.WriteLine(nro1);


////string operador="suma";
////int resul = 0;
//// if (operador=="suma")
////{
////    resul = nro1 + nro2;
////}
//// else if (operador=="multiplicacion")
////{
////    resul = nro1 - nro2;
////}
////else if (operador == "multiplicacion")
////{
////    resul = nro1 *- nro2;
////}
////else if (operador == "division")
////{
////    resul = nro1 / nro2;
////}
////Console.WriteLine($"El resultado de la {operador} es igual a {resul}");

////clase2
//Console.WriteLine("WHILE");
//int n = 0;
//while (n <= 5)
//{
//    Console.WriteLine(n);
//    n++;
//}
//Console.WriteLine("DO");
//int n1 = 0;
//do
//{
//    Console.WriteLine(n1);
//    n1++;
//} while (n1 <= 5);


////ARRAY
//int[] numerosarray = new int[5];
//numerosarray[0] = 4;
//numerosarray[1] = 5;
//numerosarray[2] = 6;
//numerosarray[3] = 7;
//numerosarray[4] = 8;


//Console.WriteLine(numerosarray[0]);
//Console.WriteLine(numerosarray[1]);
//Console.WriteLine(numerosarray[2]);
//Console.WriteLine(numerosarray[3]);
//Console.WriteLine(numerosarray[4]);





//string[] textos = new string[5] { "UNO", "DOS", "TRES", "CUATRO", "CINCO" };
//string[] textossimple = ["UNO", "DOS", "TRES", "CUATRO", "CINCO"];

//Array.Resize(ref textossimple, 10); ///para cambiar la cantidad de posiciones

//Console.WriteLine("FOR");

//for (int i = 0; i < textos.Length; i++)
//{
//    Console.WriteLine($"Posicion {i}: {textos[i]} ");
//}


//string?[] cadenasconnull = new string?[5] { "UNO", "", null, "CUATRO", "CINCO" }; // el signo de ? significa esa variable ademas de poder ser 
//                                                                                  // un tipo de variable pueda ser null (nulo), de otra manera no podria usar null

//Console.WriteLine("FOREACH");
//foreach (var item in cadenasconnull)
//{
//    //if (item == null)
//    //{
//    //  Console.WriteLine("Sin valor");
//    //}
//    //else
//    //{
//    //   Console.WriteLine(item);
//    // }
//    //Console.WriteLine(item == null ? "Sin Valor" : item);
//    Console.WriteLine(item ?? "Sin Valor");
//}


Console.WriteLine("Ejercicio uno: Definir una variable numérica, asignarle un valor y sumarle 5.\nDefinir dos variables de cadenas, asignarles valores y concatenarlas.");
int num = 8;
int num2 = 5;
int Result = num + num2;
Console.WriteLine($"la suma de {num} + {num2} es: {Result}");

string nombre = "Facundo";
string apellido = "Burguez";
Console.WriteLine($"mi nombre es {nombre} y mi apellido es {apellido}");

Console.WriteLine("Ejercicio dos:Evaluar si dos números son iguales diferentes, mayor o menor. ");


if ( num == num2 )
{
    Console.WriteLine("Son inguales");
}
else
{
    if ( num != num2 )
    {
        Console.WriteLine("Son diferentes");
    }
    if ( num > num2 )
    {
        Console.WriteLine("El primer nro es mayor y el segundo menor");  
    }
    if (num < num2)
    {
        Console.WriteLine("El segundo nro es mayor y el primero menor");
    }
}

Console.WriteLine("Ejercicio tres:Definir una variable numérica. Asignarle un\r\nvalor entre 1 y 10\r\nMostrar a que grupo pertenece:\r\n\r\nGrupo 1: del 1 al 3\r\nGrupo 2: del 4 al 6\r\nGrupo 3: del 7 al 10");

short numero = 0;
string textToShow = string.Empty;
Console.WriteLine("Escriba un numero del 1 al 10 a asignar: ");
numero = short.Parse(Console.ReadLine());
switch (numero)
{
    case <= 3:
        {
            textToShow = "intervalo del 1 al 3";
            break;
        }
    case <= 6:
        {
            textToShow = "intervalo del 4 al 6";
            break;
        }
    case <= 10:
        {
            textToShow = "intervalo del 7 al 10";
            break;
        }
    default:
        {
            textToShow = "intervalo fuera de rango";
            break;
        }
}
Console.WriteLine($"El numero dado se encuentra en el {textToShow}");







