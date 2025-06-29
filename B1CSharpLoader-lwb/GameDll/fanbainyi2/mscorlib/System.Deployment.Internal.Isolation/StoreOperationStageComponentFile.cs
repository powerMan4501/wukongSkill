using System.Runtime.InteropServices;

namespace System.Deployment.Internal.Isolation;

internal struct StoreOperationStageComponentFile
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
	public string ComponentRelativePath;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string SourceFilePath;

	public StoreOperationStageComponentFile(IDefinitionAppId App, string CompRelPath, string SrcFile)
		: this(App, null, CompRelPath, SrcFile)
	{
	}

	public StoreOperationStageComponentFile(IDefinitionAppId App, IDefinitionIdentity Component, string CompRelPath, string SrcFile)
	{
		Size = (uint)Marshal.SizeOf(typeof(StoreOperationStageComponentFile));
		Flags = OpFlags.Nothing;
		Application = App;
		this.Component = Component;
		ComponentRelativePath = CompRelPath;
		SourceFilePath = SrcFile;
	}

	public void Destroy()
	{
	}
}
