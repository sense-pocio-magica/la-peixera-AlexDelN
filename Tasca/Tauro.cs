namespace Pexetaria;

public class Tauro : Peix
{
    public Tauro(bool Femeni, int posicaoX, int posicaoY) : base(Femeni, posicaoX, posicaoY)
    {
        
    }

    public override void Interactuar(Peix altre)
    {
        if (altre is Tauro)
        {
            if (this.Femeni == altre.Femeni)
            {
                this.Viu = false;
                altre.Viu = false;
            }
        }
        
    }

    public bool Mort()
    {
        int contador = 0;
        contador++;
        if (contador == 50)
        {
           return true; 
        }
        return false;
    }
}