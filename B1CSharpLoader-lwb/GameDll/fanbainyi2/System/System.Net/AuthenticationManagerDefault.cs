using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Configuration;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;
using System.Threading;

namespace System.Net;

internal class AuthenticationManagerDefault : AuthenticationManagerBase
{
	private PrefixLookup moduleBinding = new PrefixLookup();

	private volatile ArrayList moduleList;

	private ArrayList ModuleList
	{
		get
		{
			if (moduleList == null)
			{
				lock (moduleBinding)
				{
					if (moduleList == null)
					{
						List<Type> authenticationModules = AuthenticationModulesSectionInternal.GetSection().AuthenticationModules;
						ArrayList arrayList = new ArrayList();
						foreach (Type item in authenticationModules)
						{
							try
							{
								if (Activator.CreateInstance(item, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[0], CultureInfo.InvariantCulture) is IAuthenticationModule authenticationModule)
								{
									RemoveAuthenticationType(arrayList, authenticationModule.AuthenticationType);
									arrayList.Add(authenticationModule);
								}
							}
							catch (Exception)
							{
							}
						}
						moduleList = arrayList;
					}
				}
			}
			return moduleList;
		}
	}

	public override IEnumerator RegisteredModules => ModuleList.GetEnumerator();

	public override void EnsureConfigLoaded()
	{
		try
		{
			object obj = ModuleList;
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is OutOfMemoryException || ex is StackOverflowException)
			{
				throw;
			}
		}
	}

	private static void RemoveAuthenticationType(ArrayList list, string typeToRemove)
	{
		for (int i = 0; i < list.Count; i++)
		{
			if (string.Compare(((IAuthenticationModule)list[i]).AuthenticationType, typeToRemove, StringComparison.OrdinalIgnoreCase) == 0)
			{
				list.RemoveAt(i);
				break;
			}
		}
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
			lock (moduleBinding)
			{
				for (int i = 0; i < ModuleList.Count; i++)
				{
					IAuthenticationModule authenticationModule = (IAuthenticationModule)ModuleList[i];
					if (httpWebRequest != null)
					{
						httpWebRequest.CurrentAuthenticationState.Module = authenticationModule;
					}
					authorization = authenticationModule.Authenticate(challenge, request, credentials);
					if (authorization != null)
					{
						break;
					}
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
		if (!(moduleBinding.Lookup(httpWebRequest.ChallengedUri.AbsoluteUri) is string authenticationType))
		{
			return null;
		}
		IAuthenticationModule authenticationModule = findModule(authenticationType);
		if (authenticationModule == null)
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
		Authorization authorization = authenticationModule.PreAuthenticate(request, credentials);
		if (authorization != null && !authorization.Complete && httpWebRequest != null)
		{
			httpWebRequest.CurrentAuthenticationState.Module = authenticationModule;
		}
		return authorization;
	}

	public override void Register(IAuthenticationModule authenticationModule)
	{
		if (authenticationModule == null)
		{
			throw new ArgumentNullException("authenticationModule");
		}
		lock (moduleBinding)
		{
			IAuthenticationModule authenticationModule2 = findModule(authenticationModule.AuthenticationType);
			if (authenticationModule2 != null)
			{
				ModuleList.Remove(authenticationModule2);
			}
			ModuleList.Add(authenticationModule);
		}
	}

	public override void Unregister(IAuthenticationModule authenticationModule)
	{
		if (authenticationModule == null)
		{
			throw new ArgumentNullException("authenticationModule");
		}
		lock (moduleBinding)
		{
			if (!ModuleList.Contains(authenticationModule))
			{
				throw new InvalidOperationException(SR.GetString("net_authmodulenotregistered"));
			}
			ModuleList.Remove(authenticationModule);
		}
	}

	public override void Unregister(string authenticationScheme)
	{
		if (authenticationScheme == null)
		{
			throw new ArgumentNullException("authenticationScheme");
		}
		lock (moduleBinding)
		{
			IAuthenticationModule authenticationModule = findModule(authenticationScheme);
			if (authenticationModule == null)
			{
				throw new InvalidOperationException(SR.GetString("net_authschemenotregistered"));
			}
			ModuleList.Remove(authenticationModule);
		}
	}

	public override void BindModule(Uri uri, Authorization response, IAuthenticationModule module)
	{
		if (response.ProtectionRealm != null)
		{
			string[] protectionRealm = response.ProtectionRealm;
			for (int i = 0; i < protectionRealm.Length; i++)
			{
				moduleBinding.Add(protectionRealm[i], module.AuthenticationType);
			}
		}
		else
		{
			string prefix = AuthenticationManagerBase.generalize(uri);
			moduleBinding.Add(prefix, module.AuthenticationType);
		}
	}

	private IAuthenticationModule findModule(string authenticationType)
	{
		IAuthenticationModule result = null;
		ArrayList arrayList = ModuleList;
		for (int i = 0; i < arrayList.Count; i++)
		{
			IAuthenticationModule authenticationModule = (IAuthenticationModule)arrayList[i];
			if (string.Compare(authenticationModule.AuthenticationType, authenticationType, StringComparison.OrdinalIgnoreCase) == 0)
			{
				result = authenticationModule;
				break;
			}
		}
		return result;
	}
}
