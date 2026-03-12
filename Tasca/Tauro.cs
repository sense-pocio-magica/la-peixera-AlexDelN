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

    public override Peix Reprodueix(Peix altre)
    {
        if (altre is Tauro)
        {
            if (this.Femeni != altre.Femeni)
            {
                int r = rnd.Next(0, 2);

                if (r == 1)
                {
                    Tauro fill = new Tauro(
                        false,
                        this.PosicioX,
                        this.PosicioY
                    );
                    return fill;
                }
                else if (r == 1)
                {
                    Tauro fill = new Tauro(
                        true,
                        this.PosicioX,
                        this.PosicioY
                    );
                    return fill; 
                }
            }
        }
        return null;
    }

private int contador = 0;
   public void Mort()
{
    contador++;
    if (contador >= 75)
    {
        this.Viu = false;
    }
}
    
    public override void Moure()
    {
        base.Moure();
        Mort();

    }
}