class HomeTheaterFacade 
{
    private TV tv;
    private SoundSystem soundSystem;
    private LightSystem lightSystem;

    public HomeTheaterFacade(TV tv, SoundSystem soundSystem, LightSystem lightSystem) 
    {
        this.tv = tv;
        this.soundSystem = soundSystem;
        this.lightSystem = lightSystem;
    }

    public void WatchMovie(string movie) 
    {
        Console.WriteLine($"Preparando para assistir {movie}...");
        tv.TurnOn();
        soundSystem.TurnOn();
        lightSystem.TurnOn();
        lightSystem.DimLights();
        tv.OpenStreamingApp();
        tv.PlayMovie(movie);
        soundSystem.SetVolume(20);
        Console.WriteLine("Aproveite o filme!");
    }

    public void ListenToMusic(string song) 
    {
        Console.WriteLine($"Preparando para ouvir {song}...");
        tv.TurnOn();
        soundSystem.TurnOn();
        lightSystem.TurnOn();
        tv.OpenMusicApp();
        tv.PlayMusic(song);
        soundSystem.SetVolume(15);
        Console.WriteLine("Aproveite a música!");
    }

    public void EndMovie() 
    {
        Console.WriteLine("Encerrando sessão de filme...");
        tv.TurnOff();
        soundSystem.TurnOff();
        lightSystem.TurnOff();
    }

    public void EndMusic() 
    {
        Console.WriteLine("Encerrando sessão de música...");
        tv.TurnOff();
        soundSystem.TurnOff();
        lightSystem.TurnOff();
    }
}