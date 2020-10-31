using System;


class Pagamento{

string codSeg;
double limite =200; 
int numero;

public Pagamento (int n, string c ){
 numero = n;  
 codSeg = c;
}

public bool processarPagamento(double valor, string chave){
  if (valor <= limite && chave== codSeg){
      limite-=valor;
      Console.WriteLine("Valor pago: {0} ", valor);
      return true;
    }
    else{
      return false;
    }
  }
 
 
 

}
