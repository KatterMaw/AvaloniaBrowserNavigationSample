using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApplication1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
	[ObservableProperty] private ViewModelBase _content;

	public MainViewModel()
	{
		_content = new AuthorizeViewModel(this);
	}
}
