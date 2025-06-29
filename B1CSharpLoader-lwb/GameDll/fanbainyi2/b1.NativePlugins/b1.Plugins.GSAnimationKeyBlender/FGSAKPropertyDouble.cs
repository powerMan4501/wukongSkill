using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKPropertyDouble", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKPropertyDouble
{
	private static bool FGSAKPropertyDouble_IsValid;

	private static int FGSAKPropertyDouble_StructSize;

	public FGSAKPropertyDouble Copy()
	{
		return this;
	}

	public static FGSAKPropertyDouble FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKPropertyDouble(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKPropertyDouble value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKPropertyDouble FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKPropertyDouble(nativeBuffer + arrayIndex * FGSAKPropertyDouble_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKPropertyDouble value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKPropertyDouble_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyDouble_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyDouble");
		}
	}

	public FGSAKPropertyDouble(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyDouble_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyDouble");
		}
	}

	static FGSAKPropertyDouble()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKPropertyDouble)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKPropertyDouble));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKPropertyDouble");
		FGSAKPropertyDouble_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKPropertyDouble_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKPropertyDouble", FGSAKPropertyDouble_IsValid);
	}
}
