using System.Runtime.InteropServices;

namespace System.Deployment.Internal.Isolation;

internal struct StoreOperationMetadataProperty
{
	public Guid GuidPropertySet;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string Name;

	[MarshalAs(UnmanagedType.SysUInt)]
	public IntPtr ValueSize;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string Value;

	public StoreOperationMetadataProperty(Guid PropertySet, string Name)
		: this(PropertySet, Name, null)
	{
	}

	public StoreOperationMetadataProperty(Guid PropertySet, string Name, string Value)
	{
		GuidPropertySet = PropertySet;
		this.Name = Name;
		this.Value = Value;
		ValueSize = ((Value != null) ? new IntPtr((Value.Length + 1) * 2) : IntPtr.Zero);
	}
}
