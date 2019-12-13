using System;
using System.IO;
using System.Text;
class Pessoa{
	protected string nome;
	protected int idade;
	protected string cpf;
	protected bool logado;

	//metodos get/set
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

	public string getCpf(){
		return cpf;
	}
	public void setCpf(string c){
		cpf = c;
	}
	
	public bool getLogado(){
		return logado;
	}
	public void setLogado(bool b){
		this.logado = b;
	}
	

}