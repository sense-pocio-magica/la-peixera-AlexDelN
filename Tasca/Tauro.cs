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

    public void Mort(Peix tau)
    {
        if (tau is Tauro)
        {
            int contador = 0;
            contador++;
            if (contador == 75)
            {
                tau.Viu = false;
            }
        }
        
    }
    
    public override void Moure()
    {
        base.Moure();
    }
}