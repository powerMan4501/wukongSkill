using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKBMatStateData", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKBMatStateData
{
	private static bool FGSAKBMatStateData_IsValid;

	private static int FGSAKBMatStateData_StructSize;

	public FGSAKBMatStateData Copy()
	{
		return this;
	}

	public static FGSAKBMatStateData FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKBMatStateData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKBMatStateData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKBMatStateData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKBMatStateData(nativeBuffer + arrayIndex * FGSAKBMatStateData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKBMatStateData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKBMatStateData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKBMatStateData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKBMatStateData");
		}
	}

	public FGSAKBMatStateData(IntPtr nativeStruct)
	{
		if (!FGSAKBMatStateData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKBMatStateData");
		}
	}

	static FGSAKBMatStateData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKBMatStateData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKBMatStateData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKBMatStateData");
		FGSAKBMatStateData_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKBMatStateData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKBMatStateData", FGSAKBMatStateData_IsValid);
	}
}
