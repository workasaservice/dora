using System.Collections.Generic;
using waas.doro.Core.ProjectAggregate;

namespace waas.doro.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
