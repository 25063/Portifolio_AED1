using System;

class MainClass {
  public static void Main (string[] args) {
  
		double man = 72.7;
		double woman = 62.1;
		double peso = 0;
    double altura = 0;
		Console.WriteLine("Homem(m) ou Mulher(f): ");
		string entrada = Console.ReadLine();
		Console.WriteLine("Informe sua altura: ");
		string entrada2 = Console.ReadLine();
		altura = Convert.ToDouble(entrada2);

		if(altura>0){
			if(entrada == "m"){
				peso = (man*(altura)-58.0);
				Console.WriteLine("Seu peso ideal é "+peso);
				
			}
			else if(entrada == "f"){
				peso = ((woman*altura)-44.7);
				Console.WriteLine("Seu peso ideal é "+peso);
				
			}
		
		}
		else{
			
		}
	}
}