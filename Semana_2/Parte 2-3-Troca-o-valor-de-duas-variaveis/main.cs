using System;

class MainClass {
  public static void Main (string[] args) {
    int num1 = 0,num2 = 0;

    Console.WriteLine ("1º número: ");
    num1 = int.Parse(Console.ReadLine());  

    Console.WriteLine ("2º número: ");
    num2 = int.Parse(Console.ReadLine());
    
    num1 = num1 + num2;
    num2 = num2 + num1;
    num1 = num2 - num1;
    num2 = num2 - (2 * num1);

    Console.WriteLine("1º número: {0}",num1);
    Console.WriteLine("2º número: {0}",num2);
  }
}
