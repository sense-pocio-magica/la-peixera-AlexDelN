using System.Runtime.CompilerServices;

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
                Console.WriteLine("Dos tortugues es matan");
                this.Viu = false;
                altre.Viu = false;
            }
            
        }
    }

    public override Peix Reprodueix(Peix altre)
    {
        if (altre is Tortugua && Femeni != altre.Femeni)
        {
            bool sexe = rnd.Next(0, 2) == 0? false : true;
            
            Console.WriteLine("Crien tortugues");
            Tortugua fill = new Tortugua(
                        sexe,
                        this.PosicioX,
                        this.PosicioY
                    );
            return fill;
        }
        return null;
    }

    public override void Moure()
    {
        base.Moure();
    }
}