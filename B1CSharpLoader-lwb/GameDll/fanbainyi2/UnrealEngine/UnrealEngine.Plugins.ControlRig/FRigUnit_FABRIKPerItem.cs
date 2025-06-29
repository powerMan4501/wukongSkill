using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_FABRIKPerItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FABRIKPerItem
{
	private static bool FRigUnit_FABRIKPerItem_IsValid;

	private static int FRigUnit_FABRIKPerItem_StructSize;

	public FRigUnit_FABRIKPerItem Copy()
	{
		return this;
	}

	public static FRigUnit_FABRIKPerItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FABRIKPerItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FABRIKPerItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FABRIKPerItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FABRIKPerItem(nativeBuffer + arrayIndex * FRigUnit_FABRIKPerItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FABRIKPerItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FABRIKPerItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FABRIKPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FABRIKPerItem");
		}
	}

	public FRigUnit_FABRIKPerItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_FABRIKPerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FABRIKPerItem");
		}
	}

	static FRigUnit_FABRIKPerItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FABRIKPerItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FABRIKPerItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_FABRIKPerItem");
		FRigUnit_FABRIKPerItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FABRIKPerItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_FABRIKPerItem", FRigUnit_FABRIKPerItem_IsValid);
	}
}
