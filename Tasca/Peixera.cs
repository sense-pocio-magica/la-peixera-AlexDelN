namespace Pexetaria;

public class Peixera
{
    private List<Peix> Peixos { get; set; }

    protected static Random rnd = new Random();

    public Peixera()
    {
        Peixos = new List<Peix>();
    }
    private Pop CrearPopBorde()
    {
        int costat = rnd.Next(4);

        if (costat == 0) 
            return new Pop(false, rnd.Next(20), 0);

        if (costat == 1)
            return new Pop(false, rnd.Next(20), 19);

        if (costat == 2) 
            return new Pop(false, 0, rnd.Next(20));
        
        return new Pop(false, 19, rnd.Next(20));
    }

    public void PreJoc()
    {
        for (int i = 0; i < 50; i++)
        {
            Peixos.Add(new PeixNormal(false, rnd.Next(0, 20), rnd.Next(0, 20)));
            Peixos.Add(new PeixNormal(true, rnd.Next(0, 20), rnd.Next(0, 20)));

        }
     
        for (int i = 0; i < 10; i++)
        {
            Peixos.Add(new Tauro(false, rnd.Next(0, 20), rnd.Next(0, 20)));
            Peixos.Add(new Tauro(true, rnd.Next(0, 20), rnd.Next(0, 20)));

        }
        for (int i = 0; i < 15; i++)
        {
            Peixos.Add((CrearPopBorde()));
        }
        for (int i = 0; i < 3; i++)
        {
            Peixos.Add(new Tortugua(true, rnd.Next(0, 20), rnd.Next(0, 20)));
            Peixos.Add(new Tortugua(false, rnd.Next(0, 20), rnd.Next(0, 20)));

        }
       
    }
    public void Joc()
    {
        for (int ronda = 0; ronda < 100; ronda++)
        {
            foreach (var peix in Peixos)
            {
                peix.Moure();
            }
            
            Peixos.RemoveAll(p => !p.Viu);

            List<Peix> nousPeixos = new List<Peix>();

            for (int i = 0; i < Peixos.Count; i++)
            {
                for (int j = i + 1; j < Peixos.Count; j++)
                {
                    var peix = Peixos[i];
                    var altre = Peixos[j];

                    if (peix.PosicioX == altre.PosicioX &&
                        peix.PosicioY == altre.PosicioY)
                    {
                        peix.Interactuar(altre);

                        Peix fill = peix.Reprodueix(altre);

                        if (fill != null)
                        {
                            nousPeixos.Add(fill);
                        }
                    }
                }
            }
            Peixos.AddRange(nousPeixos);
        }
        
        Console.WriteLine("Peixos normals: " + Peixos.Count(p => p is PeixNormal));
        Console.WriteLine("Taurons: " + Peixos.Count(p => p is Tauro));
        Console.WriteLine("Pops: " + Peixos.Count(p => p is Pop));
        Console.WriteLine("Tortugues: " + Peixos.Count(p => p is Tortugua));
    }




}