namespace FestasInfantis.WinApp.Compartilhado
{
    public static class Utils
    {
        public static void FormatarTxtNumericaDecimal(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int maximoCaracteres = 15;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && textBox.Text.Contains(','))
            {
                e.Handled = true;
            }
            else if (textBox.Text.Length >= maximoCaracteres && !textBox.SelectedText.Contains(',') && !char.IsControl(e.KeyChar))
            {
                int tamanhoSelecao = textBox.SelectionLength;
                int totalCaracteres = textBox.Text.Length - tamanhoSelecao + 1;

                if (totalCaracteres > maximoCaracteres)
                {
                    e.Handled = true;
                }
            }
        }

        public static void FormatarTxtNumericaInt(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int valorMaximo = int.MaxValue;

            if (e.KeyChar == '\b')
                return;

            if (textBox.SelectionLength > 0)
            {
                int inicio = textBox.SelectionStart;
                int tamanho = textBox.SelectionLength;

                textBox.Text = textBox.Text.Remove(inicio, tamanho);
                textBox.SelectionStart = inicio;
                textBox.SelectionLength = 0;
            }

            int posicaoCursor = textBox.SelectionStart;
            string novoNumero = textBox.Text.Substring(0, posicaoCursor) + e.KeyChar + textBox.Text.Substring(posicaoCursor);

            if (!int.TryParse(novoNumero, out int resultado) || resultado > valorMaximo)
            {
                e.Handled = true;
            }
        }
    }
}
