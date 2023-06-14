namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private IRepositorioTema _repositorioTema;
        private TabelaTemaControl _tabelaTema;
        public ControladorTema(IRepositorioTema repositorioTema)
        {
            _repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir Novo Tema";

        public override string ToolTipEditar => "Editar Tema Existente";

        public override string ToolTipExcluir => "Excluir Tema Existente";

        public override void Inserir()
        {
            TelaTemaForm telaTema = new();

            DialogResult dialogResult = telaTema.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                _repositorioTema.Inserir(tema);
            }

            CarregarTemas();
        }

        public override void Editar()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Edição de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTemaForm telaTema = new();
            telaTema.ConfigurarForm(temaSelecionado);

            DialogResult dialogResult = telaTema.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                _repositorioTema.Editar(tema.Id, tema);
            }

            CarregarTemas();
        }

        public override void Excluir()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Exclusão de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Deseja excluir o tema {temaSelecionado.Nome}?",
                    "Exclusão de Temas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
                _repositorioTema.Excluir(temaSelecionado);

            CarregarTemas();
        }

        public override void AdicionarItem()
        {
            base.AdicionarItem();
        }

        public override void DefinirValor()
        {
            base.DefinirValor();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tema";
        }

        private Tema ObterTemaSelecionado()
        {
            return _repositorioTema.SelecionarPorId(_tabelaTema.ObterIdSelecionado());
        }

        public override UserControl ObterUserControl()
        {
            _tabelaTema ??= new TabelaTemaControl();

            CarregarTemas();

            return _tabelaTema;
        }

        public void CarregarTemas()
        {
            List<Tema> temas = _repositorioTema.SelecionarTodos();

            _tabelaTema.AtualizarRegistros(temas);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {temas.Count} tarefa(s)");
        }
    }
}
