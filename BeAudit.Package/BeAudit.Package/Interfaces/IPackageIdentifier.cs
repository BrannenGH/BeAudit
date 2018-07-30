using BeAudit.Package.Enumerations;

namespace BeAudit.Package.Interfaces
{
    public interface IPackageIdentifier
    {
        PackageManager PackageManager { get; }
        
        string Name { get; }
        
        string Version { get; }
        
        string Coordinates { get; }
    }
}