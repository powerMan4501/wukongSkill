using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Hosting;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading;

namespace System;

[SecurityCritical]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.Infrastructure)]
public class AppDomainManager : MarshalByRefObject
{
	private AppDomainManagerInitializationOptions m_flags;

	private ApplicationActivator m_appActivator;

	private Assembly m_entryAssembly;

	public AppDomainManagerInitializationOptions InitializationFlags
	{
		get
		{
			return m_flags;
		}
		set
		{
			m_flags = value;
		}
	}

	public virtual ApplicationActivator ApplicationActivator
	{
		get
		{
			if (m_appActivator == null)
			{
				m_appActivator = new ApplicationActivator();
			}
			return m_appActivator;
		}
	}

	public virtual HostSecurityManager HostSecurityManager => null;

	public virtual HostExecutionContextManager HostExecutionContextManager => HostExecutionContextManager.GetInternalHostExecutionContextManager();

	public virtual Assembly EntryAssembly
	{
		[SecurityCritical]
		get
		{
			if (m_entryAssembly == null)
			{
				AppDomain currentDomain = AppDomain.CurrentDomain;
				if (currentDomain.IsDefaultAppDomain() && currentDomain.ActivationContext != null)
				{
					ManifestRunner manifestRunner = new ManifestRunner(currentDomain, currentDomain.ActivationContext);
					m_entryAssembly = manifestRunner.EntryAssembly;
				}
				else
				{
					RuntimeAssembly o = null;
					GetEntryAssembly(JitHelpers.GetObjectHandleOnStack(ref o));
					m_entryAssembly = o;
				}
			}
			return m_entryAssembly;
		}
	}

	internal static AppDomainManager CurrentAppDomainManager
	{
		[SecurityCritical]
		get
		{
			return AppDomain.CurrentDomain.DomainManager;
		}
	}

	[SecurityCritical]
	public virtual AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup appDomainInfo)
	{
		return CreateDomainHelper(friendlyName, securityInfo, appDomainInfo);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, ControlAppDomain = true)]
	protected static AppDomain CreateDomainHelper(string friendlyName, Evidence securityInfo, AppDomainSetup appDomainInfo)
	{
		if (friendlyName == null)
		{
			throw new ArgumentNullException(Environment.GetResourceString("ArgumentNull_String"));
		}
		if (securityInfo != null)
		{
			new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
			AppDomain.CheckDomainCreationEvidence(appDomainInfo, securityInfo);
		}
		if (appDomainInfo == null)
		{
			appDomainInfo = new AppDomainSetup();
		}
		if (appDomainInfo.AppDomainManagerAssembly == null || appDomainInfo.AppDomainManagerType == null)
		{
			AppDomain.CurrentDomain.GetAppDomainManagerType(out var assembly, out var type);
			if (appDomainInfo.AppDomainManagerAssembly == null)
			{
				appDomainInfo.AppDomainManagerAssembly = assembly;
			}
			if (appDomainInfo.AppDomainManagerType == null)
			{
				appDomainInfo.AppDomainManagerType = type;
			}
		}
		if (appDomainInfo.TargetFrameworkName == null)
		{
			appDomainInfo.TargetFrameworkName = AppDomain.CurrentDomain.GetTargetFrameworkName();
		}
		return AppDomain.nCreateDomain(friendlyName, appDomainInfo, securityInfo, (securityInfo == null) ? AppDomain.CurrentDomain.InternalEvidence : null, AppDomain.CurrentDomain.GetSecurityDescriptor());
	}

	[SecurityCritical]
	public virtual void InitializeNewDomain(AppDomainSetup appDomainInfo)
	{
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetEntryAssembly(ObjectHandleOnStack retAssembly);

	public virtual bool CheckSecuritySettings(SecurityState state)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern bool HasHost();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void RegisterWithHost(IntPtr appDomainManager);

	internal void RegisterWithHost()
	{
		if (!HasHost())
		{
			return;
		}
		IntPtr intPtr = IntPtr.Zero;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			intPtr = Marshal.GetIUnknownForObject(this);
			RegisterWithHost(intPtr);
		}
		finally
		{
			if (!intPtr.IsNull())
			{
				Marshal.Release(intPtr);
			}
		}
	}
}
