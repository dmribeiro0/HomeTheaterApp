class LightSystem 
{
    private bool isOn;

    public void TurnOn() 
    {
        isOn = true;
        Console.WriteLine("Luz ambiente ligada.");
    }

    public void TurnOff() 
    {
        isOn = false;
        Console.WriteLine("Luz ambiente desligada.");
    }

    public void DimLights() 
    {
        if (isOn) 
        {
            Console.WriteLine("Luzes diminuídas para criar ambiente de cinema.");
        } 
        else 
        {
            Console.WriteLine("Luz ambiente desligada, ligue-a primeiro.");
        }
    }
}