using System;

class Pagamento
{
  string codSeg;
  double limite =200; 


  public Pagamento (string c){ 
    codSeg = c;
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
 

} 
 
 


