using System;
using Newtonsoft.Json;

namespace SiteManager.Business.Models.RawActivityData
{
	class RawActivityDetail
	{
		[JsonProperty(PropertyName = "tag")]
		public string Tag { get; set; }
		
		[JsonProperty(PropertyName = "value")]
		public string Value { get; set; }

		public override string ToString()
		{
			return String.Format("{0}: {1}", Tag, Value);
		}
	}
}
