using System.Collections.Generic;

namespace Korea.Shared.Models
{
    public interface IBasePage
    {
        void AddBreadcrump(List<Breadcrumb> breadcrumbs);
    }
}