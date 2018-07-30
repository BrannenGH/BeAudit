using BeAudit.Package.Interfaces;
using BeAudit.Package.Scan.Interfaces;

namespace BeAudit.Package.Scan.Factories
{
    public class PackageFactory : IPackageFactory
    {
        public IPackage CreatePackage(IPackageIdentifier packageInfo)
        {
            return null;
        }
    }
}