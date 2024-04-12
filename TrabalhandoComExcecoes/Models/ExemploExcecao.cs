namespace TrabalhandoComExcecoes.Models
{
  public class ExemploExcecao
  {
    public void Metodo1() 
    {
      try 
      {
        Metodo2();
      }
      catch (Exception)
      {
        Console.WriteLine("Exceção tratada");
      }
      finally
      {
        Console.WriteLine("Continuação do fluxo do programa\n");
      }
    }
    void Metodo2()
    {
      Metodo3();
    }
    void Metodo3 ()
    {
      Metodo4();
    }
    void Metodo4()
    {
      throw new Exception("Ocorreu uma exceção");
      // Se essa exceção não for tratada, ela é propagada para os métodos superiores na cadeia de chamadas. 
      // Se não for tratada em nenhum lugar ao longo da cadeia, o programa é encerrado.
    }
  }
}