using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKPropertyVector4", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKPropertyVector4
{
	private static bool FGSAKPropertyVector4_IsValid;

	private static int FGSAKPropertyVector4_StructSize;

	public FGSAKPropertyVector4 Copy()
	{
		return this;
	}

	public static FGSAKPropertyVector4 FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKPropertyVector4(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKPropertyVector4 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKPropertyVector4 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKPropertyVector4(nativeBuffer + arrayIndex * FGSAKPropertyVector4_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKPropertyVector4 value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKPropertyVector4_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyVector4_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyVector4");
		}
	}

	public FGSAKPropertyVector4(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyVector4_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyVector4");
		}
	}

	static FGSAKPropertyVector4()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKPropertyVector4)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKPropertyVector4));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKPropertyVector4");
		FGSAKPropertyVector4_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKPropertyVector4_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKPropertyVector4", FGSAKPropertyVector4_IsValid);
	}
}
