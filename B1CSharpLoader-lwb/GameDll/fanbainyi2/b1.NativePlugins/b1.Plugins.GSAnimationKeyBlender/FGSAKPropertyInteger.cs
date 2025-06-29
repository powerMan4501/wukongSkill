using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKPropertyInteger", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKPropertyInteger
{
	private static bool FGSAKPropertyInteger_IsValid;

	private static int FGSAKPropertyInteger_StructSize;

	public FGSAKPropertyInteger Copy()
	{
		return this;
	}

	public static FGSAKPropertyInteger FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKPropertyInteger(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKPropertyInteger value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKPropertyInteger FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKPropertyInteger(nativeBuffer + arrayIndex * FGSAKPropertyInteger_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKPropertyInteger value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKPropertyInteger_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyInteger_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyInteger");
		}
	}

	public FGSAKPropertyInteger(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyInteger_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyInteger");
		}
	}

	static FGSAKPropertyInteger()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKPropertyInteger)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKPropertyInteger));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKPropertyInteger");
		FGSAKPropertyInteger_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKPropertyInteger_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKPropertyInteger", FGSAKPropertyInteger_IsValid);
	}
}
