using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CCDIKPerItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CCDIKPerItem
{
	private static bool FRigUnit_CCDIKPerItem_IsValid;

	private static int FRigUnit_CCDIKPerItem_StructSize;

	public FRigUnit_CCDIKPerItem Copy()
	{
		return this;
	}

	public static FRigUnit_CCDIKPerItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CCDIKPerItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CCDIKPerItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CCDIKPerItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CCDIKPerItem(nativeBuffer + arrayIndex * FRigUnit_CCDIKPerItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CCDIKPerItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CCDIKPerItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CCDIKPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CCDIKPerItem");
		}
	}

	public FRigUnit_CCDIKPerItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_CCDIKPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CCDIKPerItem");
		}
	}

	static FRigUnit_CCDIKPerItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CCDIKPerItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CCDIKPerItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CCDIKPerItem");
		FRigUnit_CCDIKPerItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CCDIKPerItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CCDIKPerItem", FRigUnit_CCDIKPerItem_IsValid);
	}
}
