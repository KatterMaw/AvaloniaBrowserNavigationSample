namespace AvaloniaApplication1.ViewModels;

internal sealed class AuthorizedViewModel : ViewModelBase
{
	public string Name { get; }

	public AuthorizedViewModel(string name)
	{
		Name = name;
	}
}