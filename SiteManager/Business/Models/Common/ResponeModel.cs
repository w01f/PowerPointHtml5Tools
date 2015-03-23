using System;
using Newtonsoft.Json;

namespace SiteManager.Business.Models.Common
{
	class ResponeModel
	{
		[JsonProperty(PropertyName = "status")]
		public int Status { get; set; }
		
		[JsonProperty(PropertyName = "data")]
		public string DataEncoded { get; set; }

		public bool IsSuccess
		{
			get { return Status == 200; }
		}

		public TDataType GetData<TDataType>()
		{
			if (!String.IsNullOrEmpty(DataEncoded))
				return JsonConvert.DeserializeObject<TDataType>(DataEncoded);
			throw new ArgumentNullException("data is empty");
		}

		public static ResponeModel Deserialize(string encoded)
		{
			return JsonConvert.DeserializeObject<ResponeModel>(encoded);
		}
	}
}
