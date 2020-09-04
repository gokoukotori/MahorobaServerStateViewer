using Mahoroba.Service.Server.Interface;
using Mahoroba.Shared.Entities.Servers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mahoroba.Service.Server
{
	public class ServerState : IServerState
	{
		private static readonly string BASE_URL = "https://prd-main.sakura.fusion-studio.co.jp:7001/serverconfig_dev.php?func=serverlist";
		public IReadOnlyList<Shared.Entities.Servers.Server> GetAllServerState() => GetServersState();
		public Shared.Entities.Servers.Server GetServerState(int serverId) => GetServersState(serverId).First();

		private IReadOnlyList<Shared.Entities.Servers.Server> GetServersState(int? serverId = null)
		{
			using var client = new WebClient();
			var binary = client.DownloadData(BASE_URL);
			var json = Encoding.UTF8.GetString(binary);
			var list = JsonConvert.DeserializeObject<ServerList>(json);
			if (serverId.HasValue)
			{
				return new List<Shared.Entities.Servers.Server> { list.Serverlist[serverId.Value] };
			}
			return list.Serverlist;

		}
	}
}
