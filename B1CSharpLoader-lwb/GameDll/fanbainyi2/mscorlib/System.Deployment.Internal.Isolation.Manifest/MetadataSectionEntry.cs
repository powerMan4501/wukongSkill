using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation.Manifest;

[StructLayout(LayoutKind.Sequential)]
internal class MetadataSectionEntry : IDisposable
{
	public uint SchemaVersion;

	public uint ManifestFlags;

	public uint UsagePatterns;

	public IDefinitionIdentity CdfIdentity;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string LocalPath;

	public uint HashAlgorithm;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr ManifestHash;

	public uint ManifestHashSize;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string ContentType;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string RuntimeImageVersion;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr MvidValue;

	public uint MvidValueSize;

	public DescriptionMetadataEntry DescriptionData;

	public DeploymentMetadataEntry DeploymentData;

	public DependentOSMetadataEntry DependentOSData;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string defaultPermissionSetID;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string RequestedExecutionLevel;

	public bool RequestedExecutionLevelUIAccess;

	public IReferenceIdentity ResourceTypeResourcesDependency;

	public IReferenceIdentity ResourceTypeManifestResourcesDependency;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string KeyInfoElement;

	public CompatibleFrameworksMetadataEntry CompatibleFrameworksData;

	~MetadataSectionEntry()
	{
		Dispose(fDisposing: false);
	}

	void IDisposable.Dispose()
	{
		Dispose(fDisposing: true);
	}

	[SecuritySafeCritical]
	public void Dispose(bool fDisposing)
	{
		if (ManifestHash != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(ManifestHash);
			ManifestHash = IntPtr.Zero;
		}
		if (MvidValue != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(MvidValue);
			MvidValue = IntPtr.Zero;
		}
		if (fDisposing)
		{
			GC.SuppressFinalize(this);
		}
	}
}
