using System;

class Programa
{
    static void Main()
    {
        Televisao2 tv = new Televisao2();
        Console.WriteLine($"Volume inicial: {tv.Volume}");
        Console.WriteLine($"Canal inicial: {tv.Canal}");

        tv.AumentarVolume();
        Console.WriteLine($"Após aumentar o volume: {tv.Volume}");

        tv.DiminuirVolume();
        Console.WriteLine($"Após diminuir o volue: {tv.Volume}");
        
        tv.AtivarMudo();
        Console.WriteLine($"Após ativar o mudo: {tv.Volume}");
        
        tv.DesativarMudo(); 
        Console.WriteLine($"Após desativar o mudo: {tv.Volume}");

        tv.AumentarCanal();
        Console.WriteLine($"Após aumentar o canal: {tv.Canal}");

        tv.DiminuirCanal();
        Console.WriteLine($"Após diminuir o canal: {tv.Canal}");
        
        tv.DiretoaoCanal(500);
        Console.WriteLine($"Após a tentativa de Canal Direto: {tv.Canal}");

        tv.LigarTV();
        Console.WriteLine($"Após ligar a TV o ultimo canal será: {tv.Canal}");

    }
    
}
public class Televisao2
{
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;
    private const int CANAL_MAX = 520;
    private const int CANAL_MIN = 1;

    public int Volume { get; private set;}
    public int Canal {get; private set;}
    private int volumeAnterior;
    private int ultimoCanal;

    public Televisao2()
    {
        Volume = 30;
        Canal = 90;
    }
public void AumentarVolume()
{
    if (Volume < VOL_MAX)
        Volume++;
    else
        Console.WriteLine("Volume já está no volume máximo");
}
public void DiminuirVolume()
{
    if (Volume > VOL_MIN)
        Volume--;
    else
        Console.WriteLine("Já está no volume mínimo");

}
public void AtivarMudo()
{
    if (Volume != 0)
    {
        volumeAnterior = Volume;
        Volume = 0;
    }

}
public void DesativarMudo()
    {
    Volume = volumeAnterior;
    }
public void AumentarCanal()
{
    if(Canal < CANAL_MAX)
    {  Canal++;
        ultimoCanal = Canal;
    }
    else
    {
        Console.WriteLine("Já está no canal máximo");   
    }
}
public void DiminuirCanal()
{
    if(Canal > CANAL_MIN)
    {  Canal--;
        ultimoCanal = Canal;
    }    
    else
    {  
        Console.WriteLine("Já está no canal mínimo");
    }
}
public void DiretoaoCanal(int numero)
{
    if (numero >= CANAL_MIN && numero <= CANAL_MAX)
        Canal = numero;
    else
        Console.WriteLine("Canal indisponível");

}
public void LigarTV()
    
{
    Canal = ultimoCanal;
    Console.WriteLine($"TV ligada no canal: {Canal}");

}
    

}