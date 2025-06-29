using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FGSRepGraphConfig")]
public struct FGSRepGraphConfig
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSRepGraphConfig:PatitionLayerConfig")]
	public FGSCellPatitionLayerConfig PatitionLayerConfig;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSRepGraphConfig:RepGraphLevel")]
	public int RepGraphLevel;

	private static int FGSRepGraphConfig_StructSize;

	private static int FGSRepGraphConfig_IsValid;

	private static bool PatitionLayerConfig_IsValid;

	private static int PatitionLayerConfig_Offset;

	private static bool RepGraphLevel_IsValid;

	private static int RepGraphLevel_Offset;

	public FGSRepGraphConfig Copy()
	{
		return this;
	}

	public static FGSRepGraphConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSRepGraphConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSRepGraphConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSRepGraphConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSRepGraphConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSRepGraphConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSRepGraphConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSRepGraphConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSRepGraphConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSRepGraphConfig");
			return;
		}
		FGSCellPatitionLayerConfig.ToNative(IntPtr.Add(nativeStruct, PatitionLayerConfig_Offset), PatitionLayerConfig);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RepGraphLevel_Offset), RepGraphLevel);
	}

	public FGSRepGraphConfig(IntPtr nativeStruct)
	{
		if (FGSRepGraphConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSRepGraphConfig");
			PatitionLayerConfig = default(FGSCellPatitionLayerConfig);
			RepGraphLevel = 0;
		}
		else
		{
			PatitionLayerConfig = FGSCellPatitionLayerConfig.FromNative(IntPtr.Add(nativeStruct, PatitionLayerConfig_Offset));
			RepGraphLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RepGraphLevel_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSRepGraphConfig");
		FGSRepGraphConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		PatitionLayerConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "PatitionLayerConfig");
		PatitionLayerConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PatitionLayerConfig", Classes.FStructProperty);
		RepGraphLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "RepGraphLevel");
		RepGraphLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RepGraphLevel", Classes.FIntProperty);
		FGSRepGraphConfig_IsValid = ((intPtr != IntPtr.Zero && PatitionLayerConfig_IsValid && RepGraphLevel_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSRepGraphConfig", (byte)FGSRepGraphConfig_IsValid != 0);
	}

	static FGSRepGraphConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSRepGraphConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSRepGraphConfig));
	}
}
