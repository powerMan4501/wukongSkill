using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKPropertyMargin", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKPropertyMargin
{
	private static bool FGSAKPropertyMargin_IsValid;

	private static int FGSAKPropertyMargin_StructSize;

	public FGSAKPropertyMargin Copy()
	{
		return this;
	}

	public static FGSAKPropertyMargin FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKPropertyMargin(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKPropertyMargin value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKPropertyMargin FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKPropertyMargin(nativeBuffer + arrayIndex * FGSAKPropertyMargin_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKPropertyMargin value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKPropertyMargin_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyMargin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyMargin");
		}
	}

	public FGSAKPropertyMargin(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyMargin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyMargin");
		}
	}

	static FGSAKPropertyMargin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKPropertyMargin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKPropertyMargin));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKPropertyMargin");
		FGSAKPropertyMargin_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKPropertyMargin_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKPropertyMargin", FGSAKPropertyMargin_IsValid);
	}
}
