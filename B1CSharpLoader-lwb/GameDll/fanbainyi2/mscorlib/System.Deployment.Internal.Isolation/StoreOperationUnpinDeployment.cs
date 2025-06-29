using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal struct StoreOperationUnpinDeployment
{
	[Flags]
	public enum OpFlags
	{
		Nothing = 0
	}

	public enum Disposition
	{
		Failed,
		Unpinned
	}

	[MarshalAs(UnmanagedType.U4)]
	public uint Size;

	[MarshalAs(UnmanagedType.U4)]
	public OpFlags Flags;

	[MarshalAs(UnmanagedType.Interface)]
	public IDefinitionAppId Application;

	public IntPtr Reference;

	[SecuritySafeCritical]
	public StoreOperationUnpinDeployment(IDefinitionAppId app, StoreApplicationReference reference)
	{
		Size = (uint)Marshal.SizeOf(typeof(StoreOperationUnpinDeployment));
		Flags = OpFlags.Nothing;
		Application = app;
		Reference = reference.ToIntPtr();
	}

	[SecurityCritical]
	public void Destroy()
	{
		StoreApplicationReference.Destroy(Reference);
	}
}
