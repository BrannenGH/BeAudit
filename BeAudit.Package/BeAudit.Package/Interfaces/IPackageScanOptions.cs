namespace BeAudit.Package.Interfaces
{
    public interface IPackageScanOptions
    {
        string File { get; }

        bool SkipPackagesAudit { get; }

        bool ListPackages { get; }

        bool ListArtifacts { get; }

        bool PrintConfiguration { get; }

        bool ListConfigurationRules { get; }

        bool ListAnalyizers { get; }

        bool OnlyLocalRules { get; }

        /// <summary>
        ///     File to use for the audit run
        /// </summary>
        string Profile { get; }

        string PackageName { get; }

        string PackageVersion { get; }

        bool WithOssi { get; }

        bool WithVulners { get; }

        bool WithLibIo { get; }
    }
}