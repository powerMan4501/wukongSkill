using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Sockets;
using System.Security;
using System.Threading;

namespace System.Net.NetworkInformation;

[SuppressUnmanagedCodeSecurity]
internal class TeredoHelper
{
	private static List<TeredoHelper> pendingNotifications;

	private static bool impendingAppDomainUnload;

	private readonly Action<object> callback;

	private readonly object state;

	private bool runCallbackCalled;

	private readonly StableUnicastIpAddressTableDelegate onStabilizedDelegate;

	private SafeCancelMibChangeNotify cancelHandle;

	static TeredoHelper()
	{
		pendingNotifications = new List<TeredoHelper>();
		AppDomain.CurrentDomain.DomainUnload += OnAppDomainUnload;
	}

	private TeredoHelper(Action<object> callback, object state)
	{
		this.callback = callback;
		this.state = state;
		onStabilizedDelegate = OnStabilized;
		runCallbackCalled = false;
	}

	public static bool UnsafeNotifyStableUnicastIpAddressTable(Action<object> callback, object state)
	{
		TeredoHelper teredoHelper = new TeredoHelper(callback, state);
		uint num = 0u;
		SafeFreeMibTable table = null;
		lock (pendingNotifications)
		{
			if (impendingAppDomainUnload)
			{
				return false;
			}
			num = UnsafeNetInfoNativeMethods.NotifyStableUnicastIpAddressTable(AddressFamily.Unspecified, out table, teredoHelper.onStabilizedDelegate, IntPtr.Zero, out teredoHelper.cancelHandle);
			table?.Dispose();
			if (num == 997)
			{
				pendingNotifications.Add(teredoHelper);
				return false;
			}
		}
		if (num != 0)
		{
			throw new Win32Exception((int)num);
		}
		return true;
	}

	private static void OnAppDomainUnload(object sender, EventArgs args)
	{
		lock (pendingNotifications)
		{
			impendingAppDomainUnload = true;
			foreach (TeredoHelper pendingNotification in pendingNotifications)
			{
				pendingNotification.cancelHandle.Dispose();
			}
		}
	}

	private void RunCallback(object o)
	{
		lock (pendingNotifications)
		{
			if (impendingAppDomainUnload)
			{
				return;
			}
			pendingNotifications.Remove(this);
			cancelHandle.Dispose();
		}
		callback(state);
	}

	private void OnStabilized(IntPtr context, IntPtr table)
	{
		UnsafeNetInfoNativeMethods.FreeMibTable(table);
		if (runCallbackCalled)
		{
			return;
		}
		lock (this)
		{
			if (!runCallbackCalled)
			{
				runCallbackCalled = true;
				ThreadPool.UnsafeQueueUserWorkItem(RunCallback, null);
			}
		}
	}
}
