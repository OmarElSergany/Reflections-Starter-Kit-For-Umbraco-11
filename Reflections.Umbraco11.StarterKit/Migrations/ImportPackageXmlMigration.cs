using Microsoft.Extensions.Options;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Umbraco.Cms.Core.Configuration.Models;
using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.Packaging;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Infrastructure.Migrations;
using Umbraco.Cms.Infrastructure.Packaging;

namespace Reflections.Umbraco11.StarterKit.Migrations
{
    public class ImportPackageXmlMigration : PackageMigrationBase
    {
        public ImportPackageXmlMigration(
            IPackagingService packagingService,
            IMediaService mediaService,
            MediaFileManager mediaFileManager,
            MediaUrlGeneratorCollection mediaUrlGenerators,
            IShortStringHelper shortStringHelper,
            IContentTypeBaseServiceProvider contentTypeBaseServiceProvider,
            IMigrationContext context,
            IOptions<PackageMigrationSettings> packageMigrationsSettings)
            : base(packagingService,
                mediaService,
                mediaFileManager,
                mediaUrlGenerators,
                shortStringHelper,
                contentTypeBaseServiceProvider,
                context,
                packageMigrationsSettings)
        {
        }

        protected override void Migrate()
        {
            //Task ImportPackageTask = Task.Run(() => {
            ImportPackage.FromEmbeddedResource(GetType()).Do();
            //});
            //ImportPackageTask.Wait();
            //Thread.Sleep(5000);
            Context.AddPostMigration<PublishRootBranchPostMigration>();
        }
    }
}