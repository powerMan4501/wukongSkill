using System.Configuration;
using System.Globalization;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;

namespace System.Net.Configuration;

internal sealed class DefaultProxySectionInternal
{
	private IWebProxy webProxy;

	private static object classSyncObject;

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

	internal IWebProxy WebProxy => webProxy;

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	internal DefaultProxySectionInternal(DefaultProxySection section)
	{
		if (!section.Enabled)
		{
			return;
		}
		if (section.Proxy.AutoDetect == ProxyElement.AutoDetectValues.Unspecified && section.Proxy.ScriptLocation == null && string.IsNullOrEmpty(section.Module.Type) && section.Proxy.UseSystemDefault != ProxyElement.UseSystemDefaultValues.True && section.Proxy.ProxyAddress == null && section.Proxy.BypassOnLocal == ProxyElement.BypassOnLocalValues.Unspecified && section.BypassList.Count == 0)
		{
			if (section.Proxy.UseSystemDefault == ProxyElement.UseSystemDefaultValues.False)
			{
				this.webProxy = new EmptyWebProxy();
				return;
			}
			try
			{
				new SecurityPermission(SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.ControlPrincipal).Assert();
				using (WindowsIdentity.Impersonate(IntPtr.Zero))
				{
					CodeAccessPermission.RevertAssert();
					this.webProxy = new WebRequest.WebProxyWrapper(new WebProxy(enableAutoproxy: true));
				}
			}
			catch
			{
				throw;
			}
		}
		else
		{
			if (!string.IsNullOrEmpty(section.Module.Type))
			{
				Type type = Type.GetType(section.Module.Type, throwOnError: true, ignoreCase: true);
				if ((type.Attributes & TypeAttributes.VisibilityMask) != TypeAttributes.Public)
				{
					throw new ConfigurationErrorsException(SR.GetString("net_config_proxy_module_not_public"));
				}
				if (!typeof(IWebProxy).IsAssignableFrom(type))
				{
					throw new InvalidCastException(SR.GetString("net_invalid_cast", type.FullName, "IWebProxy"));
				}
				this.webProxy = (IWebProxy)Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[0], CultureInfo.InvariantCulture);
			}
			else if (section.Proxy.UseSystemDefault == ProxyElement.UseSystemDefaultValues.True && section.Proxy.AutoDetect == ProxyElement.AutoDetectValues.Unspecified && section.Proxy.ScriptLocation == null)
			{
				try
				{
					new SecurityPermission(SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.ControlPrincipal).Assert();
					using (WindowsIdentity.Impersonate(IntPtr.Zero))
					{
						CodeAccessPermission.RevertAssert();
						this.webProxy = new WebProxy(enableAutoproxy: false);
					}
				}
				catch
				{
					throw;
				}
			}
			else
			{
				this.webProxy = new WebProxy();
			}
			if (this.webProxy is WebProxy webProxy)
			{
				if (section.Proxy.AutoDetect != ProxyElement.AutoDetectValues.Unspecified)
				{
					webProxy.AutoDetect = section.Proxy.AutoDetect == ProxyElement.AutoDetectValues.True;
				}
				if (section.Proxy.ScriptLocation != null)
				{
					webProxy.ScriptLocation = section.Proxy.ScriptLocation;
				}
				if (section.Proxy.BypassOnLocal != ProxyElement.BypassOnLocalValues.Unspecified)
				{
					webProxy.BypassProxyOnLocal = section.Proxy.BypassOnLocal == ProxyElement.BypassOnLocalValues.True;
				}
				if (section.Proxy.ProxyAddress != null)
				{
					webProxy.Address = section.Proxy.ProxyAddress;
				}
				int count = section.BypassList.Count;
				if (count > 0)
				{
					string[] array = new string[section.BypassList.Count];
					for (int i = 0; i < count; i++)
					{
						array[i] = section.BypassList[i].Address;
					}
					webProxy.BypassList = array;
				}
				if (section.Module.Type == null)
				{
					this.webProxy = new WebRequest.WebProxyWrapper(webProxy);
				}
			}
		}
		if (this.webProxy != null && section.UseDefaultCredentials)
		{
			this.webProxy.Credentials = SystemNetworkCredential.defaultCredential;
		}
	}

	internal static DefaultProxySectionInternal GetSection()
	{
		lock (ClassSyncObject)
		{
			if (!(System.Configuration.PrivilegedConfigurationManager.GetSection(ConfigurationStrings.DefaultProxySectionPath) is DefaultProxySection section))
			{
				return null;
			}
			try
			{
				return new DefaultProxySectionInternal(section);
			}
			catch (Exception ex)
			{
				if (NclUtilities.IsFatal(ex))
				{
					throw;
				}
				throw new ConfigurationErrorsException(SR.GetString("net_config_proxy"), ex);
			}
		}
	}
}
