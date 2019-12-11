using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Insira números inteiros!");
    Console.WriteLine("1º número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("2º número: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("3º número: ");
    int num3 = int.Parse(Console.ReadLine());

    if (num1 > num2 && num1 > num3){
      Console.WriteLine("O maior número é {0}.",num1);
      
    }
    if (num2 > num1 && num2 > num3){
      Console.WriteLine("O maior número é {0}.",num2); 
       
    }
    if (num3 > num1 && num3 > num2){
      Console.WriteLine("O maior número é {0}.",num3);

    }
       
    

  }
}
