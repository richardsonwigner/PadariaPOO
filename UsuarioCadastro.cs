using System;
using System.Collections.Generic;

class Cadastro{
  string n;
  double s;
  List<Cadastro> ClienteCadastro = new List<Cadastro>();
  public Cadastro()
  {

  }
  public Cadastro(string nome,double senha)
  {
    n = nome;
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
  public double getSenha()
  {
    return s;
  }

  
}