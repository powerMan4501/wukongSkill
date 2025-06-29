using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Permissions;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ManifestSignatureInformationCollection : ReadOnlyCollection<ManifestSignatureInformation>
{
	internal ManifestSignatureInformationCollection(IList<ManifestSignatureInformation> signatureInformation)
		: base(signatureInformation)
	{
	}
}
