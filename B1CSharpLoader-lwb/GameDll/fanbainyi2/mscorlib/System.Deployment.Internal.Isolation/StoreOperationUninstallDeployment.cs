using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal struct StoreOperationUninstallDeployment
{
	[Flags]
	public enum OpFlags
	{
		Nothing = 0
	}

	public enum Disposition
	{
		Failed,
		DidNotExist,
		Uninstalled
	}

	[MarshalAs(UnmanagedType.U4)]
	public uint Size;

	[MarshalAs(UnmanagedType.U4)]
	public OpFlags Flags;

	[MarshalAs(UnmanagedType.Interface)]
	public IDefinitionAppId Application;

	public IntPtr Reference;

	[SecuritySafeCritical]
	public StoreOperationUninstallDeployment(IDefinitionAppId appid, StoreApplicationReference AppRef)
	{
		Size = (uint)Marshal.SizeOf(typeof(StoreOperationUninstallDeployment));
		Flags = OpFlags.Nothing;
		Application = appid;
		Reference = AppRef.ToIntPtr();
	}

	[SecurityCritical]
	public void Destroy()
	{
		StoreApplicationReference.Destroy(Reference);
	}
}
