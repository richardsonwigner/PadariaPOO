using System;

class Pagamento
{
  double limite =200; 
  int numero;


  public Pagamento (int n){
    numero = n;
}
  public bool processarPagamento(double valor){
    if (valor <= limite)
    {
      limite-=valor;
      return true;
    }
    else
    {
      return false;
    }
}
  public double getLimite()
  {
    return limite;
  }
  public int getNumero()
  {
    return numero;
  }


} 
 
 


