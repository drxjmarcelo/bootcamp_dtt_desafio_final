namespace EquipApi.Dtos
{
    public class CreateEquipamentosDto
    {
        public string Codigo { get; set; } = "";
        public string Tipo { get; set; } = "";
        public string Modelo { get; set; } = "";
        public decimal Horimetro { get; set; }
        public string StatusOperacional { get; set; } = "";
        public DateOnly DataAquisicao { get; set; }
        public string LocalizacaoAtual { get; set; } = ""; 
    }
}