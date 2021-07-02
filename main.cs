using System;
using System.Collections.Generic;

namespace Aula10
{
class Program
{
    static void Main(string[] args)
    {
      List<Figura> listFig = new List<Figura>();
      Circulo circ1 = new Circulo(2.0);        
      Retangulo retang = new Retangulo(5, 7);

      listFig.Add(circ1);
      listFig.Add(retang);

      foreach(Figura figura in listFig)
      {
        figura.Imprimir();
      }
    }
}
}