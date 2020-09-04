using MahorobaServerStateViewer.Services.Interfaces;

namespace MahorobaServerStateViewer.Services
{
	public class MessageService : IMessageService
	{
		public string GetMessage()
		{
			return "Hello from the Message Service";
		}
	}
}
