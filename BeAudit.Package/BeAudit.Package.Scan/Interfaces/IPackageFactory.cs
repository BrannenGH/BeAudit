using BeAudit.Package.Interfaces;

namespace BeAudit.Package.Scan.Interfaces
{
    public interface IPackageFactory
    {
        IPackage CreatePackage(IPackageIdentifier packageInfo);
    }
}