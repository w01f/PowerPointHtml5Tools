using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SiteManager.Business.Models.RawActivityData
{
	class RawActivityModel
	{
		[JsonProperty(PropertyName = "id")]
		public string ID { get; set; }

		[JsonProperty(PropertyName = "date")]
		public string DateEncoded { get; set; }

		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		[JsonProperty(PropertyName = "subType")]
		public string SubType { get; set; }

		[JsonProperty(PropertyName = "ip")]
		public string Ip { get; set; }

		[JsonProperty(PropertyName = "os")]
		public string Os { get; set; }

		[JsonProperty(PropertyName = "device")]
		public string Device { get; set; }

		[JsonProperty(PropertyName = "browser")]
		public string Browser { get; set; }

		[JsonProperty(PropertyName = "details")]
		public RawActivityDetail[] Details { get; set; }

		public DateTime? Date
		{
			get
			{
				DateTime temp;
				if (DateTime.TryParse(DateEncoded, out temp))
					return temp;
				return null;
			}
		}

		public string DetailsSummary
		{
			get
			{
				var result = new StringBuilder();
				var userString = new List<string>();
				userString.Add("IP: " + Ip);
				userString.Add("OS: " + Os);
				userString.Add("Device: " + Device);
				userString.Add("Browser: " + Browser);
				result.AppendLine("User Detail - " + string.Join("; ", userString.ToArray()));
				if (Details != null)
				{
					result.AppendLine();
					result.AppendLine("Activity Detail - " + String.Join("; ", Details.Select(detail => detail.ToString())));
				}
				return result.ToString();
			}
		}
	}
}
