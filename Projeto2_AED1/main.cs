using System;  
using System.IO;
using System.Text;

class MainClass {
	static Biblioteca biblio = new Biblioteca("Anteiku","40.110-050");

  public static void Main (string[] args){
		Console.WriteLine("---------------------------------------");
		Console.WriteLine("|        Bem vindo a Anteiku !        |");
		
		Console.WriteLine("---------------------------------------");
			
		int programa = 1;
		biblio.LerLivros();
		biblio.LerUsuarios();	
		biblio.LerLivroUsuario();
		biblio.lerReclamacoes();
		biblio.lerReclamacoesEnviadas();

		while (programa <= 4){
			programa = MainClass.Login();
			if (programa == 2){
				MainClass.interacoes();
			}
			if(programa == 3){
				MainClass.interacoesADM();
			}
			if(programa == 4){
				MainClass.interacoesOuvidoria();
			}
		}

		biblio.GravarLivros();
		biblio.GravarUsuarios();
		biblio.GravarLivrosUsuario();
		biblio.gravarReclamacoes();
		biblio.gravarReclamacoesEnviadas();
		Console.WriteLine("---------------------------------------");
		Console.WriteLine(" Obrigado por utilizar o nosso sistema. ");
		Console.WriteLine("---------------------------------------");
	}
		
	public static int Login(){

		bool condicao = false;

		while ( condicao == false){
			Console.WriteLine("");
			Console.WriteLine("                 Menu                  ");
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("| 1 - Login | 2 - Cadastro | 3 - Sair |");
			Console.Write("---------------------------------------\n-> ");

			string var1 = Console.ReadLine();	
			int login = MainClass.verificarNumero(var1);
	
			//usuario.Login();
			if(login == 1){
				Console.WriteLine("");
				Console.WriteLine("                Login                 ");
				Console.WriteLine("---------------------------------------");
				Console.Write("| Digite seu nome: ");
				string senha = Console.ReadLine();
				Console.Write("| Digite seu CPF: ");
				string cep = Console.ReadLine();
				Console.WriteLine("---------------------------------------");
				if(biblio.AutentificarUsuarioOuvidoria(senha,cep) == true){
					Console.WriteLine("-> Funcionario da ouvidoria autêntificado.");
					return 4;
				}

				if (biblio.AutentificarUsuarioADM(senha,cep) == true){
					Console.WriteLine("-> Administrador autêntificado.");
					return 3;
				}
				else{
					if (biblio.AutentificarUsuario(senha,cep) == true){
						Console.WriteLine("-> Usuário autêntificado.");
						condicao = true;
					}
					else{
						Console.WriteLine("-> Login Inválido ! ");
					}
				}
			}

			else{
				if (login == 2){
					//usuario.CadastrarUsuario();
					Console.WriteLine("");
					Console.WriteLine("               Cadastro         ");					
					Console.WriteLine("---------------------------------------");

					Console.Write("| Digite seu nome: ");
					string nome = Console.ReadLine();
					
					Console.Write("| Digite sua idade: ");
					string var2 = Console.ReadLine();
					int idade = MainClass.verificarNumero(var2);
					
					Console.Write("| Digite seu CPF: ");
					string var10 = Console.ReadLine();
					biblio.autentificarCpf(var10);
					string cpf = var10;
					//biblio.autentificarCpf(cpf);
					Console.WriteLine("---------------------------------------");
					Usuario user = new Usuario(nome,idade,cpf,false);
					


					
				
					biblio.RealizarCadastro(user);
					Console.WriteLine("-> Cadastro Realizado !");
					Console.WriteLine("");					
				}
				if (login == 3){
					return 5;
				}
				if(login < 1  || login >5){
					Console.WriteLine("-> Comando Inválido !");
				}
			}

		}
		return 2;
  }


	public static void interacoes(){
		Console.WriteLine(biblio.getUsuarioLogado().getNome());
		bool condicao = true;
	
		while ( condicao == true){
			Console.WriteLine("");
			Console.WriteLine("                 Opções               ");
			Console.Write("---------------------------------------");
			Console.Write("\n| 1 - Alugar Livro                    |\n| 2 - Buscar Livro                    |\n| 3 - Livros Alugados                 |\n| 4 - Devolver Livro                  |\n| 5 - Ver Descrição                   |\n| 6 - Indicar reclamação              |\n| 7 - Logoff                          |\n");
			Console.WriteLine("---------------------------------------");
			Console.Write("-> ");
			string var3 = Console.ReadLine();
			int decisao = MainClass.verificarNumero(var3);
			Console.WriteLine("");
			
			switch (decisao    ){
				case 1:
					Console.WriteLine("---------------------------------------");
					Console.WriteLine("Digite o nome do livro no qual deseja alugar: ");
					string nomeLivroAlugar= Console.ReadLine();
					Console.WriteLine("---------------------------------------");
					
					Console.WriteLine(biblio.getUsuarioLogado().AlugarLivro(nomeLivroAlugar,biblio));
					//biblio.SalvarPessoa(user);
				break;
				
				case 2:
					Console.WriteLine("---------------------------------------");
					Console.WriteLine("Livros Disponíveis para alugar:");
					biblio.MostrarLivros();
					Console.WriteLine("---------------------------------------");
				break;

				case 3:
					Console.WriteLine("---------------------------------------");
					Console.WriteLine("Os livros que voçê possui são :");
					
					biblio.getUsuarioLogado().MostrarLivrosUsuario();
					
					Console.WriteLine("---------------------------------------");
				break;

				case 4:
					Console.WriteLine("---------------------------------------");
					Console.WriteLine("Qual o nome no livro que deseja devolver: ");
				
					string livroDevolver = Console.ReadLine();
					Console.WriteLine(biblio.getUsuarioLogado().DevolverLivro(livroDevolver,biblio));
					
					Console.WriteLine("---------------------------------------");
				break;

				case 5:
					Console.WriteLine("---------------------------------------");
					Console.WriteLine("Informe o nome do Livro: ");
					string descr = Console.ReadLine();
					for(int i = 0;i < biblio.getLivros().Length;i++ ){
						if (biblio.getLivros()[i] != null){
							if (biblio.getLivros()[i].getNome() == descr){
								biblio.getLivros()[i].MostrarDescricao(descr,biblio);
							}
						}	
					}
					Console.WriteLine("---------------------------------------");
				break;

				case 6:
				Console.WriteLine("-> Diga seu feedback sobre a biblioteca.");
				string reclama = Console.ReadLine();
				biblio.getUsuarioLogado().indicarReclamacao(reclama,biblio);

				break;
				case 7:
					biblio.getUsuarioLogado().setLogado(false);
					condicao = false;				
				
				break;
				
			}
		}
	}
	public static void interacoesADM(){

		bool condicao = true;

		while(condicao == true){
			Console.WriteLine("");
			Console.WriteLine("                Opções                 ");
			Console.Write("---------------------------------------");
			Console.Write("\n| 1 - Adicionar novo administrador    |\n| 2 - Adicionar Livro a biblioteca    |\n| 3 - Alterar faixa etaria de um Livro| \n| 4 - Mostrar Livros da Biblioteca    |\n| 5 - Mostrar Descrição de um Livro   |\n| 6 - Criar usuário da ouvidoria      |\n| 7 - Ver Reclamações                 |\n| 8 - Processar Reclamação            |\n| 9 - Realizar Loggof                 |\n");
			Console.WriteLine("---------------------------------------");
			Console.Write("-> ");
			string var4 = Console.ReadLine();
			int decisao = MainClass.verificarNumero(var4);
			
			switch(decisao){
				case 1:
					Console.WriteLine("");
					Console.WriteLine("               Cadastro         ");		
					Console.WriteLine("---------------------------------------");
					Console.Write("| Digite o nome do funcionário: ");
					string nome = Console.ReadLine();
					
					Console.Write("| Digite a idade do funcionário: ");
					string var5 = Console.ReadLine();
					int idade = MainClass.verificarNumero(var5);
					
					Console.Write("| Digite o CPF do funcionário: ");
					string var11 = Console.ReadLine();
					biblio.autentificarCpf(var11);
					string cpf = var11;
					Console.WriteLine("---------------------------------------");
					Administrador user = new Administrador(nome,idade,cpf);
					//biblio.setUsuario(user);
					biblio.RealizarCadastro(user);
					Console.WriteLine("");
				break;

				case 2:
					Console.WriteLine("");
					Console.WriteLine("           Adicionar o livro           ");
					Console.WriteLine("---------------------------------------");
					Console.Write("| Digite o nome do livro: ");
					string nomeLivro = Console.ReadLine();
					Console.WriteLine("---------------------------------------");
					Console.Write("| Digite o gênero do livro: ");
					string genero = Console.ReadLine();
					Console.WriteLine("---------------------------------------");
					Console.Write("| Digite o autor do livro: ");
					string autor = Console.ReadLine();
					Console.WriteLine("---------------------------------------");
					Console.Write("| Digite a faixa etária do livro: ");
					string var6 = Console.ReadLine();
					int faixa = MainClass.verificarNumero(var6);
					Console.WriteLine("---------------------------------------");
					Livro livro = new Livro(nomeLivro,genero,autor,faixa);
					biblio.AdicionarLivro(livro);
				break;

				case 3:
					Console.WriteLine("");
					Console.WriteLine("         Alterar Faixa Etária          ");
					Console.WriteLine("---------------------------------------");
					Console.WriteLine("Digite o nome do livro que deseja alterar: ");
					Console.Write("-> ");
					string livroNf = Console.ReadLine();
					for(int y = 0;y < biblio.getLivros().Length;y++ ){
						if (biblio.getLivros()[y] != null){
							if (biblio.getLivros()[y].getNome() == livroNf){
								Console.WriteLine("");
								Console.WriteLine("Qual a nova faixa etário desejada: ");
								Console.Write("-> ");
								string var7 = Console.ReadLine();
								int novaFaixa = MainClass.verificarNumero(var7);
								biblio.getLivros()[y].AlterarFaixaEtaria(novaFaixa);
							}
						}	
					}
					Console.WriteLine("---------------------------------------");
				break;

				case 4:
					Console.WriteLine("");
					Console.WriteLine("       Prateleira da Biblioteca        ");
					Console.WriteLine("---------------------------------------");
					Console.WriteLine("Livros Disponíveis para alugar:");
					Console.WriteLine("---------------------------------------");
					biblio.MostrarLivros();
					Console.WriteLine("---------------------------------------");
				break;

				case 5:
					Console.WriteLine("");
					Console.WriteLine("               Descrição               ");
					Console.WriteLine("---------------------------------------");
					Console.WriteLine("| Informe o nome do Livro: ");
					Console.Write("-> ");
					string descr = Console.ReadLine();

					for(int i = 0;i < biblio.getLivros().Length;i++ ){
						if (biblio.getLivros()[i] != null){
							if (biblio.getLivros()[i].getNome() == descr){
								biblio.getLivros()[i].MostrarDescricao(descr,biblio);
							}
						}	
					}
					Console.WriteLine("---------------------------------------");
					break;
					
					case 6:
					Console.Write("| Digite o nome do funcionário: ");
					string name = Console.ReadLine();
					Console.Write("| Digite a idade do funcionário: ");
					string var9 = Console.ReadLine();
					int age = MainClass.verificarNumero(var9);
					Console.Write("| Digite a cpf do funcionário: ");
					string var12 = Console.ReadLine();
					biblio.autentificarCpf(var12);
					string cpfcpf = var12;
					Ouvidoria pessoa = new Ouvidoria(name,age,cpfcpf);
					biblio.RealizarCadastro(pessoa);
					break;

					case 7:
					Console.WriteLine(biblio.verReclamacoesEnviadas());
						
					break;
					case 8:
					Console.WriteLine(biblio.getADMLogado().ProcessarReclamacao(biblio));

					break;
					case 9:
					Console.WriteLine("-> Logoff Realizado. ");
						Console.WriteLine("");
						biblio.getADMLogado().setLogado(false);
						condicao = false;
					break;

				}					
			}
		}

	public static void interacoesOuvidoria(){
		bool condicao = true;


		while(condicao == true){
			Console.WriteLine("");
			Console.WriteLine("                Opções                 ");
			Console.Write("---------------------------------------");
			Console.Write("\n| 1 - Ver Reclamações                 |\n| 2 - Avaliar Reclamação               |\n| 3 - Loggof             |\n");
			Console.WriteLine("---------------------------------------");
			Console.Write("-> ");
			string var8 = Console.ReadLine();
			int decisao = MainClass.verificarNumero(var8);
			switch(decisao){
				case 1:
				Console.WriteLine(biblio.verReclamacoes());
				break;
				case 2:
				Console.WriteLine(biblio.getOuvidoriaLogado().avaliarReclamacao(biblio));
				
				
				break;
				case 3:
				Console.WriteLine("-> Usuário da Ouvidoria deslogado.");
				biblio.getOuvidoriaLogado().setLogado(false);
				condicao = false;
				break;

			}
		
		}
	}
	
	public static int verificarNumero(string idad){
		int saida = 0; 	
		bool condicao = true;		
		/// TRY ///
		try{			
			int variavel3 = Convert.ToInt32(idad);				
			saida = variavel3;
			while(condicao == true){
				if(saida <1){
					Console.Write("\n Número Inválido!\n Digite Novamente:\n->");
					variavel3 = Convert.ToInt32(Console.ReadLine());
					saida = variavel3;
					condicao = true;
				}
				else{
					condicao = false;
				}
			}
			return saida;
		}
		
		/// CATCH 1 ///
		catch(FormatException){
			int variavel3 =0;				
			while(condicao == true){
				try{					
					Console.Write("\n Caractere ou Número Inválido!\n Digite um Número:\n-> ");
					variavel3 = Convert.ToInt32(Console.ReadLine());
					saida = variavel3;
					condicao = false;
					if(saida < 1){
						condicao = true;
					}
					else{
						condicao = false;
					}
				}
				catch(FormatException){
					condicao = true;
				}							
			saida = variavel3;
			}			
		}
		return saida;
	}
	 
}
