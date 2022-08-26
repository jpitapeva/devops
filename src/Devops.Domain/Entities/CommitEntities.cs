using Newtonsoft.Json;

namespace Devops.Domain.Entities
{
    public class CommitEntities
    {
        public class Request : RequestBaseEntities.Request
        {
            public string Autor { get; set; }
            public DateTime ApartirDe { get; set; }
            public Guid? RepositorioId { get; set; }
            public int? ValorMaximo { get; set; }
        }

        public class Response
        {
            public string Projeto { get; set; }
            [JsonProperty("count")]
            public int Quantidade { get; set; }
            [JsonProperty("value")]
            public IEnumerable<Propriedade> Propriedades { get; set; }
        }
        public class Propriedade
        {
            public string CommitId { get; set; }
            public Author Author { get; set; }
            public Commiter Commiter { get; set; }
            public string Comment { get; set; }
            public ChangeCounts ChangeCounts { get; set; }
            public string Url { get; set; }
            public string RemoteUrl { get; set; }
            public bool? CommentTruncated { get; set; }

        }
        public class Author
        {
            public string Name { get; set; }
            public DateTime? Date { get; set; }
            public string Email { get; set; }
        }
        public class Commiter
        {
            public string Name { get; set; }
            public DateTime? Date { get; set; }
            public string Email { get; set; }
        }
        public class ChangeCounts
        {
            public int? Add { get; set; }
            public int? Edit { get; set; }
            public int? Delete { get; set; }
        }
    }
}
