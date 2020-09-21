/*
 * Created by SharpDevelop.
 * User: Edgardo
 * Date: 20/9/2020
 * Time: 23:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * EJERCICIO 6:
 * Escriba un programa de aplicación que imprima en la consola todos los números pares que además sean múltiplos de 5 
 *y estén comprendidos entre 250 y 900.
 */
using System;

namespace P1_Ejercicio_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			for(int i = 250; i <= 900; i++){
				if((i%2 == 0) & (i%5 == 0)){
					Console.Write(i + ", ");
				}
			}
			
			
			Console.ReadKey(true);
		}
	}
}