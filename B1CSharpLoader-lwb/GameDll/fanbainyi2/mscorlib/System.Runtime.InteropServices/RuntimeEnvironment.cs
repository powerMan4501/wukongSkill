using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace System.Runtime.InteropServices;

[ComVisible(true)]
public class RuntimeEnvironment
{
	public static string SystemConfigurationFile
	{
		[SecuritySafeCritical]
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			stringBuilder.Append(GetRuntimeDirectory());
			stringBuilder.Append(AppDomainSetup.RuntimeConfigurationFile);
			string text = stringBuilder.ToString();
			new FileIOPermission(FileIOPermissionAccess.PathDiscovery, text).Demand();
			return text;
		}
	}

	[Obsolete("Do not create instances of the RuntimeEnvironment class.  Call the static methods directly on this type instead", true)]
	public RuntimeEnvironment()
	{
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string GetModuleFileName();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string GetDeveloperPath();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string GetHostBindingFile();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void _GetSystemVersion(StringHandleOnStack retVer);

	public static bool FromGlobalAccessCache(Assembly a)
	{
		return a.GlobalAssemblyCache;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static string GetSystemVersion()
	{
		string s = null;
		_GetSystemVersion(JitHelpers.GetStringHandleOnStack(ref s));
		return s;
	}

	[SecuritySafeCritical]
	public static string GetRuntimeDirectory()
	{
		string runtimeDirectoryImpl = GetRuntimeDirectoryImpl();
		new FileIOPermission(FileIOPermissionAccess.PathDiscovery, runtimeDirectoryImpl).Demand();
		return runtimeDirectoryImpl;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string GetRuntimeDirectoryImpl();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr GetRuntimeInterfaceImpl([In][MarshalAs(UnmanagedType.LPStruct)] Guid clsid, [In][MarshalAs(UnmanagedType.LPStruct)] Guid riid);

	[SecurityCritical]
	[ComVisible(false)]
	public static IntPtr GetRuntimeInterfaceAsIntPtr(Guid clsid, Guid riid)
	{
		return GetRuntimeInterfaceImpl(clsid, riid);
	}

	[SecurityCritical]
	[ComVisible(false)]
	public static object GetRuntimeInterfaceAsObject(Guid clsid, Guid riid)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = GetRuntimeInterfaceImpl(clsid, riid);
			return Marshal.GetObjectForIUnknown(intPtr);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.Release(intPtr);
			}
		}
	}
}
