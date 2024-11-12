namespace AT_Eletrodomestico.Models
{
    public class Geladeira : Eletrodomestico
    {
        public int CampacidadeLitros { get; set; }
        public bool TemFreezer { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo: {ConsumoEnergetico} kWh, Capacidade: {CampacidadeLitros}, Possui Freezer: {(TemFreezer ? "Sim" : "Não")}";
        }
    }
}
