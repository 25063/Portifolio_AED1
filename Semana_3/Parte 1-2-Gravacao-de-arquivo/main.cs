using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
    int soma = 0;
		Console.Write("1º número: ");
		int num1 = int.Parse(Console.ReadLine());
		
		Console.Write("2º número: ");
		int num2 = int.Parse(Console.ReadLine());
		
		soma = (num1 + num2);
		Console.WriteLine("Soma: {0}",soma);

		FileStream meuArq = new FileStream("arquivo.txt",FileMode.Open,FileAccess.Write);

		StreamWriter sw = new StreamWriter(meuArq,Encoding.UTF8);
		sw.WriteLine(soma);
		sw.Close();

  }
}