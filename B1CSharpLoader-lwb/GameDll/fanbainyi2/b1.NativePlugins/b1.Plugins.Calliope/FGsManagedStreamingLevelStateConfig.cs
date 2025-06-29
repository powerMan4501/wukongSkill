using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedStreamingLevelStateConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedStreamingLevelStateConfig
{
	private static bool ParamType_IsValid;

	private static FFieldAddress ParamType_PropertyAddress;

	private static int ParamType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsManagedParamBase:ParamType")]
	public EGsManagedParamType ParamType;

	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsManagedParamBase:ConfigGuid")]
	public Guid ConfigGuid;

	private static bool AliasName_IsValid;

	private static int AliasName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedParamBase:AliasName")]
	public FName AliasName;

	private static bool LevelID_IsValid;

	private static int LevelID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedStreamingLevelStateConfig:LevelID")]
	public int LevelID;

	private static bool DataAssetID_IsValid;

	private static int DataAssetID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedStreamingLevelStateConfig:DataAssetID")]
	public int DataAssetID;

	private static bool FGsManagedStreamingLevelStateConfig_IsValid;

	private static int FGsManagedStreamingLevelStateConfig_StructSize;

	public FGsManagedStreamingLevelStateConfig Copy()
	{
		return this;
	}

	public static FGsManagedStreamingLevelStateConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedStreamingLevelStateConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedStreamingLevelStateConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedStreamingLevelStateConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedStreamingLevelStateConfig(nativeBuffer + arrayIndex * FGsManagedStreamingLevelStateConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedStreamingLevelStateConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedStreamingLevelStateConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedStreamingLevelStateConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedStreamingLevelStateConfig");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LevelID_Offset), LevelID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DataAssetID_Offset), DataAssetID);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedStreamingLevelStateConfig(IntPtr nativeStruct)
	{
		if (!FGsManagedStreamingLevelStateConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedStreamingLevelStateConfig");
			LevelID = 0;
			DataAssetID = 0;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			LevelID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LevelID_Offset));
			DataAssetID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DataAssetID_Offset));
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedStreamingLevelStateConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedStreamingLevelStateConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedStreamingLevelStateConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedStreamingLevelStateConfig");
		FGsManagedStreamingLevelStateConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		LevelID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LevelID");
		LevelID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LevelID", Classes.FIntProperty);
		DataAssetID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataAssetID");
		DataAssetID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataAssetID", Classes.FIntProperty);
		FGsManagedStreamingLevelStateConfig_IsValid = intPtr != IntPtr.Zero && LevelID_IsValid && DataAssetID_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedStreamingLevelStateConfig", FGsManagedStreamingLevelStateConfig_IsValid);
	}
}
