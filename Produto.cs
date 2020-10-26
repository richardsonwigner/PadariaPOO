class Produto{
  int codigo;
  string nome;
  int qtd;
  double valor;

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
  public Produto(){
    
  }
  public Produto(int c,string n ,int q,double v){
    codigo = c;
    nome = n;
    qtd = q;
    valor = v;
  }

}