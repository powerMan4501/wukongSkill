using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKObjectEasingOneToOneStateData", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKObjectEasingOneToOneStateData
{
	private static bool FGSAKObjectEasingOneToOneStateData_IsValid;

	private static int FGSAKObjectEasingOneToOneStateData_StructSize;

	public FGSAKObjectEasingOneToOneStateData Copy()
	{
		return this;
	}

	public static FGSAKObjectEasingOneToOneStateData FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKObjectEasingOneToOneStateData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKObjectEasingOneToOneStateData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKObjectEasingOneToOneStateData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKObjectEasingOneToOneStateData(nativeBuffer + arrayIndex * FGSAKObjectEasingOneToOneStateData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKObjectEasingOneToOneStateData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKObjectEasingOneToOneStateData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKObjectEasingOneToOneStateData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKObjectEasingOneToOneStateData");
		}
	}

	public FGSAKObjectEasingOneToOneStateData(IntPtr nativeStruct)
	{
		if (!FGSAKObjectEasingOneToOneStateData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKObjectEasingOneToOneStateData");
		}
	}

	static FGSAKObjectEasingOneToOneStateData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKObjectEasingOneToOneStateData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKObjectEasingOneToOneStateData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKObjectEasingOneToOneStateData");
		FGSAKObjectEasingOneToOneStateData_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKObjectEasingOneToOneStateData_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKObjectEasingOneToOneStateData", FGSAKObjectEasingOneToOneStateData_IsValid);
	}
}
