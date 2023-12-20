namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor para classe Nokia:
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        
        // Procedimento para instalar aplicativos customizado para smartphone Nokia:
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia.");
        }
    }
}