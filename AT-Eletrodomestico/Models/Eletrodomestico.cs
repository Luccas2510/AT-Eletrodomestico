namespace AT_Eletrodomestico.Models
{
    public abstract class Eletrodomestico
    {
        public string Marca { get; set; } //get: obter set: dar novos valores setar novos valores
        public string Modelo { get; set; }
        public double ConsumoEnergetico { get; set; } //representa o consumo energético em kWh.
        public abstract string ExibirDetalhes();
    }
}
