using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {

		int b = 1;
		double raiz = 0;
    
		FileStream meuArq = new FileStream("numeros.txt",FileMode.Open,FileAccess.Read);

		StreamReader sr = new StreamReader(meuArq,Encoding.UTF8);

		for (int x = 0; x < 2; x++){
			int num = Convert.ToInt32(sr.ReadLine());
			Console.WriteLine(num);

		}
		sr.Close();
		
  }
}