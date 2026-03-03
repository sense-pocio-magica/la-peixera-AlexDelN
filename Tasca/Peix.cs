namespace Pexetaria;

public abstract class Peix
{
    public bool Femeni { get; set; }
    public int PosicioY { get; set; }
    public int PosicioX { get; set; }
    protected int Direccio { get; set; }
    public bool Viu { get; set; }


    public Peix(bool femeni, int posicioX, int posicioY)
    {
        Femeni = femeni;
        PosicioX = posicioX;
        PosicioY = posicioY;
        Direccio = new Random().Next(0, 4);
    }

    public abstract void Interactuar(Peix altre);
   
    
    public void Reprodueix()
    {
      
    }

    public void Baralla()
    {
        
    }
    public void Moure()
    {
        
    }
}