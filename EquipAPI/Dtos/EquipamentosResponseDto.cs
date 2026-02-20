using EquipApi.Models;
namespace EquipApi.Dtos
{
    public record EquipamentosResponseDto(
        int Id,
        string Codigo,
        string Tipo,
        string Modelo,
        decimal? Horimetro,
        string StatusOperacional,
        DateOnly DataAquisicao,
        string LocalizacaoAtual
    );
}