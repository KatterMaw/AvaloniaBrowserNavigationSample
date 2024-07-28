using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication1.ViewModels;

internal sealed partial class AuthorizeViewModel : ViewModelBase
{
	public AuthorizeViewModel(MainViewModel mainViewModel)
	{
		_mainViewModel = mainViewModel;
	}

	private readonly MainViewModel _mainViewModel;
	[ObservableProperty] private string _name = string.Empty;

	[RelayCommand]
	private void Authorize()
	{
		_mainViewModel.Content = new AuthorizedViewModel(Name);
	}
}