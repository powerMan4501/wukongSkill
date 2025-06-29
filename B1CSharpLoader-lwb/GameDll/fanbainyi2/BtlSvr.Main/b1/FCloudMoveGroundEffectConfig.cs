using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CloudMoveGroundEffectConfig")]
public struct FCloudMoveGroundEffectConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CloudMoveGroundEffectConfig:RunEffectDBC")]
	public BGWDataAsset_B1DBC RunEffectDBC;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CloudMoveGroundEffectConfig:RushEffectDBC")]
	public BGWDataAsset_B1DBC RushEffectDBC;

	private static int CloudMoveGroundEffectConfig_StructSize;

	private static int CloudMoveGroundEffectConfig_IsValid;

	private static bool RunEffectDBC_IsValid;

	private static int RunEffectDBC_Offset;

	private static bool RushEffectDBC_IsValid;

	private static int RushEffectDBC_Offset;

	public FCloudMoveGroundEffectConfig Copy()
	{
		return this;
	}

	public static FCloudMoveGroundEffectConfig FromNative(IntPtr nativeBuffer)
	{
		return new FCloudMoveGroundEffectConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCloudMoveGroundEffectConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCloudMoveGroundEffectConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCloudMoveGroundEffectConfig(IntPtr.Add(nativeBuffer, arrayIndex * CloudMoveGroundEffectConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCloudMoveGroundEffectConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CloudMoveGroundEffectConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CloudMoveGroundEffectConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CloudMoveGroundEffectConfig");
			return;
		}
		UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(nativeStruct, RunEffectDBC_Offset), RunEffectDBC);
		UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(nativeStruct, RushEffectDBC_Offset), RushEffectDBC);
	}

	public FCloudMoveGroundEffectConfig(IntPtr nativeStruct)
	{
		if (CloudMoveGroundEffectConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CloudMoveGroundEffectConfig");
			RunEffectDBC = null;
			RushEffectDBC = null;
		}
		else
		{
			RunEffectDBC = UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(nativeStruct, RunEffectDBC_Offset));
			RushEffectDBC = UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(nativeStruct, RushEffectDBC_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CloudMoveGroundEffectConfig");
		CloudMoveGroundEffectConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		RunEffectDBC_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunEffectDBC");
		RunEffectDBC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunEffectDBC", Classes.FObjectProperty);
		RushEffectDBC_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushEffectDBC");
		RushEffectDBC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushEffectDBC", Classes.FObjectProperty);
		CloudMoveGroundEffectConfig_IsValid = ((intPtr != IntPtr.Zero && RunEffectDBC_IsValid && RushEffectDBC_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CloudMoveGroundEffectConfig", (byte)CloudMoveGroundEffectConfig_IsValid != 0);
	}

	static FCloudMoveGroundEffectConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCloudMoveGroundEffectConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCloudMoveGroundEffectConfig));
	}
}
