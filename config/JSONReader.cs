using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DSharpPlusBot.config
{
    public class JSONReader
    {
        public string token { get; set; }
        public string prefix { get; set; }

        public async Task ReadJSON()
        {
            using (StreamReader sr = new StreamReader("config.json"))
            {
                {
                    string json = await sr.ReadToEndAsync();
                    JsonStructure data = JsonConvert.DeserializeObject<JsonStructure>(json);

                    this.token = data.token;
                    this.prefix = data.prefix;
                }
            }
        }

        internal sealed class JsonStructure
        {
            public string token { get; set; }

            public string prefix { get; set; }
        }
    }
}