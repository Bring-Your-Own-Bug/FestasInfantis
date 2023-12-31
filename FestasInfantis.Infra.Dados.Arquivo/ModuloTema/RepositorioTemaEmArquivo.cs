﻿using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.Infra.Dados.Arquivo.ModuloTema
{
    public class RepositorioTemaEmArquivo : RepositorioBaseEmArquivo<Tema>, IRepositorio<Tema>
    {
        public RepositorioTemaEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Tema> ObterRegistros()
        {
            return contextoDados.temas;
        }
    }
}
