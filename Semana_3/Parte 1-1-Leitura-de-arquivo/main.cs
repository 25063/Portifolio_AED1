using System;
using System.IO;
using System.Text;


class MainClass {
  public static void Main (string[] args) {
		
		FileStream arquivo = new FileStream("numeros.txt",FileMode.Open,FileAccess.Read);
  
		StreamReader sr = new StreamReader(arquivo,Encoding.UTF8);
	
		int num1 = int.Parse(sr.ReadLine());
		int num2 = int.Parse(sr.ReadLine());

		Console.WriteLine("{0} + {1} = {2}", num1, num2, num1+num2);

		sr.Close();
	
	}
}