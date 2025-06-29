using System.Globalization;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

internal class DigestClient : ISessionAuthenticationModule, IAuthenticationModule
{
	internal const string AuthType = "Digest";

	internal static string Signature;

	internal static int SignatureSize;

	private static PrefixLookup challengeCache;

	private static readonly char[] singleSpaceArray;

	private static bool _WDigestAvailable;

	public bool CanPreAuthenticate => true;

	public string AuthenticationType => "Digest";

	public bool CanUseDefaultCredentials => WDigestAvailable;

	internal static bool WDigestAvailable => _WDigestAvailable;

	static DigestClient()
	{
		Signature = "Digest".ToLower(CultureInfo.InvariantCulture);
		SignatureSize = Signature.Length;
		challengeCache = new PrefixLookup();
		singleSpaceArray = new char[1] { ' ' };
		_WDigestAvailable = SSPIWrapper.GetVerifyPackageInfo(GlobalSSPI.SSPIAuth, "WDigest") != null;
	}

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
		NetworkCredential credential = credentials.GetCredential(httpWebRequest.ChallengedUri, Signature);
		if (credential is SystemNetworkCredential)
		{
			if (WDigestAvailable)
			{
				return XPDoAuthenticate(challenge, httpWebRequest, credentials, preAuthenticate);
			}
			return null;
		}
		HttpDigestChallenge httpDigestChallenge;
		if (!preAuthenticate)
		{
			int num = AuthenticationManager.FindSubstringNotInQuotes(challenge, Signature);
			if (num < 0)
			{
				return null;
			}
			httpDigestChallenge = HttpDigest.Interpret(challenge, num, httpWebRequest);
		}
		else
		{
			httpDigestChallenge = challengeCache.Lookup(httpWebRequest.ChallengedUri.AbsoluteUri) as HttpDigestChallenge;
		}
		if (httpDigestChallenge == null)
		{
			return null;
		}
		if (!CheckQOP(httpDigestChallenge))
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, SR.GetString("net_log_digest_qop_not_supported", httpDigestChallenge.QualityOfProtection));
			}
			return null;
		}
		if (preAuthenticate)
		{
			httpDigestChallenge = httpDigestChallenge.CopyAndIncrementNonce();
			httpDigestChallenge.SetFromRequest(httpWebRequest);
		}
		if (credential == null)
		{
			return null;
		}
		ICredentialPolicy credentialPolicy = AuthenticationManager.CredentialPolicy;
		if (credentialPolicy != null && !credentialPolicy.ShouldSendCredential(httpWebRequest.ChallengedUri, httpWebRequest, credential, this))
		{
			return null;
		}
		SpnToken computeSpn = httpWebRequest.CurrentAuthenticationState.GetComputeSpn(httpWebRequest);
		ChannelBinding binding = null;
		if (httpWebRequest.CurrentAuthenticationState.TransportContext != null)
		{
			binding = httpWebRequest.CurrentAuthenticationState.TransportContext.GetChannelBinding(ChannelBindingKind.Endpoint);
		}
		Authorization authorization = HttpDigest.Authenticate(httpDigestChallenge, credential, computeSpn.Spn, binding);
		if (!preAuthenticate && webRequest.PreAuthenticate && authorization != null)
		{
			string[] array = ((httpDigestChallenge.Domain != null) ? httpDigestChallenge.Domain.Split(singleSpaceArray) : new string[1] { httpWebRequest.ChallengedUri.GetParts(UriComponents.SchemeAndServer, UriFormat.UriEscaped) });
			authorization.ProtectionRealm = ((httpDigestChallenge.Domain == null) ? null : array);
			for (int i = 0; i < array.Length; i++)
			{
				challengeCache.Add(array[i], httpDigestChallenge);
			}
		}
		return authorization;
	}

	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
	{
		return DoAuthenticate(null, webRequest, credentials, preAuthenticate: true);
	}

	internal static bool CheckQOP(HttpDigestChallenge challenge)
	{
		if (challenge.QopPresent)
		{
			int num;
			for (num = 0; num >= 0; num += "auth".Length)
			{
				num = challenge.QualityOfProtection.IndexOf("auth", num);
				if (num < 0)
				{
					return false;
				}
				if ((num == 0 || ", \"'\t\r\n".IndexOf(challenge.QualityOfProtection[num - 1]) >= 0) && (num + "auth".Length == challenge.QualityOfProtection.Length || ", \"'\t\r\n".IndexOf(challenge.QualityOfProtection[num + "auth".Length]) >= 0))
				{
					break;
				}
			}
		}
		return true;
	}

	public bool Update(string challenge, WebRequest webRequest)
	{
		HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
		if (httpWebRequest.CurrentAuthenticationState.GetSecurityContext(this) != null)
		{
			return XPUpdate(challenge, httpWebRequest);
		}
		if (httpWebRequest.ResponseStatusCode != httpWebRequest.CurrentAuthenticationState.StatusCodeMatch)
		{
			ChannelBinding binding = null;
			if (httpWebRequest.CurrentAuthenticationState.TransportContext != null)
			{
				binding = httpWebRequest.CurrentAuthenticationState.TransportContext.GetChannelBinding(ChannelBindingKind.Endpoint);
			}
			httpWebRequest.ServicePoint.SetCachedChannelBinding(httpWebRequest.ChallengedUri, binding);
			return true;
		}
		int num = ((challenge == null) ? (-1) : AuthenticationManager.FindSubstringNotInQuotes(challenge, Signature));
		if (num < 0)
		{
			return true;
		}
		int num2 = num + SignatureSize;
		string text = null;
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
			text = challenge.Substring(num2);
		}
		HttpDigestChallenge httpDigestChallenge = HttpDigest.Interpret(challenge, num, httpWebRequest);
		if (httpDigestChallenge == null)
		{
			return true;
		}
		return !httpDigestChallenge.Stale;
	}

	public void ClearSession(WebRequest webRequest)
	{
		HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
		httpWebRequest.CurrentAuthenticationState.ClearSession();
	}

	private Authorization XPDoAuthenticate(string challenge, HttpWebRequest httpWebRequest, ICredentials credentials, bool preAuthenticate)
	{
		NTAuthentication nTAuthentication = null;
		string text = null;
		if (!preAuthenticate)
		{
			int num = AuthenticationManager.FindSubstringNotInQuotes(challenge, Signature);
			if (num < 0)
			{
				return null;
			}
			nTAuthentication = httpWebRequest.CurrentAuthenticationState.GetSecurityContext(this);
			text = RefineDigestChallenge(challenge, num);
		}
		else
		{
			if (!(challengeCache.Lookup(httpWebRequest.ChallengedUri.AbsoluteUri) is HttpDigestChallenge httpDigestChallenge))
			{
				return null;
			}
			HttpDigestChallenge httpDigestChallenge2 = httpDigestChallenge.CopyAndIncrementNonce();
			httpDigestChallenge2.SetFromRequest(httpWebRequest);
			text = httpDigestChallenge2.ToBlob();
		}
		UriComponents uriComponents = (UriComponents)0;
		Uri uri = httpWebRequest.GetRemoteResourceUri();
		if (httpWebRequest.CurrentMethod.ConnectRequest)
		{
			uriComponents = UriComponents.HostAndPort;
			uri = httpWebRequest.RequestUri;
		}
		else
		{
			uriComponents = UriComponents.PathAndQuery;
		}
		string parts = uri.GetParts(uriComponents, UriFormat.UriEscaped);
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
			nTAuthentication = new NTAuthentication("WDigest", credential, computeSpn, httpWebRequest, channelBinding);
			httpWebRequest.CurrentAuthenticationState.SetSecurityContext(nTAuthentication, this);
		}
		SecurityStatus statusCode;
		string outgoingDigestBlob = nTAuthentication.GetOutgoingDigestBlob(text, httpWebRequest.CurrentMethod.Name, parts, null, isClientPreAuth: false, throwOnError: false, out statusCode);
		if (outgoingDigestBlob == null)
		{
			return null;
		}
		Authorization authorization = new Authorization("Digest " + outgoingDigestBlob, nTAuthentication.IsCompleted, string.Empty, nTAuthentication.IsMutualAuthFlag);
		if (!preAuthenticate && httpWebRequest.PreAuthenticate)
		{
			HttpDigestChallenge httpDigestChallenge3 = HttpDigest.Interpret(text, -1, httpWebRequest);
			string[] array = ((httpDigestChallenge3.Domain != null) ? httpDigestChallenge3.Domain.Split(singleSpaceArray) : new string[1] { httpWebRequest.ChallengedUri.GetParts(UriComponents.SchemeAndServer, UriFormat.UriEscaped) });
			authorization.ProtectionRealm = ((httpDigestChallenge3.Domain == null) ? null : array);
			for (int i = 0; i < array.Length; i++)
			{
				challengeCache.Add(array[i], httpDigestChallenge3);
			}
		}
		return authorization;
	}

	private bool XPUpdate(string challenge, HttpWebRequest httpWebRequest)
	{
		NTAuthentication securityContext = httpWebRequest.CurrentAuthenticationState.GetSecurityContext(this);
		if (securityContext == null)
		{
			return false;
		}
		int num = ((challenge == null) ? (-1) : AuthenticationManager.FindSubstringNotInQuotes(challenge, Signature));
		if (num < 0)
		{
			httpWebRequest.ServicePoint.SetCachedChannelBinding(httpWebRequest.ChallengedUri, securityContext.ChannelBinding);
			ClearSession(httpWebRequest);
			return true;
		}
		if (httpWebRequest.ResponseStatusCode != httpWebRequest.CurrentAuthenticationState.StatusCodeMatch)
		{
			httpWebRequest.ServicePoint.SetCachedChannelBinding(httpWebRequest.ChallengedUri, securityContext.ChannelBinding);
			ClearSession(httpWebRequest);
			return true;
		}
		string incomingBlob = RefineDigestChallenge(challenge, num);
		SecurityStatus statusCode;
		string outgoingDigestBlob = securityContext.GetOutgoingDigestBlob(incomingBlob, httpWebRequest.CurrentMethod.Name, null, null, isClientPreAuth: false, throwOnError: true, out statusCode);
		httpWebRequest.CurrentAuthenticationState.Authorization.MutuallyAuthenticated = securityContext.IsMutualAuthFlag;
		return securityContext.IsCompleted;
	}

	private static string RefineDigestChallenge(string challenge, int index)
	{
		string text = null;
		int num = index + SignatureSize;
		if (challenge.Length > num && challenge[num] != ',')
		{
			num++;
		}
		else
		{
			index = -1;
		}
		if (index >= 0 && challenge.Length > num)
		{
			text = challenge.Substring(num);
			int num2 = 0;
			int num3 = num2;
			bool flag = true;
			HttpDigestChallenge httpDigestChallenge = new HttpDigestChallenge();
			int offset;
			while (true)
			{
				offset = num3;
				index = AuthenticationManager.SplitNoQuotes(text, ref offset);
				if (offset < 0)
				{
					break;
				}
				string name = text.Substring(num3, offset - num3);
				string value = ((index >= 0) ? HttpDigest.unquote(text.Substring(offset + 1, index - offset - 1)) : HttpDigest.unquote(text.Substring(offset + 1)));
				flag = httpDigestChallenge.defineAttribute(name, value);
				if (index < 0 || !flag)
				{
					break;
				}
				num3 = ++index;
			}
			if ((!flag || offset < 0) && num3 < text.Length)
			{
				text = ((num3 > 0) ? text.Substring(0, num3 - 1) : "");
			}
			return text;
		}
		Logging.PrintError(Logging.Web, SR.GetString("net_log_auth_invalid_challenge", "Digest"));
		return string.Empty;
	}
}
