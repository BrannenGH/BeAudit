using System.Collections.Generic;
using System.Linq;
using BeAudit.Package.Interfaces;
using BeAudit.Package.Parse.Interfaces;
using BeAudit.Package.Parse.PackageIdentifiers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BeAudit.Package.Parse.Parsers
{
    internal class BowerParser: IParser
    {
        public static IEnumerable<IPackageIdentifier> Parse(JsonReader reader)
        {
            IEnumerable<IPackageIdentifier> packages = new List<IPackageIdentifier>();
            while (reader.Read())
            {
                if ((!reader.Path.Equals("dependencies") && 
                     !reader.Path.Equals("devDependencies")) ||
                    reader.TokenType != JsonToken.StartObject) 
                    continue;
                 
                var dependencies = JObject.Load(reader).Properties();

                packages = packages.Concat(
                    from dependency in dependencies
                    select new BowerPackageIdentifier()
                    {
                        Name = dependency.Name,
                        Version = (string) dependency.Value
                    }
                );
            }
            return packages;
        }
    }
}