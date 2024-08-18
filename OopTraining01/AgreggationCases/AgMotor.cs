public class Motor
{
    public string Tipo { get; set; }
    public int Potencia { get; set; }

    public Motor(string tipo, int potencia)
    {
        Tipo = tipo;
        Potencia = potencia;
    }

    public void Ligar()
    {
        Console.WriteLine("Motor ligado.");
    }
}
