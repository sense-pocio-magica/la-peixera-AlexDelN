namespace Pexetaria;

public class Tortugua : Peix
{
    public Tortugua(bool Femeni, int posicaoX, int posicaoY) : base(Femeni, posicaoX, posicaoY)
    {
        
    }

    public override void Interactuar(Peix altre)
    {
        if (altre is Tortugua)
        {
            if (this.Femeni == altre.Femeni)
            {
                this.Viu = false;
                altre.Viu = false;
            }
            
        }
    }

    public override Peix Reprodueix(Peix altre)
    {
        if (altre is Tortugua)
        {
            if (this.Femeni != altre.Femeni)
            {
                Tortugua fill = new Tortugua(
                    false,
                    this.PosicioX,
                    this.PosicioY
                );
                return fill;

            }
        }
        return null;
    }

    public override void Moure()
    {
        base.Moure();
    }
}