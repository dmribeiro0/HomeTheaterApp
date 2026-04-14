class TV 
{
    private bool isOn;

    public void TurnOn() 
    {
        isOn = true;
        Console.WriteLine("TV ligada.");
    }

    public void TurnOff() 
    {
        isOn = false;
        Console.WriteLine("TV desligada.");
    }

    public void OpenStreamingApp() 
    {
        if (isOn) 
        {
            Console.WriteLine("Streaming aberto na TV. Escolha seu filme!");
        } 
        else 
        {
            Console.WriteLine("TV desligada, ligue-a primeiro.");
        }
    }

    public void PlayMovie(string movie) 
    {
        if (isOn) 
        {
            Console.WriteLine($"Assistindo {movie} na TV.");
        } 
        else 
        {
            Console.WriteLine("TV desligada, ligue-a primeiro.");
        }
    }

    public void OpenMusicApp() 
    {
        if (isOn) 
        {
            Console.WriteLine("Aplicativo de música aberto na TV. Escolha sua música!");
        } 
        else 
        {
            Console.WriteLine("TV desligada, ligue-a primeiro.");
        }
    }

    public void PlayMusic(string song) 
    {
        if (isOn) 
        {
            Console.WriteLine($"Tocando {song} na TV.");
        } 
        else 
        {
            Console.WriteLine("TV desligada, ligue-a primeiro.");
        }
    }
}