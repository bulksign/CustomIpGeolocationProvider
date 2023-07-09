using System.Net;
using Bulksign.Extensibility;

namespace CustomIpGeolocationProvider
{
	public class CustomIpGeolocationProvider : IIPGeolocationProvider
	{
		public IJsonSerializer JsonSerializer { get; set; }
		public event LogDelegate Log;

		public string RunIpGeolocation(IPAddress address)
		{

			return string.Empty;
		}

		public Dictionary<string, string> Settings
		{
			get;
			set;
		}

		public string ProviderName => "CustomIpGeolocationProvider";

		public HttpClient HttpClient { get; set; }
	}
}