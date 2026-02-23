using SmartEnterprise.Services.IService;
using SmartEnterpriseManagement.Model;
using System.Collections.Generic;

namespace SmartEnterpriseManagement.Services.IService
{
    public interface IProjectService : IBaseService<Project>
    {
        void CreateProject(Project project);
        List<Project> GetProjects();
    }
}
