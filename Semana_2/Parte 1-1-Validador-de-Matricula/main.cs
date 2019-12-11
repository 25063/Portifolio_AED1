using System;

class MainClass {
  public static void Main (string[] args) {
    
		//Definição da variáveis
    string  entrada,matricula;
    int d1=0, d2=0, d3=0, d4=0, d5=0, d6=0, d7=0, d8=0;
    int soma, num2 = 2, num3 = 3, num4 = 4, resto;

    Console.WriteLine("Insira sua matrícula!\n Obrigatóriamente deve conter 8 dígitos.");

    Console.WriteLine("Matrícula: ");
    matricula = Console.ReadLine();


    entrada = Convert.ToString(matricula[0]);    
    d1 = int.Parse(entrada);

    entrada = Convert.ToString(matricula[1]);
    d2 = int.Parse(entrada);

    entrada = Convert.ToString(matricula[2]);
    d3 = int.Parse(entrada);

    entrada = Convert.ToString(matricula[3]);
    d4 = int.Parse(entrada);

    entrada = Convert.ToString(matricula[4]);
    d5 = int.Parse(entrada);

    entrada = Convert.ToString(matricula[5]);
    d6 = int.Parse(entrada);

    entrada = Convert.ToString(matricula[6]);
    d7 = int.Parse(entrada);

    entrada = Convert.ToString(matricula[7]);
    d8 = int.Parse(entrada);
    
		//Verificar dígitos
    soma = ((d1*num2) + (d2*num3) + (d3*num4) + (d4*num3) + (d5*num2) + d6 + d7 + d8);
    resto = soma%10;
    
    Console.WriteLine("Dígito verificador: {0}",resto);

    if (resto == d8){
      Console.WriteLine("Sua matrícula é Válida!");
    }
    if (resto != d8){
      Console.WriteLine("Sua matrícula é Inválida!");
    }  
    

  }
}