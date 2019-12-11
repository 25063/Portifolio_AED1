using System;

class MainClass {
  public static void Main (string[] args) {
		int num = 0;
		Console.WriteLine("Para parar o programa digite -1.");
		
		while (num != (-1)){
			Console.Write("Insira um número: ");
			num = int.Parse(Console.ReadLine());
			
			if ((num %2 != 0) || (num %3 != 0) || (num %5 != 0) || (num %7 != 0)){
				Console.WriteLine(0);
			}
			
			if ((num %2 == 0) || (num %3 == 0)){
				Console.WriteLine(1);
			}
			if ((num %5 == 0) || (num %7 == 0)){
				Console.WriteLine(2);
			}
		}
  }
}