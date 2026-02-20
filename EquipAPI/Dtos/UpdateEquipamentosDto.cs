namespace EquipApi.Dtos
{
    public class UpdateEquipamentosDto
    {
        public decimal Horimetro { get; set; }
        public string? StatusOperacional { get; set; }
        public string LocalizacaoAtual { get; set; } = default!; 
    }
}