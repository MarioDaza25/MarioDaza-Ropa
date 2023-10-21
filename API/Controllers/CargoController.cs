using API.Dtos;
using API.Helpers;
using AutoMapper;
using Dominio.Entidades;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiVersion("1.0")]
[ApiVersion("1.1")]
[Authorize(Roles = "Empleado, Administrador, Gerente")]
public class CargoController : BaseApiController
{
  private readonly IUnitOfWork _unitOfWork;
  private readonly IMapper _mapper;
  public CargoController(IMapper mapper, IUnitOfWork unitOfWork)
  {
    _mapper = mapper;
    _unitOfWork = unitOfWork;
  }

  [HttpGet]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<ActionResult<IEnumerable<CargoDto>>> Get()
  {
      var cargo = await _unitOfWork.Cargos.GetAllAsync();
      return Ok(cargo);
  }


  [HttpGet]
  [ApiVersion("1.1")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<ActionResult<Pager<CargoDto>>> Get([FromQuery] Params cargoP)
  {
  var (totalRegistros, registros) = await _unitOfWork.Cargos.GetAllAsync(cargoP.PageIndex,cargoP.PageSize,cargoP.Search);
  var lista = _mapper.Map<List<CargoDto>>(registros);
  return new Pager<CargoDto>(lista,totalRegistros,cargoP.PageIndex,cargoP.PageSize,cargoP.Search);
  }


  [HttpPost]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<ActionResult<IEnumerable<CargoDto>>> Post(CargoDto cargoDto)
  {
  var resultado = _mapper.Map<Cargo>(cargoDto);
      _unitOfWork.Cargos.Add(resultado);
      await _unitOfWork.SaveAsync();
      if (resultado == null)
      {
          return BadRequest();
      }
      return NoContent();
  }

  [HttpPut("{id}")]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> Update(int id, [FromBody] CargoDto cargoDto)
  {
      if (id != cargoDto.Id)
      {
          return BadRequest();
      }
  
      var existe = await _unitOfWork.Cargos.GetByIdAsync(id);
      if (existe == null)
      {
          return NotFound();
      }
  
  
        _mapper.Map(cargoDto, existe);
      _unitOfWork.Cargos.Update(existe);
      await _unitOfWork.SaveAsync();
  
      return NoContent();
  }

  [HttpDelete("{id}")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> Delete(int id)
  {
    var resultado = await _unitOfWork.Cargos.GetByIdAsync(id);
    if (resultado == null)
    {
      return NotFound();
    }
  
    _unitOfWork.Cargos.Remove(resultado);
    await _unitOfWork.SaveAsync();
  
    return Ok();
  }
}
