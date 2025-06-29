using System.Collections;
using System.Collections.Specialized;

namespace System.Net;

internal interface IAuthenticationManager
{
	ICredentialPolicy CredentialPolicy { get; set; }

	StringDictionary CustomTargetNameDictionary { get; }

	SpnDictionary SpnDictionary { get; }

	bool OSSupportsExtendedProtection { get; }

	bool SspSupportsExtendedProtection { get; }

	IEnumerator RegisteredModules { get; }

	void EnsureConfigLoaded();

	Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

	Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

	void Register(IAuthenticationModule authenticationModule);

	void Unregister(IAuthenticationModule authenticationModule);

	void Unregister(string authenticationScheme);

	void BindModule(Uri uri, Authorization response, IAuthenticationModule module);
}
