namespace ApkBiblotekaMikolaj
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Height = 460;
            window.Width = 1140;

            return window;
        }
    }
}
