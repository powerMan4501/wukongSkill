using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKPropertyLinearColor", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKPropertyLinearColor
{
	private static bool FGSAKPropertyLinearColor_IsValid;

	private static int FGSAKPropertyLinearColor_StructSize;

	public FGSAKPropertyLinearColor Copy()
	{
		return this;
	}

	public static FGSAKPropertyLinearColor FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKPropertyLinearColor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKPropertyLinearColor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKPropertyLinearColor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKPropertyLinearColor(nativeBuffer + arrayIndex * FGSAKPropertyLinearColor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKPropertyLinearColor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKPropertyLinearColor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyLinearColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyLinearColor");
		}
	}

	public FGSAKPropertyLinearColor(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyLinearColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyLinearColor");
		}
	}

	static FGSAKPropertyLinearColor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKPropertyLinearColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKPropertyLinearColor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKPropertyLinearColor");
		FGSAKPropertyLinearColor_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKPropertyLinearColor_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKPropertyLinearColor", FGSAKPropertyLinearColor_IsValid);
	}
}
