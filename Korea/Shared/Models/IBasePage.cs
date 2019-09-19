using System.Collections.Generic;

namespace Korea.Shared.Models
{
    public interface IBasePage
    {
		bool HasHeader { get; set; }
        void AddBreadcrump(List<Breadcrumb> breadcrumbs);

    }
}