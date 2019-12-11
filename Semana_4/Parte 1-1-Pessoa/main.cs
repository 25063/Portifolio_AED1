using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("");

		string nome = "";
		int idade = 0;
		string sexo = "";
		float altura = 0f;

		Pessoa user = new Pessoa(nome,idade,sexo,altura);

		Console.WriteLine("Nome:");
		nome = Console.ReadLine();
		user.setNome(nome);

		Console.WriteLine("Idade:");
		idade = Convert.ToInt32(Console.ReadLine());
		user.setIdade(idade);

		Console.WriteLine("Sexo:");
		sexo = Console.ReadLine();
		user.setSexo(sexo);

		Console.WriteLine("Altura:");
		altura = float.Parse(Console.ReadLine());
		user.setAltura(altura);
		
		Console.WriteLine(user.getNome());
		Console.WriteLine(user.getIdade());
		Console.WriteLine(user.getSexo());
		Console.WriteLine(user.getAltura());

  }
}