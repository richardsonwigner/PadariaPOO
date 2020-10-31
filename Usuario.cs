using System;
using System.Collections.Generic;

class Cadastro{
  string nome;
  string endereço;
  double senha;
  List<Cadastro> ClienteCadastro = new List<Cadastro>();
  public Cadastro()
  {

  }
  public Cadastro(string n,string e,double s)
  {
    nome = n;
    endereço = e;
    senha = s;

  }
  public List<Cadastro> getCadastro() 
  {
    return ClienteCadastro;
  }
  public string getNome()
  {
    return nome;
  }
   public string getEndereço()
   {
    return endereço;
  }
  public double getSenha()
  {
    return senha;
  }

  
}