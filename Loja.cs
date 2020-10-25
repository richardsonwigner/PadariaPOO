using System;
using System.Collections.Generic;
class Loja
{
  public List<produtos> Produto = new List<produtos>(0,"teste",0,0);
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


  }

