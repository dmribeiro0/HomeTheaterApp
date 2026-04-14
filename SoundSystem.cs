class SoundSystem 
{
    private bool isOn;
    private int volume;

    public void TurnOn() 
    {
        isOn = true;
        Console.WriteLine("Sistema de som ligado.");
    }

    public void TurnOff() 
    {
        isOn = false;
        Console.WriteLine("Sistema de som desligado.");
    }

    public void SetVolume(int level) 
    {
        if (isOn) 
        {
            volume = level;
            Console.WriteLine($"Volume do sistema de som ajustado para {level}.");
        } 
        else 
        {
            Console.WriteLine("Sistema de som desligado, ligue-o primeiro.");
        }
    }
}