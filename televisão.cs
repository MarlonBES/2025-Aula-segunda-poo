public class Televisao{

    private int const int VOL_MAX = 100;
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }

    public float Tamanho { get; set; }
    public int Resolucao { get; set; }
    public int Volume {get; private set; }
    public int Canal {get; set; }
    public bool Estado {get; set;}
    
    public void AumentarVolume()
    {
        if(Volume < 100)
        Volume = Volume + 1;
        else
        Console.WriteLine("Tv já está no max.")
    }
}