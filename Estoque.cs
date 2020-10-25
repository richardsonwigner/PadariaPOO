using System;

class Estoque{
  int Pedido_;
  double total;
  double V;
  int Voltar;
  int Pao_Frances = 20,Pao_Doce = 20,Pao_Especial = 20,Pao_de_Queijo = 20,Pao_Integral = 20;
  int Leite_Desnatado = 20,Leite_Semi_Desnatado,Leite_Integral = 20
  int QtdPaoF,QtdPaoD,QtdPaoE,QtdPaoQ,QtdPaoI;
  int QtdLeiteI, QtdLeiteD, QtdLeiteSd;
  
  public void Pao(){
    Console.WriteLine("Tipos de Pães: ");
    Console.WriteLine("1: Pão Francês- R$0,50 unidade");
    Console.WriteLine("2: Pão Doce - R$0,50 unidade");
    Console.WriteLine("3: Pão Especial - R$0,70 unidade");
    Console.WriteLine("4: Pão de Queijo - R$2,50 unidade");
    Console.WriteLine("5: Pão Integral - R$1,00 unidade");
    Console.WriteLine("Caso deseje voltar digite 0");
    Pedido_ = Console.ReadLine();
    if (Pedido == 1){
      Console.WriteLine("A quantidade disponivel é: {0}", Pao_Frances);
      Console.WriteLine("Digite a quantidade que deseja");
      QtdPaoF = Console.ReadLine();
      V= QtdPaoF * 0,50;
      Console.WriteLine("Valor dessa compra: {0}", V);
    }else{
      if (Pedido == 2){
      Console.WriteLine("A quantidade disponivel é: {0}", Pao_Doce);
      Console.WriteLine("Digite a quantidade que deseja");
      QtdPaoD = Console.ReadLine();
      V= QtdPaoF * 0,50;
      Console.WriteLine("Valor dessa compra: {0}", V);
    }
  }
  
  public void Leite(){
    Console.WriteLine("Tipos de Leites");
    Console.WriteLine("1:Leite Desnatado R$4,50 unidade");
    Console.WriteLine("2:Leite Semi-Desnatado R$5 unidade ");
    Console.WriteLine("3:Leite Integral R$6 unidade");
    Console.WriteLine("Caso deseje voltar digite 0");
    Pedido_ = Console.ReadLine();
      if(Pedido_ == 1){
        Console.WriteLine("A quantidade disponivel é {0}",Leite_Desnatado);
        Console.WriteLine("Digite a quantidade que deseja");
        QtdLeiteD = Console.ReadLine();
        V = QtdLeiteD * 4.50;
        Console.WriteLine("O valor dessa compra é {0}",V);
        
      }
       if(Pedido_ == 2){
        Console.WriteLine("A quantidade disponivel é {0}",Leite_Desnatado);
        Console.WriteLine("Digite a quantidade que deseja");
        QtdLeiteD = Console.ReadLine();
        V = QtdLeiteD * 5;
        Console.WriteLine("O valor dessa compra é {0}",V);
        
      }
       if(Pedido_ == 3){
        Console.WriteLine("A quantidade disponivel é {0}",Leite_Desnatado);
        Console.WriteLine("Digite a quantidade que deseja");
        QtdLeiteD = Console.ReadLine();
        V = QtdLeiteD * 5.50;
        Console.WriteLine("O valor dessa compra é {0}",V);
      }
  }

  public void Biscoito(){}

  public void Bolo(){}

  public void Variados(){}
}
