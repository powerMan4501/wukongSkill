using System.Globalization;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

internal class KerberosClient : ISessionAuthenticationModule, IAuthenticationModule
{
	internal const string AuthType = "Kerberos";

	internal static string Signature = "Kerberos".ToLower(CultureInfo.InvariantCulture);

	internal static int SignatureSize = Signature.Length;

	public bool CanPreAuthenticate => true;

	public string AuthenticationType => "Kerberos";

	public bool CanUseDefaultCredentials => true;

	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
	{
		return DoAuthenticate(challenge, webRequest, credentials, preAuthenticate: false);
	}

	private Authorization DoAuthenticate(string challenge, WebRequest webRequest, ICredentials credentials, bool preAuthenticate)
	{
		if (credentials == null)
		{
			return null;
		}
		HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
		NTAuthentication nTAuthentication = null;
		string incomingBlob = null;
		if (!preAuthenticate)
		{
			int num = AuthenticationManager.FindSubstringNotInQuotes(challenge, Signature);
			if (num < 0)
			{
				return null;
			}
			int num2 = num + SignatureSize;
			if (challenge.Length > num2 && challenge[num2] != ',')
			{
				num2++;
			}
			else
			{
				num = -1;
			}
			if (num >= 0 && challenge.Length > num2)
			{
				num = challenge.IndexOf(',', num2);
				incomingBlob = ((num == -1) ? challenge.Substring(num2) : challenge.Substring(num2, num - num2));
			}
			nTAuthentication = httpWebRequest.CurrentAuthenticationState.GetSecurityContext(this);
		}
		if (nTAuthentication == null)
		{
			NetworkCredential credential = credentials.GetCredential(httpWebRequest.ChallengedUri, Signature);
			if (credential == null || (!(credential is SystemNetworkCredential) && credential.InternalGetUserName().Length == 0))
			{
				return null;
			}
			ICredentialPolicy credentialPolicy = AuthenticationManager.CredentialPolicy;
			if (credentialPolicy != null && !credentialPolicy.ShouldSendCredential(httpWebRequest.ChallengedUri, httpWebRequest, credential, this))
			{
				return null;
			}
			SpnToken computeSpn = httpWebRequest.CurrentAuthenticationState.GetComputeSpn(httpWebRequest);
			ChannelBinding channelBinding = null;
			if (httpWebRequest.CurrentAuthenticationState.TransportContext != null)
			{
				channelBinding = httpWebRequest.CurrentAuthenticationState.TransportContext.GetChannelBinding(ChannelBindingKind.Endpoint);
			}
			nTAuthentication = new NTAuthentication("Kerberos", credential, computeSpn, httpWebRequest, channelBinding);
			httpWebRequest.CurrentAuthenticationState.SetSecurityContext(nTAuthentication, this);
		}
		string outgoingBlob = nTAuthentication.GetOutgoingBlob(incomingBlob);
		if (outgoingBlob == null)
		{
			return null;
		}
		return new Authorization("Kerberos " + outgoingBlob, nTAuthentication.IsCompleted, string.Empty, nTAuthentication.IsMutualAuthFlag);
	}

	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
	{
		return DoAuthenticate(null, webRequest, credentials, preAuthenticate: true);
	}

	public bool Update(string challenge, WebRequest webRequest)
	{
		HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
		NTAuthentication securityContext = httpWebRequest.CurrentAuthenticationState.GetSecurityContext(this);
		if (securityContext == null)
		{
			return true;
		}
		if (httpWebRequest.CurrentAuthenticationState.StatusCodeMatch == httpWebRequest.ResponseStatusCode)
		{
			return false;
		}
		int num = ((challenge == null) ? (-1) : AuthenticationManager.FindSubstringNotInQuotes(challenge, Signature));
		if (num >= 0)
		{
			int num2 = num + SignatureSize;
			string incomingBlob = null;
			if (challenge.Length > num2 && challenge[num2] != ',')
			{
				num2++;
			}
			else
			{
				num = -1;
			}
			if (num >= 0 && challenge.Length > num2)
			{
				incomingBlob = challenge.Substring(num2);
			}
			string outgoingBlob = securityContext.GetOutgoingBlob(incomingBlob);
			httpWebRequest.CurrentAuthenticationState.Authorization.MutuallyAuthenticated = securityContext.IsMutualAuthFlag;
		}
		httpWebRequest.ServicePoint.SetCachedChannelBinding(httpWebRequest.ChallengedUri, securityContext.ChannelBinding);
		ClearSession(httpWebRequest);
		return true;
	}

	public void ClearSession(WebRequest webRequest)
	{
		HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
		httpWebRequest.CurrentAuthenticationState.ClearSession();
	}
}
