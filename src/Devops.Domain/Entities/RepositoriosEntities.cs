using Newtonsoft.Json;

namespace Devops.Domain.Entities
{
    public class RepositoriosEntities
    {
        public class Response
        {
            [JsonProperty("Value")]
            public IEnumerable<Propriedade>? Propriedades { get; set; }

            [JsonProperty("Count")]
            public int? Quantidade { get; set; }
        }

        public class Propriedade
        {
            [JsonProperty("Id")]
            public Guid? Id { get; set; }

            [JsonProperty("Name")]
            public string? Nome { get; set; }

            [JsonProperty("Url")]
            public string? Url { get; set; }

            [JsonProperty("Project")]
            public Project? Projeto { get; set; }

            [JsonProperty("DefaultBranch")]
            public string? DefaultBranch { get; set; }

            [JsonProperty("Size")]
            public int? Size { get; set; }

            [JsonProperty("RemoteUrl")]
            public string? RemoteUrl { get; set; }

            [JsonProperty("SshUrl")]
            public string? SshUrl { get; set; }

            [JsonProperty("WebUrl")]
            public string? WebUrl { get; set; }

            [JsonProperty("IsFork")]
            public bool? IsFork { get; set; }
        }

        public class Project
        {
            [JsonProperty("Id")]
            public string? Id { get; set; }

            [JsonProperty("Name")]
            public string? Nome { get; set; }

            [JsonProperty("Url")]
            public string? Url { get; set; }

            [JsonProperty("State")]
            public string? Estado { get; set; }

            [JsonProperty("Revision")]
            public int? Revisao { get; set; }

            [JsonProperty("Visibility")]
            public string? Visibilidade { get; set; }

            [JsonProperty("LastUpdateTime")]
            public DateTime? UltimaAtualizacao { get; set; }

            [JsonProperty("Description")]
            public string? Descricao { get; set; }
        }
    }
}