using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloFesta;
using FestasInfantis.Dominio.ModuloTema;
using FestasInfantis.WinApp.ModuloFesta;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private readonly IRepositorioAluguel _repositorioAluguel;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel)
        {
            _repositorioAluguel = repositorioAluguel;
        }

        public override string ToolTipInserir => "Inserir Novo Aluguel";
        public override string ToolTipEditar => "Editar Aluguel Existente";
        public override string ToolTipExcluir => "Excluir Aluguel Existente";

        public override void Inserir()
        {
            //List<Aluguel> alugueis = _repositorioAluguel.SelecionarTodos();
            //TelaAluguelForm telaAluguel = new(alugueis);

            //if (telaAluguel.ShowDialog() == DialogResult.OK)
            //    _repositorioAluguel.Inserir(telaAluguel.ObterAluguel());

            //CarregarAlugueis();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterUserControl()
        {
            throw new NotImplementedException();
        }
    }
}
