using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using MahorobaServerStateViewer.Core;
using Mahoroba.Service.Server.Interface;
using MahorobaServerStateViewer.Core.Mvvm;
using Reactive.Bindings;
using Mahoroba.Shared.Entities.Servers;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace MahorobaServerStateViewer.Modules.StateView.ViewModels
{
	public class StatusViewModel : RegionViewModelBase
	{

		public ReactiveProperty<List<Server>> Status { get; set; }
		public ReactiveProperty<long> AllServerConnections { get; set; }

		public StatusViewModel(IRegionManager regionManager, IServerState state) : base(regionManager)
		{
			var list = state.GetAllServerState();
			Status = new ReactiveProperty<List<Server>>
			{
				Value = list.ToList()
			};
			AllServerConnections = new ReactiveProperty<long>
			{
				Value = list.Sum(x => x.OnlineNums)
			};

			Observable.Interval(TimeSpan.FromSeconds(10))
			.Subscribe(_ =>
			{
				var list = state.GetAllServerState();
				Status.Value = list.ToList();
				AllServerConnections.Value = list.Sum(x => x.OnlineNums);
			});

		}
		public override void OnNavigatedTo(NavigationContext navigationContext)
		{
			//do something
		}
	}
}
