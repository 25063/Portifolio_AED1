using System;

class MainClass {
  public static void Main (string[] args) {
		float soma = 0.0f;
		float media = 0.0f;
		int x = 0;
		while(x < 10){
			Console.Write((x+1)+"º Number: ");
			soma += float.Parse(Console.ReadLine());
			x++;
		}
		media = soma/10;
		Console.WriteLine("Média: "+media);
  }
}