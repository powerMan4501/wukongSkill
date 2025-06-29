using System.Globalization;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

internal class NtlmClient : ISessionAuthenticationModule, IAuthenticationModule
{
	internal const string AuthType = "NTLM";

	internal static string Signature = "NTLM".ToLower(CultureInfo.InvariantCulture);

	internal static int SignatureSize = Signature.Length;

	public bool CanPreAuthenticate => true;

	public string AuthenticationType => "NTLM";

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
		string text = null;
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
				text = ((num == -1) ? challenge.Substring(num2) : challenge.Substring(num2, num - num2));
			}
			nTAuthentication = httpWebRequest.CurrentAuthenticationState.GetSecurityContext(this);
		}
		if (nTAuthentication == null)
		{
			NetworkCredential credential = credentials.GetCredential(httpWebRequest.ChallengedUri, Signature);
			string empty = string.Empty;
			if (credential == null || (!(credential is SystemNetworkCredential) && (empty = credential.InternalGetUserName()).Length == 0))
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
			nTAuthentication = new NTAuthentication("NTLM", credential, computeSpn, httpWebRequest, channelBinding);
			httpWebRequest.CurrentAuthenticationState.SetSecurityContext(nTAuthentication, this);
		}
		string outgoingBlob = nTAuthentication.GetOutgoingBlob(text);
		if (outgoingBlob == null)
		{
			return null;
		}
		bool unsafeOrProxyAuthenticatedConnectionSharing = httpWebRequest.UnsafeOrProxyAuthenticatedConnectionSharing;
		if (unsafeOrProxyAuthenticatedConnectionSharing)
		{
			httpWebRequest.LockConnection = true;
		}
		httpWebRequest.NtlmKeepAlive = text == null;
		return AuthenticationManager.GetGroupAuthorization(this, "NTLM " + outgoingBlob, nTAuthentication.IsCompleted, nTAuthentication, unsafeOrProxyAuthenticatedConnectionSharing, mutualAuth: false);
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
		if (!securityContext.IsCompleted && httpWebRequest.CurrentAuthenticationState.StatusCodeMatch == httpWebRequest.ResponseStatusCode)
		{
			return false;
		}
		ClearSession(httpWebRequest);
		if (!httpWebRequest.UnsafeOrProxyAuthenticatedConnectionSharing)
		{
			httpWebRequest.ServicePoint.ReleaseConnectionGroup(httpWebRequest.GetConnectionGroupLine());
		}
		httpWebRequest.ServicePoint.SetCachedChannelBinding(httpWebRequest.ChallengedUri, securityContext.ChannelBinding);
		return true;
	}

	public void ClearSession(WebRequest webRequest)
	{
		HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
		httpWebRequest.CurrentAuthenticationState.ClearSession();
	}
}
