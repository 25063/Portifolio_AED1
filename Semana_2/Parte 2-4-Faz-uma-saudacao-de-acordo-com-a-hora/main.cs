using System;

class MainClass {
  public static void Main (string[] args) {
    
    int hora = 0;

    Console.WriteLine("Informe a hora: ");
    hora = int.Parse(Console.ReadLine());

    if (hora > 0 & hora <= 12){
      Console.WriteLine("Bom dia!");
    }
    if (hora > 12 & hora <= 18){
      Console.WriteLine("Boa Tarde!");
    }
    if (hora > 18 & hora <=23){
      Console.WriteLine("Boa Noite!");
    }
    if (hora >= 24 | hora <= 0){
      Console.WriteLine("Hora Inválida!");
    }
  } 