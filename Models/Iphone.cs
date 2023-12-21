namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no celular Iphone");
        }
        public override string ToString()
        {
            return "Tipo: Iphone\n" + base.ToString();
        }
    }
}