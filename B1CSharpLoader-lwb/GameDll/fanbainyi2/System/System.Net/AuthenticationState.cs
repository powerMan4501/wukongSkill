using System.Net.Security;

namespace System.Net;

internal class AuthenticationState
{
	private bool TriedPreAuth;

	internal Authorization Authorization;

	internal IAuthenticationModule Module;

	internal string UniqueGroupId;

	private bool IsProxyAuth;

	internal Uri ChallengedUri;

	private SpnToken ChallengedSpn;

	private NTAuthentication SecurityContext;

	private TransportContext _TransportContext;

	internal TransportContext TransportContext
	{
		get
		{
			return _TransportContext;
		}
		set
		{
			_TransportContext = value;
		}
	}

	internal HttpResponseHeader AuthenticateHeader
	{
		get
		{
			if (!IsProxyAuth)
			{
				return HttpResponseHeader.WwwAuthenticate;
			}
			return HttpResponseHeader.ProxyAuthenticate;
		}
	}

	internal string AuthorizationHeader
	{
		get
		{
			if (!IsProxyAuth)
			{
				return "Authorization";
			}
			return "Proxy-Authorization";
		}
	}

	internal HttpStatusCode StatusCodeMatch
	{
		get
		{
			if (!IsProxyAuth)
			{
				return HttpStatusCode.Unauthorized;
			}
			return HttpStatusCode.ProxyAuthenticationRequired;
		}
	}

	internal NTAuthentication GetSecurityContext(IAuthenticationModule module)
	{
		if (module != Module)
		{
			return null;
		}
		return SecurityContext;
	}

	internal void SetSecurityContext(NTAuthentication securityContext, IAuthenticationModule module)
	{
		SecurityContext = securityContext;
	}

	internal AuthenticationState(bool isProxyAuth)
	{
		IsProxyAuth = isProxyAuth;
	}

	private void PrepareState(HttpWebRequest httpWebRequest)
	{
		Uri uri = (IsProxyAuth ? httpWebRequest.ServicePoint.InternalAddress : httpWebRequest.GetRemoteResourceUri());
		if ((object)ChallengedUri != uri)
		{
			if ((object)ChallengedUri == null || (object)ChallengedUri.Scheme != uri.Scheme || ChallengedUri.Host != uri.Host || ChallengedUri.Port != uri.Port)
			{
				ChallengedSpn = null;
			}
			ChallengedUri = uri;
		}
		httpWebRequest.CurrentAuthenticationState = this;
	}

	internal SpnToken GetComputeSpn(HttpWebRequest httpWebRequest)
	{
		if (ChallengedSpn != null)
		{
			return ChallengedSpn;
		}
		bool flag = true;
		string parts = httpWebRequest.ChallengedUri.GetParts(UriComponents.SchemeAndServer | UriComponents.Path, UriFormat.SafeUnescaped);
		SpnToken spnToken = AuthenticationManager.SpnDictionary.InternalGet(parts);
		if (spnToken == null || spnToken.Spn == null)
		{
			string text;
			if (!IsProxyAuth && (httpWebRequest.ServicePoint.InternalProxyServicePoint || httpWebRequest.UseCustomHost))
			{
				text = httpWebRequest.ChallengedUri.Host;
				if (httpWebRequest.ChallengedUri.HostNameType != UriHostNameType.IPv6 && httpWebRequest.ChallengedUri.HostNameType != UriHostNameType.IPv4 && text.IndexOf('.') == -1)
				{
					try
					{
						if (Dns.TryInternalResolve(text, out var result))
						{
							text = result.HostName;
							flag &= result.isTrustedHost;
						}
					}
					catch (Exception exception)
					{
						if (NclUtilities.IsFatal(exception))
						{
							throw;
						}
					}
				}
			}
			else
			{
				text = httpWebRequest.ServicePoint.Hostname;
				flag &= httpWebRequest.ServicePoint.IsTrustedHost;
			}
			string spn = "HTTP/" + text;
			parts = httpWebRequest.ChallengedUri.GetParts(UriComponents.SchemeAndServer, UriFormat.SafeUnescaped) + "/";
			spnToken = new SpnToken(spn, flag);
			AuthenticationManager.SpnDictionary.InternalSet(parts, spnToken);
		}
		ChallengedSpn = spnToken;
		return ChallengedSpn;
	}

	internal void PreAuthIfNeeded(HttpWebRequest httpWebRequest, ICredentials authInfo)
	{
		if (TriedPreAuth)
		{
			return;
		}
		TriedPreAuth = true;
		if (authInfo == null)
		{
			return;
		}
		PrepareState(httpWebRequest);
		Authorization authorization = null;
		try
		{
			authorization = AuthenticationManager.PreAuthenticate(httpWebRequest, authInfo);
			if (authorization != null && authorization.Message != null)
			{
				UniqueGroupId = authorization.ConnectionGroupId;
				httpWebRequest.Headers.Set(AuthorizationHeader, authorization.Message);
			}
		}
		catch (Exception)
		{
			ClearSession(httpWebRequest);
		}
	}

	internal bool AttemptAuthenticate(HttpWebRequest httpWebRequest, ICredentials authInfo)
	{
		if (Authorization != null && Authorization.Complete)
		{
			if (IsProxyAuth)
			{
				ClearAuthReq(httpWebRequest);
			}
			return false;
		}
		if (authInfo == null)
		{
			return false;
		}
		string text = httpWebRequest.AuthHeader(AuthenticateHeader);
		if (text == null)
		{
			if (!IsProxyAuth && Authorization != null && httpWebRequest.ProxyAuthenticationState.Authorization != null)
			{
				httpWebRequest.Headers.Set(AuthorizationHeader, Authorization.Message);
			}
			return false;
		}
		PrepareState(httpWebRequest);
		try
		{
			Authorization = AuthenticationManager.Authenticate(text, httpWebRequest, authInfo);
		}
		catch (Exception)
		{
			Authorization = null;
			ClearSession(httpWebRequest);
			throw;
		}
		if (Authorization == null)
		{
			return false;
		}
		if (Authorization.Message == null)
		{
			Authorization = null;
			return false;
		}
		UniqueGroupId = Authorization.ConnectionGroupId;
		try
		{
			httpWebRequest.Headers.Set(AuthorizationHeader, Authorization.Message);
		}
		catch
		{
			Authorization = null;
			ClearSession(httpWebRequest);
			throw;
		}
		return true;
	}

	internal void ClearAuthReq(HttpWebRequest httpWebRequest)
	{
		TriedPreAuth = false;
		Authorization = null;
		UniqueGroupId = null;
		httpWebRequest.Headers.Remove(AuthorizationHeader);
	}

	internal void Update(HttpWebRequest httpWebRequest)
	{
		if (Authorization == null)
		{
			return;
		}
		PrepareState(httpWebRequest);
		if (Module is ISessionAuthenticationModule sessionAuthenticationModule)
		{
			string challenge = httpWebRequest.AuthHeader(AuthenticateHeader);
			if (IsProxyAuth || httpWebRequest.ResponseStatusCode != HttpStatusCode.ProxyAuthenticationRequired)
			{
				bool complete = true;
				try
				{
					complete = sessionAuthenticationModule.Update(challenge, httpWebRequest);
				}
				catch (Exception)
				{
					ClearSession(httpWebRequest);
					if (httpWebRequest.AuthenticationLevel == AuthenticationLevel.MutualAuthRequired && (httpWebRequest.CurrentAuthenticationState == null || httpWebRequest.CurrentAuthenticationState.Authorization == null || !httpWebRequest.CurrentAuthenticationState.Authorization.MutuallyAuthenticated))
					{
						throw;
					}
				}
				Authorization.SetComplete(complete);
			}
		}
		if (httpWebRequest.PreAuthenticate && Module != null && Authorization.Complete && Module.CanPreAuthenticate && httpWebRequest.ResponseStatusCode != StatusCodeMatch)
		{
			AuthenticationManager.BindModule(ChallengedUri, Authorization, Module);
		}
	}

	internal void ClearSession()
	{
		if (SecurityContext != null)
		{
			SecurityContext.CloseContext();
			SecurityContext = null;
		}
	}

	internal void ClearSession(HttpWebRequest httpWebRequest)
	{
		PrepareState(httpWebRequest);
		ISessionAuthenticationModule sessionAuthenticationModule = Module as ISessionAuthenticationModule;
		Module = null;
		if (sessionAuthenticationModule == null)
		{
			return;
		}
		try
		{
			sessionAuthenticationModule.ClearSession(httpWebRequest);
		}
		catch (Exception exception)
		{
			if (NclUtilities.IsFatal(exception))
			{
				throw;
			}
		}
	}
}
