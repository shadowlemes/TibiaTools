namespace TibiaTools
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_pressione_Clicked(object sender, EventArgs e)
        {
            try
            {                
                double level = Convert.ToDouble(txt_level.Text);

                // Cálculos
                double resultadoMax = Math.Round(level * 3 / 2);
                double resultadoMin = Math.Round(level * 2 / 3);

                // Exibir os resultados (opcional)
                await DisplayAlert("É possível sharear com: ", $"Level Máximo: {resultadoMax}\nLevel Mínimo: {resultadoMin}", "Fechar");
            }
            catch (Exception)
            {
                // Tratamento genérico para exceções inesperadas
                await DisplayAlert("Erro", "Insira um valor que seja númerico", "Fechar");                
                return;
            }
        }
    }
}
