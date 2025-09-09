Console.WriteLine("Hello, World!");

Televisao tv = new Televisao(55f);

Console.WriteLine($"A TV tem o tamanho {tv.Tamanho} polegadas");

tv.Ligar();

tv.AumentarVolume();
Console.WriteLine($"Volume: {tv.Volume}");

tv.DiminuirVolume();
Console.WriteLine($"Volume: {tv.Volume}");

tv.AtivarMudo();
tv.DesativarMudo();

tv.DefinirCanal(100);
Console.WriteLine($"Canal atual: {tv.Canal}");

tv.ProximoCanal();
Console.WriteLine($"Canal atual: {tv.Canal}");

tv.CanalAnterior();
Console.WriteLine($"Canal atual: {tv.Canal}");

tv.Desligar();

