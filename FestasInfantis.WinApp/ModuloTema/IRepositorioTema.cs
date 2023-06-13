﻿namespace FestasInfantis.WinApp.ModuloTema
{
    public interface IRepositorioTema
    {
        void Inserir(Tema tema);
        void Editar(int id, Tema tema);
        void Excluir(Tema tema);
        Tema SelecionarPorId(int id);
    }
}
