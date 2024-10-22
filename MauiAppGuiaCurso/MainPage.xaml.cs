namespace MauiAppGuiaCurso
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void PRIMEIRO_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Primeiro());
        }
        
        private void SEGUNDO_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Segundo());
        }

        private void TERCEIRO_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Terceiro());
        }
    }

}
