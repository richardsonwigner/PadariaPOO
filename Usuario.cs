using System;
using System.Collections.Generic;

class Cadastro{
  string n;
  string e;
  double s;
  List<Cadastro> ClienteCadastro = new List<Cadastro>();
  public Cadastro()
  {

  }
  public Cadastro(string nome,string endereço,double senha)
  {
    n = nome;
    e = endereço;
    s = senha;

  }
  public List<Cadastro> getCadastro() 
  {
    return ClienteCadastro;
  }
  public string getNome()
  {
    return n;
  }
   public string getEndereço()
   {
    return e;
  }
  public double getSenha()
  {
    return s;
  }

  
}