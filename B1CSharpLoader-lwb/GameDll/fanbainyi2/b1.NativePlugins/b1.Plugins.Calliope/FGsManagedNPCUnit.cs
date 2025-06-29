using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedNPCUnit", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedNPCUnit
{
	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/Calliope.GsManagedSceneObjBase:ActorGuid")]
	public string ActorGuid;

	private static bool NeedStateManaged_IsValid;

	private static FFieldAddress NeedStateManaged_PropertyAddress;

	private static int NeedStateManaged_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedSceneObjBase:bNeedStateManaged")]
	public bool NeedStateManaged;

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

	private static bool Actor_IsValid;

	private static int Actor_Offset;

	[UProperty(Flags = (PropFlags)7881299348029445uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:Actor")]
	public TSoftObject<ACharacter> Actor;

	private static bool Tamer_IsValid;

	private static int Tamer_Offset;

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:Tamer")]
	public TSoftObject<AActor> Tamer;

	private static bool NPCInstanceGroup_IsValid;

	private static FFieldAddress NPCInstanceGroup_PropertyAddress;

	private static int NPCInstanceGroup_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:NPCInstanceGroup")]
	public List<FGsNPCReferenceInfo> NPCInstanceGroup;

	private static bool TeamID_IsValid;

	private static int TeamID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:TeamID")]
	public int TeamID;

	private static bool TeamIDParam_IsValid;

	private static int TeamIDParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:TeamIDParam")]
	public FGsSmartParam TeamIDParam;

	private static bool IdleAMIdx_IsValid;

	private static int IdleAMIdx_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:IdleAMIdx")]
	public int IdleAMIdx;

	private static bool IdleAMIdxParam_IsValid;

	private static int IdleAMIdxParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:IdleAMIdxParam")]
	public FGsSmartParam IdleAMIdxParam;

	private static bool LeisureAnimIndex_IsValid;

	private static int LeisureAnimIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:LeisureAnimIndex")]
	public int LeisureAnimIndex;

	private static bool LeisureAnimIndexParam_IsValid;

	private static int LeisureAnimIndexParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:LeisureAnimIndexParam")]
	public FGsSmartParam LeisureAnimIndexParam;

	private static bool InteractGroupID_IsValid;

	private static int InteractGroupID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:InteractGroupID")]
	public int InteractGroupID;

	private static bool InteractGroupIDParam_IsValid;

	private static int InteractGroupIDParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:InteractGroupIDParam")]
	public FGsSmartParam InteractGroupIDParam;

	private static bool ShowState_IsValid;

	private static FFieldAddress ShowState_PropertyAddress;

	private static int ShowState_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:ShowState")]
	public EGsNPCShowState ShowState;

	private static bool ActiveInstance_IsValid;

	private static int ActiveInstance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedNPCUnit:ActiveInstance")]
	public Guid ActiveInstance;

	private static bool FGsManagedNPCUnit_IsValid;

	private static int FGsManagedNPCUnit_StructSize;

	public FGsManagedNPCUnit Copy()
	{
		FGsManagedNPCUnit result = this;
		if (NPCInstanceGroup != null)
		{
			result.NPCInstanceGroup = new List<FGsNPCReferenceInfo>(NPCInstanceGroup);
		}
		return result;
	}

	public static FGsManagedNPCUnit FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedNPCUnit(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedNPCUnit value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedNPCUnit FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedNPCUnit(nativeBuffer + arrayIndex * FGsManagedNPCUnit_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedNPCUnit value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedNPCUnit_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedNPCUnit_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedNPCUnit");
			return;
		}
		TSoftObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Tamer_Offset), Tamer);
		new TArrayCopyMarshaler<FGsNPCReferenceInfo>(1, NPCInstanceGroup_PropertyAddress, CachedMarshalingDelegates<FGsNPCReferenceInfo, FGsNPCReferenceInfo>.FromNative, CachedMarshalingDelegates<FGsNPCReferenceInfo, FGsNPCReferenceInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, NPCInstanceGroup_Offset), NPCInstanceGroup);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TeamID_Offset), TeamID);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, TeamIDParam_Offset), TeamIDParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IdleAMIdx_Offset), IdleAMIdx);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, IdleAMIdxParam_Offset), IdleAMIdxParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LeisureAnimIndex_Offset), LeisureAnimIndex);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, LeisureAnimIndexParam_Offset), LeisureAnimIndexParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InteractGroupID_Offset), InteractGroupID);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, InteractGroupIDParam_Offset), InteractGroupIDParam);
		EnumMarshaler<EGsNPCShowState>.ToNative(IntPtr.Add(nativeStruct, ShowState_Offset), 0, ShowState_PropertyAddress.Address, ShowState);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ActiveInstance_Offset), ActiveInstance);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedStateManaged_Offset), 0, NeedStateManaged_PropertyAddress.Address, NeedStateManaged);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedNPCUnit(IntPtr nativeStruct)
	{
		if (!FGsManagedNPCUnit_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedNPCUnit");
			Actor = default(TSoftObject<ACharacter>);
			Tamer = default(TSoftObject<AActor>);
			NPCInstanceGroup = null;
			TeamID = 0;
			TeamIDParam = default(FGsSmartParam);
			IdleAMIdx = 0;
			IdleAMIdxParam = default(FGsSmartParam);
			LeisureAnimIndex = 0;
			LeisureAnimIndexParam = default(FGsSmartParam);
			InteractGroupID = 0;
			InteractGroupIDParam = default(FGsSmartParam);
			ShowState = EGsNPCShowState.Show;
			ActiveInstance = default(Guid);
			ActorGuid = FStringMarshaler.DefaultString;
			NeedStateManaged = false;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			Actor = TSoftObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			Tamer = TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Tamer_Offset));
			NPCInstanceGroup = new TArrayCopyMarshaler<FGsNPCReferenceInfo>(1, NPCInstanceGroup_PropertyAddress, CachedMarshalingDelegates<FGsNPCReferenceInfo, FGsNPCReferenceInfo>.FromNative, CachedMarshalingDelegates<FGsNPCReferenceInfo, FGsNPCReferenceInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, NPCInstanceGroup_Offset));
			TeamID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TeamID_Offset));
			TeamIDParam = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, TeamIDParam_Offset));
			IdleAMIdx = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IdleAMIdx_Offset));
			IdleAMIdxParam = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, IdleAMIdxParam_Offset));
			LeisureAnimIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LeisureAnimIndex_Offset));
			LeisureAnimIndexParam = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, LeisureAnimIndexParam_Offset));
			InteractGroupID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InteractGroupID_Offset));
			InteractGroupIDParam = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, InteractGroupIDParam_Offset));
			ShowState = EnumMarshaler<EGsNPCShowState>.FromNative(IntPtr.Add(nativeStruct, ShowState_Offset), 0, ShowState_PropertyAddress.Address);
			ActiveInstance = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ActiveInstance_Offset));
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
			NeedStateManaged = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NeedStateManaged_Offset), 0, NeedStateManaged_PropertyAddress.Address);
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedNPCUnit()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedNPCUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedNPCUnit));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedNPCUnit");
		FGsManagedNPCUnit_StructSize = NativeReflection.GetStructSize(intPtr);
		ActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedStateManaged_PropertyAddress, intPtr, "bNeedStateManaged");
		NeedStateManaged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNeedStateManaged");
		NeedStateManaged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNeedStateManaged", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		Actor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Actor", Classes.FSoftObjectProperty);
		Tamer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tamer");
		Tamer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tamer", Classes.FSoftObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NPCInstanceGroup_PropertyAddress, intPtr, "NPCInstanceGroup");
		NPCInstanceGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NPCInstanceGroup");
		NPCInstanceGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NPCInstanceGroup", Classes.FArrayProperty);
		TeamID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TeamID");
		TeamID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TeamID", Classes.FIntProperty);
		TeamIDParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TeamIDParam");
		TeamIDParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TeamIDParam", Classes.FStructProperty);
		IdleAMIdx_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IdleAMIdx");
		IdleAMIdx_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IdleAMIdx", Classes.FIntProperty);
		IdleAMIdxParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IdleAMIdxParam");
		IdleAMIdxParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IdleAMIdxParam", Classes.FStructProperty);
		LeisureAnimIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeisureAnimIndex");
		LeisureAnimIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeisureAnimIndex", Classes.FIntProperty);
		LeisureAnimIndexParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeisureAnimIndexParam");
		LeisureAnimIndexParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeisureAnimIndexParam", Classes.FStructProperty);
		InteractGroupID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteractGroupID");
		InteractGroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteractGroupID", Classes.FIntProperty);
		InteractGroupIDParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteractGroupIDParam");
		InteractGroupIDParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteractGroupIDParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowState_PropertyAddress, intPtr, "ShowState");
		ShowState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShowState");
		ShowState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShowState", Classes.FEnumProperty);
		ActiveInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActiveInstance");
		ActiveInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActiveInstance", Classes.FStructProperty);
		FGsManagedNPCUnit_IsValid = intPtr != IntPtr.Zero && Actor_IsValid && Tamer_IsValid && NPCInstanceGroup_IsValid && TeamID_IsValid && TeamIDParam_IsValid && IdleAMIdx_IsValid && IdleAMIdxParam_IsValid && LeisureAnimIndex_IsValid && LeisureAnimIndexParam_IsValid && InteractGroupID_IsValid && InteractGroupIDParam_IsValid && ShowState_IsValid && ActiveInstance_IsValid && ActorGuid_IsValid && NeedStateManaged_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedNPCUnit", FGsManagedNPCUnit_IsValid);
	}
}
