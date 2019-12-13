using System;
using System.IO;
using System.Text;
class Administrador : Pessoa{
	private int reclamacoesProcessadas;

	public Administrador(string name, int id,string cp){
		this.nome = name;
		this.idade = id;
		this.cpf = cp;
		this.reclamacoesProcessadas = 0;
	}
		public Administrador(string name, int id,string cp,int rp){
		this.nome = name;
		this.idade = id;
		this.cpf = cp;
		this.reclamacoesProcessadas = rp;
		this.logado = true;
	}
	public Administrador(){
		this.nome = "";
	}
	public int getReclamacoesProcessadas(){
		return reclamacoesProcessadas;
	}
	public void setReclamacoesProcessadas(int entrada){
		reclamacoesProcessadas = entrada;
	}

	public string ProcessarReclamacao(Biblioteca biblio){
		int qtde =0;
		for(int y=0;y<biblio.getReclamacoesAprovadas().Length;y++){
			if(biblio.getReclamacoesAprovadas()[y] != null){
				qtde++;
			}
		}
		if(qtde == 0){
			return "-> Não há reclamações disponiveis";
		}
		Console.WriteLine("-> Existem "+qtde+" Reclamações disponiveis!");
		Console.WriteLine("-> Selecione o valor da reclamação que deseja acessar: ");
		bool loop = true;
		while(loop == true){
		int valor = int.Parse(Console.ReadLine());
		for(int x=0;x<biblio.getReclamacoesAprovadas().Length;x++){
			if(biblio.getReclamacoesAprovadas()[x] != null){	

				if(valor == x+1){
					Console.WriteLine("Reclamação :"+biblio.getReclamacoesAprovadas()[x]);
					Console.WriteLine("---------------------------------------");
					Console.WriteLine("|1 - Aprovar | 2 - Recusar | 3 - Sair |");
					Console.WriteLine("---------------------------------------");
					Console.WriteLine("-> ");
					int decisao = int.Parse(Console.ReadLine());
					if (decisao == 3){
						return "-> Volte Sempre!";
					}
					if (decisao == 1 ){
						reclamacoesProcessadas++;
						biblio.getReclamacoesAprovadas()[x] = null;
						return "-> Informação Processada!";
					} 
					else{
						if(decisao == 2){
							biblio.getReclamacoesAprovadas()[x] = null;
							return "-> Feedback Deletado!";
						}
					}

				}
			}
		}
		if(valor == 0){
			return "-> Retornando para o menu";
		}
		Console.WriteLine("-> Valor não encontrado, tente novamente ou aperte '0' para sair");
	}
	return "-> valor não encontrado";
	}



}
