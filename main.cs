using System;
using System.Collections.Generic;

class MainClass{
  static int aux1;
  static int aux2;
  static int Pedido;
  static string x1;
  static string x2;
  static Loja loja = new Loja();
  static Carrinho carrinho = new Carrinho();
  public static void Main (string[] args) {
  double v = 1000;
  string c = "123"; 
  Cadastro Cadastro1 = new Cadastro("TESTE","Teste",0);
  Pagamento Pagamento1 = new Pagamento(v,c,1000);
  IniciarVariavel();
    string n=""; 
    string x = "n";
    while (x =="n"){
      Console.WriteLine("Digite seu nome");
      n = Console.ReadLine();
      Console.WriteLine("Confirma seu nome?s/n");
      Console.WriteLine(n);
      x = Console.ReadLine();
    }
    string e ="";
    string y = "n";
    while (y =="n"){
      Console.WriteLine("Digite seu endereço");
      e = Console.ReadLine();
      Console.WriteLine("Confirma seu endereço?s/n");
      Console.WriteLine(e);
      y = Console.ReadLine();
  }
    double s = 0; 
    string z = "n";
    while (z =="n"){
      Console.WriteLine("Digite sua senha");
      s = double.Parse(Console.ReadLine());
      Console.WriteLine("Confirma sua senha?s/n");
      Console.WriteLine(s);
      z = Console.ReadLine();
    }
    pedido();
    Cadastro1 = new Cadastro(n,e,s);

  }
    public static void pedido(){
      Pedido = 0;
      x1 = "s";
      while(x1 == "s")
      Console.WriteLine("Escolha o tipo de produto");
      Console.WriteLine("1:Pão");
      Console.WriteLine("2:Leite");
      Console.WriteLine("3:Biscoito");
      Console.WriteLine("4:Bolo");
      Console.WriteLine("5:Bebidas");
       if(carrinho.getCarrinho().Count != 0 && x1 == "s"){
       Console.WriteLine("Realizar Pagamento");
       Console.WriteLine("Cancelar Pagamento");
       }
      Pedido = int.Parse(Console.ReadLine());
       if(Pedido == 1){
        aux1 =0; 
        aux2 =5;
        ClientePedido();
       }
        else if(Pedido == 2){
        aux1 =5;
        aux2 =8;
        ClientePedido();
        }
        else if (Pedido == 3){
        aux1 =8;
        aux2 =13;
        ClientePedido();
        }
        else if (Pedido == 4){
        aux1 =13;
        aux2 =18;
        ClientePedido();
        }
        else if(Pedido == 5){
        aux1 =18;
        aux2 =26;
        ClientePedido();
        }
       
        
    }
    public static void IniciarVariavel(){
       
      loja.produtos.Add(new Produto(0, "Pão Francês", 20,0.5f));
      loja.produtos.Add(new Produto(1, "Pão Doce", 20, 0.5f));
      loja.produtos.Add(new Produto(2, "Pão Especial", 20, 0.7f));
      loja.produtos.Add(new Produto(3, "Pão de Queijo", 20, 2.5f));
      loja.produtos.Add(new Produto(4, "Pão Integral", 20, 1.00f));
      loja.produtos.Add(new Produto(5, "Leite Integral", 20, 3.5f));
      loja.produtos.Add(new Produto(6, "Leite Desnatado", 20, 3.00f));
      loja.produtos.Add(new Produto(7, "Leite Semi-Desnatado", 20, 3.25f)); 
      loja.produtos.Add(new Produto(8, "Biscoito Recheado", 20, 2.5f)); 
      loja.produtos.Add(new Produto(9, "Biscoito Polvilho", 20, 2.99f));
      loja.produtos.Add(new Produto(10, "Biscoito Água e Sal", 20, 2.00f));
      loja.produtos.Add(new Produto(11, "Biscoito (Wafer)", 20, 2.99f));
      loja.produtos.Add(new Produto(12, "Biscoito (Cookie)", 20, 3.5f));
      loja.produtos.Add(new Produto(13, "Bolo de Fubá ", 20, 5.99f));
      loja.produtos.Add(new Produto(14, "Bolo de Chocolate", 20, 5.99f));
      loja.produtos.Add(new Produto(15, "Bolo de Laranja", 20, 5.99f));
      loja.produtos.Add(new Produto(16, "Bolo de Cenoura", 20, 6.5f));
      loja.produtos.Add(new Produto(17, "Bolo de Festa", 20, 25.99f));
      loja.produtos.Add(new Produto(18, "Refrigerante 2L", 20, 7.50f));
      loja.produtos.Add(new Produto(19, "Refrigerante 600mL", 20, 5.00f));
      loja.produtos.Add(new Produto(20, "Refrigerante Lata", 20, 3.5f));
      loja.produtos.Add(new Produto(21, "Água mineral", 20, 2.5f));
      loja.produtos.Add(new Produto(22, "Café", 20, 1.00f));
      loja.produtos.Add(new Produto(23, "Suco", 20, 3.50f));
      loja.produtos.Add(new Produto(24, "Energético", 20, 8.99f));
      loja.produtos.Add(new Produto(25, "Café com Leite", 20, 2.5f));
  }
  public static void ClientePedido(){
        for(int i=aux1;i>=aux1 && i<aux2;i++)
          Console.WriteLine("{0}:{1},{2}R$",loja.produtos[i].getCodigo(),loja.produtos[i].getNome(),loja.produtos[i].getValor());
       
        Console.WriteLine("Digite o codigo");
        Pedido = int.Parse(Console.ReadLine());
          foreach(Produto produtos in loja.produtos)
            if(produtos.getCodigo() == Pedido){
            carrinho.getCarrinho().Add(produtos);
            foreach(Produto i in carrinho.getCarrinho())
              Console.WriteLine("{0},{1}", i.getNome(),i.getValor());
            }
        Console.WriteLine("Deseja Pedir novamente?");
        Console.WriteLine("Digite s ou n");
        x1 = Console.ReadLine();
  }
  
}


