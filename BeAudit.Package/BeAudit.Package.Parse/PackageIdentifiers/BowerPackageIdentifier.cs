using BeAudit.Package.Enumerations;
using BeAudit.Package.Interfaces;

namespace BeAudit.Package.Parse.PackageIdentifiers
{
    public class BowerPackageIdentifier: IPackageIdentifier
    {
        public PackageManager PackageManager => PackageManager.Bower;
        
        public string Name { get; set; }
        
        public string Version { get; set; }
    }
}