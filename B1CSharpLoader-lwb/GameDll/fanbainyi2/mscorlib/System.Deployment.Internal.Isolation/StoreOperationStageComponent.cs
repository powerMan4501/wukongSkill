using System.Runtime.InteropServices;

namespace System.Deployment.Internal.Isolation;

internal struct StoreOperationStageComponent
{
	[Flags]
	public enum OpFlags
	{
		Nothing = 0
	}

	public enum Disposition
	{
		Failed,
		Installed,
		Refreshed,
		AlreadyInstalled
	}

	[MarshalAs(UnmanagedType.U4)]
	public uint Size;

	[MarshalAs(UnmanagedType.U4)]
	public OpFlags Flags;

	[MarshalAs(UnmanagedType.Interface)]
	public IDefinitionAppId Application;

	[MarshalAs(UnmanagedType.Interface)]
	public IDefinitionIdentity Component;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string ManifestPath;

	public void Destroy()
	{
	}

	public StoreOperationStageComponent(IDefinitionAppId app, string Manifest)
		: this(app, null, Manifest)
	{
	}

	public StoreOperationStageComponent(IDefinitionAppId app, IDefinitionIdentity comp, string Manifest)
	{
		Size = (uint)Marshal.SizeOf(typeof(StoreOperationStageComponent));
		Flags = OpFlags.Nothing;
		Application = app;
		Component = comp;
		ManifestPath = Manifest;
	}
}
