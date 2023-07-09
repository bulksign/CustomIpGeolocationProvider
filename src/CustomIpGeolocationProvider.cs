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
			//this provider receives the signer IP address and must return geo-location information for that IP address.
			//this information is then added to the envelope audit trail


			//based on the provided IP address, retrieve the geo-location data here 



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