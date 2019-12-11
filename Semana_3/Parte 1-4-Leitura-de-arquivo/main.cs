using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
		char entrada = ' ';
		char vogal = ' ';
		/*Crie um programa em C# que realize a leitura de 20 letras presentes em um arquivo e, em seguida, exiba para o usuário o total de vogais, o total de consoantes e o total de dígitos.*/
		FileStream meuArq = new FileStream("caracteres.txt",FileMode.Open,FileAccess.Read);

		StreamReader sr = new StreamReader(meuArq,Encoding.UTF8);
		
		Console.WriteLine();
		sr.Close();
  }
}