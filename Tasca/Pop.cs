namespace Pexetaria;

public class Pop
{
    private int PosicioY { get; set; }
    private int PosicioX { get; set; }

    public void MouPop()
    {
        
         if (PosicioY == 20 && PosicioX < 20)
        {
            PosicioX++;
        }
        else if (PosicioX == 20 && PosicioY < 0)
        {
            PosicioY--;
        }
        else if (PosicioY == 0 && PosicioX > 0)
        {
            PosicioX--;
        }
         else if (PosicioX == 0 && PosicioY > 0)
         {
             PosicioY++;
         }
    }
}