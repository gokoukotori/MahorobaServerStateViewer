using Prism.Ioc;
using MahorobaServerStateViewer.Views;
using System.Windows;
using Prism.Modularity;
using System.Text;
using Mahoroba.Service.Server;
using Mahoroba.Service.Server.Interface;
using MahorobaServerStateViewer.Modules.StateView;

namespace MahorobaServerStateViewer
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App
	{
		protected override Window CreateShell()
		{
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
			return Container.Resolve<MainWindow>();
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterSingleton<IServerState, ServerState>();
		}

		protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
		{
			moduleCatalog.AddModule<StateViewModule>();
		}
	}
}
