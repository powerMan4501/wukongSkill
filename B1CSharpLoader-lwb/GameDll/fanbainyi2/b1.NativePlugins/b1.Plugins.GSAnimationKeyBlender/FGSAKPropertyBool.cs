using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKPropertyBool", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKPropertyBool
{
	private static bool FGSAKPropertyBool_IsValid;

	private static int FGSAKPropertyBool_StructSize;

	public FGSAKPropertyBool Copy()
	{
		return this;
	}

	public static FGSAKPropertyBool FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKPropertyBool(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKPropertyBool value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKPropertyBool FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKPropertyBool(nativeBuffer + arrayIndex * FGSAKPropertyBool_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKPropertyBool value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKPropertyBool_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyBool");
		}
	}

	public FGSAKPropertyBool(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyBool");
		}
	}

	static FGSAKPropertyBool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKPropertyBool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKPropertyBool));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKPropertyBool");
		FGSAKPropertyBool_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKPropertyBool_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKPropertyBool", FGSAKPropertyBool_IsValid);
	}
}
