using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_CollectionLoop", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_CollectionLoop
{
	private static bool FRigUnit_CollectionLoop_IsValid;

	private static int FRigUnit_CollectionLoop_StructSize;

	public FRigUnit_CollectionLoop Copy()
	{
		return this;
	}

	public static FRigUnit_CollectionLoop FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_CollectionLoop(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_CollectionLoop value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_CollectionLoop FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_CollectionLoop(nativeBuffer + arrayIndex * FRigUnit_CollectionLoop_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_CollectionLoop value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_CollectionLoop_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionLoop_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionLoop");
		}
	}

	public FRigUnit_CollectionLoop(IntPtr nativeStruct)
	{
		if (!FRigUnit_CollectionLoop_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_CollectionLoop");
		}
	}

	static FRigUnit_CollectionLoop()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_CollectionLoop)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_CollectionLoop));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_CollectionLoop");
		FRigUnit_CollectionLoop_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_CollectionLoop_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_CollectionLoop", FRigUnit_CollectionLoop_IsValid);
	}
}
