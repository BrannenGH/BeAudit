using System.Collections.Generic;
using System.IO;
using System.Security;
using BeAudit.Package.Enumerations;
using BeAudit.Package.Interfaces;
using BeAudit.Package.Parse.Parsers;
using Newtonsoft.Json;

namespace BeAudit.Package.Parse.Factories
{
    public class PackagePropertiesFactory
    {
        public IEnumerable<IPackageIdentifier> CreatePackageIdentifiersFromStream(PackageManager packageManager,
                                                                                  Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                switch (packageManager)
                {
                    case PackageManager.Bower:
                        JsonReader jsonReader = new JsonTextReader(reader);
                        return BowerParser.Parse(jsonReader);
                    default:
                        return null;
                }
            }
        }
    }
}