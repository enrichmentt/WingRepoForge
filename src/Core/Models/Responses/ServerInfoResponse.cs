using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WingRepoForge.Core.Models.Responses
{
    public record ServerInformationResponse(
            string SourceIdentifier,
            string ServerVersion,
            string ProtocolVersion
        );

    public record ManifestSearchCapabilityResponse(
        string[] SupportedQueryMethods
    );
}
