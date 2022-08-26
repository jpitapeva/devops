using AutoMapper;
using Devops.Domain.Entities;
using Devops.Model.ViewModel.Devops;

namespace Devops.Infra.Mappings.Profiles
{
    public class ViewModelToExternalServiceProfile : Profile
    {
        public ViewModelToExternalServiceProfile()
        {
            CreateMap<CommitsViewModel.Request, CommitEntities.Request>();
            CreateMap<ProjetosViewModel.Request, RequestBaseEntities.Request>();
            CreateMap<RepositoriosViewModel.Request, RequestBaseEntities.Request>();
        }
    }
}