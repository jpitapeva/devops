namespace Devops.Infra.ExternalService.Entities
{
    public class RequestBaseEntities
    {
        public class Request
        {
            public string? PersonalAccessToken { get; set; }

            public string? Organizacao { get; set; }
        }
    }
}
