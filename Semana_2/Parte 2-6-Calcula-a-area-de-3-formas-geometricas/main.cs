using System;

class MainClass {
  public static void Main (string[] args) {
    int opcao = 0;
    float baseTriangulo = 0.0f, alturaTriangulo = 0.0f, areaTriangulo = 0.0f;
    float baseRetangulo = 0.0f, alturaRetangulo = 0.0f, areaRetangulo = 0.0f;
    float pi = 3.14159f, raio = 0.0f, areaCirculo = 0.0f;
    Console.WriteLine("|------------------------------------|");
    Console.WriteLine("|          Cálculo da área:          |");
    Console.WriteLine("|------------------------------------|");
    Console.WriteLine("|    -> 1º Triângulo                 |");
    Console.WriteLine("|    -> 2º Retângulo                 |");
    Console.WriteLine("|    -> 3º Circunsferência           |");
    Console.WriteLine("|------------------------------------|");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine("|------------------------------------|");
    Console.WriteLine("|      Escolha a opção desejada:     |");
    Console.WriteLine("|------------------------------------|");
    Console.Write("| -> Opção: ");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine("|------------------------------------|");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    switch (opcao){
      case 1:
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|   Informe os dados necessários:    |");
        Console.WriteLine("|------------------------------------|");
        Console.Write("|  Base: ");
        baseTriangulo = float.Parse(Console.ReadLine());
        Console.Write("|  Altura: ");
        alturaTriangulo = float.Parse(Console.ReadLine());
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        areaTriangulo = ((baseTriangulo*alturaTriangulo)/2);
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|  A área do Triângulo é: {0}m²        |",areaTriangulo);
        Console.WriteLine("|------------------------------------|");
        break;
      case 2:
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|   Informe os dados necessários:    |");
        Console.WriteLine("|------------------------------------|");
        Console.Write("|  Base: ");
        baseRetangulo = float.Parse(Console.ReadLine());
        Console.Write("|  Altura: ");
        alturaRetangulo = float.Parse(Console.ReadLine());
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        areaRetangulo = (baseRetangulo*alturaRetangulo);
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("| A área do Retângulo é: {0}m²       |",areaRetangulo);
        Console.WriteLine("|------------------------------------|");
        break;
      case 3:
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|   Informe os dados necessários:    |");
        Console.WriteLine("|  Valor de Pi: {0}",pi);
        Console.Write("|  Raio:  ");
        raio = float.Parse(Console.ReadLine());
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        areaCirculo = (pi*(raio*raio));
        Console.WriteLine("|-----------------------------------------|");
        Console.WriteLine("| A área da circunsferência é: {0}m² |",areaCirculo);
        Console.WriteLine("|-----------------------------------------|");
        break;
      default:
        Console.WriteLine("|------------------------------------|");
        Console.WriteLine("|           Opção Inválida!          |");
        Console.WriteLine("|------------------------------------|");
        break;
    }
  }
} 