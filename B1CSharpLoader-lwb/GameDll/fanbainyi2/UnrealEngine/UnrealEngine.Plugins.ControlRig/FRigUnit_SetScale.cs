using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetScale", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetScale
{
	private static bool FRigUnit_SetScale_IsValid;

	private static int FRigUnit_SetScale_StructSize;

	public FRigUnit_SetScale Copy()
	{
		return this;
	}

	public static FRigUnit_SetScale FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetScale(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetScale value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetScale FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetScale(nativeBuffer + arrayIndex * FRigUnit_SetScale_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetScale value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetScale_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetScale_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetScale");
		}
	}

	public FRigUnit_SetScale(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetScale_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetScale");
		}
	}

	static FRigUnit_SetScale()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetScale)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetScale));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetScale");
		FRigUnit_SetScale_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetScale_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetScale", FRigUnit_SetScale_IsValid);
	}
}
