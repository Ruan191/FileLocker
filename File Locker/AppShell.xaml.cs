using File_Locker.Views;

namespace File_Locker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(FilesPage), typeof(FilesPage));
        }
    }
}
