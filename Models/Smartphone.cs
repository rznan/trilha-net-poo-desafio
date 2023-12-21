namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string IMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            this.IMEI = IMEI;
            Memoria = memoria;
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

        public override string ToString()
        {
            return  $"Número: {Numero}\n" + 
                    $"Modelo: {Modelo}\n" +
                    $"IMEI: {IMEI}\n" +
                    $"Memoria: {Memoria}\n";
        }
    }
}