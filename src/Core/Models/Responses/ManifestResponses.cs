using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models.Responses
{
    public record ManifestSearchResponse(
        PackageSearchResultDto[] Data
    );

    public record PackageSearchResultDto(
        string PackageIdentifier,
        string PackageName,
        string Pablisher,
        PackageVersionDto[] Versions
    );

    public record PackageVersionDto(
        string PackageVersion
    );
}
