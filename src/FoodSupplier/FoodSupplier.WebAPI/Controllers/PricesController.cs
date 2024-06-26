﻿using AutoMapper;
using FoodSupplier.BusinessLogic.Abstractions;
using FoodSupplier.BusinessLogic.Models;
using FoodSupplier.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodSupplier.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PricesController : ControllerBase
{
    private readonly IPricesService _pricesService;
    private readonly IMapper _mapper;

    public PricesController(IPricesService pricesService, IMapper mapper)
    {
        _pricesService = pricesService;
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<PriceModel> Get([FromQuery] PriceEntryGetModel model)
    {
        try
        {
            var candidate = _pricesService.Get(model.Id);
            var result = _mapper.Map<PriceModel>(candidate);

            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetLastByProduct")]
    public ActionResult<PriceModel> GetLastByProduct([FromQuery] ProductGetModel model)
    {
        try
        {
            var candidate = _pricesService.GetLast(model.Id);
            var result = _mapper.Map<PriceModel>(candidate);

            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("GetAllByProduct")]
    public ActionResult<IEnumerable<PriceModel>> GetAllByProduct([FromQuery] ProductGetModel model)
    {
        try
        {
            var candidate = _pricesService.GetAll(model.Id);
            var result = _mapper.Map<IEnumerable<PriceEntry>, IEnumerable<PriceModel>>(candidate);

            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}