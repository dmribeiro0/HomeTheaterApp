TV tv = new TV();
SoundSystem soundSystem = new SoundSystem();
LightSystem lightSystem = new LightSystem();

HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, soundSystem, lightSystem);

Console.WriteLine("===== DEMO HOME THEATER =====\n");

Console.WriteLine("--- 1) Assistir filme via Facade ---");
homeTheater.WatchMovie("Interstellar");
Console.WriteLine();

Console.WriteLine("--- 2) Encerrar sessão de filme ---");
homeTheater.EndMovie();
Console.WriteLine();

Console.WriteLine("--- 3) Ouvir música via Facade ---");
homeTheater.ListenToMusic("Bohemian Rhapsody");
Console.WriteLine();

Console.WriteLine("--- 4) Encerrar sessão de música ---");
homeTheater.EndMusic();
Console.WriteLine();

Console.WriteLine("--- 5) Testes diretos dos dispositivos (todos os métodos) ---");

Console.WriteLine("TV desligada tentando abrir streaming e tocar filme:");
tv.OpenStreamingApp();
tv.PlayMovie("Matrix");

Console.WriteLine("\nSom desligado tentando ajustar volume:");
soundSystem.SetVolume(10);

Console.WriteLine("\nLuz desligada tentando diminuir luzes:");
lightSystem.DimLights();

Console.WriteLine("\nLigando TV e usando apps:");
tv.TurnOn();
tv.OpenStreamingApp();
tv.PlayMovie("Matrix");
tv.OpenMusicApp();
tv.PlayMusic("Imagine");
tv.TurnOff();

Console.WriteLine("\nLigando sistema de som e ajustando volume:");
soundSystem.TurnOn();
soundSystem.SetVolume(25);
soundSystem.TurnOff();

Console.WriteLine("\nLigando luz ambiente e diminuindo luzes:");
lightSystem.TurnOn();
lightSystem.DimLights();
lightSystem.TurnOff();

Console.WriteLine("\n===== FIM DA DEMO =====");
