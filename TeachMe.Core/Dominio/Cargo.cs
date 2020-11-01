﻿using System;
using System.Collections.Generic;

namespace TeachMe.Core.Dominio
{
    public class Cargo
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
