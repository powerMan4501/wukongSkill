using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Diagnostics;

[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class Debugger
{
	private class CrossThreadDependencyNotification : ICustomDebuggerNotification
	{
	}

	private static bool s_triggerThreadAbortExceptionForDebugger;

	public static readonly string DefaultCategory;

	[__DynamicallyInvokable]
	public static extern bool IsAttached
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get;
	}

	[Obsolete("Do not create instances of the Debugger class.  Call the static methods directly on this type instead", true)]
	public Debugger()
	{
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void Break()
	{
		if (!IsAttached)
		{
			try
			{
				new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
			}
			catch (SecurityException)
			{
				return;
			}
		}
		BreakInternal();
	}

	[SecuritySafeCritical]
	private static void BreakCanThrow()
	{
		if (!IsAttached)
		{
			new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		}
		BreakInternal();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void BreakInternal();

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool Launch()
	{
		if (IsAttached)
		{
			return true;
		}
		try
		{
			new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		}
		catch (SecurityException)
		{
			return false;
		}
		return LaunchInternal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void NotifyOfCrossThreadDependencySlow()
	{
		CrossThreadDependencyNotification data = new CrossThreadDependencyNotification();
		CustomNotification(data);
		if (s_triggerThreadAbortExceptionForDebugger)
		{
			throw new ThreadAbortException();
		}
	}

	[ComVisible(false)]
	public static void NotifyOfCrossThreadDependency()
	{
		if (IsAttached)
		{
			NotifyOfCrossThreadDependencySlow();
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool LaunchInternal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	public static extern void Log(int level, string category, string message);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	public static extern bool IsLogging();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private static extern void CustomNotification(ICustomDebuggerNotification data);
}
