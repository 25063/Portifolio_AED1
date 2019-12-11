using System;

class MainClass {
  public static void Main (string[] args) {

		int num = 0;
    Console.Write("-> Tabuada\nDigite o número:");
		num = Convert.ToInt32(Console.ReadLine());

		while(num>=0){
				Console.WriteLine("-> Adição");
				Console.WriteLine(" "+num+" + 1 = "+(num+1)+"\n"+" "+num+" + 2 = "+(num+2)+"\n"+" "+num+" + 3 = "+(num+3)+"\n"+" "+num+" + 4 = "+(num+4)+"\n"+" "+num+" + 5 = "+(num+5)+"\n"+" "+num+" + 6 = "+(num+6)+"\n"+" "+num+" + 7 = "+(num+7)+"\n"+" "+num+" + 8 = "+(num+8)+"\n"+" "+num+" + 9 = "+(num+9)+"\n"+" "+num+" + 10 = "+(num+10)+"\n");

				Console.WriteLine("-> Subtração");
				Console.WriteLine(" 1 - "+num+" = "+(1-num)+"\n"+" 2 - "+num+" = "+(2-num)+"\n"+" 3 - "+num+" = "+(3-num)+"\n"+" 4 - "+num+" = "+(4-num)+"\n"+" 5 - "+num+" = "+(5-num)+"\n"+" 6 - "+num+" = "+(6-num)+"\n"+" 7 - "+num+" = "+(7-num)+"\n"+" 8 - "+num+" = "+(8-num)+"\n"+" 9 - "+num+" = "+(9-num)+"\n"+" 10 - "+num+" = "+(10-num)+"\n");

				Console.WriteLine("-> Multiplicação");
				Console.WriteLine(" "+num+" x 1 = "+(num*1)+"\n"+" "+num+" x 2 = "+(num*2)+"\n"+" "+num+" x 3 = "+(num*3)+"\n"+" "+num+" x 4 = "+(num*4)+"\n"+" "+num+" x 5 = "+(num*5)+"\n"+" "+num+" x 6 = "+(num*6)+"\n"+" "+num+" x 7 = "+(num*7)+"\n"+" "+num+" x 8 = "+(num*8)+"\n"+" "+num+" x 9 = "+(num*9)+"\n"+" "+num+" x 10 = "+(num*10)+"\n");	
				Console.Write("-> Digite o número:");
				num = Convert.ToInt32(Console.ReadLine());

		}
		
		Console.WriteLine("Número negativo!");
	}
}