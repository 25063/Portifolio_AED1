using System;

class MainClass {
  public static void Main (string[] args) {

		int titulacao;
		string matricula;
		double hora_semanal = 0.0;
		double hora_mensal = 0.0;

		double salario_bruto = 0.0;
		double planejamento = 0.0; //15% de planejamento
		double taxa_contribuicao = 0.0;
		double taxa_ir = 0.0;

		double salario_liquido = 0.0;		
		double imposto_renda = 0.0;
		double desconto_ir = 0.0;
		double inss = 0.0;
		double desconto_inss = 0.0;

		double valor_liquido = 0.0;
		double valor_bruto = 0.0;
		double valor_horaE = 15.00;
		double valor_horaM = 20.00;
		double valor_horaD = 30.00;
		Console.Clear();

		Console.WriteLine("===============================");
		Console.WriteLine("| Informe sua matrícula:      |"); 
		Console.WriteLine("===============================");
		Console.Write("-> ");
		matricula = Console.ReadLine();

		Console.WriteLine("");
		Console.WriteLine("===============================");
		Console.WriteLine("| Horas semanais trabalhadas: |");
		Console.WriteLine("===============================");
		Console.Write("-> ");
		hora_semanal = double.Parse(Console.ReadLine());

		Console.WriteLine("");
		Console.WriteLine("===============================");
		Console.WriteLine("| Qual a sua titulação:       |");
		Console.WriteLine("|-----------------------------|");
		Console.WriteLine("| 1 - Especialista            |");
		Console.WriteLine("| 2 - Mestre                  |");
		Console.WriteLine("| 3 - Doutor                  |");
		Console.WriteLine("===============================");
		Console.Write("-> ");
		titulacao = int.Parse(Console.ReadLine());
		
		
		
		if(titulacao == 1){
			hora_mensal = (hora_semanal*4);
			valor_bruto = (valor_horaE*hora_mensal);
			planejamento = (valor_bruto*0.15); 
			salario_bruto = (valor_bruto+planejamento);
			
			//Desconto INSS
			if(salario_bruto >= 151.00 && salario_bruto <= 256.00){
				taxa_contribuicao = (valor_bruto*0.08);
				valor_liquido = (valor_bruto-taxa_contribuicao);

				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}
			}
			//Desconto INSS
			else if(salario_bruto >= 256.01 && salario_bruto <= 510.00){
				taxa_contribuicao = (valor_bruto*0.09);
				valor_liquido = (valor_bruto-taxa_contribuicao);
				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}
			}
			//Desconto INSS
			else if(salario_bruto >= 510.01 && salario_bruto <= 1200.00){
				taxa_contribuicao = (valor_bruto*0.1);
				valor_liquido = (valor_bruto-taxa_contribuicao);
				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}
			}
			//Desconto INSS
			else if(salario_bruto > 1200.00){
				taxa_contribuicao = (valor_bruto*0.11);
				valor_liquido = (valor_bruto-taxa_contribuicao);
				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}
			}
			
			Console.WriteLine("");
			Console.WriteLine("| Adicional de Planejamento: "+planejamento);
			Console.WriteLine("| Salário Bruto: "+salario_bruto);
			Console.WriteLine("| Desconto INSS: "+taxa_contribuicao);
			Console.WriteLine("| Desconto IR: "+taxa_ir);
			Console.WriteLine("| Salário Líquido: "+salario_liquido);
			
		}

		else if(titulacao == 2){
			hora_mensal = (hora_semanal*4);
			valor_bruto = (valor_horaM*hora_mensal);
			planejamento = (valor_bruto*0.2); 
			salario_bruto = (valor_bruto+planejamento);

			//Desconto INSS
			if(salario_bruto >= 151.00 && salario_bruto <= 256.00){
				taxa_contribuicao = (valor_bruto*0.08);
				valor_liquido = (valor_bruto-taxa_contribuicao);

				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}
			}
			//Desconto INSS
			else if(salario_bruto >= 256.01 && salario_bruto <= 510.00){
				taxa_contribuicao = (valor_bruto*0.09);
				valor_liquido = (valor_bruto-taxa_contribuicao);
				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}
			}
			//Desconto INSS
			else if(salario_bruto >= 510.01 && salario_bruto <= 1200.00){
				taxa_contribuicao = (valor_bruto*0.1);
				valor_liquido = (valor_bruto-taxa_contribuicao);
				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}
			}
			//Desconto INSS
			else if(salario_bruto > 1200.00){
				taxa_contribuicao = (valor_bruto*0.11);
				valor_liquido = (valor_bruto-taxa_contribuicao);
				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}				
			}
						
			Console.WriteLine("");
			Console.WriteLine("| Adicional de Planejamento: "+planejamento);
			Console.WriteLine("| Salário Bruto: "+salario_bruto);
			Console.WriteLine("| Desconto INSS: "+taxa_contribuicao);
			Console.WriteLine("| Desconto IR: "+taxa_ir);
			Console.WriteLine("| Salário Líquido: "+salario_liquido);
			
		}

		else if(titulacao == 3){
			hora_mensal = (hora_semanal*4);
			valor_bruto = (valor_horaD*hora_mensal);
			planejamento = (valor_bruto*0.3); 
			salario_bruto = (valor_bruto+planejamento);

			//Desconto INSS
			if(salario_bruto >= 151.00 && salario_bruto <= 256.00){
				taxa_contribuicao = (valor_bruto*0.08);
				valor_liquido = (valor_bruto-taxa_contribuicao);

				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}
			}
			//Desconto INSS
			else if(salario_bruto >= 256.01 && salario_bruto <= 510.00){
				taxa_contribuicao = (valor_bruto*0.09);
				valor_liquido = (valor_bruto-taxa_contribuicao);
				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}
			}
			//Desconto INSS
			else if(salario_bruto >= 510.01 && salario_bruto <= 1200.00){
				taxa_contribuicao = (valor_bruto*0.1);
				valor_liquido = (valor_bruto-taxa_contribuicao);
				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}				
			}
			//Desconto INSS
			else if(salario_bruto > 1200.00){
				taxa_contribuicao = (valor_bruto*0.11);
				valor_liquido = (valor_bruto-taxa_contribuicao);
				//Desconto IR
				if(valor_liquido <= 800.00){
					taxa_ir = 0.0;
					salario_liquido = valor_liquido;
				}
				else if(valor_liquido >= 801.01 && valor_liquido <= 1200.00){
					taxa_ir = (valor_liquido*0.1);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 1200.01 && valor_liquido <= 2400.00){
					taxa_ir = (valor_liquido*0.15);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 2400.01 && valor_liquido <= 3200.00){
					taxa_ir = (valor_liquido*0.2);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido >= 3200.01 && valor_liquido <= 5750.00){
					taxa_ir = (valor_liquido*0.25);
					salario_liquido = (valor_liquido-taxa_ir);
				}
				else if(valor_liquido > 5750.00){
					taxa_ir = (valor_liquido*0.275);
					salario_liquido = (valor_liquido-taxa_ir);
				}
			}						
			Console.WriteLine("");
			Console.WriteLine("| Adicional de Planejamento: "+planejamento);
			Console.WriteLine("| Salário Bruto: "+salario_bruto);
			Console.WriteLine("| Desconto INSS: "+taxa_contribuicao);
			Console.WriteLine("| Desconto IR: "+taxa_ir);
			Console.WriteLine("| Salário Líquido: "+salario_liquido);
			
		}
		else{
			Console.WriteLine("Inválido!");
			
		}
		
  }
}
