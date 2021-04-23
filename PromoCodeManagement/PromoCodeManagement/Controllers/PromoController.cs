using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromoCodeManagement.Data;
using PromoCodeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromoCodeManagement.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class PromoController : ControllerBase
    {
        private readonly IPromoRepository _repository;

        public readonly IMapper _mapper;

        public PromoController(IPromoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<PromoCodeItem[]>> Get()
        {
            try
            {
                var results = await _repository.GetAllPromosAsync();

                return _mapper.Map<PromoCodeItem[]>(results);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

        }
        [HttpGet("{codeId}")]
        public async Task<ActionResult<PromoCodeItem>> Get(int codeId)
        {
            try
            {
                var result = await _repository.GetPromoAsync(codeId);
                if (result == null) return NotFound();
                return _mapper.Map<PromoCodeItem>(result);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");

            }
        }
    }
}
