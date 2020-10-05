/*
 * Created by SharpDevelop.
 * User: Edgardo
 * Date: 5/10/2020
 * Time: 17:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * EJERCICIO 4:
 * Escriba un programa de aplicación (Main) que permita al usuario ingresar en una consola una serie de datos de la forma 
 * "Nombre<TAB>Documento<TAB>Edad<ENTER>".
 * 		A) Utilizando un arreglo de Personas. 
 * 		Antes de comenzar con la carga el usuario debe ingresar por consola la cantidad de personas que va cargar.
 * 		B) Utilizando un ArrayList. En este caso el usuario no debe ingresar la cantidad de
 *		personas que va a cargar, simplemente el proceso de entrada finaliza con un string vacío.
 *		
 *	Una vez finalizada la entrada de datos, el programa debe imprimir en la consola el listado con la forma:
 *		Nro.) Nombre (Edad) <TAB> DNI.
 *		Ejemplo:
 *		1) Juan Perez (40) 2098745
 *		2) José García (41) 1965412
 */
using System;

namespace P4_Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Por favor indique la cantidad de personas a ingresar: "); 
			
			int cantidad = int.Parse(Console.ReadLine()); // Asignamos valor de cantidad a la variable
			
			Persona[] Arreglo = new Persona[cantidad]; // Se crea un arreglo de Personas
			
			for(int i = 0; i < Arreglo.Length; i++){ // Recorremos el arreglo
				
				Persona p1 = new Persona(); // Creamos una persona
				
				Console.Write("Nombre: ");
				p1.nombre = Console.ReadLine();
				Console.Write("Edad: ");
				p1.edad = Console.ReadLine();
				Console.Write("DNI: ");
				p1.dni = Console.ReadLine();
				
				Arreglo[i] = p1; // Cargamos es persona en una posición del arreglo
				
			}
			
			for(int j = 0; j < Arreglo.Length; j++){ // Recorremos el arreglo con las personas cargadas
				
				Console.WriteLine(j+1 + ") {0}	{1}	{2}", Arreglo[j].nombre, Arreglo[j].edad, Arreglo[j].dni); // Imprimimos msj
				
			}
			
			Console.ReadKey(true);
		}
		
		class Persona{ // Clase Persona
			public string nombre;
			public string dni;
			public string edad;
				
			
		}
	}
}