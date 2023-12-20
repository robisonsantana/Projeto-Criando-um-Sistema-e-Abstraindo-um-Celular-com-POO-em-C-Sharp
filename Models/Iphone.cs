namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor para classe Iphone:
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        // Procedimento para instalar aplicativos customizado para smartphone Apple:
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone.");
        }
    }
}