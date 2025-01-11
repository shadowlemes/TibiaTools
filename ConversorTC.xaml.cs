using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibiaTools
{
    public partial class ConversorTC : ContentPage
    {
        public ConversorTC()
        {
            InitializeComponent();
        }

        private void Txt_ResultadoGold(object sender, TextChangedEventArgs e)
        {
            try 
            {
                if (string.IsNullOrWhiteSpace(txt_gold.Text) || string.IsNullOrWhiteSpace(txt_tcserver.Text))
                {
                    txt_resultadogold.Text=""; // Limpa o resultado se algum campo estiver vazio
                    return;
                }
                int gold = Convert.ToInt32(txt_gold.Text);

                int valorTC = Convert.ToInt32(txt_tcserver.Text);

                int valorFinal = gold * valorTC;

                txt_resultadogold.Text = valorFinal.ToString();
            }
            catch (Exception)
            {
                //await DisplayAlert("Erro", "Insira um valor que seja númerico", "Fechar");
                Console.WriteLine("Insira o valor em números");
            }

        }
    }
}
