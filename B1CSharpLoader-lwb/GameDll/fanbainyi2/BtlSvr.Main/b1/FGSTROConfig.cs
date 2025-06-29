using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FGSTROConfig")]
public struct FGSTROConfig
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSTROConfig:PatitionLayerConfig")]
	public FGSCellPatitionLayerConfig PatitionLayerConfig;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSTROConfig:TROLevel")]
	public int TROLevel;

	private static int FGSTROConfig_StructSize;

	private static int FGSTROConfig_IsValid;

	private static bool PatitionLayerConfig_IsValid;

	private static int PatitionLayerConfig_Offset;

	private static bool TROLevel_IsValid;

	private static int TROLevel_Offset;

	public FGSTROConfig Copy()
	{
		return this;
	}

	public static FGSTROConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSTROConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSTROConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSTROConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSTROConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSTROConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSTROConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSTROConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSTROConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSTROConfig");
			return;
		}
		FGSCellPatitionLayerConfig.ToNative(IntPtr.Add(nativeStruct, PatitionLayerConfig_Offset), PatitionLayerConfig);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TROLevel_Offset), TROLevel);
	}

	public FGSTROConfig(IntPtr nativeStruct)
	{
		if (FGSTROConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSTROConfig");
			PatitionLayerConfig = default(FGSCellPatitionLayerConfig);
			TROLevel = 0;
		}
		else
		{
			PatitionLayerConfig = FGSCellPatitionLayerConfig.FromNative(IntPtr.Add(nativeStruct, PatitionLayerConfig_Offset));
			TROLevel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TROLevel_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSTROConfig");
		FGSTROConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		PatitionLayerConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "PatitionLayerConfig");
		PatitionLayerConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PatitionLayerConfig", Classes.FStructProperty);
		TROLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "TROLevel");
		TROLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TROLevel", Classes.FIntProperty);
		FGSTROConfig_IsValid = ((intPtr != IntPtr.Zero && PatitionLayerConfig_IsValid && TROLevel_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSTROConfig", (byte)FGSTROConfig_IsValid != 0);
	}

	static FGSTROConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSTROConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSTROConfig));
	}
}
