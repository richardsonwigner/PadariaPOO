using System;

class MainClass{
  static Estoque estoque = new Estoque();
  public static void Main (string[] args) {
  double v = 1000;
  string c = "123"; 
  Cadastro Cadastro1 = new Cadastro("TESTE","Teste",0);
  Pagamento Pagamento1 = new Pagamento(v,c,1000);
  
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
      int Pedido = 0;
      string x1 = "n";
      while(x1 == "n"){
      Console.WriteLine("Escolha o tipo de produto");
      Console.WriteLine("1:Pão");
      Console.WriteLine("2:Leite");
      Console.WriteLine("3:Biscoito");
      Console.WriteLine("4:Bolo");
      Console.WriteLine("5:Variados");
      Pedido = int.Parse(Console.ReadLine());
      estoque_(Pedido);
      }
    }
  
    public static void estoque_(int Pedido){
      if(Pedido == 1){
       estoque.Pao();}
      if(Pedido == 2){
       estoque.Leite();}
      if(Pedido == 3){
       estoque.Biscoito();}
      if(Pedido == 4){
       estoque.Bolo();}
      if(Pedido == 5){
       estoque.Variados();}
  }

  }


