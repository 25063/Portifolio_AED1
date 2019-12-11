using System;

class MainClass {
  public static void Main (string[] args) {
    
		int k = 0;
		int n = 0;
		int soma = 0;

			try{
			Console.WriteLine ("Soma dos N primeiros múltiplos de K!");
			Console.Write("Insira o valor de K: ");
			k = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Insira N:");
			n = Convert.ToInt32(Console.ReadLine());
			
			while(k>0 & n>0){
				for(int x = 1; x <= n; x++){
					soma += (k*x);
				}
				Console.WriteLine("A soma dos "+n+" primeiros dígitos múltiplos de "+k+" é: "+soma);
				Console.Write("Insira o valor de K: ");
				k = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Insira N:");
				n = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Dígito Inválido!");
		}
		catch(FormatException){
			Console.WriteLine("Dígito Inválido!");		

			Console.Write("Insira o valor de K: ");
			k = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Insira N:");
			n = Convert.ToInt32(Console.ReadLine());

			for(int x = 1; x <= n; x++){
				soma += (k*x);
			}
			Console.WriteLine("A soma dos "+n+" primeiros dígitos múltiplos de "+k+" é: "+soma);		
						
			while(k>0 & n>0){
			for(int x = 1; x <= n; x++){
				soma += (k*x);
			}
			Console.WriteLine("A soma dos "+n+" primeiros dígitos múltiplos de "+k+" é: "+soma);		
			

			}
			
		}
	}
}