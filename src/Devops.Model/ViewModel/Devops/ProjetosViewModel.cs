using System.ComponentModel.DataAnnotations;

namespace Devops.Model.ViewModel.Devops
{
    public static class ProjetosViewModel
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
            public int? Quantidade { get; set; }
            public IEnumerable<Propriedade> Propriedades { get; set; } = null!;
        }

        public class Propriedade
        {
            public string Id { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public string Url { get; set; }
            public string Estado { get; set; }
            public int Revisao { get; set; }
            public string Visibilidade { get; set; }
            public DateTime? UltimaAtualiacao { get; set; }
        }
    }
}
