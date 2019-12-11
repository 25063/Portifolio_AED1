using System;
class Pessoa{
	//Atributos
	private string nome;
	private int idade;
	private string sexo;
	private float altura;

	//Construtores
	/*public Pessoa(){
		nome = "Amanda";
		idade = 20;
		sexo = "Feminino";
		altura = 1.60f;
	}*/
	public Pessoa(string n, int i, string s, float a){
		this.nome = n;
		this.idade = i;
		this.sexo = s;
		this.altura = a;
	}
	//Métodos get/set
	public string getNome(){
		return nome;
	}
	public void setNome(string n){
		nome = n;
	}

	public int getIdade(){
		return idade;
	}
	public void setIdade(int i){
		idade = i;
	}

	public string getSexo(){
		return sexo;
	}
	public void setSexo(string s){
		sexo = s;
	}

	public float getAltura(){
		return altura;
	}
	public void setAltura(float a){
		altura = a;
	}

}