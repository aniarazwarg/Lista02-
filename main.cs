using System;
/*Construa um algoritmo que, recebendo os valores de vendas do mês de determinado vendedor (VM) e o nome do mesmo (NOME), apresente o nome, quando o valor da venda estiver entre R$ 10000,00 e R$ 50000,00 (inclusive). */
class Program {
  public static void Main (string[] args) {
    string NOME;
    double VM;
    Console.Write ("Vendas do mês: R$");
    VM = double.Parse(Console.ReadLine());
      Console.Write ("Nome de Vendedor(a): ");
    NOME = Console.ReadLine();
    
    if (VM>=10000.00&&VM<=50000.00)
      Console.WriteLine("{0} Vendeu R$:{1}.",NOME,VM);
    
    else 
      Console.Write("{0}",NOME);
  }
}