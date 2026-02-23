using SmartEnterprise.Repository.IRepo;
using SmartEnterprise.Repository.Repo;
using SmartEnterpriseManagement.Model;
//using SmartEnterpriseManagement.Repository.IRepository;
//using SmartEnterpriseManagement.Repository.Repo;
using SmartEnterpriseManagement.Services.IService;

namespace SmartEnterpriseManagement.Services.Service
{
    public class ProjectService : IProjectService
    {
        private readonly IRepository<Project> _repository;

        public ProjectService()
        {
            _repository = new Repository<Project>();
        }

        public void CreateProject(Project project)
        {
            _repository.Add(project);
        }

        public List<Project> GetProjects()
        {
            return _repository.GetAll();
        }

        public void Add(Project entity)
        {
            _repository.Add(entity);
        }

        public List<Project> GetAll()
        {
            return _repository.GetAll();
        }

        public Project GetById(int id)
        {
            return _repository.GetById(id);
        }

        
    }
}
