﻿namespace FestasInfantis.Infra.Dados.Memoria.Compartilhado
{
    public class RepositorioBaseEmMemoria<T> where T : EntidadeBase<T>
    {
        protected List<T> listaRegistros;
        protected int contadorRegistros = 0;

        public virtual void Inserir(T registro)
        {
            contadorRegistros++;

            registro.Id = contadorRegistros;

            listaRegistros.Add(registro);
        }

        public virtual void Editar(int id, T registroAtualizado)
        {
            T registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Editar(T registroSelecionado, T registroAtualizado)
        {
            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Excluir(int id)
        {
            T registroSelecionado = SelecionarPorId(id);

            listaRegistros.Remove(registroSelecionado);
        }

        public virtual void Excluir(T registroSelecionado)
        {
            listaRegistros.Remove(registroSelecionado);
        }

        public virtual T SelecionarPorId(int id)
        {
            return listaRegistros.Find(x => x.Id == id);
        }

        public virtual List<T> SelecionarTodos()
        {
            return listaRegistros;
        }

        public bool TemRegistro()
        {
            return listaRegistros.Count > 0;
        }

        public bool TemRegistro(List<T> listaRegistros)
        {
            return listaRegistros.Count > 0;
        }
    }
}
