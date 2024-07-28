using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaApplication1.ViewModels;

internal sealed class AuthorizeViewModel : ViewModelBase
{
	[Reactive] public string Name { get; set; } = string.Empty;

	public ICommand AuthorizeCommand { get; }

	public AuthorizeViewModel(MainViewModel mainViewModel)
	{
		_mainViewModel = mainViewModel;
		AuthorizeCommand = ReactiveCommand.Create(Authorize);
	}

	private readonly MainViewModel _mainViewModel;

	private void Authorize()
	{
		_mainViewModel.Content = new AuthorizedViewModel(Name);
	}
}