using Newtonsoft.Json;

namespace TestExample.Setup
{
    public class Config
    {
        public string PATH { get; set; }

        public void ReadJson()
        {
            //config.json must be created in the artifact directory
            using (StreamReader sr = new StreamReader("config.json"))
            {
                string json = sr.ReadToEnd();
                JsonStructure data = JsonConvert.DeserializeObject<JsonStructure>(json);

                this.PATH = data.PATH;
            }
        }

        internal sealed class JsonStructure
        {
            public string PATH { get; set; }
        }
    }
}
