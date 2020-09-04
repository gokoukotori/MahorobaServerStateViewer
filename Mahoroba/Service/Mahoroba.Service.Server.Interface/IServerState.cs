using Mahoroba.Shared.Entities.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahoroba.Service.Server.Interface
{
	public interface IServerState
	{
		public Shared.Entities.Servers.Server GetServerState(int serverId);
		public IReadOnlyList<Shared.Entities.Servers.Server> GetAllServerState();
	}
}
