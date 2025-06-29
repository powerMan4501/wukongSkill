using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ConvertVectorToQuaternion", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ConvertVectorToQuaternion
{
	private static bool FRigUnit_ConvertVectorToQuaternion_IsValid;

	private static int FRigUnit_ConvertVectorToQuaternion_StructSize;

	public FRigUnit_ConvertVectorToQuaternion Copy()
	{
		return this;
	}

	public static FRigUnit_ConvertVectorToQuaternion FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ConvertVectorToQuaternion(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ConvertVectorToQuaternion value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ConvertVectorToQuaternion FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ConvertVectorToQuaternion(nativeBuffer + arrayIndex * FRigUnit_ConvertVectorToQuaternion_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ConvertVectorToQuaternion value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ConvertVectorToQuaternion_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertVectorToQuaternion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertVectorToQuaternion");
		}
	}

	public FRigUnit_ConvertVectorToQuaternion(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertVectorToQuaternion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertVectorToQuaternion");
		}
	}

	static FRigUnit_ConvertVectorToQuaternion()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ConvertVectorToQuaternion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ConvertVectorToQuaternion));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ConvertVectorToQuaternion");
		FRigUnit_ConvertVectorToQuaternion_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ConvertVectorToQuaternion_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ConvertVectorToQuaternion", FRigUnit_ConvertVectorToQuaternion_IsValid);
	}
}
