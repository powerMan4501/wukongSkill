using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PoseGetItems", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PoseGetItems
{
	private static bool FRigUnit_PoseGetItems_IsValid;

	private static int FRigUnit_PoseGetItems_StructSize;

	public FRigUnit_PoseGetItems Copy()
	{
		return this;
	}

	public static FRigUnit_PoseGetItems FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PoseGetItems(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PoseGetItems value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PoseGetItems FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PoseGetItems(nativeBuffer + arrayIndex * FRigUnit_PoseGetItems_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PoseGetItems value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PoseGetItems_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetItems_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetItems");
		}
	}

	public FRigUnit_PoseGetItems(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetItems_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetItems");
		}
	}

	static FRigUnit_PoseGetItems()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PoseGetItems)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PoseGetItems));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PoseGetItems");
		FRigUnit_PoseGetItems_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PoseGetItems_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PoseGetItems", FRigUnit_PoseGetItems_IsValid);
	}
}
