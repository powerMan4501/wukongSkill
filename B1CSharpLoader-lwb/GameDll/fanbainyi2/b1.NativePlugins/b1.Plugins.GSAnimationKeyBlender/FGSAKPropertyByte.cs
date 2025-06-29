using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKPropertyByte", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKPropertyByte
{
	private static bool FGSAKPropertyByte_IsValid;

	private static int FGSAKPropertyByte_StructSize;

	public FGSAKPropertyByte Copy()
	{
		return this;
	}

	public static FGSAKPropertyByte FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKPropertyByte(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKPropertyByte value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKPropertyByte FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKPropertyByte(nativeBuffer + arrayIndex * FGSAKPropertyByte_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKPropertyByte value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKPropertyByte_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyByte_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyByte");
		}
	}

	public FGSAKPropertyByte(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyByte_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyByte");
		}
	}

	static FGSAKPropertyByte()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKPropertyByte)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKPropertyByte));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKPropertyByte");
		FGSAKPropertyByte_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKPropertyByte_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKPropertyByte", FGSAKPropertyByte_IsValid);
	}
}
