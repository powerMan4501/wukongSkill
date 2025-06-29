using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSRichCaltureConfig", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSRichCaltureConfig
{
	private static bool FGSRichCaltureConfig_IsValid;

	private static int FGSRichCaltureConfig_StructSize;

	public FGSRichCaltureConfig Copy()
	{
		return this;
	}

	public static FGSRichCaltureConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSRichCaltureConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSRichCaltureConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSRichCaltureConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSRichCaltureConfig(nativeBuffer + arrayIndex * FGSRichCaltureConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSRichCaltureConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSRichCaltureConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSRichCaltureConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSRichCaltureConfig");
		}
	}

	public FGSRichCaltureConfig(IntPtr nativeStruct)
	{
		if (!FGSRichCaltureConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSRichCaltureConfig");
		}
	}

	static FGSRichCaltureConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSRichCaltureConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSRichCaltureConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GSRichCaltureConfig");
		FGSRichCaltureConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		FGSRichCaltureConfig_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GSRichCaltureConfig", FGSRichCaltureConfig_IsValid);
	}
}
