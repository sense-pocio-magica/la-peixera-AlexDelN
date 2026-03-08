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

    public override void Moure()
    {
        base.Moure();
    }
}