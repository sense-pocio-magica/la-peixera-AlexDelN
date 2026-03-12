namespace Pexetaria;

public class PeixNormal : Peix
{

    public PeixNormal(bool Femeni, int posicaoX, int posicaoY) : base(Femeni, posicaoX, posicaoY)
    {

    }


    public override void Interactuar(Peix altre)
    {
        if (altre is PeixNormal)
        {

            if (altre.Viu == true && this.Viu == true)
            {
                if (this.Femeni == altre.Femeni)
                {
                    altre.Viu = false;
                    this.Viu = false;

                }
            }
        }

        if (altre is Tauro)
        {
            this.Viu = false;
        }

    }

    public override Peix Reprodueix(Peix altre)
    {
        if (altre is PeixNormal)
        {
            if (this.Femeni != altre.Femeni)
            {
                int r = rnd.Next(0, 2);
                if (r == 0)
                {
                    PeixNormal fill = new PeixNormal(
                        false,
                        this.PosicioX,
                        this.PosicioY
                    );

                    return fill;
                }

                if (r == 1)
                {
                    PeixNormal fill = new PeixNormal(
                        true,
                        this.PosicioX,
                        this.PosicioY
                    );
                }
            }
        }
        return null;
    }
    
    public override void Moure()
    {
        base.Moure();
    }
}