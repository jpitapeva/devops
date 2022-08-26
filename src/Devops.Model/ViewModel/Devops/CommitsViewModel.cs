using System.ComponentModel.DataAnnotations;

namespace Devops.Model.ViewModel.Devops
{
    public class CommitsViewModel
    {
        public class Request
        {
            [Required(ErrorMessage = "Personal access token é campo um obrigatório")]
            public string PersonalAccessToken { get; set; }

            [Required(ErrorMessage = "Organizacao é campo um obrigatório")]
            public string Organizacao { get; set; }

            [Required(ErrorMessage = "Autor valido campo obrigatorio")]
            public string Autor { get; set; }

            [Required(ErrorMessage = "ApartirDe valido campo obrigatorio")]
            public string ApartirDe { get; set; }

            /// <summary>
            /// Default 100
            /// </summary>
            public int? ValorMaximo { get; set; }
        }

        public class Response
        {
            public int Quantidade { get; set; }
            public string Projeto { get; set; }
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
            public bool CommentTruncated { get; set; }

        }
        public class Author
        {
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public string Email { get; set; }
        }
        public class Commiter
        {
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public string Email { get; set; }
        }
        public class ChangeCounts
        {
            public int Add { get; set; }
            public int Edit { get; set; }
            public int Delete { get; set; }
        }
    }
}
