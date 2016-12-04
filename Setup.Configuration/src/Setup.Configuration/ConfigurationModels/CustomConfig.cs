using Newtonsoft.Json;

namespace Setup.Configuration.ConfigurationModels
{
    public class CustomConfig
    {
        public string WelcomeMessage { get; set; }  

        public string Enviornment { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
