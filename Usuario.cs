using System;

class Cadastro{
  string nome;
  string endereço;
  double senha;

  public Cadastro(string n,string e,double s){
    nome = n;
    endereço = e;
    senha = s;

  }
  public string getNome(){
    return nome;
  }
   public string getEndereço(){
    return endereço;
  }
  
}