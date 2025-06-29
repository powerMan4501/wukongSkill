using System.Collections.Generic;
using System.Configuration;
using System.Threading;

namespace System.Net.Configuration;

internal sealed class AuthenticationModulesSectionInternal
{
	private List<Type> authenticationModules;

	private static object classSyncObject;

	internal List<Type> AuthenticationModules
	{
		get
		{
			List<Type> list = authenticationModules;
			if (list == null)
			{
				list = new List<Type>(0);
			}
			return list;
		}
	}

	internal static object ClassSyncObject
	{
		get
		{
			if (classSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref classSyncObject, value, null);
			}
			return classSyncObject;
		}
	}

	internal AuthenticationModulesSectionInternal(AuthenticationModulesSection section)
	{
		if (section.AuthenticationModules.Count <= 0)
		{
			return;
		}
		authenticationModules = new List<Type>(section.AuthenticationModules.Count);
		foreach (AuthenticationModuleElement authenticationModule in section.AuthenticationModules)
		{
			Type type = null;
			try
			{
				type = Type.GetType(authenticationModule.Type, throwOnError: true, ignoreCase: true);
				if (!typeof(IAuthenticationModule).IsAssignableFrom(type))
				{
					throw new InvalidCastException(SR.GetString("net_invalid_cast", type.FullName, "IAuthenticationModule"));
				}
			}
			catch (Exception ex)
			{
				if (NclUtilities.IsFatal(ex))
				{
					throw;
				}
				throw new ConfigurationErrorsException(SR.GetString("net_config_authenticationmodules"), ex);
			}
			authenticationModules.Add(type);
		}
	}

	internal static AuthenticationModulesSectionInternal GetSection()
	{
		lock (ClassSyncObject)
		{
			if (!(System.Configuration.PrivilegedConfigurationManager.GetSection(ConfigurationStrings.AuthenticationModulesSectionPath) is AuthenticationModulesSection section))
			{
				return null;
			}
			return new AuthenticationModulesSectionInternal(section);
		}
	}
}
