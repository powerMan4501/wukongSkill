using System;
using System.Net;

namespace Microsoft.Win32;

public class IntranetZoneCredentialPolicy : ICredentialPolicy
{
	private const int URLZONE_INTRANET = 1;

	private IInternetSecurityManager _ManagerRef;

	public IntranetZoneCredentialPolicy()
	{
		ExceptionHelper.ControlPolicyPermission.Demand();
		_ManagerRef = (IInternetSecurityManager)new InternetSecurityManager();
	}

	public virtual bool ShouldSendCredential(Uri challengeUri, WebRequest request, NetworkCredential credential, IAuthenticationModule authModule)
	{
		_ManagerRef.MapUrlToZone(challengeUri.AbsoluteUri, out var pdwZone, 0);
		return pdwZone == 1;
	}
}
