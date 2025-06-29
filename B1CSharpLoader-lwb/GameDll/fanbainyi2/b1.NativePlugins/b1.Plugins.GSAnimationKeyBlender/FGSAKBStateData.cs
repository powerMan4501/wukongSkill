using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKBStateData", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKBStateData
{
	private static bool FGSAKBStateData_IsValid;

	private static int FGSAKBStateData_StructSize;

	public FGSAKBStateData Copy()
	{
		return this;
	}

	public static FGSAKBStateData FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKBStateData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKBStateData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKBStateData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKBStateData(nativeBuffer + arrayIndex * FGSAKBStateData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKBStateData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKBStateData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKBStateData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKBStateData");
		}
	}

	public FGSAKBStateData(IntPtr nativeStruct)
	{
		if (!FGSAKBStateData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKBStateData");
		}
	}

	static FGSAKBStateData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKBStateData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKBStateData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKBStateData");
		FGSAKBStateData_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKBStateData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKBStateData", FGSAKBStateData_IsValid);
	}
}
