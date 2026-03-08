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

    protected virtual void CanviaDireccio()
    
    {
        Direccio = Direccio+ 2;
        if (Direccio > 4)
        {
            Direccio = Direccio - 4;
        }
    }
    
    public void Reprodueix()
    {
      
    }

    public void Baralla()
    {
        
    }
    
    public virtual void Moure()
    {
        if (Direccio == 1)
        {
            PosicioX--;
        }
        else if (Direccio == 2)
        {
            PosicioY--;
        }
        else if (Direccio == 3)
        {
            PosicioX++;
        }
        else if (Direccio == 4)
        {
            PosicioY++;
        }
        
    }
}