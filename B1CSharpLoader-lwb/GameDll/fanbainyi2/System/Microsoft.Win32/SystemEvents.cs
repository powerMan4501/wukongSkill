using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace Microsoft.Win32;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
public sealed class SystemEvents
{
	private class SystemEventInvokeInfo
	{
		private SynchronizationContext _syncContext;

		private Delegate _delegate;

		public SystemEventInvokeInfo(Delegate d)
		{
			_delegate = d;
			_syncContext = AsyncOperationManager.SynchronizationContext;
		}

		public void Invoke(bool checkFinalization, params object[] args)
		{
			try
			{
				if (_syncContext == null || UseEverettThreadAffinity)
				{
					InvokeCallback(args);
				}
				else
				{
					_syncContext.Send(InvokeCallback, args);
				}
			}
			catch (InvalidAsynchronousStateException)
			{
				if (!checkFinalization || !AppDomain.CurrentDomain.IsFinalizingForUnload())
				{
					InvokeCallback(args);
				}
			}
		}

		private void InvokeCallback(object arg)
		{
			_delegate.DynamicInvoke((object[])arg);
		}

		public override bool Equals(object other)
		{
			if (!(other is SystemEventInvokeInfo systemEventInvokeInfo))
			{
				return false;
			}
			return systemEventInvokeInfo._delegate.Equals(_delegate);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}

	private static readonly object eventLockObject = new object();

	private static readonly object procLockObject = new object();

	private static volatile SystemEvents systemEvents;

	private static volatile Thread windowThread;

	private static volatile ManualResetEvent eventWindowReady;

	private static Random randomTimerId = new Random();

	private static volatile bool startupRecreates;

	private static volatile bool registeredSessionNotification = false;

	private static volatile int domainQualifier;

	private static volatile NativeMethods.WNDCLASS staticwndclass;

	private static volatile IntPtr defWindowProc;

	private static volatile string className = null;

	private static volatile Queue threadCallbackList;

	private static volatile int threadCallbackMessage = 0;

	private static volatile ManualResetEvent eventThreadTerminated;

	private static volatile bool checkedThreadAffinity = false;

	private static volatile bool useEverettThreadAffinity = false;

	private const string everettThreadAffinityValue = "EnableSystemEventsThreadAffinityCompatibility";

	private volatile IntPtr windowHandle;

	private NativeMethods.WndProc windowProc;

	private NativeMethods.ConHndlr consoleHandler;

	private static readonly object OnUserPreferenceChangingEvent = new object();

	private static readonly object OnUserPreferenceChangedEvent = new object();

	private static readonly object OnSessionEndingEvent = new object();

	private static readonly object OnSessionEndedEvent = new object();

	private static readonly object OnPowerModeChangedEvent = new object();

	private static readonly object OnLowMemoryEvent = new object();

	private static readonly object OnDisplaySettingsChangingEvent = new object();

	private static readonly object OnDisplaySettingsChangedEvent = new object();

	private static readonly object OnInstalledFontsChangedEvent = new object();

	private static readonly object OnTimeChangedEvent = new object();

	private static readonly object OnTimerElapsedEvent = new object();

	private static readonly object OnPaletteChangedEvent = new object();

	private static readonly object OnEventsThreadShutdownEvent = new object();

	private static readonly object OnSessionSwitchEvent = new object();

	private static Dictionary<object, List<SystemEventInvokeInfo>> _handlers;

	private static volatile IntPtr processWinStation = IntPtr.Zero;

	private static volatile bool isUserInteractive = false;

	private static volatile object appFileVersion;

	private static volatile Type mainType;

	private static volatile string executablePath = null;

	private static bool UserInteractive
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				IntPtr zero = IntPtr.Zero;
				zero = Microsoft.Win32.UnsafeNativeMethods.GetProcessWindowStation();
				if (zero != IntPtr.Zero && processWinStation != zero)
				{
					isUserInteractive = true;
					int lpnLengthNeeded = 0;
					NativeMethods.USEROBJECTFLAGS uSEROBJECTFLAGS = new NativeMethods.USEROBJECTFLAGS();
					if (Microsoft.Win32.UnsafeNativeMethods.GetUserObjectInformation(new HandleRef(null, zero), 1, uSEROBJECTFLAGS, Marshal.SizeOf((object)uSEROBJECTFLAGS), ref lpnLengthNeeded) && (uSEROBJECTFLAGS.dwFlags & 1) == 0)
					{
						isUserInteractive = false;
					}
					processWinStation = zero;
				}
			}
			else
			{
				isUserInteractive = true;
			}
			return isUserInteractive;
		}
	}

	private NativeMethods.WNDCLASS WndClass
	{
		get
		{
			if (staticwndclass == null)
			{
				IntPtr moduleHandle = Microsoft.Win32.UnsafeNativeMethods.GetModuleHandle(null);
				className = string.Format(CultureInfo.InvariantCulture, ".NET-BroadcastEventWindow.{0}.{1}.{2}", new object[3]
				{
					"4.0.0.0",
					Convert.ToString(AppDomain.CurrentDomain.GetHashCode(), 16),
					domainQualifier
				});
				NativeMethods.WNDCLASS wNDCLASS = new NativeMethods.WNDCLASS();
				wNDCLASS.hbrBackground = (IntPtr)6;
				wNDCLASS.style = 0;
				windowProc = WindowProc;
				wNDCLASS.lpszClassName = className;
				wNDCLASS.lpfnWndProc = windowProc;
				wNDCLASS.hInstance = moduleHandle;
				staticwndclass = wNDCLASS;
			}
			return staticwndclass;
		}
	}

	private IntPtr DefWndProc
	{
		get
		{
			if (defWindowProc == IntPtr.Zero)
			{
				string lpProcName = ((Marshal.SystemDefaultCharSize == 1) ? "DefWindowProcA" : "DefWindowProcW");
				defWindowProc = Microsoft.Win32.UnsafeNativeMethods.GetProcAddress(new HandleRef(this, Microsoft.Win32.UnsafeNativeMethods.GetModuleHandle("user32.dll")), lpProcName);
			}
			return defWindowProc;
		}
	}

	internal static bool UseEverettThreadAffinity
	{
		get
		{
			if (!checkedThreadAffinity)
			{
				lock (eventLockObject)
				{
					if (!checkedThreadAffinity)
					{
						checkedThreadAffinity = true;
						string format = "Software\\{0}\\{1}\\{2}";
						try
						{
							new RegistryPermission(PermissionState.Unrestricted).Assert();
							RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Format(CultureInfo.CurrentCulture, format, new object[3] { CompanyNameInternal, ProductNameInternal, ProductVersionInternal }));
							if (registryKey != null)
							{
								object value = registryKey.GetValue("EnableSystemEventsThreadAffinityCompatibility");
								if (value != null && (int)value != 0)
								{
									useEverettThreadAffinity = true;
								}
							}
						}
						catch (SecurityException)
						{
						}
						catch (InvalidCastException)
						{
						}
					}
				}
			}
			return useEverettThreadAffinity;
		}
	}

	private static string CompanyNameInternal
	{
		get
		{
			string text = null;
			Assembly entryAssembly = Assembly.GetEntryAssembly();
			if (entryAssembly != null)
			{
				object[] customAttributes = entryAssembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), inherit: false);
				if (customAttributes != null && customAttributes.Length != 0)
				{
					text = ((AssemblyCompanyAttribute)customAttributes[0]).Company;
				}
			}
			if (text == null || text.Length == 0)
			{
				text = GetAppFileVersionInfo().CompanyName;
				if (text != null)
				{
					text = text.Trim();
				}
			}
			if (text == null || text.Length == 0)
			{
				Type appMainType = GetAppMainType();
				if (appMainType != null)
				{
					string text2 = appMainType.Namespace;
					if (!string.IsNullOrEmpty(text2))
					{
						int num = text2.IndexOf(".", StringComparison.Ordinal);
						text = ((num == -1) ? text2 : text2.Substring(0, num));
					}
					else
					{
						text = ProductNameInternal;
					}
				}
			}
			return text;
		}
	}

	private static string ProductNameInternal
	{
		get
		{
			string text = null;
			Assembly entryAssembly = Assembly.GetEntryAssembly();
			if (entryAssembly != null)
			{
				object[] customAttributes = entryAssembly.GetCustomAttributes(typeof(AssemblyProductAttribute), inherit: false);
				if (customAttributes != null && customAttributes.Length != 0)
				{
					text = ((AssemblyProductAttribute)customAttributes[0]).Product;
				}
			}
			if (text == null || text.Length == 0)
			{
				text = GetAppFileVersionInfo().ProductName;
				if (text != null)
				{
					text = text.Trim();
				}
			}
			if (text == null || text.Length == 0)
			{
				Type appMainType = GetAppMainType();
				if (appMainType != null)
				{
					string text2 = appMainType.Namespace;
					if (!string.IsNullOrEmpty(text2))
					{
						int num = text2.LastIndexOf(".", StringComparison.Ordinal);
						text = ((num == -1 || num >= text2.Length - 1) ? text2 : text2.Substring(num + 1));
					}
					else
					{
						text = appMainType.Name;
					}
				}
			}
			return text;
		}
	}

	private static string ProductVersionInternal
	{
		get
		{
			string text = null;
			Assembly entryAssembly = Assembly.GetEntryAssembly();
			if (entryAssembly != null)
			{
				object[] customAttributes = entryAssembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), inherit: false);
				if (customAttributes != null && customAttributes.Length != 0)
				{
					text = ((AssemblyInformationalVersionAttribute)customAttributes[0]).InformationalVersion;
				}
			}
			if (text == null || text.Length == 0)
			{
				text = GetAppFileVersionInfo().ProductVersion;
				if (text != null)
				{
					text = text.Trim();
				}
			}
			if (text == null || text.Length == 0)
			{
				text = "1.0.0.0";
			}
			return text;
		}
	}

	private static string ExecutablePath
	{
		get
		{
			if (executablePath == null)
			{
				Assembly entryAssembly = Assembly.GetEntryAssembly();
				if (entryAssembly == null)
				{
					StringBuilder stringBuilder = new StringBuilder(260);
					Microsoft.Win32.UnsafeNativeMethods.GetModuleFileName(NativeMethods.NullHandleRef, stringBuilder, stringBuilder.Capacity);
					executablePath = IntSecurity.UnsafeGetFullPath(stringBuilder.ToString());
				}
				else
				{
					string escapedCodeBase = entryAssembly.EscapedCodeBase;
					Uri uri = new Uri(escapedCodeBase);
					if (uri.Scheme == "file")
					{
						executablePath = NativeMethods.GetLocalPath(escapedCodeBase);
					}
					else
					{
						executablePath = uri.ToString();
					}
				}
			}
			Uri uri2 = new Uri(executablePath);
			if (uri2.Scheme == "file")
			{
				new FileIOPermission(FileIOPermissionAccess.PathDiscovery, executablePath).Demand();
			}
			return executablePath;
		}
	}

	public static event EventHandler DisplaySettingsChanging
	{
		add
		{
			AddEventHandler(OnDisplaySettingsChangingEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnDisplaySettingsChangingEvent, value);
		}
	}

	public static event EventHandler DisplaySettingsChanged
	{
		add
		{
			AddEventHandler(OnDisplaySettingsChangedEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnDisplaySettingsChangedEvent, value);
		}
	}

	public static event EventHandler EventsThreadShutdown
	{
		add
		{
			AddEventHandler(OnEventsThreadShutdownEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnEventsThreadShutdownEvent, value);
		}
	}

	public static event EventHandler InstalledFontsChanged
	{
		add
		{
			AddEventHandler(OnInstalledFontsChangedEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnInstalledFontsChangedEvent, value);
		}
	}

	[Obsolete("This event has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static event EventHandler LowMemory
	{
		add
		{
			EnsureSystemEvents(requireHandle: true, throwOnRefusal: true);
			AddEventHandler(OnLowMemoryEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnLowMemoryEvent, value);
		}
	}

	public static event EventHandler PaletteChanged
	{
		add
		{
			AddEventHandler(OnPaletteChangedEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnPaletteChangedEvent, value);
		}
	}

	public static event PowerModeChangedEventHandler PowerModeChanged
	{
		add
		{
			EnsureSystemEvents(requireHandle: true, throwOnRefusal: true);
			AddEventHandler(OnPowerModeChangedEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnPowerModeChangedEvent, value);
		}
	}

	public static event SessionEndedEventHandler SessionEnded
	{
		add
		{
			EnsureSystemEvents(requireHandle: true, throwOnRefusal: false);
			AddEventHandler(OnSessionEndedEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnSessionEndedEvent, value);
		}
	}

	public static event SessionEndingEventHandler SessionEnding
	{
		add
		{
			EnsureSystemEvents(requireHandle: true, throwOnRefusal: false);
			AddEventHandler(OnSessionEndingEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnSessionEndingEvent, value);
		}
	}

	public static event SessionSwitchEventHandler SessionSwitch
	{
		add
		{
			EnsureSystemEvents(requireHandle: true, throwOnRefusal: true);
			EnsureRegisteredSessionNotification();
			AddEventHandler(OnSessionSwitchEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnSessionSwitchEvent, value);
		}
	}

	public static event EventHandler TimeChanged
	{
		add
		{
			EnsureSystemEvents(requireHandle: true, throwOnRefusal: false);
			AddEventHandler(OnTimeChangedEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnTimeChangedEvent, value);
		}
	}

	public static event TimerElapsedEventHandler TimerElapsed
	{
		add
		{
			EnsureSystemEvents(requireHandle: true, throwOnRefusal: false);
			AddEventHandler(OnTimerElapsedEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnTimerElapsedEvent, value);
		}
	}

	public static event UserPreferenceChangedEventHandler UserPreferenceChanged
	{
		add
		{
			AddEventHandler(OnUserPreferenceChangedEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnUserPreferenceChangedEvent, value);
		}
	}

	public static event UserPreferenceChangingEventHandler UserPreferenceChanging
	{
		add
		{
			AddEventHandler(OnUserPreferenceChangingEvent, value);
		}
		remove
		{
			RemoveEventHandler(OnUserPreferenceChangingEvent, value);
		}
	}

	private SystemEvents()
	{
	}

	private static void AddEventHandler(object key, Delegate value)
	{
		lock (eventLockObject)
		{
			if (_handlers == null)
			{
				_handlers = new Dictionary<object, List<SystemEventInvokeInfo>>();
				EnsureSystemEvents(requireHandle: false, throwOnRefusal: false);
			}
			if (!_handlers.TryGetValue(key, out var value2))
			{
				value2 = new List<SystemEventInvokeInfo>();
				_handlers[key] = value2;
			}
			else
			{
				value2 = _handlers[key];
			}
			value2.Add(new SystemEventInvokeInfo(value));
		}
	}

	private int ConsoleHandlerProc(int signalType)
	{
		switch (signalType)
		{
		case 5:
			OnSessionEnded((IntPtr)1, (IntPtr)int.MinValue);
			break;
		case 6:
			OnSessionEnded((IntPtr)1, (IntPtr)0);
			break;
		}
		return 0;
	}

	private void BumpQualifier()
	{
		staticwndclass = null;
		domainQualifier++;
	}

	private IntPtr CreateBroadcastWindow()
	{
		NativeMethods.WNDCLASS_I wNDCLASS_I = new NativeMethods.WNDCLASS_I();
		IntPtr moduleHandle = Microsoft.Win32.UnsafeNativeMethods.GetModuleHandle(null);
		if (!Microsoft.Win32.UnsafeNativeMethods.GetClassInfo(new HandleRef(this, moduleHandle), WndClass.lpszClassName, wNDCLASS_I))
		{
			if (Microsoft.Win32.UnsafeNativeMethods.RegisterClass(WndClass) == 0)
			{
				windowProc = null;
				return IntPtr.Zero;
			}
		}
		else if (wNDCLASS_I.lpfnWndProc == DefWndProc)
		{
			short num = 0;
			if (Microsoft.Win32.UnsafeNativeMethods.UnregisterClass(WndClass.lpszClassName, new HandleRef(null, Microsoft.Win32.UnsafeNativeMethods.GetModuleHandle(null))) != 0)
			{
				num = Microsoft.Win32.UnsafeNativeMethods.RegisterClass(WndClass);
			}
			if (num == 0)
			{
				do
				{
					BumpQualifier();
				}
				while (Microsoft.Win32.UnsafeNativeMethods.RegisterClass(WndClass) == 0 && Marshal.GetLastWin32Error() == 1410);
			}
		}
		return Microsoft.Win32.UnsafeNativeMethods.CreateWindowEx(0, WndClass.lpszClassName, WndClass.lpszClassName, int.MinValue, 0, 0, 0, 0, NativeMethods.NullHandleRef, NativeMethods.NullHandleRef, new HandleRef(this, moduleHandle), null);
	}

	public static IntPtr CreateTimer(int interval)
	{
		if (interval <= 0)
		{
			throw new ArgumentException(SR.GetString("InvalidLowBoundArgument", "interval", interval.ToString(Thread.CurrentThread.CurrentCulture), "0"));
		}
		EnsureSystemEvents(requireHandle: true, throwOnRefusal: true);
		IntPtr intPtr = Microsoft.Win32.UnsafeNativeMethods.SendMessage(new HandleRef(systemEvents, systemEvents.windowHandle), 1025, (IntPtr)interval, IntPtr.Zero);
		if (intPtr == IntPtr.Zero)
		{
			throw new ExternalException(SR.GetString("ErrorCreateTimer"));
		}
		return intPtr;
	}

	private void Dispose()
	{
		if (windowHandle != IntPtr.Zero)
		{
			if (registeredSessionNotification)
			{
				Microsoft.Win32.UnsafeNativeMethods.WTSUnRegisterSessionNotification(new HandleRef(systemEvents, systemEvents.windowHandle));
			}
			IntPtr handle = windowHandle;
			windowHandle = IntPtr.Zero;
			HandleRef handleRef = new HandleRef(this, handle);
			if (Microsoft.Win32.UnsafeNativeMethods.IsWindow(handleRef) && DefWndProc != IntPtr.Zero)
			{
				Microsoft.Win32.UnsafeNativeMethods.SetWindowLong(handleRef, -4, new HandleRef(this, DefWndProc));
				Microsoft.Win32.UnsafeNativeMethods.SetClassLong(handleRef, -24, DefWndProc);
			}
			if (Microsoft.Win32.UnsafeNativeMethods.IsWindow(handleRef) && !Microsoft.Win32.UnsafeNativeMethods.DestroyWindow(handleRef))
			{
				Microsoft.Win32.UnsafeNativeMethods.PostMessage(handleRef, 16, IntPtr.Zero, IntPtr.Zero);
			}
			else
			{
				IntPtr moduleHandle = Microsoft.Win32.UnsafeNativeMethods.GetModuleHandle(null);
				Microsoft.Win32.UnsafeNativeMethods.UnregisterClass(className, new HandleRef(this, moduleHandle));
			}
		}
		if (consoleHandler != null)
		{
			Microsoft.Win32.UnsafeNativeMethods.SetConsoleCtrlHandler(consoleHandler, 0);
			consoleHandler = null;
		}
	}

	private static void EnsureSystemEvents(bool requireHandle, bool throwOnRefusal)
	{
		if (systemEvents != null)
		{
			return;
		}
		lock (procLockObject)
		{
			if (systemEvents != null)
			{
				return;
			}
			if (Thread.GetDomain().GetData(".appDomain") != null)
			{
				if (throwOnRefusal)
				{
					throw new InvalidOperationException(SR.GetString("ErrorSystemEventsNotSupported"));
				}
				return;
			}
			if (!UserInteractive || Thread.CurrentThread.GetApartmentState() == ApartmentState.STA)
			{
				systemEvents = new SystemEvents();
				systemEvents.Initialize();
			}
			else
			{
				eventWindowReady = new ManualResetEvent(initialState: false);
				systemEvents = new SystemEvents();
				windowThread = new Thread(systemEvents.WindowThreadProc);
				windowThread.IsBackground = true;
				windowThread.Name = ".NET SystemEvents";
				windowThread.Start();
				eventWindowReady.WaitOne();
			}
			if (requireHandle && systemEvents.windowHandle == IntPtr.Zero)
			{
				throw new ExternalException(SR.GetString("ErrorCreateSystemEvents"));
			}
			startupRecreates = false;
		}
	}

	private static void EnsureRegisteredSessionNotification()
	{
		if (!registeredSessionNotification)
		{
			IntPtr intPtr = Microsoft.Win32.SafeNativeMethods.LoadLibrary("wtsapi32.dll");
			if (intPtr != IntPtr.Zero)
			{
				Microsoft.Win32.UnsafeNativeMethods.WTSRegisterSessionNotification(new HandleRef(systemEvents, systemEvents.windowHandle), 0);
				registeredSessionNotification = true;
				Microsoft.Win32.SafeNativeMethods.FreeLibrary(new HandleRef(null, intPtr));
			}
		}
	}

	private UserPreferenceCategory GetUserPreferenceCategory(int msg, IntPtr wParam, IntPtr lParam)
	{
		UserPreferenceCategory result = UserPreferenceCategory.General;
		switch (msg)
		{
		case 26:
			if (lParam != IntPtr.Zero && Marshal.PtrToStringAuto(lParam).Equals("Policy"))
			{
				result = UserPreferenceCategory.Policy;
				break;
			}
			if (lParam != IntPtr.Zero && Marshal.PtrToStringAuto(lParam).Equals("intl"))
			{
				result = UserPreferenceCategory.Locale;
				break;
			}
			switch ((int)wParam)
			{
			case 51:
			case 53:
			case 55:
			case 57:
			case 59:
			case 61:
			case 63:
			case 65:
			case 67:
			case 71:
				result = UserPreferenceCategory.Accessibility;
				break;
			case 19:
			case 20:
			case 21:
			case 47:
			case 75:
			case 87:
				result = UserPreferenceCategory.Desktop;
				break;
			case 13:
			case 24:
			case 26:
			case 34:
			case 46:
			case 88:
				result = UserPreferenceCategory.Icon;
				break;
			case 4:
			case 29:
			case 30:
			case 32:
			case 33:
			case 93:
			case 96:
			case 101:
			case 103:
			case 105:
			case 113:
			case 4111:
			case 4119:
			case 4121:
			case 4123:
				result = UserPreferenceCategory.Mouse;
				break;
			case 11:
			case 23:
			case 69:
			case 91:
				result = UserPreferenceCategory.Keyboard;
				break;
			case 28:
			case 107:
			case 4099:
			case 4115:
			case 4117:
				result = UserPreferenceCategory.Menu;
				break;
			case 81:
			case 82:
			case 85:
			case 86:
				result = UserPreferenceCategory.Power;
				break;
			case 15:
			case 17:
			case 97:
				result = UserPreferenceCategory.Screensaver;
				break;
			case 6:
			case 37:
			case 42:
			case 44:
			case 73:
			case 76:
			case 77:
			case 111:
			case 4097:
			case 4101:
			case 4103:
			case 4105:
			case 4107:
			case 4109:
			case 4159:
			case 8193:
			case 8195:
			case 8197:
			case 8199:
				result = UserPreferenceCategory.Window;
				break;
			}
			break;
		case 21:
			result = UserPreferenceCategory.Color;
			break;
		}
		return result;
	}

	private void Initialize()
	{
		consoleHandler = ConsoleHandlerProc;
		if (!Microsoft.Win32.UnsafeNativeMethods.SetConsoleCtrlHandler(consoleHandler, 1))
		{
			consoleHandler = null;
		}
		windowHandle = CreateBroadcastWindow();
		AppDomain.CurrentDomain.ProcessExit += Shutdown;
		AppDomain.CurrentDomain.DomainUnload += Shutdown;
	}

	private void InvokeMarshaledCallbacks()
	{
		Delegate obj = null;
		lock (threadCallbackList)
		{
			if (threadCallbackList.Count > 0)
			{
				obj = (Delegate)threadCallbackList.Dequeue();
			}
		}
		while ((object)obj != null)
		{
			try
			{
				if (obj is EventHandler eventHandler)
				{
					eventHandler(null, EventArgs.Empty);
				}
				else
				{
					obj.DynamicInvoke();
				}
			}
			catch (Exception)
			{
			}
			lock (threadCallbackList)
			{
				obj = ((threadCallbackList.Count <= 0) ? null : ((Delegate)threadCallbackList.Dequeue()));
			}
		}
	}

	public static void InvokeOnEventsThread(Delegate method)
	{
		EnsureSystemEvents(requireHandle: true, throwOnRefusal: true);
		if (threadCallbackList == null)
		{
			lock (eventLockObject)
			{
				if (threadCallbackList == null)
				{
					threadCallbackMessage = Microsoft.Win32.SafeNativeMethods.RegisterWindowMessage("SystemEventsThreadCallbackMessage");
					threadCallbackList = new Queue();
				}
			}
		}
		lock (threadCallbackList)
		{
			threadCallbackList.Enqueue(method);
		}
		Microsoft.Win32.UnsafeNativeMethods.PostMessage(new HandleRef(systemEvents, systemEvents.windowHandle), threadCallbackMessage, IntPtr.Zero, IntPtr.Zero);
	}

	public static void KillTimer(IntPtr timerId)
	{
		EnsureSystemEvents(requireHandle: true, throwOnRefusal: true);
		if (systemEvents.windowHandle != IntPtr.Zero && (int)Microsoft.Win32.UnsafeNativeMethods.SendMessage(new HandleRef(systemEvents, systemEvents.windowHandle), 1026, timerId, IntPtr.Zero) == 0)
		{
			throw new ExternalException(SR.GetString("ErrorKillTimer"));
		}
	}

	private IntPtr OnCreateTimer(IntPtr wParam)
	{
		IntPtr intPtr = (IntPtr)randomTimerId.Next();
		IntPtr intPtr2 = Microsoft.Win32.UnsafeNativeMethods.SetTimer(new HandleRef(this, windowHandle), new HandleRef(this, intPtr), (int)wParam, NativeMethods.NullHandleRef);
		if (!(intPtr2 == IntPtr.Zero))
		{
			return intPtr;
		}
		return IntPtr.Zero;
	}

	private void OnDisplaySettingsChanging()
	{
		RaiseEvent(OnDisplaySettingsChangingEvent, this, EventArgs.Empty);
	}

	private void OnDisplaySettingsChanged()
	{
		RaiseEvent(OnDisplaySettingsChangedEvent, this, EventArgs.Empty);
	}

	private void OnGenericEvent(object eventKey)
	{
		RaiseEvent(eventKey, this, EventArgs.Empty);
	}

	private void OnShutdown(object eventKey)
	{
		RaiseEvent(false, eventKey, this, EventArgs.Empty);
	}

	private bool OnKillTimer(IntPtr wParam)
	{
		return Microsoft.Win32.UnsafeNativeMethods.KillTimer(new HandleRef(this, windowHandle), new HandleRef(this, wParam));
	}

	private void OnPowerModeChanged(IntPtr wParam)
	{
		PowerModes mode;
		switch ((int)wParam)
		{
		default:
			return;
		case 4:
		case 5:
			mode = PowerModes.Suspend;
			break;
		case 6:
		case 7:
		case 8:
			mode = PowerModes.Resume;
			break;
		case 9:
		case 10:
		case 11:
			mode = PowerModes.StatusChange;
			break;
		}
		RaiseEvent(OnPowerModeChangedEvent, this, new PowerModeChangedEventArgs(mode));
	}

	private void OnSessionEnded(IntPtr wParam, IntPtr lParam)
	{
		if (wParam != (IntPtr)0)
		{
			SessionEndReasons reason = SessionEndReasons.SystemShutdown;
			if (((int)(long)lParam & int.MinValue) != 0)
			{
				reason = SessionEndReasons.Logoff;
			}
			SessionEndedEventArgs e = new SessionEndedEventArgs(reason);
			RaiseEvent(OnSessionEndedEvent, this, e);
		}
	}

	private int OnSessionEnding(IntPtr lParam)
	{
		int num = 1;
		SessionEndReasons reason = SessionEndReasons.SystemShutdown;
		if (((long)lParam & int.MinValue) != 0L)
		{
			reason = SessionEndReasons.Logoff;
		}
		SessionEndingEventArgs e = new SessionEndingEventArgs(reason);
		RaiseEvent(OnSessionEndingEvent, this, e);
		return (!e.Cancel) ? 1 : 0;
	}

	private void OnSessionSwitch(int wParam)
	{
		SessionSwitchEventArgs e = new SessionSwitchEventArgs((SessionSwitchReason)wParam);
		RaiseEvent(OnSessionSwitchEvent, this, e);
	}

	private void OnThemeChanged()
	{
		RaiseEvent(OnUserPreferenceChangingEvent, this, new UserPreferenceChangingEventArgs(UserPreferenceCategory.VisualStyle));
		UserPreferenceCategory category = UserPreferenceCategory.Window;
		RaiseEvent(OnUserPreferenceChangedEvent, this, new UserPreferenceChangedEventArgs(category));
		category = UserPreferenceCategory.VisualStyle;
		RaiseEvent(OnUserPreferenceChangedEvent, this, new UserPreferenceChangedEventArgs(category));
	}

	private void OnUserPreferenceChanged(int msg, IntPtr wParam, IntPtr lParam)
	{
		UserPreferenceCategory userPreferenceCategory = GetUserPreferenceCategory(msg, wParam, lParam);
		RaiseEvent(OnUserPreferenceChangedEvent, this, new UserPreferenceChangedEventArgs(userPreferenceCategory));
	}

	private void OnUserPreferenceChanging(int msg, IntPtr wParam, IntPtr lParam)
	{
		UserPreferenceCategory userPreferenceCategory = GetUserPreferenceCategory(msg, wParam, lParam);
		RaiseEvent(OnUserPreferenceChangingEvent, this, new UserPreferenceChangingEventArgs(userPreferenceCategory));
	}

	private void OnTimerElapsed(IntPtr wParam)
	{
		RaiseEvent(OnTimerElapsedEvent, this, new TimerElapsedEventArgs(wParam));
	}

	private static FileVersionInfo GetAppFileVersionInfo()
	{
		if (appFileVersion == null)
		{
			Type appMainType = GetAppMainType();
			if (appMainType != null)
			{
				FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
				fileIOPermission.AllFiles = FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery;
				fileIOPermission.Assert();
				try
				{
					appFileVersion = FileVersionInfo.GetVersionInfo(appMainType.Module.FullyQualifiedName);
				}
				finally
				{
					CodeAccessPermission.RevertAssert();
				}
			}
			else
			{
				appFileVersion = FileVersionInfo.GetVersionInfo(ExecutablePath);
			}
		}
		return (FileVersionInfo)appFileVersion;
	}

	private static Type GetAppMainType()
	{
		if (mainType == null)
		{
			Assembly entryAssembly = Assembly.GetEntryAssembly();
			if (entryAssembly != null)
			{
				mainType = entryAssembly.EntryPoint.ReflectedType;
			}
		}
		return mainType;
	}

	private static void RaiseEvent(object key, params object[] args)
	{
		RaiseEvent(checkFinalization: true, key, args);
	}

	private static void RaiseEvent(bool checkFinalization, object key, params object[] args)
	{
		if (checkFinalization && AppDomain.CurrentDomain.IsFinalizingForUnload())
		{
			return;
		}
		SystemEventInvokeInfo[] array = null;
		lock (eventLockObject)
		{
			if (_handlers != null && _handlers.ContainsKey(key))
			{
				List<SystemEventInvokeInfo> list = _handlers[key];
				if (list != null)
				{
					array = list.ToArray();
				}
			}
		}
		if (array == null)
		{
			return;
		}
		for (int i = 0; i < array.Length; i++)
		{
			try
			{
				SystemEventInvokeInfo systemEventInvokeInfo = array[i];
				systemEventInvokeInfo.Invoke(checkFinalization, args);
				array[i] = null;
			}
			catch (Exception)
			{
			}
		}
		lock (eventLockObject)
		{
			List<SystemEventInvokeInfo> value = null;
			foreach (SystemEventInvokeInfo systemEventInvokeInfo2 in array)
			{
				if (systemEventInvokeInfo2 != null)
				{
					if (value == null && !_handlers.TryGetValue(key, out value))
					{
						break;
					}
					value.Remove(systemEventInvokeInfo2);
				}
			}
		}
	}

	private static void RemoveEventHandler(object key, Delegate value)
	{
		lock (eventLockObject)
		{
			if (_handlers != null && _handlers.ContainsKey(key))
			{
				List<SystemEventInvokeInfo> list = _handlers[key];
				list.Remove(new SystemEventInvokeInfo(value));
			}
		}
	}

	private static void Startup()
	{
		if (startupRecreates)
		{
			EnsureSystemEvents(requireHandle: false, throwOnRefusal: false);
		}
	}

	private static void Shutdown()
	{
		if (systemEvents == null || !(systemEvents.windowHandle != IntPtr.Zero))
		{
			return;
		}
		lock (procLockObject)
		{
			if (systemEvents != null)
			{
				startupRecreates = true;
				if (windowThread != null)
				{
					eventThreadTerminated = new ManualResetEvent(initialState: false);
					Microsoft.Win32.UnsafeNativeMethods.PostMessage(new HandleRef(systemEvents, systemEvents.windowHandle), 18, IntPtr.Zero, IntPtr.Zero);
					eventThreadTerminated.WaitOne();
					windowThread.Join();
				}
				else
				{
					systemEvents.Dispose();
					systemEvents = null;
				}
			}
		}
	}

	[PrePrepareMethod]
	private static void Shutdown(object sender, EventArgs e)
	{
		Shutdown();
	}

	private IntPtr WindowProc(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam)
	{
		switch (msg)
		{
		case 26:
		{
			IntPtr lparam = lParam;
			if (lParam != IntPtr.Zero)
			{
				string text = Marshal.PtrToStringAuto(lParam);
				if (text != null)
				{
					lparam = Marshal.StringToHGlobalAuto(text);
				}
			}
			Microsoft.Win32.UnsafeNativeMethods.PostMessage(new HandleRef(this, windowHandle), 8192 + msg, wParam, lparam);
			break;
		}
		case 689:
			OnSessionSwitch((int)wParam);
			break;
		case 21:
		case 29:
		case 30:
		case 65:
		case 126:
		case 275:
		case 785:
		case 794:
			Microsoft.Win32.UnsafeNativeMethods.PostMessage(new HandleRef(this, windowHandle), 8192 + msg, wParam, lParam);
			break;
		case 1025:
			return OnCreateTimer(wParam);
		case 1026:
			return (IntPtr)(OnKillTimer(wParam) ? 1 : 0);
		case 8218:
			try
			{
				OnUserPreferenceChanging(msg - 8192, wParam, lParam);
				OnUserPreferenceChanged(msg - 8192, wParam, lParam);
			}
			finally
			{
				try
				{
					if (lParam != IntPtr.Zero)
					{
						Marshal.FreeHGlobal(lParam);
					}
				}
				catch (Exception)
				{
				}
			}
			break;
		case 8213:
			OnUserPreferenceChanging(msg - 8192, wParam, lParam);
			OnUserPreferenceChanged(msg - 8192, wParam, lParam);
			break;
		case 8986:
			OnThemeChanged();
			break;
		case 17:
			return (IntPtr)OnSessionEnding(lParam);
		case 22:
			OnSessionEnded(wParam, lParam);
			break;
		case 536:
			OnPowerModeChanged(wParam);
			break;
		case 8257:
			OnGenericEvent(OnLowMemoryEvent);
			break;
		case 8318:
			OnDisplaySettingsChanging();
			OnDisplaySettingsChanged();
			break;
		case 8221:
			OnGenericEvent(OnInstalledFontsChangedEvent);
			break;
		case 8977:
			OnGenericEvent(OnPaletteChangedEvent);
			break;
		case 8222:
			OnGenericEvent(OnTimeChangedEvent);
			break;
		case 8467:
			OnTimerElapsed(wParam);
			break;
		default:
			if (msg == threadCallbackMessage && msg != 0)
			{
				InvokeMarshaledCallbacks();
				return IntPtr.Zero;
			}
			break;
		}
		return Microsoft.Win32.UnsafeNativeMethods.DefWindowProc(hWnd, msg, wParam, lParam);
	}

	private void WindowThreadProc()
	{
		try
		{
			Initialize();
			eventWindowReady.Set();
			if (windowHandle != IntPtr.Zero)
			{
				NativeMethods.MSG msg = default(NativeMethods.MSG);
				bool flag = true;
				while (flag)
				{
					int num = Microsoft.Win32.UnsafeNativeMethods.MsgWaitForMultipleObjectsEx(0, IntPtr.Zero, 100, 255, 4);
					if (num == 258)
					{
						Thread.Sleep(1);
						continue;
					}
					while (Microsoft.Win32.UnsafeNativeMethods.PeekMessage(ref msg, NativeMethods.NullHandleRef, 0, 0, 1))
					{
						if (msg.message == 18)
						{
							flag = false;
							break;
						}
						Microsoft.Win32.UnsafeNativeMethods.TranslateMessage(ref msg);
						Microsoft.Win32.UnsafeNativeMethods.DispatchMessage(ref msg);
					}
				}
			}
			OnShutdown(OnEventsThreadShutdownEvent);
		}
		catch (Exception ex)
		{
			eventWindowReady.Set();
			if (!(ex is ThreadInterruptedException))
			{
				_ = ex is ThreadAbortException;
			}
		}
		Dispose();
		if (eventThreadTerminated != null)
		{
			eventThreadTerminated.Set();
		}
	}
}
