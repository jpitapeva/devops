using System.ComponentModel.DataAnnotations;

namespace Devops.Model.ViewModel.Devops
{
    public static class RepositoriosViewModel
    {
        public class Request
        {
            [Required(ErrorMessage = "Personal access token é campo um obrigatório")]
            public string PersonalAccessToken { get; set; }

            [Required(ErrorMessage = "Organizacao é campo um obrigatório")]
            public string Organizacao { get; set; }
        }
        public class Response
        {
            public IEnumerable<Propriedade> Propriedades { get; set; }
            public int? Quantidade { get; set; }
        }

        public class Propriedade
        {
            public string Id { get; set; }
            public string Nome { get; set; }
            public string Url { get; set; }
            public Projeto Projeto { get; set; }
            public string DefaultBranch { get; set; }
            public int? Size { get; set; }
            public string RemoteUrl { get; set; }
            public string SshUrl { get; set; }
            public string WebUrl { get; set; }
            public bool? IsFork { get; set; }
        }

        public class Projeto
        {
            public string Id { get; set; }
            public string Nome { get; set; }
            public string Url { get; set; }
            public string Estado { get; set; }
            public int? Revisao { get; set; }
            public string Visibilidade { get; set; }
            public DateTime? UltimaAtualizacao { get; set; }
            public string Descricao { get; set; }
        }
    }
}