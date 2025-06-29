using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKBMatParamsData", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKBMatParamsData
{
	private static bool FGSAKBMatParamsData_IsValid;

	private static int FGSAKBMatParamsData_StructSize;

	public FGSAKBMatParamsData Copy()
	{
		return this;
	}

	public static FGSAKBMatParamsData FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKBMatParamsData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKBMatParamsData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKBMatParamsData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKBMatParamsData(nativeBuffer + arrayIndex * FGSAKBMatParamsData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKBMatParamsData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKBMatParamsData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKBMatParamsData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKBMatParamsData");
		}
	}

	public FGSAKBMatParamsData(IntPtr nativeStruct)
	{
		if (!FGSAKBMatParamsData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKBMatParamsData");
		}
	}

	static FGSAKBMatParamsData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKBMatParamsData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKBMatParamsData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKBMatParamsData");
		FGSAKBMatParamsData_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKBMatParamsData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKBMatParamsData", FGSAKBMatParamsData_IsValid);
	}
}
