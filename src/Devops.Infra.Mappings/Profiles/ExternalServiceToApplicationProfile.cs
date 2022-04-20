using AutoMapper;
using Devops.Infra.ExternalService.Entities;
using Devops.Model.ViewModel.Devops;

namespace Devops.Infra.Mappings.Profiles
{
    public class ExternalServiceToApplicationProfile : Profile
    {
        public ExternalServiceToApplicationProfile()
        {
            CreateMap<ProjetosEntities.Response, ProjetosViewModel.Response>();
            CreateMap<ProjetosEntities.Propriedade, ProjetosViewModel.Propriedade>();

            CreateMap<RepositoriosEntities.Response, RepositoriosViewModel.Response>();
            CreateMap<RepositoriosEntities.Propriedade, RepositoriosViewModel.Propriedade>();
            CreateMap<RepositoriosEntities.Project, RepositoriosViewModel.Projeto>();
        }
    }
}