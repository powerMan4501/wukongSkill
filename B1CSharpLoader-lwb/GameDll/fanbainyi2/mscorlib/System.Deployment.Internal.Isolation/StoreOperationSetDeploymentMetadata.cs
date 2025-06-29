using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal struct StoreOperationSetDeploymentMetadata
{
	[Flags]
	public enum OpFlags
	{
		Nothing = 0
	}

	public enum Disposition
	{
		Failed = 0,
		Set = 2
	}

	[MarshalAs(UnmanagedType.U4)]
	public uint Size;

	[MarshalAs(UnmanagedType.U4)]
	public OpFlags Flags;

	[MarshalAs(UnmanagedType.Interface)]
	public IDefinitionAppId Deployment;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr InstallerReference;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr cPropertiesToTest;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr PropertiesToTest;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr cPropertiesToSet;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr PropertiesToSet;

	public StoreOperationSetDeploymentMetadata(IDefinitionAppId Deployment, StoreApplicationReference Reference, StoreOperationMetadataProperty[] SetProperties)
		: this(Deployment, Reference, SetProperties, null)
	{
	}

	[SecuritySafeCritical]
	public StoreOperationSetDeploymentMetadata(IDefinitionAppId Deployment, StoreApplicationReference Reference, StoreOperationMetadataProperty[] SetProperties, StoreOperationMetadataProperty[] TestProperties)
	{
		Size = (uint)Marshal.SizeOf(typeof(StoreOperationSetDeploymentMetadata));
		Flags = OpFlags.Nothing;
		this.Deployment = Deployment;
		if (SetProperties != null)
		{
			PropertiesToSet = MarshalProperties(SetProperties);
			cPropertiesToSet = new IntPtr(SetProperties.Length);
		}
		else
		{
			PropertiesToSet = IntPtr.Zero;
			cPropertiesToSet = IntPtr.Zero;
		}
		if (TestProperties != null)
		{
			PropertiesToTest = MarshalProperties(TestProperties);
			cPropertiesToTest = new IntPtr(TestProperties.Length);
		}
		else
		{
			PropertiesToTest = IntPtr.Zero;
			cPropertiesToTest = IntPtr.Zero;
		}
		InstallerReference = Reference.ToIntPtr();
	}

	[SecurityCritical]
	public void Destroy()
	{
		if (PropertiesToSet != IntPtr.Zero)
		{
			DestroyProperties(PropertiesToSet, (ulong)cPropertiesToSet.ToInt64());
			PropertiesToSet = IntPtr.Zero;
			cPropertiesToSet = IntPtr.Zero;
		}
		if (PropertiesToTest != IntPtr.Zero)
		{
			DestroyProperties(PropertiesToTest, (ulong)cPropertiesToTest.ToInt64());
			PropertiesToTest = IntPtr.Zero;
			cPropertiesToTest = IntPtr.Zero;
		}
		if (InstallerReference != IntPtr.Zero)
		{
			StoreApplicationReference.Destroy(InstallerReference);
			InstallerReference = IntPtr.Zero;
		}
	}

	[SecurityCritical]
	private static void DestroyProperties(IntPtr rgItems, ulong iItems)
	{
		if (rgItems != IntPtr.Zero)
		{
			IntPtr intPtr = rgItems;
			ulong num = (ulong)Marshal.SizeOf(typeof(StoreOperationMetadataProperty));
			for (ulong num2 = 0uL; num2 < iItems; num2++)
			{
				Marshal.DestroyStructure(new IntPtr((long)(num2 * num) + rgItems.ToInt64()), typeof(StoreOperationMetadataProperty));
			}
			Marshal.FreeCoTaskMem(rgItems);
		}
	}

	[SecurityCritical]
	private static IntPtr MarshalProperties(StoreOperationMetadataProperty[] Props)
	{
		if (Props == null || Props.Length == 0)
		{
			return IntPtr.Zero;
		}
		int num = Marshal.SizeOf(typeof(StoreOperationMetadataProperty));
		IntPtr result = Marshal.AllocCoTaskMem(num * Props.Length);
		for (int i = 0; i != Props.Length; i++)
		{
			Marshal.StructureToPtr(Props[i], new IntPtr(i * num + result.ToInt64()), fDeleteOld: false);
		}
		return result;
	}
}
