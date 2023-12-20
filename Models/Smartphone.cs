namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        
        // Procedimentos com modelos para exibir as informações dos smartphones:
        public void ExibirNumero(string numero)
        {
            Console.WriteLine($"Número de telefone: {numero}");
        }

        public void ExibirModelo(string modelo)
        {
            Console.WriteLine($"Modelo do smartphone: {modelo}");
        }

        public void ExibirImei(string imei)
        {
            Console.WriteLine($"IMEI: {imei}");
        }

        public void ExibirMemoria(int memoria)
        {
            Console.WriteLine($"Mémoria: {memoria} GB");
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}