using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAKBStateEasingCfg", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAKBStateEasingCfg
{
	private static bool FGSAKBStateEasingCfg_IsValid;

	private static int FGSAKBStateEasingCfg_StructSize;

	public FGSAKBStateEasingCfg Copy()
	{
		return this;
	}

	public static FGSAKBStateEasingCfg FromNative(IntPtr nativeBuffer)
	{
		return new FGSAKBStateEasingCfg(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAKBStateEasingCfg value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAKBStateEasingCfg FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAKBStateEasingCfg(nativeBuffer + arrayIndex * FGSAKBStateEasingCfg_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAKBStateEasingCfg value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAKBStateEasingCfg_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAKBStateEasingCfg_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKBStateEasingCfg");
		}
	}

	public FGSAKBStateEasingCfg(IntPtr nativeStruct)
	{
		if (!FGSAKBStateEasingCfg_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAKBStateEasingCfg");
		}
	}

	static FGSAKBStateEasingCfg()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAKBStateEasingCfg)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAKBStateEasingCfg));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAKBStateEasingCfg");
		FGSAKBStateEasingCfg_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSAKBStateEasingCfg_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAKBStateEasingCfg", FGSAKBStateEasingCfg_IsValid);
	}
}
