namespace FestasInfantis.WinApp.Compartilhado
{
    public static class Utils
    {
        public static void FormatarTxtNumerica(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(','))
            {
                e.Handled = true;
            }
        }
    }
}
