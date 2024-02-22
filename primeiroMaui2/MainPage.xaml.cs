

namespace primeiroMaui2
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_n1.Text);
            double b = Convert.ToDouble(txt_n2.Text);
            double c = Convert.ToDouble(txt_n3.Text);

            double delta = (b * b) - (4 * a * c);


            if (delta < 0)
            {
                
                string msg = $"Delta {delta} é menor que zero, conta sem resultados reais ";
                DisplayAlert("Maui", msg, "Fechar");
            }
            if (delta == 0)
            {
                double raiz = Math.Sqrt(delta);
                double R1 = -((b) + raiz) / (2 * a);

                string msg = $"O resultado é: delta {delta} e as duas raízes serão iguais: x {R1} ";
                DisplayAlert("Maui", msg, "Fechar");
            }
            else
            {
                double raiz = Math.Sqrt(delta);

                double R1 = -((b) + raiz) / (2 * a);
                double R2 = -((b) - raiz) / (2 * a);


                string msg = $"O resultado é: delta {delta} e as raízes: x' {R1} e x'' {R2}";
                DisplayAlert("Maui", msg, "Fechar");
            }
        }
    }

}
