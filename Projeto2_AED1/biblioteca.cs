using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Biblioteca{
	
	//Declaração dos Atributos
	private string nome;
	private string cep;
	private string[] reclamacoes = new string[100];
	private string[] reclamacoesAprovadas = new string[100];
	private Pessoa[] pessoas = new Pessoa[50];
	private Livro[] livros = new Livro [100];

	 
		
	//Construtores
	public Biblioteca(string n, string c){
		this.nome = n;
		this.cep = c;
	}
	
	public Biblioteca(){
		this.nome = "";
		this.cep = "";
	}

	//Métodos get/set
	public string getNome(){
		return nome;
	}
	public void setNome(string n){
		nome = n;
	}
	

	public void setUsuario(Pessoa user){
		pessoas[0] = user;
	}

	public string getCep(){
		return cep;
	}
	public void setCep(string c){
		cep = c;
	}
	

	public Livro[] getLivros(){
		return this.livros;
	}
	public void setLivros(Livro[] livro){
		this.livros = livro;
	}
	public string[] getReclamacoes(){
		return reclamacoes;
	}
	public void setReclamacoes(string[] reclama){
		this.reclamacoes = reclama;
	}
	public string[] getReclamacoesAprovadas(){
		return reclamacoesAprovadas;
	}
	public void setReclamacoesAprovadas(string[] reclama){
		this.reclamacoesAprovadas = reclama;
	}
	

	public Usuario getUsuarioLogado(){
		Usuario user = new Usuario();
		for(int x=0; x < pessoas.Length;x++){
			if(pessoas[x] != null){
				if(pessoas[x].getLogado() == true ){
					if(pessoas[x].GetType() == typeof(Usuario)){
					user = (Usuario) pessoas[x];
					return user;
					}
				}
			}	
		}
		return null;
	}
		public Ouvidoria getOuvidoriaLogado(){
		Ouvidoria funci = new Ouvidoria();
		for(int x=0; x < pessoas.Length;x++){
			if(pessoas[x] != null){
				if(pessoas[x].getLogado() == true ){
					if(pessoas[x].GetType() == typeof(Ouvidoria)){
					funci = (Ouvidoria) pessoas[x];
					return funci;
					}
				}
			}	
		}
		return null;
	}
		public Administrador getADMLogado(){
		Administrador admin = new Administrador();
		for(int x=0; x < pessoas.Length;x++){
			if(pessoas[x] != null){
				if(pessoas[x].getLogado() == true ){
					if(pessoas[x].GetType() == typeof(Administrador)){
					admin = (Administrador) pessoas[x];
					return admin;
					}
				}
			}	
		}
		return null;
	}
	public Pessoa retornarUsuarioLogado(){
		if(getUsuarioLogado().GetType().ToString() == "Usuario" ){
			return getUsuarioLogado();
		}
		return null;

	}

	//Métodos Funcionais

	public void  RealizarCadastro(Pessoa user){
		for(int x=0;x < pessoas.Length;x++){
			if(pessoas[x] == null){
				pessoas[x] = user;
				break;
			}
		}
	}

	public bool AutentificarUsuario(string nome,string oCep){	
		for(int x=0; x< pessoas.Length;x++){
			if(pessoas[x] != null){
				if(pessoas[x].getNome() == nome && pessoas[x].getCpf() == oCep){
					pessoas[x].setLogado(true);
					return true;
				}
			}
		}
		return false;
	}	


	public bool AutentificarUsuarioADM(string nome,string oCep){
		for(int x=0; x< pessoas.Length;x++){
			if(pessoas[x] != null){
				if(pessoas[x].getNome() == nome && pessoas[x].getCpf() == oCep && pessoas[x].GetType().ToString() == "Administrador"){
					pessoas[x].setLogado(true);
					return true;
				}
			}
			
		}
		return false;
	}
	public bool AutentificarUsuarioOuvidoria(string nome, string oCep){
		for(int x=0; x< pessoas.Length;x++){
			if(pessoas[x] != null){
				if(pessoas[x].getNome() == nome && pessoas[x].getCpf() == oCep && pessoas[x].GetType().ToString() == "Ouvidoria"){
					pessoas[x].setLogado(true);
					return true;
				}
			}
		}
		return false;
	}

	public void SalvarPessoa(Pessoa pes){
		for(int x=0;x<pessoas.Length;x++){
			if(pessoas[x] != null){
				if(pessoas[x].getNome() == pes.getNome() && pessoas[x].getCpf() == pes.getCpf()){
					pessoas[x] = pes;
					Console.WriteLine("Alterações feitas com sucesso");
				}
			}
		}
		
	}
	
	

	public void AdicionarLivro(Livro livro){
		for(int x=0;x < livros.Length;x++){
			if(livros[x] == null){
				livros[x] = livro;
				Console.WriteLine("-> Livro Adicionado.");
				break;
			}	
		}
	}


	public void MostrarLivros(){
		for(int x=0; x < livros.Length;x++){
			if(livros[x] != null){
				Console.WriteLine(livros[x].getNome());
			}
		}
	}

	public string verReclamacoesEnviadas(){
		int qtde = 0;
		for(int x=0;x<reclamacoesAprovadas.Length;x++){
			if(reclamacoesAprovadas[x] != null){
				qtde++;
			}
		}
			if(qtde == 0){
				return "Não existe nenhuma reclamação atualmente";
			}
		Console.WriteLine("Existem "+qtde+" Reclamações, selecione um valor para respectiva reclamação que deseja ver:");
		int valor = int.Parse(Console.ReadLine());
		for(int y=0;y<reclamacoesAprovadas.Length;y++){
			if(reclamacoesAprovadas[y] != null){
				if((y+1) == valor){
					return reclamacoesAprovadas[y];
				}
			}
		}
		return "Reclamação não foi encontrada";
	}

	public string verReclamacoes(){
		int qtde = 0;
		for(int x=0;x<getReclamacoes().Length;x++){
			if(getReclamacoes()[x] != null){
				qtde++;
			}
		}
			if(qtde == 0){
				return "Não existe nenhuma reclamação atualmente";
			}
		Console.WriteLine("Existem "+qtde+" Reclamações, selecione um valor para respectiva reclamação que deseja ver:");
		int valor = int.Parse(Console.ReadLine());
		for(int y=0;y<getReclamacoes().Length;y++){
			if(getReclamacoes()[y] != null){
				if((y+1) == valor){
					return getReclamacoes()[y];
				}
			}
		}
		return "Reclamação não foi encontrada";
	}
		



	public void LerLivros(){
		FileStream leituraArquivo = new FileStream("dadosLivro.txt",FileMode.Open,FileAccess.Read);
		StreamReader sr = new StreamReader(leituraArquivo,Encoding.UTF8);
		while(!sr.EndOfStream){
			string linha = sr.ReadLine();
			string[] vetorInfo = linha.Split(";");
			string varNome = vetorInfo[0];
			string varGenero = vetorInfo[1];
			string varAutor = vetorInfo[2];
			int varFaixa_etaria = int.Parse(vetorInfo[3]);

			Livro livro = new Livro(varNome,varGenero,varAutor,varFaixa_etaria);

			for (int i=0;i<livros.Length;i++){
				if(livros[i] == null){
					livros[i] = livro;
					break;
				}
			}
		}	
		sr.Close();
		leituraArquivo.Close();
	}
	

	//Setor de arquivos
	public void GravarLivros(){
		
		string variavel;
		List<string> todasLinhas = new List<string>();
		for(int x = 0;x<livros.Length;x++){
			if (livros[x] != null){
			
				variavel = "";
				variavel += livros[x].getNome() + ";";
				variavel += livros[x].getGenero() + ";";
				variavel += livros[x].getAutor() + ";";
				variavel += livros[x].getFaixa_etaria();
				todasLinhas.Add(variavel);

			}
		}
		File.WriteAllLines("dadosLivro.txt", todasLinhas);

	}


	public void GravarUsuarios(){
		string userDoido;
		List<string> todasLinhas = new List<string>();
		Usuario user = null;
		Administrador admi = null;
		Ouvidoria ouvido= null;


		for(int x = 0; x < pessoas.Length; x++){
			
			if (pessoas[x] != null){
				userDoido = "";
				if(pessoas[x].GetType() == typeof(Usuario) ){
				user = (Usuario) pessoas[x];
				userDoido += 1 + ";";
				userDoido += user.getNome() + ";";
				userDoido += user.getIdade() + ";";
				userDoido += user.getCpf() + ";";
				todasLinhas.Add(userDoido);
				}
				if(pessoas[x].GetType() == typeof(Administrador)){
				admi = (Administrador) pessoas[x];
				userDoido += 2 + ";";
				userDoido += admi.getNome() + ";";
				userDoido += admi.getIdade() + ";";
				userDoido += admi.getCpf() + ";";
				userDoido += admi.getReclamacoesProcessadas();
				todasLinhas.Add(userDoido);

				}
				if(pessoas[x].GetType() == typeof(Ouvidoria)){
				ouvido = (Ouvidoria) pessoas[x];
					
				userDoido += 3 + ";";
				userDoido += ouvido.getNome() + ";";
				userDoido += ouvido.getIdade() + ";";
				userDoido += ouvido.getCpf() + ";";
				userDoido += ouvido.getReclamacoesEnviadas();

				todasLinhas.Add(userDoido);
				}

			}	
		}

		File.WriteAllLines("dadosUsuario.txt", todasLinhas);
	}


	public void LerUsuarios(){
		FileStream lerUser = new FileStream("dadosUsuario.txt",FileMode.Open,FileAccess.Read);		
		StreamReader sr = new StreamReader(lerUser,Encoding.UTF8);

		while(!sr.EndOfStream){
			
			string userDoido2 = sr.ReadLine();
			string[] vetorUser = userDoido2.Split(";");
			int valor = int.Parse(vetorUser[0]);
			Usuario user = null;
			Administrador admi = null;
			Ouvidoria ouvi = null;
			
			if(valor == 1){
			string userNome = vetorUser[1];
			int userIdade = int.Parse(vetorUser[2]);
			string userCpf = vetorUser[3];
			user = new Usuario(userNome, userIdade, userCpf);
			for (int i = 0; i < pessoas.Length; i++){
				if(pessoas[i] == null){
					pessoas[i] = user;
					user = null;
					break;
				}
			}			
			}
			if(valor == 2){
			string admNome = vetorUser[1];
			int admIdade = int.Parse(vetorUser[2]);
			string admCpf = vetorUser[3];
			int admReclamation = int.Parse(vetorUser[4]);

			admi = new Administrador(admNome, admIdade, admCpf,admReclamation);
			for (int i = 0; i < pessoas.Length; i++){
				if(pessoas[i] == null){
					pessoas[i] = admi;
					admi = null;
					break;
				}
			}			
			}			
			if(valor == 3){
			string userNome = vetorUser[1];
			int userIdade = int.Parse(vetorUser[2]);
			string userCpf = vetorUser[3];
			int OuviReclamacoes= int.Parse(vetorUser[4]);
			ouvi = new Ouvidoria(userNome, userIdade, userCpf,OuviReclamacoes);
			for (int i = 0; i < pessoas.Length; i++){
				if(pessoas[i] == null){
					pessoas[i] = ouvi;
					ouvi = null;
					break;
				}
			}			
			}
		}
		sr.Close();
		lerUser.Close();		
	}

	
	public void GravarLivrosUsuario(){

		List<string> todasLinhas = new List<string>();
		Usuario cara = null;
		
		for(int x=0;x<pessoas.Length;x++){

			if(pessoas[x] != null){

				if(pessoas[x].GetType() == typeof(Usuario) ){
				cara = (Usuario) pessoas[x];

					for(int i=0;i<cara.getLivroUsuario().Length;i++){

						if(cara.getLivroUsuario()[i] != null){						
							string valores = "";
							valores += (cara.getNome()+";");
							valores += (cara.getCpf()+";");
							valores += (cara.getLivroUsuario()[i].getNome()+";");
							valores += (cara.getLivroUsuario()[i].getGenero()+";");
							valores += (cara.getLivroUsuario()[i].getAutor()+";");
							valores += (cara.getLivroUsuario()[i].getFaixa_etaria());

							todasLinhas.Add( valores );
						}
					}
				}
			}
		}

		if(todasLinhas.Count == 0){
			File.WriteAllText("dadosLivrosUsuarios.txt", "");
		}
		else{
			File.WriteAllLines("dadosLivrosUsuarios.txt", todasLinhas);
		}
	}
	public void LerLivroUsuario(){
		FileStream lerUser = new FileStream("dadosLivrosUsuarios.txt",FileMode.Open,FileAccess.Read);		
		StreamReader sr = new StreamReader(lerUser,Encoding.UTF8);
		Usuario user =null;

		while(!sr.EndOfStream){
			string variavel = sr.ReadLine();

			string[] vetorInfo = variavel.Split(";");
			string varNomeUser = vetorInfo[0];
			string varCPFuser = vetorInfo[1];
			string varNome = vetorInfo[2];
			string varGenero = vetorInfo[3];
			string varAutor = vetorInfo[4];
			int varFaixa_etaria = int.Parse(vetorInfo[5]);
			Livro livro = new Livro(varNome,varGenero,varAutor,varFaixa_etaria);
			for(int x=0;x<pessoas.Length;x++){
				if(pessoas[x] != null){
					if(pessoas[x].GetType() == typeof(Usuario)){
					user = (Usuario) pessoas[x];
					if(user.getNome() == varNomeUser && user.getCpf() == varCPFuser){
						for(int y = 0 ; y < user.getLivroUsuario().Length;y++){
							if(user.getLivroUsuario()[y] == null){
								user.getLivroUsuario()[y] = livro;
								pessoas[x] = user;
								break;
							}
							}
						}
					}
				}
			}		
		}
		sr.Close();
		lerUser.Close();
	}

	public void lerReclamacoes(){
		
		FileStream leituraArquivo = new FileStream("Reclamacoes.txt",FileMode.Open,FileAccess.Read);
		StreamReader sr = new StreamReader(leituraArquivo,Encoding.UTF8);

		while(!sr.EndOfStream){
			string linha = sr.ReadLine();
			int x =0;
			reclamacoes[x] = linha;
			x++;	
		}
		leituraArquivo.Close();
		sr.Close();
		}

	public void gravarReclamacoes(){

		List<string> todasLinhas = new List<string>();
		for(int x = 0;x<reclamacoes.Length;x++){
			if (reclamacoes[x] != null){
				todasLinhas.Add(reclamacoes[x]);

				
			}
		}
		File.WriteAllLines("Reclamacoes.txt", todasLinhas);
		
		
	}

	public void lerReclamacoesEnviadas(){
		FileStream leituraArquivo = new FileStream("ReclamacoesEnviadas.txt",FileMode.Open,FileAccess.Read);
		StreamReader sr = new StreamReader(leituraArquivo,Encoding.UTF8);

		while(!sr.EndOfStream){
			string linha = sr.ReadLine();
			int x =0;
			reclamacoesAprovadas[x] = linha;
			x++;	
		}
		leituraArquivo.Close();
		sr.Close();
		}
	
	

	public void gravarReclamacoesEnviadas(){

		
		List<string> todasLinhas = new List<string>();
		for(int x = 0;x<reclamacoesAprovadas.Length;x++){
			if (reclamacoesAprovadas[x] != null){
				todasLinhas.Add(reclamacoesAprovadas[x]);

				
			}
		}
		File.WriteAllLines("ReclamacoesEnviadas.txt", todasLinhas);
		
	}






	public bool autentificarCpf(string ac){
		
		int condicao = 1;
		while(condicao == 1){
			
			try{
				condicao = 1;
				string entrada = ac;
				int[] cpf = new int[11];
				int soma = 0, soma2 = 0, resto = 0, resto2 = 0;

				for(int x=0;x<11;x++){
					cpf[x] = Convert.ToInt32(entrada[x].ToString());
				}					
				for(int y=0; y<11; y++){					
					if(cpf[y] == cpf[y+1]){
					}

					else{
						//Validação do primeiro dígito
						soma = ((cpf[0]*10)+(cpf[1]*9)+(cpf[2]*8)+(cpf[3]*7)+(cpf[4]*6)+(cpf[5]*5)+(cpf[6]*4)+(cpf[7]*3)+(cpf[8]*2));
						resto = ((soma*10)%11);

						if( resto == 10){
							resto = 0;
						}

						//Validação do segundo dígito
						soma2 = ((cpf[0]*11)+(cpf[1]*10)+(cpf[2]*9)+(cpf[3]*8)+(cpf[4]*7)+(cpf[5]*6)+(cpf[6]*5)+(cpf[7]*4)+(cpf[8]*3)+(cpf[9]*2));
						resto2 = ((soma2*10)%11);
							
						if(resto == cpf[9] && resto2 == cpf[10]){
							Console.WriteLine("Cpf Válido!");
							condicao = 2;
							return true;
						}
						
						else{
							Console.WriteLine("Cpf Inválido!");
							condicao = 1;
						}
					}
				}
				condicao = 2;
			}

			catch(FormatException ){
				
				while(condicao == 1){
					Console.WriteLine("Cpf Inválido! ");
					Console.WriteLine("Cpf:\n-> ");
					ac = Console.ReadLine();
					
					if (autentificarCpf(ac) == true){
						condicao = 2;
					}
					else{
						condicao = 1;
					}
				}
				break;
			}
				
			catch(Exception){
				while (condicao == 1){
					Console.WriteLine("Cpf Inválido!");
					Console.Write("Cpf:\n-> ");
					ac = Console.ReadLine();

					if (autentificarCpf(ac) == true){
						condicao = 2;
					}
					else{
						condicao = 1;						
					}
				}
			}
		}	
		return true;
	}	
}

