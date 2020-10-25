using System;
using System.Collections.Generic;

class Estoque{
  int Pedido_;
  double total;
  double V;
  int qtd = 0;
  List<int> Carinho_Quantidade = new List<int>();

  List<string> Pao_ = new List<string>();
  List<int> QtdPao = new List<int>{20,20,20,20,20};
  List<string> Leite_ = new List<string>();
  List<int> QtdLeite = new List<int>();
  List<string> Biscoito_ = new List<string>();
  List<int> QtdBiscoito = new List<int>();
  List<string> Bolo_ = new List<string>();
  List<int> QtdBolo= new List<int>();
  List<string> Variados_ = new List<string>();
  List<int> QtdVariados= new List<int>();

  public void Pao(){

  
    Console.WriteLine("Tipos de Pães: ");
    Console.WriteLine("1: Pão Francês- R$0,50 unidade");
    Console.WriteLine("2: Pão Doce - R$0,50 unidade");
    Console.WriteLine("3: Pão Especial - R$0,70 unidade");
    Console.WriteLine("4: Pão de Queijo - R$2,50 unidade");
    Console.WriteLine("5: Pão Integral - R$1,00 unidade");
    Console.WriteLine("Caso deseje voltar digite 0");
    Pedido_ = int.Parse(Console.ReadLine());
      if(Pedido_ == 1){
        int qtd;
        Console.WriteLine("Escolha a quantidade desejada");
         qtd = int.Parse(Console.ReadLine());
         QtdPao[Pedido_]-= qtd;
         //Carinho_Quantidade.Add(qtd);
         Console.WriteLine("TESTE {0}", QtdPao[Pedido_]);
         
         
      }
    
  } 
  public void Leite(){
    Console.WriteLine("Tipos de Leites");
    Console.WriteLine("1:Leite Desnatado R$4,50 unidade");
    Console.WriteLine("2:Leite Semi-Desnatado R$5 unidade ");
    Console.WriteLine("3:Leite Integral R$6 unidade");
    Console.WriteLine("Caso deseje voltar digite 0");
    Pedido_ = int.Parse(Console.ReadLine());
    
  }

  public void Biscoito(){
    Console.WriteLine("Tipos de Biscoito");
    Console.WriteLine("1:Biscoito De Sal");
    Console.WriteLine("2:Biscoito Trakinas");
    Console.WriteLine("3:Biscoito De Limão");
    Console.WriteLine("4:Biscoto De Morango");

  }

  public void Bolo(){
    Console.WriteLine("1:Bolo De Chocolate");
    Console.WriteLine("2:Bolo Amanteigado");
    Console.WriteLine("3:Bolo Chiffon");
    Console.WriteLine("4:Bolo Anjo");
    Console.WriteLine("5:Bolo Sem Farinha"); 
  }

  public void Variados(){
    Console.WriteLine("1:Coca-Cola");
    Console.WriteLine("2:Coxinha");
    Console.WriteLine("3:Cheetos");
    Console.WriteLine("4:Doritos");
    Console.WriteLine("5:Doce Fini");
  }
}
