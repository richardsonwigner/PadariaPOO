class ItemCarrinho
{
  public Produto produto;
  int qtd;

  public ItemCarrinho(Produto p,int q)
  {
    produto = p;
    qtd = q;
  }
  public double TotalValor()
  {
    return qtd * produto.getValor();
  }
  public int getqtd()
  {
    return qtd;
  }
}