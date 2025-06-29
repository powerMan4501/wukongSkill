using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Configuration;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

internal class AuthenticationManager2 : AuthenticationManagerBase
{
	private PrefixLookup moduleBinding;

	private ConcurrentDictionary<string, IAuthenticationModule> moduleList;

	public override IEnumerator RegisteredModules => moduleList.Values.GetEnumerator();

	public AuthenticationManager2()
	{
		moduleBinding = new PrefixLookup();
		InitializeModuleList();
	}

	public AuthenticationManager2(int maxPrefixLookupEntries)
	{
		moduleBinding = new PrefixLookup(maxPrefixLookupEntries);
		InitializeModuleList();
	}

	public override Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (credentials == null)
		{
			throw new ArgumentNullException("credentials");
		}
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		Authorization authorization = null;
		HttpWebRequest httpWebRequest = request as HttpWebRequest;
		if (httpWebRequest != null && httpWebRequest.CurrentAuthenticationState.Module != null)
		{
			authorization = httpWebRequest.CurrentAuthenticationState.Module.Authenticate(challenge, request, credentials);
		}
		else
		{
			foreach (IAuthenticationModule value in moduleList.Values)
			{
				if (httpWebRequest != null)
				{
					httpWebRequest.CurrentAuthenticationState.Module = value;
				}
				authorization = value.Authenticate(challenge, request, credentials);
				if (authorization != null)
				{
					break;
				}
			}
		}
		return authorization;
	}

	public override Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (credentials == null)
		{
			return null;
		}
		if (!(request is HttpWebRequest httpWebRequest))
		{
			return null;
		}
		if (!(moduleBinding.Lookup(httpWebRequest.ChallengedUri.AbsoluteUri) is string text))
		{
			return null;
		}
		if (!moduleList.TryGetValue(text.ToUpperInvariant(), out var value))
		{
			return null;
		}
		if (httpWebRequest.ChallengedUri.Scheme == Uri.UriSchemeHttps)
		{
			object cachedChannelBinding = httpWebRequest.ServicePoint.CachedChannelBinding;
			if (cachedChannelBinding is ChannelBinding binding)
			{
				httpWebRequest.CurrentAuthenticationState.TransportContext = new CachedTransportContext(binding);
			}
		}
		Authorization authorization = value.PreAuthenticate(request, credentials);
		if (authorization != null && !authorization.Complete && httpWebRequest != null)
		{
			httpWebRequest.CurrentAuthenticationState.Module = value;
		}
		return authorization;
	}

	public override void Register(IAuthenticationModule authenticationModule)
	{
		if (authenticationModule == null)
		{
			throw new ArgumentNullException("authenticationModule");
		}
		string key = authenticationModule.AuthenticationType.ToUpperInvariant();
		moduleList.AddOrUpdate(key, authenticationModule, (string text, IAuthenticationModule value) => authenticationModule);
	}

	public override void Unregister(IAuthenticationModule authenticationModule)
	{
		if (authenticationModule == null)
		{
			throw new ArgumentNullException("authenticationModule");
		}
		string normalizedAuthenticationType = authenticationModule.AuthenticationType.ToUpperInvariant();
		UnregisterInternal(normalizedAuthenticationType);
	}

	public override void Unregister(string authenticationScheme)
	{
		if (authenticationScheme == null)
		{
			throw new ArgumentNullException("authenticationScheme");
		}
		string normalizedAuthenticationType = authenticationScheme.ToUpperInvariant();
		UnregisterInternal(normalizedAuthenticationType);
	}

	public override void BindModule(Uri uri, Authorization response, IAuthenticationModule module)
	{
		if (response.ProtectionRealm != null)
		{
			string[] protectionRealm = response.ProtectionRealm;
			for (int i = 0; i < protectionRealm.Length; i++)
			{
				moduleBinding.Add(protectionRealm[i], module.AuthenticationType.ToUpperInvariant());
			}
		}
		else
		{
			string prefix = AuthenticationManagerBase.generalize(uri);
			moduleBinding.Add(prefix, module.AuthenticationType);
		}
	}

	private void InitializeModuleList()
	{
		List<Type> authenticationModules = AuthenticationModulesSectionInternal.GetSection().AuthenticationModules;
		moduleList = new ConcurrentDictionary<string, IAuthenticationModule>();
		IAuthenticationModule moduleToRegister;
		foreach (Type item in authenticationModules)
		{
			try
			{
				moduleToRegister = Activator.CreateInstance(item, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[0], CultureInfo.InvariantCulture) as IAuthenticationModule;
				if (moduleToRegister != null)
				{
					string key = moduleToRegister.AuthenticationType.ToUpperInvariant();
					moduleList.AddOrUpdate(key, moduleToRegister, (string text, IAuthenticationModule value) => moduleToRegister);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	private void UnregisterInternal(string normalizedAuthenticationType)
	{
		if (!moduleList.TryRemove(normalizedAuthenticationType, out var _))
		{
			throw new InvalidOperationException(SR.GetString("net_authmodulenotregistered"));
		}
	}
}
