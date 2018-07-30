using System;
using BeAudit.Package.Enumerations;
using BeAudit.Package.Interfaces;
using BeAudit.Package.Scan.Interfaces;

namespace BeAudit.Package.Scan.Scanners
{
    public static class BowerScanner
    {
        public static IPackage Scan(IPackageIdentifier bowerPackage)
        {
            // Can only handle Bower objects.
            if (bowerPackage.PackageManager != PackageManager.Bower)
                throw new TypeAccessException("BowerScanner can only handle Bower dependencies!");
          
            
        }
    }
}