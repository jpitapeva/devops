using Newtonsoft.Json;

namespace Devops.Infra.ExternalService.Entities
{
    public class ProjetosEntities
    {
        public class Response
        {
            [JsonProperty("Count")]
            public int? Quantidade { get; set; }

            [JsonProperty("Value")]
            public IEnumerable<Propriedade>? Propriedades { get; set; }
        }

        public class Propriedade
        {
            [JsonProperty("Id")]
            public string? Id { get; set; }
            
            [JsonProperty("Name")]
            public string? Nome { get; set; }

            [JsonProperty("Description")]
            public string? Descricao { get; set; }

            [JsonProperty("Url")]
            public string? Url { get; set; }
            
            [JsonProperty("State")]
            public string? Estado { get; set; }

            [JsonProperty("Revision")]
            public int? Revisao { get; set; }

            [JsonProperty("Visibility")]
            public string? Visibilidade { get; set; }

            [JsonProperty("LastUpdateTime")]
            public DateTime? UltimaAtualiacao { get; set; }
        }
    }
}