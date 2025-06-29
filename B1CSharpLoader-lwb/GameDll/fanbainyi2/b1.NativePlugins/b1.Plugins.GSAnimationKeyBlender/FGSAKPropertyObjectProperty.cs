using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKPropertyObjectProperty", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKPropertyObjectProperty
{
	private static bool FGSAKPropertyObjectProperty_IsValid;

	private static int FGSAKPropertyObjectProperty_StructSize;

	public FGSAKPropertyObjectProperty Copy()
	{
		return this;
	}

	public static FGSAKPropertyObjectProperty FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKPropertyObjectProperty(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKPropertyObjectProperty value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKPropertyObjectProperty FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKPropertyObjectProperty(nativeBuffer + arrayIndex * FGSAKPropertyObjectProperty_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKPropertyObjectProperty value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKPropertyObjectProperty_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyObjectProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyObjectProperty");
		}
	}

	public FGSAKPropertyObjectProperty(IntPtr nativeStruct)
	{
		if (!FGSAKPropertyObjectProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKPropertyObjectProperty");
		}
	}

	static FGSAKPropertyObjectProperty()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKPropertyObjectProperty)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKPropertyObjectProperty));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKPropertyObjectProperty");
		FGSAKPropertyObjectProperty_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKPropertyObjectProperty_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKPropertyObjectProperty", FGSAKPropertyObjectProperty_IsValid);
	}
}
