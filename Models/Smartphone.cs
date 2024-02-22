namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string numero { get; set; }
        private string modelo { get; set; }
        private string imei { get; set; }
        private int memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
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