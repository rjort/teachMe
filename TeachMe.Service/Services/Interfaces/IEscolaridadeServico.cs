﻿using System;
using System.Collections.Generic;
using TeachMe.Core.Dominio;

namespace TeachMe.Service.Services.Interfaces
{
    public interface IEscolaridadeServico
    {
        List<Escolaridade> ObterTodasEscolaridades();
        Escolaridade ObterEscolaridadePorId(Guid Id);
    }
}
