using ReactiveUI.Fody.Helpers;

namespace AvaloniaApplication1.ViewModels;

public class MainViewModel : ViewModelBase
{
	[Reactive] public ViewModelBase Content { get; set; }

	public MainViewModel()
	{
		Content = new AuthorizeViewModel(this);
	}
}
