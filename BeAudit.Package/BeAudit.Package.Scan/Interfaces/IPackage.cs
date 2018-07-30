using System.Collections.Generic;
using BeAudit.Package.Enumerations;
using BeAudit.Package.Interfaces;

namespace BeAudit.Package.Scan.Interfaces
{
    public interface IPackage
    {
        IPackageIdentifier Identifier { get; }

        IEnumerable<IPackage> Dependencies { get; }

        IEnumerable<IVulnerability> Vulnerabilities { get; }
    }
}