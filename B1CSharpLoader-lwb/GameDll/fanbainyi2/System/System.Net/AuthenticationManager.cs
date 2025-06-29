using System.Collections;
using System.Collections.Specialized;
using System.Threading;

namespace System.Net;

public class AuthenticationManager
{
	private static object instanceLock = new object();

	private static IAuthenticationManager internalInstance = null;

	internal const string authenticationManagerRoot = "System.Net.AuthenticationManager";

	internal const string configHighPerformance = "System.Net.AuthenticationManager.HighPerformance";

	internal const string configPrefixLookupMaxCount = "System.Net.AuthenticationManager.PrefixLookupMaxCount";

	private static IAuthenticationManager Instance
	{
		get
		{
			if (internalInstance == null)
			{
				lock (instanceLock)
				{
					if (internalInstance == null)
					{
						internalInstance = SelectAuthenticationManagerInstance();
					}
				}
			}
			return internalInstance;
		}
	}

	public static ICredentialPolicy CredentialPolicy
	{
		get
		{
			return Instance.CredentialPolicy;
		}
		set
		{
			ExceptionHelper.ControlPolicyPermission.Demand();
			Instance.CredentialPolicy = value;
		}
	}

	public static StringDictionary CustomTargetNameDictionary => Instance.CustomTargetNameDictionary;

	internal static SpnDictionary SpnDictionary => Instance.SpnDictionary;

	internal static bool OSSupportsExtendedProtection => Instance.OSSupportsExtendedProtection;

	internal static bool SspSupportsExtendedProtection => Instance.SspSupportsExtendedProtection;

	public static IEnumerator RegisteredModules => Instance.RegisteredModules;

	private AuthenticationManager()
	{
	}

	private static IAuthenticationManager SelectAuthenticationManagerInstance()
	{
		bool flag = false;
		try
		{
			if (RegistryConfiguration.GlobalConfigReadInt("System.Net.AuthenticationManager.HighPerformance", 0) == 1)
			{
				flag = true;
			}
			else if (RegistryConfiguration.AppConfigReadInt("System.Net.AuthenticationManager.HighPerformance", 0) == 1)
			{
				flag = true;
			}
			if (flag)
			{
				int? num = ReadPrefixLookupMaxEntriesConfig();
				if (num.HasValue && num > 0)
				{
					return new AuthenticationManager2(num.Value);
				}
				return new AuthenticationManager2();
			}
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
		}
		return new AuthenticationManagerDefault();
	}

	private static int? ReadPrefixLookupMaxEntriesConfig()
	{
		int? result = null;
		int num = RegistryConfiguration.GlobalConfigReadInt("System.Net.AuthenticationManager.PrefixLookupMaxCount", -1);
		if (num > 0)
		{
			result = num;
		}
		num = RegistryConfiguration.AppConfigReadInt("System.Net.AuthenticationManager.PrefixLookupMaxCount", -1);
		if (num > 0)
		{
			result = num;
		}
		return result;
	}

	internal static void EnsureConfigLoaded()
	{
		Instance.EnsureConfigLoaded();
	}

	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
	{
		return Instance.Authenticate(challenge, request, credentials);
	}

	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
	{
		return Instance.PreAuthenticate(request, credentials);
	}

	public static void Register(IAuthenticationModule authenticationModule)
	{
		ExceptionHelper.UnmanagedPermission.Demand();
		Instance.Register(authenticationModule);
	}

	public static void Unregister(IAuthenticationModule authenticationModule)
	{
		ExceptionHelper.UnmanagedPermission.Demand();
		Instance.Unregister(authenticationModule);
	}

	public static void Unregister(string authenticationScheme)
	{
		ExceptionHelper.UnmanagedPermission.Demand();
		Instance.Unregister(authenticationScheme);
	}

	internal static void BindModule(Uri uri, Authorization response, IAuthenticationModule module)
	{
		Instance.BindModule(uri, response, module);
	}

	internal static int FindSubstringNotInQuotes(string challenge, string signature)
	{
		int num = -1;
		if (challenge != null && signature != null && challenge.Length >= signature.Length)
		{
			int num2 = -1;
			int num3 = -1;
			for (int i = 0; i < challenge.Length; i++)
			{
				if (num >= 0)
				{
					break;
				}
				if (challenge[i] == '"')
				{
					if (num2 <= num3)
					{
						num2 = i;
					}
					else
					{
						num3 = i;
					}
				}
				if (i != challenge.Length - 1 && (challenge[i] != '"' || num2 <= num3))
				{
					continue;
				}
				if (i == challenge.Length - 1)
				{
					num2 = challenge.Length;
				}
				if (num2 < num3 + 3)
				{
					continue;
				}
				int num4 = num3 + 1;
				int num5 = num2 - num3 - 1;
				do
				{
					num = IndexOf(challenge, signature, num4, num5);
					if (num >= 0)
					{
						if ((num == 0 || challenge[num - 1] == ' ' || challenge[num - 1] == ',') && (num + signature.Length == challenge.Length || challenge[num + signature.Length] == ' ' || challenge[num + signature.Length] == ','))
						{
							break;
						}
						num5 -= num - num4 + 1;
						num4 = num + 1;
					}
				}
				while (num >= 0);
			}
		}
		return num;
	}

	private static int IndexOf(string challenge, string lwrCaseSignature, int start, int count)
	{
		count += start + 1 - lwrCaseSignature.Length;
		while (start < count)
		{
			int i;
			for (i = 0; i < lwrCaseSignature.Length && (challenge[start + i] | 0x20) == lwrCaseSignature[i]; i++)
			{
			}
			if (i == lwrCaseSignature.Length)
			{
				return start;
			}
			start++;
		}
		return -1;
	}

	internal static int SplitNoQuotes(string challenge, ref int offset)
	{
		int num = offset;
		offset = -1;
		if (challenge != null && num < challenge.Length)
		{
			int num2 = -1;
			int num3 = -1;
			for (int i = num; i < challenge.Length; i++)
			{
				if (num2 > num3 && challenge[i] == '\\' && i + 1 < challenge.Length && challenge[i + 1] == '"')
				{
					i++;
				}
				else if (challenge[i] == '"')
				{
					if (num2 <= num3)
					{
						num2 = i;
					}
					else
					{
						num3 = i;
					}
				}
				else if (challenge[i] == '=' && num2 <= num3 && offset < 0)
				{
					offset = i;
				}
				else if (challenge[i] == ',' && num2 <= num3)
				{
					return i;
				}
			}
		}
		return -1;
	}

	internal static Authorization GetGroupAuthorization(IAuthenticationModule thisModule, string token, bool finished, NTAuthentication authSession, bool shareAuthenticatedConnections, bool mutualAuth)
	{
		return new Authorization(token, finished, shareAuthenticatedConnections ? null : (thisModule.GetType().FullName + "/" + authSession.UniqueUserId), mutualAuth);
	}
}
