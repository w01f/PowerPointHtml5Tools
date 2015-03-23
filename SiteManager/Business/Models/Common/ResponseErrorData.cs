using Newtonsoft.Json;

namespace SiteManager.Business.Models.Common
{
	class ResponseErrorData
	{
		[JsonProperty(PropertyName = "code")]
		public int Code { get; set; }

		[JsonProperty(PropertyName = "message")]
		public string Message { get; set; }

		[JsonProperty(PropertyName = "details")]
		public string Details { get; set; }
	}
}
