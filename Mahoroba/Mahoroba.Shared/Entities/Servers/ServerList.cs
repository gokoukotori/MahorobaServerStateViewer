using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahoroba.Shared.Entities.Servers
{
	public class ServerList
	{
		[JsonProperty("news")]
		public object News { get; set; }

		[JsonProperty("serverlist")]
		public List<Server> Serverlist { get; set; }

		[JsonProperty("allsid")]
		public string Allsid { get; set; }

		[JsonProperty("gap")]
		public long Gap { get; set; }

		[JsonProperty("updateVersion")]
		public object UpdateVersion { get; set; }

		[JsonProperty("updateZip")]
		public object UpdateZip { get; set; }

		[JsonProperty("payurl")]
		public object Payurl { get; set; }

		[JsonProperty("newVersion")]
		public string NewVersion { get; set; }

		[JsonProperty("noOpenCDK")]
		public object NoOpenCdk { get; set; }

		[JsonProperty("currentVersion")]
		public string CurrentVersion { get; set; }

		[JsonProperty("lastSubLog")]
		public List<object> LastSubLog { get; set; }
	}
}
