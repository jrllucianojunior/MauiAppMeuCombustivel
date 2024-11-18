namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                // Captura os valores da marca, modelo, etanol e gasolina
                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                // Verifica qual combustível compensa mais
                if (etanol <= (gasolina * 0.7))
                {
                    msg = $"O etanol está compensando para o veículo {marca} {modelo}.";
                }
                else
                {
                    msg = $"A gasolina está compensando para o veículo {marca} {modelo}.";
                }

                // Exibe o resultado em um alerta
                DisplayAlert("Calculado", msg, "OK");

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        }
    }
}
