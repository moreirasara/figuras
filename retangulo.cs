using System;

namespace Aula10
{
  public class Retangulo : Figura
  {
    private double _base;
    private double _altura;
    public double Base
    {
      get
      {
        return this._base;
      }
       
      set
      {
        if (value <= 0)
        {
         Console.WriteLine("Base inválida");
        }
        else
        {
         this._base = value;
         this.AtualizarArea();
         this.AtualizarPerimetro();
        }
      }
    }
    public double Altura
    {
      get
      {
        return this._altura;
      }
       
      set
      {
        if (value <= 0)
        {
         Console.WriteLine("Altura inválida");
        }
        else
        {
         this._altura = value;
         this.AtualizarArea();
         this.AtualizarPerimetro();
        }
      }
    }
    
    public Retangulo(double rBase, double rAltura)
    {
      this.Base = rBase;
      this.Altura = rAltura;
    }
    private void AtualizarArea()
    {
      this._area = this._altura * this._base;
    }
    private void AtualizarPerimetro()
    {
      this._perimetro = 2 * this._altura + 2 * this._base;
    }
  }
}