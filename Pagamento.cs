using System;


class Pagamento {

string chave;
double valor;
int numero;
double limite; 


public void Pagamento_(double v, string c, int n){
valor = v;
chave = c;
numero = n;
}

class Cartao {
  public string numero;
  private double limite;

  public bool processarPagamento(double valor, string chave){
    if (valor <= limite && chave==numero){
      limite-=valor;
      return true;
    }
    else{
      return false;
    }
  }
  //GET e SET
  //SET obriga parametro
  public bool setLimite(double valor){
    if (valor <=200){
      limite+=valor;
      return true;
    }
    else
      return false;
  }

  public double getLimite(){
    return limite;
  }


}