using System.Deployment.Internal.Isolation.Manifest;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Util;

namespace System.Security.Policy;

[ComVisible(true)]
public static class ApplicationSecurityManager
{
	private static volatile IApplicationTrustManager m_appTrustManager;

	private static string s_machineConfigFile;

	public static ApplicationTrustCollection UserApplicationTrusts
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPolicy)]
		get
		{
			return new ApplicationTrustCollection(storeBounded: true);
		}
	}

	public static IApplicationTrustManager ApplicationTrustManager
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPolicy)]
		get
		{
			if (m_appTrustManager == null)
			{
				m_appTrustManager = DecodeAppTrustManager();
				if (m_appTrustManager == null)
				{
					throw new PolicyException(Environment.GetResourceString("Policy_NoTrustManager"));
				}
			}
			return m_appTrustManager;
		}
	}

	[SecuritySafeCritical]
	static ApplicationSecurityManager()
	{
		m_appTrustManager = null;
		s_machineConfigFile = Config.MachineDirectory + "applicationtrust.config";
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Assert, Unrestricted = true)]
	public static bool DetermineApplicationTrust(ActivationContext activationContext, TrustManagerContext context)
	{
		if (activationContext == null)
		{
			throw new ArgumentNullException("activationContext");
		}
		ApplicationTrust applicationTrust = null;
		AppDomainManager domainManager = AppDomain.CurrentDomain.DomainManager;
		if (domainManager != null)
		{
			HostSecurityManager hostSecurityManager = domainManager.HostSecurityManager;
			if (hostSecurityManager != null && (hostSecurityManager.Flags & HostSecurityManagerOptions.HostDetermineApplicationTrust) == HostSecurityManagerOptions.HostDetermineApplicationTrust)
			{
				return hostSecurityManager.DetermineApplicationTrust(CmsUtils.MergeApplicationEvidence(null, activationContext.Identity, activationContext, null), null, context)?.IsApplicationTrustedToRun ?? false;
			}
		}
		return DetermineApplicationTrustInternal(activationContext, context)?.IsApplicationTrustedToRun ?? false;
	}

	[SecurityCritical]
	internal static ApplicationTrust DetermineApplicationTrustInternal(ActivationContext activationContext, TrustManagerContext context)
	{
		ApplicationTrust applicationTrust = null;
		ApplicationTrustCollection applicationTrustCollection = new ApplicationTrustCollection(storeBounded: true);
		if (context == null || !context.IgnorePersistedDecision)
		{
			applicationTrust = applicationTrustCollection[activationContext.Identity.FullName];
			if (applicationTrust != null)
			{
				return applicationTrust;
			}
		}
		applicationTrust = ApplicationTrustManager.DetermineApplicationTrust(activationContext, context);
		if (applicationTrust == null)
		{
			applicationTrust = new ApplicationTrust(activationContext.Identity);
		}
		applicationTrust.ApplicationIdentity = activationContext.Identity;
		if (applicationTrust.Persist)
		{
			applicationTrustCollection.Add(applicationTrust);
		}
		return applicationTrust;
	}

	[SecurityCritical]
	private static IApplicationTrustManager DecodeAppTrustManager()
	{
		if (File.InternalExists(s_machineConfigFile))
		{
			string xml;
			using (FileStream stream = new FileStream(s_machineConfigFile, FileMode.Open, FileAccess.Read))
			{
				xml = new StreamReader(stream).ReadToEnd();
			}
			SecurityElement securityElement = SecurityElement.FromString(xml);
			SecurityElement securityElement2 = securityElement.SearchForChildByTag("mscorlib");
			if (securityElement2 != null)
			{
				SecurityElement securityElement3 = securityElement2.SearchForChildByTag("security");
				if (securityElement3 != null)
				{
					SecurityElement securityElement4 = securityElement3.SearchForChildByTag("policy");
					if (securityElement4 != null)
					{
						SecurityElement securityElement5 = securityElement4.SearchForChildByTag("ApplicationSecurityManager");
						if (securityElement5 != null)
						{
							SecurityElement securityElement6 = securityElement5.SearchForChildByTag("IApplicationTrustManager");
							if (securityElement6 != null)
							{
								IApplicationTrustManager applicationTrustManager = DecodeAppTrustManagerFromElement(securityElement6);
								if (applicationTrustManager != null)
								{
									return applicationTrustManager;
								}
							}
						}
					}
				}
			}
		}
		return DecodeAppTrustManagerFromElement(CreateDefaultApplicationTrustManagerElement());
	}

	[SecurityCritical]
	private static SecurityElement CreateDefaultApplicationTrustManagerElement()
	{
		SecurityElement securityElement = new SecurityElement("IApplicationTrustManager");
		securityElement.AddAttribute("class", "System.Security.Policy.TrustManager, System.Windows.Forms, Version=" + ((RuntimeAssembly)Assembly.GetExecutingAssembly()).GetVersion()?.ToString() + ", Culture=neutral, PublicKeyToken=b77a5c561934e089");
		securityElement.AddAttribute("version", "1");
		return securityElement;
	}

	[SecurityCritical]
	private static IApplicationTrustManager DecodeAppTrustManagerFromElement(SecurityElement elTrustManager)
	{
		new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Assert();
		string typeName = elTrustManager.Attribute("class");
		Type type = Type.GetType(typeName, throwOnError: false, ignoreCase: false);
		if (type == null)
		{
			return null;
		}
		IApplicationTrustManager applicationTrustManager = Activator.CreateInstance(type) as IApplicationTrustManager;
		applicationTrustManager?.FromXml(elTrustManager);
		return applicationTrustManager;
	}
}
