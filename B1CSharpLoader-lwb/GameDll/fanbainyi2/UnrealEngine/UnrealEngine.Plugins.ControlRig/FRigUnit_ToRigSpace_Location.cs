using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ToRigSpace_Location", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ToRigSpace_Location
{
	private static bool FRigUnit_ToRigSpace_Location_IsValid;

	private static int FRigUnit_ToRigSpace_Location_StructSize;

	public FRigUnit_ToRigSpace_Location Copy()
	{
		return this;
	}

	public static FRigUnit_ToRigSpace_Location FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ToRigSpace_Location(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ToRigSpace_Location value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ToRigSpace_Location FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ToRigSpace_Location(nativeBuffer + arrayIndex * FRigUnit_ToRigSpace_Location_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ToRigSpace_Location value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ToRigSpace_Location_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToRigSpace_Location_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToRigSpace_Location");
		}
	}

	public FRigUnit_ToRigSpace_Location(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToRigSpace_Location_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToRigSpace_Location");
		}
	}

	static FRigUnit_ToRigSpace_Location()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ToRigSpace_Location)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ToRigSpace_Location));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ToRigSpace_Location");
		FRigUnit_ToRigSpace_Location_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ToRigSpace_Location_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ToRigSpace_Location", FRigUnit_ToRigSpace_Location_IsValid);
	}
}
