using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKPropertyFloat", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKPropertyFloat
{
	private static bool FGSAKPropertyFloat_IsValid;

	private static int FGSAKPropertyFloat_StructSize;

	public FGSAKPropertyFloat Copy()
	{
		return this;
	}

	public static FGSAKPropertyFloat FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKPropertyFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKPropertyFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKPropertyFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKPropertyFloat(nativeBuffer + arrayIndex * FGSAKPropertyFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKPropertyFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKPropertyFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyFloat");
		}
	}

	public FGSAKPropertyFloat(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyFloat");
		}
	}

	static FGSAKPropertyFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKPropertyFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKPropertyFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKPropertyFloat");
		FGSAKPropertyFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKPropertyFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKPropertyFloat", FGSAKPropertyFloat_IsValid);
	}
}
