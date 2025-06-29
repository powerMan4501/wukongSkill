using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

internal class NegotiateClient : ISessionAuthenticationModule, IAuthenticationModule
{
	internal const string AuthType = "Negotiate";

	private const string negotiateHeader = "Negotiate";

	private const string negotiateSignature = "negotiate";

	private const string nego2Header = "Nego2";

	private const string nego2Signature = "nego2";

	public bool CanPreAuthenticate => true;

	public string AuthenticationType => "Negotiate";

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
		bool useNego = false;
		if (!preAuthenticate)
		{
			int num = GetSignatureIndex(challenge, out useNego);
			if (num < 0)
			{
				return null;
			}
			int num2 = num + (useNego ? "nego2".Length : "negotiate".Length);
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
			NetworkCredential credential = credentials.GetCredential(httpWebRequest.ChallengedUri, "negotiate");
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
			nTAuthentication = new NTAuthentication("Negotiate", credential, computeSpn, httpWebRequest, channelBinding);
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
		httpWebRequest.NtlmKeepAlive = text == null && nTAuthentication.IsValidContext && !nTAuthentication.IsKerberos;
		return AuthenticationManager.GetGroupAuthorization(this, (useNego ? "Nego2" : "Negotiate") + " " + outgoingBlob, nTAuthentication.IsCompleted, nTAuthentication, unsafeOrProxyAuthenticatedConnectionSharing, nTAuthentication.IsKerberos);
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
		if (!httpWebRequest.UnsafeOrProxyAuthenticatedConnectionSharing)
		{
			httpWebRequest.ServicePoint.ReleaseConnectionGroup(httpWebRequest.GetConnectionGroupLine());
		}
		bool useNego = true;
		int num = ((challenge == null) ? (-1) : GetSignatureIndex(challenge, out useNego));
		if (num >= 0)
		{
			int num2 = num + (useNego ? "nego2".Length : "negotiate".Length);
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

	private static int GetSignatureIndex(string challenge, out bool useNego2)
	{
		useNego2 = true;
		int num = -1;
		if (ComNetOS.IsWin7orLater)
		{
			num = AuthenticationManager.FindSubstringNotInQuotes(challenge, "nego2");
		}
		if (num < 0)
		{
			useNego2 = false;
			num = AuthenticationManager.FindSubstringNotInQuotes(challenge, "negotiate");
		}
		return num;
	}
}
