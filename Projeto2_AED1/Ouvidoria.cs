using System;
using System.IO;
using System.Text;
class Ouvidoria : Pessoa{
	
	public int reclamacoesEnviadas;

	public Ouvidoria(string name, int id,string cp){
		this.nome = name;
		this.idade = id;
		this.cpf = cp;
		this.logado = false;
	}
	public Ouvidoria(string name, int id,string cp,int reclama){
		this.nome = name;
		this.idade = id;
		this.cpf = cp;
		reclamacoesEnviadas = reclama;

	}	

	public Ouvidoria(){
		this.nome="";
	}
	public int getReclamacoesEnviadas(){
		return reclamacoesEnviadas;
	}

	public string avaliarReclamacao(Biblioteca biblio){
		int qtde =0;
		for(int y=0;y<biblio.getReclamacoes().Length;y++){
			if(biblio.getReclamacoes()[y] != null){
				qtde++;
			}
		}
		if(qtde == 0){
			return "-> Não há reclamações disponiveis!";
		}
		Console.WriteLine("!Existem "+qtde+" Reclamações disponiveis!");
		Console.WriteLine("-> Selecione o valor da reclamação que deseja acessar: ");
		bool loop = true;
		while(loop == true){
		int valor = 0;
		valor = int.Parse(Console.ReadLine());
		for(int x=0;x<biblio.getReclamacoes().Length;x++){
			
			if(biblio.getReclamacoes()[x] != null){	

				if(valor == x+1){
					Console.WriteLine("Reclamação :"+biblio.getReclamacoes()[x]);
					Console.WriteLine("Deseja aprovar(1), recusar(2) ou sair :");
					int decisao = int.Parse(Console.ReadLine());
						if (decisao == 3){
						return "Volte sempre";
					}
					if (decisao == 1 ){
						reclamacoesEnviadas++;
						for(int i=0;i<biblio.getReclamacoesAprovadas().Length;i++){
							if(biblio.getReclamacoesAprovadas()[i] == null){
								biblio.getReclamacoesAprovadas()[i] = biblio.getReclamacoes()[x];
								biblio.getReclamacoes()[x] = null;
								return "Feedback aprovado";
							}
						}

						return "-> Aprovado!";
					} 
					else{
						if(decisao == 2){
							biblio.getReclamacoes()[x] = null;
							return "Feedback deletado";
						}
					}

				}
			}
		}
		if(valor == 0){
					return "-> Retornando para o menu!";
				}
		Console.WriteLine("-> Valor não encontrado, tente novamente ou aperte '0' para sair!");
	}
	return "-> Valor não encontrado!";
	}
}