// <auto-generated />
namespace Elastic.Example.Data.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class ApiId : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(ApiId));
        
        string IMigrationMetadata.Id
        {
            get { return "201709030751409_ApiId"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
