using System;
using System.Collections.Generic;


class MainClass{
  static int Pedido;
  static string x1;
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
    while (x =="n")
    {
      Console.WriteLine("Digite seu nome");
      n = Console.ReadLine();
      Console.WriteLine("Confirma seu nome?s/n");
      Console.WriteLine(n);
      x = Console.ReadLine();
    }
    string e ="";
    string y = "n";
    while (y =="n")
    {
      Console.WriteLine("Digite seu endereço");
      e = Console.ReadLine();
      Console.WriteLine("Confirma seu endereço?s/n");
      Console.WriteLine(e);
      y = Console.ReadLine();
    }
    double s = 0; 
    string z = "n";
    while (z =="n")
    {
      try
      {
        Console.WriteLine("Digite sua senha");
        s = double.Parse(Console.ReadLine());
        Console.WriteLine("Confirma sua senha?s/n");
        Console.WriteLine(s);
        z = Console.ReadLine();
      }
      catch(Exception) 
      {
        Console.WriteLine("Você digitou uma senha inválida");  
      }
    }
    pedido();
    Cadastro1 = new Cadastro(n,e,s);
  }
    public static void pedido(){
      Pedido = 0;
      x1 = "s";
      while(x1 == "s"){
        Console.WriteLine("Escolha o tipo de produto");
        Console.WriteLine("1:Pão");
        Console.WriteLine("2:Leite");
        Console.WriteLine("3:Biscoito");
        Console.WriteLine("4:Bolo");
        Console.WriteLine("5:Bebidas");
          if(carrinho.getItemCarrinho().Count != 0 && x1 == "s"){
        Console.WriteLine("6:Realizar Pagamento");
        Console.WriteLine("7:Cancelar Pagamento");
        Console.WriteLine("8:Verificar Carrinho");
       }
        Pedido = int.Parse(Console.ReadLine());
        if(Pedido == 1){
          ClientePedido("Pao");
        }
        else if(Pedido == 2){
          ClientePedido("Leite");
        }
        else if(Pedido == 3){
        ClientePedido("Biscoito");
        }
        else if(Pedido == 4){
          ClientePedido("Bolo");
        }
        else if(Pedido == 5){
          ClientePedido("Bebida");
        }
        else if(Pedido == 8)
        {
          VerificarCarrinho();
        }
    }
    }
    public static void IniciarVariavel(){
      loja.produtos.Add(new Produto(0, "Pão Francês", 20,0.5f,"Pao"));
      loja.produtos.Add(new Produto(1, "Pão Doce", 20, 0.5f,"Pao"));
      loja.produtos.Add(new Produto(2, "Pão Especial", 20, 0.7f,"Pao"));
      loja.produtos.Add(new Produto(3, "Pão de Queijo", 20, 2.5f,"Pao"));
      loja.produtos.Add(new Produto(4, "Pão Integral", 20, 1.00f,"Pao"));
      loja.produtos.Add(new Produto(5, "Leite Integral", 20, 3.5f,"Leite"));
      loja.produtos.Add(new Produto(6, "Leite Desnatado", 20, 3.00f,"Leite"));
      loja.produtos.Add(new Produto(7, "Leite Semi-Desnatado", 20, 3.25f,"Leite")); 
      loja.produtos.Add(new Produto(8, "Biscoito Recheado", 20, 2.5f,"Biscoito")); 
      loja.produtos.Add(new Produto(9, "Biscoito Polvilho", 20, 2.99f,"Biscoito"));
      loja.produtos.Add(new Produto(10, "Biscoito Água e Sal", 20, 2.00f,"Biscoito"));
      loja.produtos.Add(new Produto(11, "Biscoito (Wafer)", 20, 2.99f,"Biscoito"));
      loja.produtos.Add(new Produto(12, "Biscoito (Cookie)", 20, 3.5f,"Biscoito"));
      loja.produtos.Add(new Produto(13, "Bolo de Fubá ", 20, 5.99f,"Bolo"));
      loja.produtos.Add(new Produto(14, "Bolo de Chocolate", 20, 5.99f,"Bolo"));
      loja.produtos.Add(new Produto(15, "Bolo de Laranja", 20, 5.99f,"Bolo"));
      loja.produtos.Add(new Produto(16, "Bolo de Cenoura", 20, 6.5f,"Bolo"));
      loja.produtos.Add(new Produto(17, "Bolo de Festa", 20, 25.99f,"Bolo"));
      loja.produtos.Add(new Produto(18, "Refrigerante 2L", 20, 7.50f,"Bebida"));
      loja.produtos.Add(new Produto(19, "Refrigerante 600mL", 20, 5.00f,"Bebida"));
      loja.produtos.Add(new Produto(20, "Refrigerante Lata", 20, 3.5f,"Bebida"));
      loja.produtos.Add(new Produto(21, "Água mineral", 20, 2.5f,"Bebida"));
      loja.produtos.Add(new Produto(22, "Café", 20, 1.00f,"Bebida"));
      loja.produtos.Add(new Produto(23, "Suco", 20, 3.50f,"Bebida"));
      loja.produtos.Add(new Produto(24, "Energético", 20, 8.99f,"Bebida"));
      loja.produtos.Add(new Produto(25, "Café com Leite", 20, 2.5f,"Bebida"));
  }
  public static void ClientePedido(string categoria){
    int x = 0;
    int QTD;
    int CodigoPedido = 0;
    double sum = 0;
    Pedido = -1;
    Produto ProdutoEscolhido = null;
    foreach(Produto produtos in loja.produtos)
    {
      if(produtos.getCategoria() == categoria)
      {
      Console.WriteLine("Código:{0} Produto:{1} {2:C2}R$,Quantidade{3}",produtos.getCodigo(),produtos.getNome(),produtos.getValor(),produtos.getQtd());
      }     
    }
    while(x == 0)
      try{
        Console.WriteLine("Digite o codigo");
        CodigoPedido = int.Parse(Console.ReadLine());
        x = 1;
        }
        catch(Exception){
          Console.WriteLine("Você não digitou um código");
        }
    foreach(Produto produtos in loja.produtos)
    {
      if(produtos.getCategoria() == categoria)
      {
        if(produtos.getCodigo() == CodigoPedido)
        {
          Pedido = CodigoPedido;
          ProdutoEscolhido = produtos;
        }
      }
    }
    if(Pedido != -1 )
    {
    Console.WriteLine("Digite a Quantidade");
    QTD = int.Parse(Console.ReadLine());
      if(QTD > 0 && QTD <= ProdutoEscolhido.getQtd())
      {
        foreach(Produto produtos in loja.produtos)
          if(produtos.getCodigo() == Pedido)
          {
            carrinho.getItemCarrinho().Add(new ItemCarrinho(produtos,QTD));
            produtos.DiminuirEstoque(QTD);
          }
          foreach(ItemCarrinho i in carrinho.getItemCarrinho())
          {
            Console.WriteLine("{0},{1}R$", i.produto.getNome(),i.produto.getValor()*i.qtd); 
          }
          foreach(ItemCarrinho i in carrinho.getItemCarrinho())
          {
            sum += i.TotalValor();
            Console.WriteLine("Total da compra {0}R$",sum);
          }  
      }
      else
      {
        Console.WriteLine("Você digitou um valor inválido ");
      }
    }
    else
      Console.WriteLine("Você digitou um codigo inválido");
}
  public static void VerificarCarrinho()
  {
    int OpCarrinho = 0;
    int CodigoPedido;
    int x = 0;
    foreach(ItemCarrinho i in carrinho.getItemCarrinho())
    {
      Console.WriteLine("{0},{1}",i.produto.getCodigo(), i.produto.getNome());
    }
    Console.WriteLine("1:Remover Produto");
    Console.WriteLine("2:Sair");
    OpCarrinho = int.Parse(Console.ReadLine());
      while( x == 0) 
      if(OpCarrinho == 1)
      {
        Console.WriteLine("Digite o código do produto");
        CodigoPedido = int.Parse(Console.ReadLine());
        foreach(ItemCarrinho i in carrinho.getItemCarrinho())
          if(i.produto.getCodigo() == CodigoPedido)
        {
          carrinho.getItemCarrinho().Remove(i);
          x =1;
          break;
        }
      }
      else
        x = 1;   
}
}