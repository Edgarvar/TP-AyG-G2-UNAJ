/*
 * Created by SharpDevelop.
 * User: Edgardo
 * Date: 20/9/2020
 * Time: 23:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * EJERCICIO 1:
 * Escriba una función que reciba una lista de palabras como parametros e informe cuáles son palíndromos.
 * En el programa principal, al ingresar las palabras resuelva el ejercicio:
 * 		a) utilizando la sentencia WHILE
 * 		b) utilizando la sentencia FOR
 * 		c) utilizando la sentecia FOREACH
 */
using System;
using System.Collections;

namespace P3_Ejercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//vector de strings
			string[] palabras = new string[] {"reconocer", "sometemos", "presionar", "abracadabra", "neuquen"};
			
			//llamamos a la función pasandole el vector de string como parametro
			imprimirPalindromos(palabras);
			
			Console.WriteLine("------------------------------------------------------------");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		//Armado de función
		static void imprimirPalindromos(string[] lista){
			//Creamos una pila
			Stack pila = new Stack();
			
			//Creamos una variable string para colocar la palabra invertida
			string palabraRevertida;
			
			
			while(lista.Length != 0){
				foreach(string palabra in lista){ //Recorremos el vector
					for(int i = 0; i < palabra.Length; i++){ //Recorremos la palabra
						pila.Push(palabra[i]); //cada caracter de la palabra la guardamos en la pila letra por letra
					}
					palabraRevertida = Convert.ToString(pila.Pop()); //le asignamos la ultima letra de la pila en la variable
					int qty = pila.Count; // guardamos la cantidad de contenido de la pila en una nueva variable
					for(int j = 0; j < qty; j++){ 
						palabraRevertida = palabraRevertida + Convert.ToString(pila.Pop()); //concatenamos cada letra de la palabra en la variable para que se arme de forma invertida
					}
					
					if(palabra == palabraRevertida){ // igualamos la palabra normal con la palabra invertida 
						Console.WriteLine(palabra + ": es palindromo"); //true
						Console.WriteLine("------------------------------------------------------------");
					} else {
						Console.WriteLine(palabra + ": no es palindromo"); // false
						Console.WriteLine("------------------------------------------------------------");
					}
					
				}
				break;
			}
			
		}
	}
}