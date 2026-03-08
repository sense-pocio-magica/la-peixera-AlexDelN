namespace Pexetaria;

public class Pop : Peix
{
    public Pop(bool Femeni, int posicaoX, int posicaoY) : base(Femeni, posicaoX, posicaoY)
    {
        
    }

    public override void Interactuar(Peix altre)
    {
        if (altre is Pop)
        {

            if (altre.Viu == true && this.Viu == true)
            {
                CanviaDireccio();
            }
        }
    }

    public override Peix Reprodueix(Peix altre)
    {
        return null;
    }



    public override void Moure()
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