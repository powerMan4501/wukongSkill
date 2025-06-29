using System.Collections;
using System.Collections.Specialized;

namespace System.Net;

internal abstract class AuthenticationManagerBase : IAuthenticationManager
{
	private static volatile ICredentialPolicy s_ICredentialPolicy;

	private static SpnDictionary m_SpnDictionary = new SpnDictionary();

	private static TriState s_OSSupportsExtendedProtection = TriState.Unspecified;

	private static TriState s_SspSupportsExtendedProtection = TriState.Unspecified;

	public ICredentialPolicy CredentialPolicy
	{
		get
		{
			return s_ICredentialPolicy;
		}
		set
		{
			s_ICredentialPolicy = value;
		}
	}

	public StringDictionary CustomTargetNameDictionary => m_SpnDictionary;

	public SpnDictionary SpnDictionary => m_SpnDictionary;

	public bool OSSupportsExtendedProtection
	{
		get
		{
			if (s_OSSupportsExtendedProtection == TriState.Unspecified)
			{
				if (ComNetOS.IsWin7orLater)
				{
					s_OSSupportsExtendedProtection = TriState.True;
				}
				else if (SspSupportsExtendedProtection)
				{
					if (UnsafeNclNativeMethods.HttpApi.ExtendedProtectionSupported)
					{
						s_OSSupportsExtendedProtection = TriState.True;
					}
					else
					{
						s_OSSupportsExtendedProtection = TriState.False;
					}
				}
				else
				{
					s_OSSupportsExtendedProtection = TriState.False;
				}
			}
			return s_OSSupportsExtendedProtection == TriState.True;
		}
	}

	public bool SspSupportsExtendedProtection
	{
		get
		{
			if (s_SspSupportsExtendedProtection == TriState.Unspecified)
			{
				if (ComNetOS.IsWin7orLater)
				{
					s_SspSupportsExtendedProtection = TriState.True;
				}
				else
				{
					ContextFlags requestedContextFlags = ContextFlags.Connection | ContextFlags.AcceptIntegrity;
					NTAuthentication nTAuthentication = new NTAuthentication(isServer: false, "NTLM", SystemNetworkCredential.defaultCredential, "http/localhost", requestedContextFlags, null);
					try
					{
						NTAuthentication nTAuthentication2 = new NTAuthentication(isServer: true, "NTLM", SystemNetworkCredential.defaultCredential, null, ContextFlags.Connection, null);
						try
						{
							byte[] incomingBlob = null;
							while (!nTAuthentication2.IsCompleted)
							{
								incomingBlob = nTAuthentication.GetOutgoingBlob(incomingBlob, throwOnError: true, out var statusCode);
								incomingBlob = nTAuthentication2.GetOutgoingBlob(incomingBlob, throwOnError: true, out statusCode);
							}
							if (nTAuthentication2.OSSupportsExtendedProtection)
							{
								s_SspSupportsExtendedProtection = TriState.True;
							}
							else
							{
								if (Logging.On)
								{
									Logging.PrintWarning(Logging.Web, SR.GetString("net_ssp_dont_support_cbt"));
								}
								s_SspSupportsExtendedProtection = TriState.False;
							}
						}
						finally
						{
							nTAuthentication2.CloseContext();
						}
					}
					finally
					{
						nTAuthentication.CloseContext();
					}
				}
			}
			return s_SspSupportsExtendedProtection == TriState.True;
		}
	}

	public abstract IEnumerator RegisteredModules { get; }

	public virtual void EnsureConfigLoaded()
	{
	}

	public abstract Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

	public abstract Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

	public abstract void Register(IAuthenticationModule authenticationModule);

	public abstract void Unregister(IAuthenticationModule authenticationModule);

	public abstract void Unregister(string authenticationScheme);

	public abstract void BindModule(Uri uri, Authorization response, IAuthenticationModule module);

	protected static string generalize(Uri location)
	{
		string components = location.GetComponents(UriComponents.SchemeAndServer | UriComponents.UserInfo | UriComponents.Path, UriFormat.UriEscaped);
		int num = components.LastIndexOf('/');
		if (num < 0)
		{
			return components;
		}
		return components.Substring(0, num + 1);
	}
}
