﻿using System;
using System.Collections.Generic;

namespace TeachMe.Core.Dominio
{
    public class Usuario
    {
        public Usuario()
        {
                
        }

        public Usuario(Usuario usuario) : this()
        {
            Id = usuario.Id;
            Nome = usuario.Nome;
            DataNascimento = usuario.DataNascimento;
            Email = usuario.Email;
            Senha = usuario.Senha;
            Telefone = usuario.Telefone;
            Escolaridade = usuario.Escolaridade;
            TipoDocumento = usuario.TipoDocumento;
            NuDocumento = usuario.NuDocumento;
            CargoId = usuario.CargoId;
            UF = usuario.UF;
            Cidade = usuario.Cidade;
        }

        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public Guid EscolaridadeId { get; set; }
        public string TipoDocumento { get; set; }
        public string NuDocumento { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public Guid CargoId { get; set; }

        public Cargo Cargo { get; set; }
        public Escolaridade Escolaridade { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public List<ProfessorDisciplina> ProfessorDisciplina { get; set; }
        public EmailValidacao EmailValidacao { get; set; }
        public Professor Professor { get; set; }
        public List<ContratoAula> ContratoAulas { get; set; }
}
}
