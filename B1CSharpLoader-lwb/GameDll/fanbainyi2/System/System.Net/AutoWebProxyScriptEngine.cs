using System.Collections.Generic;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;

namespace System.Net;

internal class AutoWebProxyScriptEngine
{
	private static class SyncStatus
	{
		internal const int Unlocked = 0;

		internal const int Locking = 1;

		internal const int LockOwner = 2;

		internal const int AbortedLocked = 3;

		internal const int Aborted = 4;
	}

	private class AutoDetector
	{
		private static volatile NetworkAddressChangePolled s_AddressChange;

		private static volatile UnsafeNclNativeMethods.RasHelper s_RasHelper;

		private static int s_CurrentVersion;

		private static volatile AutoDetector s_CurrentAutoDetector;

		private static volatile bool s_Initialized;

		private static object s_LockObject;

		private readonly string m_Connectoid;

		private readonly int m_CurrentVersion;

		internal static AutoDetector CurrentAutoDetector
		{
			get
			{
				Initialize();
				return s_CurrentAutoDetector;
			}
		}

		internal string Connectoid => m_Connectoid;

		internal int NetworkChangeStatus => m_CurrentVersion;

		static AutoDetector()
		{
			s_LockObject = new object();
		}

		private static void Initialize()
		{
			if (s_Initialized)
			{
				return;
			}
			lock (s_LockObject)
			{
				if (!s_Initialized)
				{
					s_CurrentAutoDetector = new AutoDetector(UnsafeNclNativeMethods.RasHelper.GetCurrentConnectoid(), 1);
					if (NetworkChange.CanListenForNetworkChanges)
					{
						s_AddressChange = new NetworkAddressChangePolled();
					}
					if (UnsafeNclNativeMethods.RasHelper.RasSupported)
					{
						s_RasHelper = new UnsafeNclNativeMethods.RasHelper();
					}
					s_CurrentVersion = 1;
					s_Initialized = true;
				}
			}
		}

		internal static bool CheckForNetworkChanges(ref int changeStatus)
		{
			Initialize();
			CheckForChanges();
			int num = changeStatus;
			changeStatus = Volatile.Read(ref s_CurrentVersion);
			return num != changeStatus;
		}

		private static void CheckForChanges()
		{
			bool flag = false;
			if (s_RasHelper != null && s_RasHelper.HasChanged)
			{
				s_RasHelper.Reset();
				flag = true;
			}
			if (s_AddressChange != null && s_AddressChange.CheckAndReset())
			{
				flag = true;
			}
			if (flag)
			{
				int currentVersion = Interlocked.Increment(ref s_CurrentVersion);
				s_CurrentAutoDetector = new AutoDetector(UnsafeNclNativeMethods.RasHelper.GetCurrentConnectoid(), currentVersion);
			}
		}

		private AutoDetector(string connectoid, int currentVersion)
		{
			m_Connectoid = connectoid;
			m_CurrentVersion = currentVersion;
		}
	}

	private bool automaticallyDetectSettings;

	private Uri automaticConfigurationScript;

	private WebProxy webProxy;

	private IWebProxyFinder webProxyFinder;

	private bool executeWinHttpGetProxyForUrl;

	private Timer retryWinHttpGetProxyForUrlTimer;

	private bool m_LockHeld;

	private bool m_UseRegistry;

	private int m_NetworkChangeStatus;

	private AutoDetector m_AutoDetector;

	private SafeRegistryHandle hkcu;

	private WindowsIdentity m_Identity;

	private SafeRegistryHandle regKey;

	private SafeRegistryHandle regKeyLM;

	private SafeRegistryHandle regKeyPolicy;

	private AutoResetEvent registryChangeEvent;

	private AutoResetEvent registryChangeEventLM;

	private AutoResetEvent registryChangeEventPolicy;

	private bool registryChangeDeferred;

	private bool registryChangeLMDeferred;

	private bool registryChangePolicyDeferred;

	private bool needRegistryUpdate;

	private bool needConnectoidUpdate;

	private bool registrySuppress;

	internal bool AutomaticallyDetectSettings
	{
		get
		{
			return automaticallyDetectSettings;
		}
		set
		{
			if (automaticallyDetectSettings != value)
			{
				automaticallyDetectSettings = value;
				webProxyFinder.Reset();
			}
		}
	}

	internal Uri AutomaticConfigurationScript
	{
		get
		{
			return automaticConfigurationScript;
		}
		set
		{
			if (!object.Equals(automaticConfigurationScript, value))
			{
				automaticConfigurationScript = value;
				webProxyFinder.Reset();
			}
		}
	}

	internal ICredentials Credentials => webProxy.Credentials;

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	internal AutoWebProxyScriptEngine(WebProxy proxy, bool useRegistry)
	{
		webProxy = proxy;
		m_UseRegistry = useRegistry;
		m_AutoDetector = AutoDetector.CurrentAutoDetector;
		m_NetworkChangeStatus = m_AutoDetector.NetworkChangeStatus;
		SafeRegistryHandle.RegOpenCurrentUser(131097u, out hkcu);
		if (m_UseRegistry)
		{
			ListenForRegistry();
			m_Identity = WindowsIdentity.GetCurrent();
		}
		webProxyFinder = new HybridWebProxyFinder(this);
	}

	private void EnterLock(ref int syncStatus)
	{
		if (syncStatus != 0)
		{
			return;
		}
		lock (this)
		{
			if (syncStatus == 4)
			{
				return;
			}
			syncStatus = 1;
			do
			{
				if (!m_LockHeld)
				{
					syncStatus = 2;
					m_LockHeld = true;
					return;
				}
				Monitor.Wait(this);
			}
			while (syncStatus != 4);
			Monitor.Pulse(this);
		}
	}

	private void ExitLock(ref int syncStatus)
	{
		if (syncStatus == 0 || syncStatus == 4)
		{
			return;
		}
		lock (this)
		{
			m_LockHeld = false;
			if (syncStatus == 3)
			{
				webProxyFinder.Reset();
				syncStatus = 4;
			}
			else
			{
				syncStatus = 0;
			}
			Monitor.Pulse(this);
		}
	}

	internal void Abort(ref int syncStatus)
	{
		lock (this)
		{
			switch (syncStatus)
			{
			case 0:
				syncStatus = 4;
				break;
			case 1:
				syncStatus = 4;
				Monitor.PulseAll(this);
				break;
			case 2:
				syncStatus = 3;
				webProxyFinder.Abort();
				break;
			}
		}
	}

	internal bool GetProxies(Uri destination, out IList<string> proxyList)
	{
		int syncStatus = 0;
		return GetProxies(destination, out proxyList, ref syncStatus);
	}

	internal bool GetProxies(Uri destination, out IList<string> proxyList, ref int syncStatus)
	{
		proxyList = null;
		CheckForChanges(ref syncStatus);
		if (!webProxyFinder.IsValid)
		{
			if (retryWinHttpGetProxyForUrlTimer == null && SettingsSectionInternal.Section.AutoConfigUrlRetryInterval != 0)
			{
				long num = SettingsSectionInternal.Section.AutoConfigUrlRetryInterval * 1000;
				retryWinHttpGetProxyForUrlTimer = new Timer(delegate(object s)
				{
					WeakReference<AutoWebProxyScriptEngine> weakReference = (WeakReference<AutoWebProxyScriptEngine>)s;
					if (weakReference.TryGetTarget(out var target))
					{
						target.executeWinHttpGetProxyForUrl = true;
					}
				}, new WeakReference<AutoWebProxyScriptEngine>(this), num, num);
			}
			if (!executeWinHttpGetProxyForUrl)
			{
				return false;
			}
			executeWinHttpGetProxyForUrl = false;
		}
		else if (retryWinHttpGetProxyForUrlTimer != null)
		{
			retryWinHttpGetProxyForUrlTimer.Dispose();
			retryWinHttpGetProxyForUrlTimer = null;
		}
		try
		{
			EnterLock(ref syncStatus);
			if (syncStatus != 2)
			{
				return false;
			}
			return webProxyFinder.GetProxies(destination, out proxyList);
		}
		finally
		{
			ExitLock(ref syncStatus);
		}
	}

	internal WebProxyData GetWebProxyData()
	{
		WebProxyDataBuilder webProxyDataBuilder = null;
		webProxyDataBuilder = ((!ComNetOS.IsWin7orLater) ? ((WebProxyDataBuilder)new RegBlobWebProxyDataBuilder(m_AutoDetector.Connectoid, hkcu)) : ((WebProxyDataBuilder)new WinHttpWebProxyBuilder()));
		return webProxyDataBuilder.Build();
	}

	internal void Close()
	{
		if (m_AutoDetector == null)
		{
			return;
		}
		int syncStatus = 0;
		try
		{
			EnterLock(ref syncStatus);
			if (m_AutoDetector != null)
			{
				registrySuppress = true;
				if (registryChangeEventPolicy != null)
				{
					registryChangeEventPolicy.Close();
					registryChangeEventPolicy = null;
				}
				if (registryChangeEventLM != null)
				{
					registryChangeEventLM.Close();
					registryChangeEventLM = null;
				}
				if (registryChangeEvent != null)
				{
					registryChangeEvent.Close();
					registryChangeEvent = null;
				}
				if (regKeyPolicy != null && !regKeyPolicy.IsInvalid)
				{
					regKeyPolicy.Close();
				}
				if (regKeyLM != null && !regKeyLM.IsInvalid)
				{
					regKeyLM.Close();
				}
				if (regKey != null && !regKey.IsInvalid)
				{
					regKey.Close();
				}
				if (hkcu != null)
				{
					hkcu.RegCloseKey();
					hkcu = null;
				}
				if (m_Identity != null)
				{
					m_Identity.Dispose();
					m_Identity = null;
				}
				webProxyFinder.Dispose();
				m_AutoDetector = null;
			}
		}
		finally
		{
			ExitLock(ref syncStatus);
		}
	}

	internal void ListenForRegistry()
	{
		if (!registrySuppress)
		{
			if (registryChangeEvent == null)
			{
				ListenForRegistryHelper(ref regKey, ref registryChangeEvent, IntPtr.Zero, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections");
			}
			if (registryChangeEventLM == null)
			{
				ListenForRegistryHelper(ref regKeyLM, ref registryChangeEventLM, UnsafeNclNativeMethods.RegistryHelper.HKEY_LOCAL_MACHINE, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections");
			}
			if (registryChangeEventPolicy == null)
			{
				ListenForRegistryHelper(ref regKeyPolicy, ref registryChangeEventPolicy, UnsafeNclNativeMethods.RegistryHelper.HKEY_LOCAL_MACHINE, "SOFTWARE\\Policies\\Microsoft\\Windows\\CurrentVersion\\Internet Settings");
			}
			if (registryChangeEvent == null && registryChangeEventLM == null && registryChangeEventPolicy == null)
			{
				registrySuppress = true;
			}
		}
	}

	private void ListenForRegistryHelper(ref SafeRegistryHandle key, ref AutoResetEvent changeEvent, IntPtr baseKey, string subKey)
	{
		uint num = 0u;
		if (key == null || key.IsInvalid)
		{
			num = ((!(baseKey == IntPtr.Zero)) ? SafeRegistryHandle.RegOpenKeyEx(baseKey, subKey, 0u, 131097u, out key) : ((hkcu == null) ? 1168u : hkcu.RegOpenKeyEx(subKey, 0u, 131097u, out key)));
			if (num == 0)
			{
				changeEvent = new AutoResetEvent(initialState: false);
			}
		}
		if (num == 0)
		{
			num = key.RegNotifyChangeKeyValue(watchSubTree: true, 4u, changeEvent.SafeWaitHandle, async: true);
		}
		if (num == 0)
		{
			return;
		}
		if (key != null && !key.IsInvalid)
		{
			try
			{
				num = key.RegCloseKey();
			}
			catch (Exception exception)
			{
				if (NclUtilities.IsFatal(exception))
				{
					throw;
				}
			}
		}
		key = null;
		if (changeEvent != null)
		{
			changeEvent.Close();
			changeEvent = null;
		}
	}

	private void RegistryChanged()
	{
		if (Logging.On)
		{
			Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_system_setting_update"));
		}
		WebProxyData webProxyData;
		using (m_Identity.Impersonate())
		{
			webProxyData = GetWebProxyData();
		}
		webProxy.Update(webProxyData);
	}

	private void ConnectoidChanged()
	{
		if (Logging.On)
		{
			Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_update_due_to_ip_config_change"));
		}
		m_AutoDetector = AutoDetector.CurrentAutoDetector;
		if (m_UseRegistry)
		{
			WebProxyData webProxyData;
			using (m_Identity.Impersonate())
			{
				webProxyData = GetWebProxyData();
			}
			webProxy.Update(webProxyData);
		}
		if (automaticallyDetectSettings)
		{
			webProxyFinder.Reset();
		}
	}

	internal void CheckForChanges()
	{
		int syncStatus = 0;
		CheckForChanges(ref syncStatus);
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	private void CheckForChanges(ref int syncStatus)
	{
		try
		{
			bool flag = AutoDetector.CheckForNetworkChanges(ref m_NetworkChangeStatus);
			bool flag2 = false;
			if (flag || needConnectoidUpdate)
			{
				try
				{
					EnterLock(ref syncStatus);
					if (flag || needConnectoidUpdate)
					{
						needConnectoidUpdate = syncStatus != 2;
						if (!needConnectoidUpdate)
						{
							ConnectoidChanged();
							flag2 = true;
						}
					}
				}
				finally
				{
					ExitLock(ref syncStatus);
				}
			}
			if (!m_UseRegistry)
			{
				return;
			}
			bool flag3 = false;
			AutoResetEvent autoResetEvent = registryChangeEvent;
			if (!registryChangeDeferred)
			{
				bool num = autoResetEvent?.WaitOne(0, exitContext: false) ?? false;
				flag3 = num;
				if (!num)
				{
					goto IL_0102;
				}
			}
			try
			{
				EnterLock(ref syncStatus);
				if (flag3 || registryChangeDeferred)
				{
					registryChangeDeferred = syncStatus != 2;
					if (!registryChangeDeferred && registryChangeEvent != null)
					{
						try
						{
							using (m_Identity.Impersonate())
							{
								ListenForRegistryHelper(ref regKey, ref registryChangeEvent, IntPtr.Zero, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections");
							}
						}
						catch
						{
							throw;
						}
						needRegistryUpdate = true;
					}
				}
			}
			finally
			{
				ExitLock(ref syncStatus);
			}
			goto IL_0102;
			IL_0244:
			if (!needRegistryUpdate)
			{
				return;
			}
			try
			{
				EnterLock(ref syncStatus);
				if (needRegistryUpdate && syncStatus == 2)
				{
					needRegistryUpdate = false;
					if (!flag2)
					{
						RegistryChanged();
					}
				}
				return;
			}
			finally
			{
				ExitLock(ref syncStatus);
			}
			IL_0102:
			flag3 = false;
			autoResetEvent = registryChangeEventLM;
			if (!registryChangeLMDeferred)
			{
				bool num2 = autoResetEvent?.WaitOne(0, exitContext: false) ?? false;
				flag3 = num2;
				if (!num2)
				{
					goto IL_01a3;
				}
			}
			try
			{
				EnterLock(ref syncStatus);
				if (flag3 || registryChangeLMDeferred)
				{
					registryChangeLMDeferred = syncStatus != 2;
					if (!registryChangeLMDeferred && registryChangeEventLM != null)
					{
						try
						{
							using (m_Identity.Impersonate())
							{
								ListenForRegistryHelper(ref regKeyLM, ref registryChangeEventLM, UnsafeNclNativeMethods.RegistryHelper.HKEY_LOCAL_MACHINE, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections");
							}
						}
						catch
						{
							throw;
						}
						needRegistryUpdate = true;
					}
				}
			}
			finally
			{
				ExitLock(ref syncStatus);
			}
			goto IL_01a3;
			IL_01a3:
			flag3 = false;
			autoResetEvent = registryChangeEventPolicy;
			if (!registryChangePolicyDeferred)
			{
				bool num3 = autoResetEvent?.WaitOne(0, exitContext: false) ?? false;
				flag3 = num3;
				if (!num3)
				{
					goto IL_0244;
				}
			}
			try
			{
				EnterLock(ref syncStatus);
				if (flag3 || registryChangePolicyDeferred)
				{
					registryChangePolicyDeferred = syncStatus != 2;
					if (!registryChangePolicyDeferred && registryChangeEventPolicy != null)
					{
						try
						{
							using (m_Identity.Impersonate())
							{
								ListenForRegistryHelper(ref regKeyPolicy, ref registryChangeEventPolicy, UnsafeNclNativeMethods.RegistryHelper.HKEY_LOCAL_MACHINE, "SOFTWARE\\Policies\\Microsoft\\Windows\\CurrentVersion\\Internet Settings");
							}
						}
						catch
						{
							throw;
						}
						needRegistryUpdate = true;
					}
				}
			}
			finally
			{
				ExitLock(ref syncStatus);
			}
			goto IL_0244;
		}
		catch (ObjectDisposedException)
		{
		}
	}
}
