using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsNPCUnitPoliceConfig
{
	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfigBase:ConfigGuid")]
	public Guid ConfigGuid;

	private static bool ManagedTeamID_IsValid;

	private static int ManagedTeamID_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig:ManagedTeamID")]
	public FGsNPCUnitIntParamConfig ManagedTeamID;

	private static bool ManagedTeamIDParam_IsValid;

	private static int ManagedTeamIDParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig:ManagedTeamIDParam")]
	public FGsNPCUnitSmartParamConfig ManagedTeamIDParam;

	private static bool ManagedIdleAMIdx_IsValid;

	private static int ManagedIdleAMIdx_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig:ManagedIdleAMIdx")]
	public FGsNPCUnitIntParamConfig ManagedIdleAMIdx;

	private static bool ManagedIdleAMIdxParam_IsValid;

	private static int ManagedIdleAMIdxParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig:ManagedIdleAMIdxParam")]
	public FGsNPCUnitSmartParamConfig ManagedIdleAMIdxParam;

	private static bool ManagedLeisureAnimIndex_IsValid;

	private static int ManagedLeisureAnimIndex_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig:ManagedLeisureAnimIndex")]
	public FGsNPCUnitIntParamConfig ManagedLeisureAnimIndex;

	private static bool ManagedLeisureAnimIndexParam_IsValid;

	private static int ManagedLeisureAnimIndexParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig:ManagedLeisureAnimIndexParam")]
	public FGsNPCUnitSmartParamConfig ManagedLeisureAnimIndexParam;

	private static bool ManagedInteractGroupID_IsValid;

	private static int ManagedInteractGroupID_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig:ManagedInteractGroupID")]
	public FGsNPCUnitIntParamConfig ManagedInteractGroupID;

	private static bool ManagedInteractGroupIDParam_IsValid;

	private static int ManagedInteractGroupIDParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig:ManagedInteractGroupIDParam")]
	public FGsNPCUnitSmartParamConfig ManagedInteractGroupIDParam;

	private static bool ManagedShowState_IsValid;

	private static int ManagedShowState_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig:ManagedShowState")]
	public FGsNPCUnitShowStateParamConfig ManagedShowState;

	private static bool ManagedActiveInstance_IsValid;

	private static int ManagedActiveInstance_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig:ManagedActiveInstance")]
	public FGsNPCUnitGuidParamConfig ManagedActiveInstance;

	private static bool ManagedBuffIDList_IsValid;

	private static FFieldAddress ManagedBuffIDList_PropertyAddress;

	private static int ManagedBuffIDList_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitPoliceConfig:ManagedBuffIDList")]
	public List<FGsNPCUnitBuffParamConfig> ManagedBuffIDList;

	private static bool FGsNPCUnitPoliceConfig_IsValid;

	private static int FGsNPCUnitPoliceConfig_StructSize;

	public FGsNPCUnitPoliceConfig Copy()
	{
		FGsNPCUnitPoliceConfig result = this;
		if (ManagedBuffIDList != null)
		{
			result.ManagedBuffIDList = new List<FGsNPCUnitBuffParamConfig>(ManagedBuffIDList);
		}
		return result;
	}

	public static FGsNPCUnitPoliceConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsNPCUnitPoliceConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsNPCUnitPoliceConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsNPCUnitPoliceConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsNPCUnitPoliceConfig(nativeBuffer + arrayIndex * FGsNPCUnitPoliceConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsNPCUnitPoliceConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsNPCUnitPoliceConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitPoliceConfig");
			return;
		}
		FGsNPCUnitIntParamConfig.ToNative(IntPtr.Add(nativeStruct, ManagedTeamID_Offset), ManagedTeamID);
		FGsNPCUnitSmartParamConfig.ToNative(IntPtr.Add(nativeStruct, ManagedTeamIDParam_Offset), ManagedTeamIDParam);
		FGsNPCUnitIntParamConfig.ToNative(IntPtr.Add(nativeStruct, ManagedIdleAMIdx_Offset), ManagedIdleAMIdx);
		FGsNPCUnitSmartParamConfig.ToNative(IntPtr.Add(nativeStruct, ManagedIdleAMIdxParam_Offset), ManagedIdleAMIdxParam);
		FGsNPCUnitIntParamConfig.ToNative(IntPtr.Add(nativeStruct, ManagedLeisureAnimIndex_Offset), ManagedLeisureAnimIndex);
		FGsNPCUnitSmartParamConfig.ToNative(IntPtr.Add(nativeStruct, ManagedLeisureAnimIndexParam_Offset), ManagedLeisureAnimIndexParam);
		FGsNPCUnitIntParamConfig.ToNative(IntPtr.Add(nativeStruct, ManagedInteractGroupID_Offset), ManagedInteractGroupID);
		FGsNPCUnitSmartParamConfig.ToNative(IntPtr.Add(nativeStruct, ManagedInteractGroupIDParam_Offset), ManagedInteractGroupIDParam);
		FGsNPCUnitShowStateParamConfig.ToNative(IntPtr.Add(nativeStruct, ManagedShowState_Offset), ManagedShowState);
		FGsNPCUnitGuidParamConfig.ToNative(IntPtr.Add(nativeStruct, ManagedActiveInstance_Offset), ManagedActiveInstance);
		new TArrayCopyMarshaler<FGsNPCUnitBuffParamConfig>(1, ManagedBuffIDList_PropertyAddress, CachedMarshalingDelegates<FGsNPCUnitBuffParamConfig, FGsNPCUnitBuffParamConfig>.FromNative, CachedMarshalingDelegates<FGsNPCUnitBuffParamConfig, FGsNPCUnitBuffParamConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, ManagedBuffIDList_Offset), ManagedBuffIDList);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
	}

	public FGsNPCUnitPoliceConfig(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitPoliceConfig");
			ManagedTeamID = default(FGsNPCUnitIntParamConfig);
			ManagedTeamIDParam = default(FGsNPCUnitSmartParamConfig);
			ManagedIdleAMIdx = default(FGsNPCUnitIntParamConfig);
			ManagedIdleAMIdxParam = default(FGsNPCUnitSmartParamConfig);
			ManagedLeisureAnimIndex = default(FGsNPCUnitIntParamConfig);
			ManagedLeisureAnimIndexParam = default(FGsNPCUnitSmartParamConfig);
			ManagedInteractGroupID = default(FGsNPCUnitIntParamConfig);
			ManagedInteractGroupIDParam = default(FGsNPCUnitSmartParamConfig);
			ManagedShowState = default(FGsNPCUnitShowStateParamConfig);
			ManagedActiveInstance = default(FGsNPCUnitGuidParamConfig);
			ManagedBuffIDList = null;
			ConfigGuid = default(Guid);
		}
		else
		{
			ManagedTeamID = FGsNPCUnitIntParamConfig.FromNative(IntPtr.Add(nativeStruct, ManagedTeamID_Offset));
			ManagedTeamIDParam = FGsNPCUnitSmartParamConfig.FromNative(IntPtr.Add(nativeStruct, ManagedTeamIDParam_Offset));
			ManagedIdleAMIdx = FGsNPCUnitIntParamConfig.FromNative(IntPtr.Add(nativeStruct, ManagedIdleAMIdx_Offset));
			ManagedIdleAMIdxParam = FGsNPCUnitSmartParamConfig.FromNative(IntPtr.Add(nativeStruct, ManagedIdleAMIdxParam_Offset));
			ManagedLeisureAnimIndex = FGsNPCUnitIntParamConfig.FromNative(IntPtr.Add(nativeStruct, ManagedLeisureAnimIndex_Offset));
			ManagedLeisureAnimIndexParam = FGsNPCUnitSmartParamConfig.FromNative(IntPtr.Add(nativeStruct, ManagedLeisureAnimIndexParam_Offset));
			ManagedInteractGroupID = FGsNPCUnitIntParamConfig.FromNative(IntPtr.Add(nativeStruct, ManagedInteractGroupID_Offset));
			ManagedInteractGroupIDParam = FGsNPCUnitSmartParamConfig.FromNative(IntPtr.Add(nativeStruct, ManagedInteractGroupIDParam_Offset));
			ManagedShowState = FGsNPCUnitShowStateParamConfig.FromNative(IntPtr.Add(nativeStruct, ManagedShowState_Offset));
			ManagedActiveInstance = FGsNPCUnitGuidParamConfig.FromNative(IntPtr.Add(nativeStruct, ManagedActiveInstance_Offset));
			ManagedBuffIDList = new TArrayCopyMarshaler<FGsNPCUnitBuffParamConfig>(1, ManagedBuffIDList_PropertyAddress, CachedMarshalingDelegates<FGsNPCUnitBuffParamConfig, FGsNPCUnitBuffParamConfig>.FromNative, CachedMarshalingDelegates<FGsNPCUnitBuffParamConfig, FGsNPCUnitBuffParamConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, ManagedBuffIDList_Offset));
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
		}
	}

	static FGsNPCUnitPoliceConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsNPCUnitPoliceConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsNPCUnitPoliceConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsNPCUnitPoliceConfig");
		FGsNPCUnitPoliceConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		ManagedTeamID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedTeamID");
		ManagedTeamID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedTeamID", Classes.FStructProperty);
		ManagedTeamIDParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedTeamIDParam");
		ManagedTeamIDParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedTeamIDParam", Classes.FStructProperty);
		ManagedIdleAMIdx_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedIdleAMIdx");
		ManagedIdleAMIdx_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedIdleAMIdx", Classes.FStructProperty);
		ManagedIdleAMIdxParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedIdleAMIdxParam");
		ManagedIdleAMIdxParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedIdleAMIdxParam", Classes.FStructProperty);
		ManagedLeisureAnimIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedLeisureAnimIndex");
		ManagedLeisureAnimIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedLeisureAnimIndex", Classes.FStructProperty);
		ManagedLeisureAnimIndexParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedLeisureAnimIndexParam");
		ManagedLeisureAnimIndexParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedLeisureAnimIndexParam", Classes.FStructProperty);
		ManagedInteractGroupID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedInteractGroupID");
		ManagedInteractGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedInteractGroupID", Classes.FStructProperty);
		ManagedInteractGroupIDParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedInteractGroupIDParam");
		ManagedInteractGroupIDParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedInteractGroupIDParam", Classes.FStructProperty);
		ManagedShowState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedShowState");
		ManagedShowState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedShowState", Classes.FStructProperty);
		ManagedActiveInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedActiveInstance");
		ManagedActiveInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedActiveInstance", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ManagedBuffIDList_PropertyAddress, intPtr, "ManagedBuffIDList");
		ManagedBuffIDList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagedBuffIDList");
		ManagedBuffIDList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagedBuffIDList", Classes.FArrayProperty);
		FGsNPCUnitPoliceConfig_IsValid = intPtr != IntPtr.Zero && ManagedTeamID_IsValid && ManagedTeamIDParam_IsValid && ManagedIdleAMIdx_IsValid && ManagedIdleAMIdxParam_IsValid && ManagedLeisureAnimIndex_IsValid && ManagedLeisureAnimIndexParam_IsValid && ManagedInteractGroupID_IsValid && ManagedInteractGroupIDParam_IsValid && ManagedShowState_IsValid && ManagedActiveInstance_IsValid && ManagedBuffIDList_IsValid && ConfigGuid_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsNPCUnitPoliceConfig", FGsNPCUnitPoliceConfig_IsValid);
	}
}
