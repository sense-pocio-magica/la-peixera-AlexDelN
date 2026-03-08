namespace Pexetaria;

public class Peixera
{
    private List<Peix> Peixos { get; set; }

    public void Joc()
    {
        foreach (var peix in Peixos)
        {
            peix.Moure();
            
            
            if (peix.Viu == false)
            {
                Peixos.Remove(peix);
            }
        }
        
        
        foreach (var peix in Peixos)
        {
            foreach (var altre in Peixos)
            {
                if (peix.PosicioX == altre.PosicioX && peix.PosicioY == altre.PosicioY)
                {
                    peix.Interactuar(altre);
                }
            }
        }
    }    
    
    
    
    
}