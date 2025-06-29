using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.Remoting;

[ComVisible(true)]
public static class RemotingConfiguration
{
	private static volatile bool s_ListeningForActivationRequests;

	public static string ApplicationName
	{
		get
		{
			if (!RemotingConfigHandler.HasApplicationNameBeenSet())
			{
				return null;
			}
			return RemotingConfigHandler.ApplicationName;
		}
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
		set
		{
			RemotingConfigHandler.ApplicationName = value;
		}
	}

	public static string ApplicationId
	{
		[SecurityCritical]
		get
		{
			return Identity.AppDomainUniqueId;
		}
	}

	public static string ProcessId
	{
		[SecurityCritical]
		get
		{
			return Identity.ProcessGuid;
		}
	}

	public static CustomErrorsModes CustomErrorsMode
	{
		get
		{
			return RemotingConfigHandler.CustomErrorsMode;
		}
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
		set
		{
			RemotingConfigHandler.CustomErrorsMode = value;
		}
	}

	[SecuritySafeCritical]
	[Obsolete("Use System.Runtime.Remoting.RemotingConfiguration.Configure(string fileName, bool ensureSecurity) instead.", false)]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void Configure(string filename)
	{
		Configure(filename, ensureSecurity: false);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void Configure(string filename, bool ensureSecurity)
	{
		RemotingConfigHandler.DoConfiguration(filename, ensureSecurity);
		RemotingServices.InternalSetRemoteActivationConfigured();
	}

	public static bool CustomErrorsEnabled(bool isLocalRequest)
	{
		return CustomErrorsMode switch
		{
			CustomErrorsModes.Off => false, 
			CustomErrorsModes.On => true, 
			CustomErrorsModes.RemoteOnly => !isLocalRequest, 
			_ => true, 
		};
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void RegisterActivatedServiceType(Type type)
	{
		ActivatedServiceTypeEntry entry = new ActivatedServiceTypeEntry(type);
		RegisterActivatedServiceType(entry);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
	{
		RemotingConfigHandler.RegisterActivatedServiceType(entry);
		if (!s_ListeningForActivationRequests)
		{
			s_ListeningForActivationRequests = true;
			ActivationServices.StartListeningForRemoteRequests();
		}
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void RegisterWellKnownServiceType(Type type, string objectUri, WellKnownObjectMode mode)
	{
		WellKnownServiceTypeEntry entry = new WellKnownServiceTypeEntry(type, objectUri, mode);
		RegisterWellKnownServiceType(entry);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
	{
		RemotingConfigHandler.RegisterWellKnownServiceType(entry);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void RegisterActivatedClientType(Type type, string appUrl)
	{
		ActivatedClientTypeEntry entry = new ActivatedClientTypeEntry(type, appUrl);
		RegisterActivatedClientType(entry);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
	{
		RemotingConfigHandler.RegisterActivatedClientType(entry);
		RemotingServices.InternalSetRemoteActivationConfigured();
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void RegisterWellKnownClientType(Type type, string objectUrl)
	{
		WellKnownClientTypeEntry entry = new WellKnownClientTypeEntry(type, objectUrl);
		RegisterWellKnownClientType(entry);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
	{
		RemotingConfigHandler.RegisterWellKnownClientType(entry);
		RemotingServices.InternalSetRemoteActivationConfigured();
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static ActivatedServiceTypeEntry[] GetRegisteredActivatedServiceTypes()
	{
		return RemotingConfigHandler.GetRegisteredActivatedServiceTypes();
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static WellKnownServiceTypeEntry[] GetRegisteredWellKnownServiceTypes()
	{
		return RemotingConfigHandler.GetRegisteredWellKnownServiceTypes();
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static ActivatedClientTypeEntry[] GetRegisteredActivatedClientTypes()
	{
		return RemotingConfigHandler.GetRegisteredActivatedClientTypes();
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static WellKnownClientTypeEntry[] GetRegisteredWellKnownClientTypes()
	{
		return RemotingConfigHandler.GetRegisteredWellKnownClientTypes();
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType)
	{
		if (svrType == null)
		{
			throw new ArgumentNullException("svrType");
		}
		RuntimeType runtimeType = svrType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"));
		}
		return RemotingConfigHandler.IsRemotelyActivatedClientType(runtimeType);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(string typeName, string assemblyName)
	{
		return RemotingConfigHandler.IsRemotelyActivatedClientType(typeName, assemblyName);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType)
	{
		if (svrType == null)
		{
			throw new ArgumentNullException("svrType");
		}
		RuntimeType runtimeType = svrType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"));
		}
		return RemotingConfigHandler.IsWellKnownClientType(runtimeType);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static WellKnownClientTypeEntry IsWellKnownClientType(string typeName, string assemblyName)
	{
		return RemotingConfigHandler.IsWellKnownClientType(typeName, assemblyName);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static bool IsActivationAllowed(Type svrType)
	{
		RuntimeType runtimeType = svrType as RuntimeType;
		if (svrType != null && runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"));
		}
		return RemotingConfigHandler.IsActivationAllowed(runtimeType);
	}
}
