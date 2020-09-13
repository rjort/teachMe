﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TeachMe.API.Models.DTO;
using TeachMe.Core.Services.Interfaces;

namespace TeachMe.API.Controllers
{
    [Route("api/v1/disciplina")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaServico _servico;
        private readonly ILogger<DisciplinaController> _logger;
        private readonly IMapper _mapper;
        public DisciplinaController(IDisciplinaServico servico, ILogger<DisciplinaController> logger, IMapper mapper)
        {
            _servico = servico;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("obter/{id}")]
        [Authorize]
        public ActionResult<DisciplinaDTO> ObterDisciplinaPorId(Guid id)
        {
            _logger.LogDebug("ObterDisciplinaPorId");
            var resultado = _servico.ObterDisciplinaPorId(id);

            return resultado != null
                ? (ActionResult)Ok(_mapper.Map<DisciplinaDTO>(resultado))
                : NoContent();
        }

        [HttpGet]
        [Route("obterTodos")]
        [Authorize]
        public ActionResult<List<DisciplinaDTO>> ObterDisciplinas()
        {
            _logger.LogDebug("ObterDisciplinas");
            var resultado = _servico.ObterDisciplinas();

            return resultado.Count > 0
                ? (ActionResult)Ok(resultado.Select(r => _mapper.Map<DisciplinaDTO>(r)).ToList())
                : NoContent();
        }
    }
}