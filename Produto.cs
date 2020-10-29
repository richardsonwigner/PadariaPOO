class Produto{
  int codigo;
  string nome;
  int qtd;
  double valor;
  string Categoria;

  public int getCodigo(){
    return codigo;
  }
  public string getNome(){
    return nome;
  }
  public int getQtd(){
    return qtd;
  }
  public double getValor(){
    return valor;
  }
  public string getCategoria(){
    return Categoria;
  }
  public Produto(){
    
  }
  public Produto(int c,string n ,int q,double v,string Ctg){
    codigo = c;
    nome = n;
    qtd = q;
    valor = v;
    Categoria = Ctg;
  }
  public void DiminuirEstoque(int QTD)
  {
    qtd -= QTD;

  }
}