using System;
using Umbraco.Cms.Core.Packaging;
using Umbraco.Cms.Infrastructure.Packaging;

namespace Reflections.Umbraco11.StarterKit.Migrations
{
    public class StarterKitPackageMigrationPlan : PackageMigrationPlan
    {
        public StarterKitPackageMigrationPlan()
            : base("Reflections.Umbraco11.StarterKit")
        {
        }

        protected override void DefinePlan()
        {
            To<ImportPackageXmlMigration>(new Guid("CF6A1675-BBD8-45C2-9DB9-4964091F73CD"));
        }
    }
}