using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 1052673)]
[BlueprintType]
[UMetaPath("/Script/b1.ECSNetSerialization", "b1", UnrealModuleType.Game)]
public struct FECSNetSerialization
{
	private static bool FECSNetSerialization_IsValid;

	private static int FECSNetSerialization_StructSize;

	public FECSNetSerialization Copy()
	{
		return this;
	}

	public static FECSNetSerialization FromNative(IntPtr nativeBuffer)
	{
		return new FECSNetSerialization(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FECSNetSerialization value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FECSNetSerialization FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FECSNetSerialization(nativeBuffer + arrayIndex * FECSNetSerialization_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FECSNetSerialization value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FECSNetSerialization_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FECSNetSerialization_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.ECSNetSerialization");
		}
	}

	public FECSNetSerialization(IntPtr nativeStruct)
	{
		if (!FECSNetSerialization_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.ECSNetSerialization");
		}
	}

	static FECSNetSerialization()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FECSNetSerialization)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FECSNetSerialization));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.ECSNetSerialization");
		FECSNetSerialization_StructSize = NativeReflection.GetStructSize(intPtr);
		FECSNetSerialization_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/b1.ECSNetSerialization", FECSNetSerialization_IsValid);
	}
}
