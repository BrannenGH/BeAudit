using BeAudit.Package.Enumerations;
using BeAudit.Package.Interfaces;

namespace BeAudit.Package.Parse.PackageIdentifiers
{
    public class ChocolateyPackageIdentifier: IPackageIdentifier
    {
        public PackageManager PackageManager => PackageManager.Chocolatey;
        
        public string Name { get; set; }
        
        public string Version { get; set; }
    }
}