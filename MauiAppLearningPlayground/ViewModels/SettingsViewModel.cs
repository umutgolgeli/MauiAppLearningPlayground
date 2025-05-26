using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiAppLearningPlayground.ViewModels;

public class SettingsViewModel : INotifyPropertyChanged
{
    private AppTheme _selectedTheme;

    public ObservableCollection<AppTheme> Themes { get; } = new()
    {
        AppTheme.Light,
        AppTheme.Dark
    };

    public AppTheme SelectedTheme
    {
        get => _selectedTheme;
        set
        {
            if (_selectedTheme != value)
            {
                _selectedTheme = value;
                OnPropertyChanged();
                Application.Current.UserAppTheme = _selectedTheme;
            }
        }
    }

    public SettingsViewModel()
    {
        _selectedTheme = Application.Current.UserAppTheme;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
