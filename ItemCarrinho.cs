class ItemCarrinho
{
  public Produto produto;
  public int qtd;

  public ItemCarrinho(Produto p,int q)
  {
    produto = p;
    qtd = q;
  }
  public double TotalValor()
  {
    return qtd * produto.getValor();
  }
}