using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EquipApi.Models;
using EquipApi.Services;
namespace EquipApi.Controllers

{
    [ApiController]
    [Route("api/equipamentos")]
    public class EquipamentosController : ControllerBase
    {
        private readonly EquipService _service;

        public EquipamentosController(EquipService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] Equipamento equipamento)
        {
            try
            {
                var criado = await _service.CriarAsync(equipamento);
                return CreatedAtAction(nameof(ObterPorId),
                    new { id = criado.Id }, criado);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
            => Ok(await _service.ListarAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var equipamento = await _service.ObterPorIdAsync(id);
            if (equipamento == null)
                return NotFound();

            return Ok(equipamento);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, Equipamento equipamento)
        {
            try
            {
                await _service.AtualizarAsync(id, equipamento);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remover(int id)
        {
            try
            {
                await _service.RemoverAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }

}