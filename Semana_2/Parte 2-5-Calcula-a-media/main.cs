using System;

class MainClass {
  public static void Main (string[] args) {
        
    float nota1 = 0.0f, nota2 =0.0f, peso1 = 0.0f, peso2 = 0.0f;
    float semestral = 0.0f, peso3 = 0.0f, soma = 0.0f, media = 0.0f;
    
    Console.WriteLine ("Informe suas notas para calculo da média!");
    
      Console.WriteLine ("Nota 1:");
      nota1 = float.Parse (Console.ReadLine ());
      Console.WriteLine("Peso 1:");
      peso1 = float.Parse (Console.ReadLine ());
      
      Console.WriteLine ("Nota 2: ");
      nota2 = float.Parse (Console.ReadLine ());
      Console.WriteLine ("Peso 2: ");
      peso2 = float.Parse (Console.ReadLine ());
      
      Console.WriteLine ("Exame Semestral: ");
      semestral = float.Parse (Console.ReadLine ());
      Console.WriteLine ("Peso: ");
      peso3 = float.Parse (Console.ReadLine ());
      
      soma = ((nota1*peso1)+(nota2*peso2)+(semestral*peso3));
      media = (soma/(peso1+peso2+peso3));

      if (media >= 5){
        Console.WriteLine("Você está aprovado!");
      }
      if ( media < 5 & media >= 4){
        Console.WriteLine("Você está apto para fazer o exame suplementar!");
      }
      if (media < 4){
        Console.WriteLine("Você está reprovado!");
      }
  }
} 