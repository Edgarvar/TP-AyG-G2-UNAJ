/*
 * Created by SharpDevelop.
 * User: Edgardo
 * Date: 20/9/2020
 * Time: 23:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * EJERCICIO 7:
 * Implemente una función que reciba una matriz (arreglo de dos dimensiones) pasada como parámetro, e imprima por consola todos sus elementos.
 * Debe imprimir todos los elementos de una fila en la misma linea en la consola.
 * 
 * 			static void imprimirMatriz(double[,] matriz)
 * 
 * AYUDA: Si A es una arreglo, A.GetLength(i) devuelve la longitud del arreglo en la dimensión i.
 */
using System;

namespace P2_Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{	
			int filas, columnas;
			
			//Armamos la matriz
			Console.WriteLine("Ingrese la cantidad de filas:");
			filas = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la cantidad de columnas:");
			columnas = int.Parse(Console.ReadLine());
			
			double[,] numeros = new double[filas, columnas];
			
			//Asignamos valores en cada posición de la matriz
			for(int fila = 0; fila < filas; fila++){
				for(int columna = 0; columna < columnas; columna++){
					Console.WriteLine("Dame un número:");
					numeros[fila, columna] = double.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine("----------------------------------");
			Console.WriteLine("----------------------------------");
			
			//Llamamos a la función pasandole como parámetro la matriz armada.
			imprimirMatriz(numeros);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		//función que muestra los valores de cada fila de la matriz
		static void imprimirMatriz(double[ , ] matriz){
			int i = 0;
			for(int fil = 0; fil < matriz.GetLength(i); fil++){
				Console.WriteLine(fil+1 + "° Fila:");
				for(int col = 0; col < matriz.GetLength(i+1); col++){
					Console.Write(matriz[fil, col] + ", ");
				}
				Console.WriteLine("");
				Console.WriteLine("----------------------------------");
			}
		}
	}
}