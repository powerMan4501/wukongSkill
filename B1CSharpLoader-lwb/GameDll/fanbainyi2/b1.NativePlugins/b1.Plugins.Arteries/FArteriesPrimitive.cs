using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.Arteries;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Arteries.ArteriesPrimitive", "Arteries", UnrealModuleType.GamePlugin)]
public struct FArteriesPrimitive
{
	private static bool FArteriesPrimitive_IsValid;

	private static int FArteriesPrimitive_StructSize;

	public FArteriesPrimitive Copy()
	{
		return this;
	}

	public static FArteriesPrimitive FromNative(IntPtr nativeBuffer)
	{
		return new FArteriesPrimitive(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FArteriesPrimitive value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FArteriesPrimitive FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FArteriesPrimitive(nativeBuffer + arrayIndex * FArteriesPrimitive_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FArteriesPrimitive value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FArteriesPrimitive_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FArteriesPrimitive_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Arteries.ArteriesPrimitive");
		}
	}

	public FArteriesPrimitive(IntPtr nativeStruct)
	{
		if (!FArteriesPrimitive_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Arteries.ArteriesPrimitive");
		}
	}

	static FArteriesPrimitive()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FArteriesPrimitive)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FArteriesPrimitive));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Arteries.ArteriesPrimitive");
		FArteriesPrimitive_StructSize = NativeReflection.GetStructSize(intPtr);
		FArteriesPrimitive_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Arteries.ArteriesPrimitive", FArteriesPrimitive_IsValid);
	}
}
