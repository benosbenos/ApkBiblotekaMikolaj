namespace ApkBiblotekaMikolaj
{
    public partial class MainPage : ContentPage
    {

        int potopIlosc = 1;
        int zbrodniaIlosc = 1;
        int panIlosc = 1;

        public MainPage()
        {
            InitializeComponent();
            UaktualnijKsiazki();
        }

        void UaktualnijKsiazki()
        {
            PotopIlosc.Text = potopIlosc.ToString();
            ZbrodniaIlosc.Text = zbrodniaIlosc.ToString();
            PanIlosc.Text = panIlosc.ToString();
        }

        void WypozyczFun(object sender, EventArgs e)
        {
            int id = int.TryParse(Wypozycz.Text, out id) ? id : 0;

            switch (id)
            {
                case 1:
                    if (potopIlosc >= 1) potopIlosc -= 1;
                    else DisplayAlert("Ksiazki juz nie ma!", "", "OK");
                    break;
                case 2:
                    if (zbrodniaIlosc >= 1) zbrodniaIlosc -= 1;
                    else DisplayAlert("Ksiazki juz nie ma!", "", "OK");
                    break;
                case 3:
                    if (panIlosc >= 1) panIlosc -= 1;
                    else DisplayAlert("Ksiazki juz nie ma!", "", "OK");
                    break;

                default:
                    DisplayAlert("Ksiazka o podanym id nie istnieje!", "", "OK");
                    break;
            }

            UaktualnijKsiazki();
        }
        void OddajFun(object sender, EventArgs e)
        {
            int id = int.TryParse(Oddaj.Text, out id) ? id : 0;

            switch (id)
            {
                case 1:
                    potopIlosc += 1;
                    DisplayAlert("Dzieki za oddanie ksiazki", "", "OK");
                    break;
                case 2:
                    zbrodniaIlosc += 1;
                    DisplayAlert("Dzieki za oddanie ksiazki", "", "OK");
                    break;
                case 3:
                    panIlosc += 1;
                    DisplayAlert("Dzieki za oddanie ksiazki", "", "OK");
                    break;

                default:
                    DisplayAlert("Ksiazka o podanym id nie istnieje!", "", "OK");
                    break;
            }
            UaktualnijKsiazki();
        }
    }

}
