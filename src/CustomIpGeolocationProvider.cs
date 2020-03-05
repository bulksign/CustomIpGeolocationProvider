using System.Collections.Generic;
using System.Net;
using Bulksign.Extensibility;

namespace CustomIpGeolocationProvider
{
	public class CustomIpGeolocationProvider : IIPGeolocationProvider
	{
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
	}
}