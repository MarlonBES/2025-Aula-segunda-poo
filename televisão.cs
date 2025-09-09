public class Televisao
{
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;
    private const int CANAL_MAX = 520;
    private const int CANAL_MIN = 1;

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Canal = 1;
        Volume = 10;
    }

    public float Tamanho { get; set; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; private set; }
    public bool Estado { get; private set; }
    private int ultimoCanalAssistido;
    private bool mudo;

    public void AumentarVolume()
    {
        if (Volume < VOL_MAX)
            Volume++;
    }

    public void DiminuirVolume()
    {
        if (Volume > VOL_MIN)
            Volume--;
    }

    public void AtivarMudo()
    {
        mudo = true;
        Console.WriteLine("Mudo ativado.");
    }

    public void DesativarMudo()
    {
        mudo = false;
        Console.WriteLine("Mudo desativado.");
    }

    public void DefinirCanal(int novoCanal)
    {
        if (novoCanal >= CANAL_MIN && novoCanal <= CANAL_MAX)
        {
            Canal = novoCanal;
        }
        else
        {
            Console.WriteLine("Canal inválido.");
        }
    }

    public void ProximoCanal()
    {
        if (Canal < CANAL_MAX)
            Canal++;
    }

    public void CanalAnterior()
    {
        if (Canal > CANAL_MIN)
            Canal--;
    }

    public void Ligar()
    {
        Estado = true;
        Canal = ultimoCanalAssistido == 0 ? 1 : ultimoCanalAssistido;
        Console.WriteLine($"TV ligada no canal {Canal}");
    }

    public void Desligar()
    {
        Estado = false;
        ultimoCanalAssistido = Canal;
        Console.WriteLine("TV desligada.");
    }
}
