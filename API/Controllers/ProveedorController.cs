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
//[Authorize(Roles = "Empleado, Administrador, Gerente")]
public class ProveedorController : BaseApiController
{
  private readonly IUnitOfWork _unitOfWork;
  private readonly IMapper _mapper;
  public ProveedorController(IMapper mapper, IUnitOfWork unitOfWork)
  {
    _mapper = mapper;
    _unitOfWork = unitOfWork;
  }

  
  [HttpGet]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<ActionResult<IEnumerable<Proveedor>>> Get()
  {
      var nameVar = await _unitOfWork.Proveedores.GetAllAsync();
      return Ok(nameVar);
  }

  [HttpGet]
  [ApiVersion("1.1")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<ActionResult<Pager<ProveedorDto>>> Get([FromQuery] Params entidadP)
  {
  var (totalRegistros, registros) = await _unitOfWork.Proveedores.GetAllAsync(entidadP.PageIndex,entidadP.PageSize,entidadP.Search);
  var lista = _mapper.Map<List<ProveedorDto>>(registros);
  return new Pager<ProveedorDto>(lista,totalRegistros,entidadP.PageIndex,entidadP.PageSize,entidadP.Search);
  }

  [HttpPost]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<ActionResult<IEnumerable<Proveedor>>> Post(ProveedorDto nameDto)
  {
  var resultado = _mapper.Map<Proveedor>(nameDto);
      _unitOfWork.Proveedores.Add(resultado);
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
  public async Task<IActionResult> Update(int id, [FromBody] ProveedorDto nameDto)
  {
      if (id != nameDto.Id)
      {
          return BadRequest();
      }
  
      var existe = await _unitOfWork.Proveedores.GetByIdAsync(id);
      if (existe == null)
      {
          return NotFound();
      }
  
  
        _mapper.Map(nameDto, existe);
      _unitOfWork.Proveedores.Update(existe);
      await _unitOfWork.SaveAsync();
  
      return NoContent();
  }

  [HttpDelete("{id}")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<IActionResult> Delete(int id)
  {
    var resultado = await _unitOfWork.Proveedores.GetByIdAsync(id);
    if (resultado == null)
    {
      return NotFound();
    }
  
    _unitOfWork.Proveedores.Remove(resultado);
    await _unitOfWork.SaveAsync();
  
    return Ok();
  }


  //Listar los proveedores que sean persona natural.
  [HttpGet("PorTipoPersona/{tipopersona}")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<ActionResult<IEnumerable<ProveedorDto>>> ProveedoresPorTipoPersona(string tipopersona)
  {
      if (tipopersona == "")
      {
          return BadRequest("Ingrese un Dato.");
      }
      var resultado = await _unitOfWork.Proveedores.ProveedoresPorTipoPersona(tipopersona);
      return _mapper.Map<List<ProveedorDto>>(resultado);
  } 

  //Listar los insumos que son vendidos por un determinado proveedor. El usuario debe ingresar el Nit de proveedor.
  [HttpGet("ConInsumos/{nit}")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public async Task<ActionResult<IEnumerable<ProveedorDto>>> InsumoPorProveedor(string nit)
  {
      if (nit == "")
      {
          return BadRequest("Ingrese un Dato.");
      }
      var resultado = await _unitOfWork.Proveedores.InsumoPorProveedor(nit);
      return _mapper.Map<List<ProveedorDto>>(resultado);
  } 
}
