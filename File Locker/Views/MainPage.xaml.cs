
using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Core.Primitives;
using CommunityToolkit.Maui.Storage;
using FileLocker.Core.Models;
using Microsoft.Maui.Storage;

namespace File_Locker.Views
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<FolderItem> Folders { get; set; }
        private readonly IFolderPicker _folderPicker;

        public MainPage(IFolderPicker folderPicker)
        {
            InitializeComponent();
            Folders = new ObservableCollection<FolderItem>
            {
                new FolderItem { Name = "Documents", IsVisibilityLocked = true, IsEncrypted = false },
                new FolderItem { Name = "Photos", IsVisibilityLocked = false, IsEncrypted = true },
                new FolderItem { Name = "Videos", IsVisibilityLocked = true, IsEncrypted = true }
            };

            _folderPicker = folderPicker;
            BindingContext = this;
            FolderBtn.Command = new Command(async () => await OnAddFolderClicked());
        }

        private void OnFolderTapped(object sender, EventArgs e)
        {
            if (sender is Frame frame && frame.BindingContext is FolderItem folder)
            {
                // Handle click
                DisplayAlert("Clicked", $"You clicked {folder.Name}", "OK");
            }
        }

        private async void OnGoToFilesPageClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(FilesPage));
        }

        private async Task OnAddFolderClicked()
        {
            var result = await _folderPicker.PickAsync();
            DisplayAlert("Clicked", $"You clicked {result.Folder.Name}", "OK");
        }
    }
}
