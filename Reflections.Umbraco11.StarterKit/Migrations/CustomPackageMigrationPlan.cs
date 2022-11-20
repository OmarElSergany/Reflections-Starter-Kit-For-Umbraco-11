using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Packaging;

namespace Reflections.Umbraco11.StarterKit.Migrations
{
    internal class CustomPackageMigrationPlan : PackageMigrationPlan
    {
        public CustomPackageMigrationPlan() : base("Reflections.Umbraco11.StarterKit")
        {
        }

        protected override void DefinePlan()
        {
            To<CustomPackageMigration>(new Guid("06E9A1CD-796F-4BD6-AE92-FA656A9DECDF"));
        }
    }
}
