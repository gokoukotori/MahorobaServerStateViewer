using Prism.Mvvm;

namespace MahorobaServerStateViewer.ViewModels
{
	public class MainWindowViewModel : BindableBase
	{
		private string _title = "まほたん接続数チェッカー";
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		public MainWindowViewModel()
		{

		}
	}
}
