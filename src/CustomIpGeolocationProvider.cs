using System.Net;
using Bulksign.Extensibility;

namespace CustomIpGeolocationProvider
{
	public class CustomIpGeolocationProvider : IIPGeolocation
	{
		public event LogDelegate Log;

		public string RunIpGeolocation(IPAddress address)
		{

			return string.Empty;
		}

		public string ProviderName => "CustomIpGeolocationProvider";
	}
}