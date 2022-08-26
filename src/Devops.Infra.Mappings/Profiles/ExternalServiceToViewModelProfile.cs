using AutoMapper;
using Devops.Domain.Entities;
using Devops.Model.ViewModel.Devops;

namespace Devops.Infra.Mappings.Profiles
{
    public class ExternalServiceToViewModelProfile : Profile
    {
        public ExternalServiceToViewModelProfile()
        {
            CreateMap<ProjetosEntities.Response, ProjetosViewModel.Response>();
            CreateMap<ProjetosEntities.Propriedade, ProjetosViewModel.Propriedade>();

            CreateMap<RepositoriosEntities.Response, RepositoriosViewModel.Response>();
            CreateMap<RepositoriosEntities.Propriedade, RepositoriosViewModel.Propriedade>();
            CreateMap<RepositoriosEntities.Project, RepositoriosViewModel.Projeto>();

            CreateMap<CommitEntities.Response, CommitsViewModel.Response>();
            CreateMap<CommitEntities.Propriedade, CommitsViewModel.Propriedade>();
            CreateMap<CommitEntities.Author, CommitsViewModel.Author>();
            CreateMap<CommitEntities.Commiter, CommitsViewModel.Commiter>();
            CreateMap<CommitEntities.ChangeCounts, CommitsViewModel.ChangeCounts>();
        }
    }
}