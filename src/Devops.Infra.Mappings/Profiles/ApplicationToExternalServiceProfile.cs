using AutoMapper;
using Devops.Infra.ExternalService.Entities;
using Devops.Model.ViewModel.Devops;

namespace Devops.Infra.Mappings.Profiles
{
    public class ApplicationToExternalServiceProfile : Profile
    {
        public ApplicationToExternalServiceProfile()
        {
            CreateMap<ProjetosViewModel.Request, RequestBaseEntities.Request>();
            CreateMap<RepositoriosViewModel.Request, RequestBaseEntities.Request>();
        }
    }
}