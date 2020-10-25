using System;


class Pagamento {

double limite;
double valor;
string chave;

public Pagamento (double v, string c, double l){
 valor = v;
 chave = c; 
 limite = l;
}
  public double getLimite(){
    return limite;
  }


public bool pagamentoCartao (){
  if (valor <= limite){
    limite-=valor;
    return true;
  }
  else{
  return false;

}



}
}