using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsStreamingLevelStateConfigPoliceConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsStreamingLevelStateConfigPoliceConfig
{
	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfigBase:ConfigGuid")]
	public Guid ConfigGuid;

	private static bool ManagedDataAssetID_IsValid;

	private static int ManagedDataAssetID_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsStreamingLevelStateConfigPoliceConfig:ManagedDataAssetID")]
	public FGsStreamingLevelStateConfigIntParamConfig ManagedDataAssetID;

	private static bool FGsStreamingLevelStateConfigPoliceConfig_IsValid;

	private static int FGsStreamingLevelStateConfigPoliceConfig_StructSize;

	public FGsStreamingLevelStateConfigPoliceConfig Copy()
	{
		return this;
	}

	public static FGsStreamingLevelStateConfigPoliceConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsStreamingLevelStateConfigPoliceConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsStreamingLevelStateConfigPoliceConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsStreamingLevelStateConfigPoliceConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsStreamingLevelStateConfigPoliceConfig(nativeBuffer + arrayIndex * FGsStreamingLevelStateConfigPoliceConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsStreamingLevelStateConfigPoliceConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsStreamingLevelStateConfigPoliceConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsStreamingLevelStateConfigPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsStreamingLevelStateConfigPoliceConfig");
			return;
		}
		FGsStreamingLevelStateConfigIntParamConfig.ToNative(IntPtr.Add(nativeStruct, ManagedDataAssetID_Offset), ManagedDataAssetID);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
	}

	public FGsStreamingLevelStateConfigPoliceConfig(IntPtr nativeStruct)
	{
		if (!FGsStreamingLevelStateConfigPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsStreamingLevelStateConfigPoliceConfig");
			ManagedDataAssetID = default(FGsStreamingLevelStateConfigIntParamConfig);
			ConfigGuid = default(Guid);
		}
		else
		{
			ManagedDataAssetID = FGsStreamingLevelStateConfigIntParamConfig.FromNative(IntPtr.Add(nativeStruct, ManagedDataAssetID_Offset));
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
		}
	}

	static FGsStreamingLevelStateConfigPoliceConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsStreamingLevelStateConfigPoliceConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsStreamingLevelStateConfigPoliceConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsStreamingLevelStateConfigPoliceConfig");
		FGsStreamingLevelStateConfigPoliceConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		ManagedDataAssetID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedDataAssetID");
		ManagedDataAssetID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedDataAssetID", Classes.FStructProperty);
		FGsStreamingLevelStateConfigPoliceConfig_IsValid = intPtr != IntPtr.Zero && ManagedDataAssetID_IsValid && ConfigGuid_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsStreamingLevelStateConfigPoliceConfig", FGsStreamingLevelStateConfigPoliceConfig_IsValid);
	}
}
