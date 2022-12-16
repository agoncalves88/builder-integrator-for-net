using System;
using Newtonsoft.Json;

namespace Builder.Integrator.For.Net.CrossCutting
{
	public class DataSourceConfigOptions
	{
        public const string DataSourcesConfigOptions = "DataSourcesConfig";
        [JsonProperty("DATASOURCES")]
        public List<DATASOURCE> DATASOURCES { get; set; } = new List<DATASOURCE>();

        public class DATASOURCE
        {

            [JsonProperty("NAME")]
            public string NAME { get; set; } = String.Empty;

            [JsonProperty("GROUP")]
            public string GROUP { get; set; } = String.Empty;

            [JsonProperty("URL")]
            public string URL { get; set; } = String.Empty;

            [JsonProperty("HAS_PARAM")]
            public bool HASPARAM { get; set; } = false;

            [JsonProperty("PROPERTIES_TO_GET")]
            public List<PROPERTIESTOGET> PROPERTIES_TO_GET { get; set; }
        }

       
          
    

        public class PROPERTIESTOGET
        {
            [JsonProperty("VALUE_TO_GET")]
            public string VALUE_TO_GET { get; set; } = String.Empty;

            [JsonProperty("INPUT_NAME")]
            public string INPUT_NAME { get; set; } = String.Empty;
        }
    }
}
