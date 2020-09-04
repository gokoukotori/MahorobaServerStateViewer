using MahorobaServerStateViewer.Modules.StateView.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using MahorobaServerStateViewer;
using MahorobaServerStateViewer.Core;

namespace MahorobaServerStateViewer.Modules.StateView
{
	public class StateViewModule : IModule
	{
		private readonly IRegionManager _regionManager;

		public StateViewModule(IRegionManager regionManager)
		{
			_regionManager = regionManager;
		}
		public void OnInitialized(IContainerProvider containerProvider)
		{
			_regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(Status));
		}

		public void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterForNavigation<Status>();
		}
	}
}