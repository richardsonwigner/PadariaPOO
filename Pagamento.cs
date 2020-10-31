using System;


class Pagamento{

string codSeg;
double limite =100; 
int numero;

public Pagamento (int n, string c ){
 numero = n;  
 codSeg = c;
}

public bool processarPagamento(double valor, string chave){
  if (valor <= limite && chave== codSeg){
      limite-=valor;
      return true;
    }
    else{
      return false;
    }
  }
 


}
