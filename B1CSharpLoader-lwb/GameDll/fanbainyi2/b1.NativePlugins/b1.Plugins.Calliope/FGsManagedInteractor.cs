using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedInteractor", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedInteractor
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

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/Calliope.GsManagedInteractor:Actor")]
	public TSoftObject<AActor> Actor;

	private static bool State_IsValid;

	private static FFieldAddress State_PropertyAddress;

	private static int State_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsManagedInteractor:State")]
	public EGsInteractorState State;

	private static bool GroupID_IsValid;

	private static int GroupID_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsManagedInteractor:GroupID")]
	public FGsSmartParam GroupID;

	private static bool FGsManagedInteractor_IsValid;

	private static int FGsManagedInteractor_StructSize;

	public FGsManagedInteractor Copy()
	{
		return this;
	}

	public static FGsManagedInteractor FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedInteractor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedInteractor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedInteractor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedInteractor(nativeBuffer + arrayIndex * FGsManagedInteractor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedInteractor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedInteractor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedInteractor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedInteractor");
			return;
		}
		TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		EnumMarshaler<EGsInteractorState>.ToNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address, State);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, GroupID_Offset), GroupID);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedStateManaged_Offset), 0, NeedStateManaged_PropertyAddress.Address, NeedStateManaged);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedInteractor(IntPtr nativeStruct)
	{
		if (!FGsManagedInteractor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedInteractor");
			Actor = default(TSoftObject<AActor>);
			State = EGsInteractorState.Interactive;
			GroupID = default(FGsSmartParam);
			ActorGuid = FStringMarshaler.DefaultString;
			NeedStateManaged = false;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			Actor = TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			State = EnumMarshaler<EGsInteractorState>.FromNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address);
			GroupID = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, GroupID_Offset));
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
			NeedStateManaged = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NeedStateManaged_Offset), 0, NeedStateManaged_PropertyAddress.Address);
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedInteractor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedInteractor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedInteractor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedInteractor");
		FGsManagedInteractor_StructSize = NativeReflection.GetStructSize(intPtr);
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
		NativeReflectionCached.GetPropertyRef(ref State_PropertyAddress, intPtr, "State");
		State_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "State");
		State_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "State", Classes.FEnumProperty);
		GroupID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupID");
		GroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupID", Classes.FStructProperty);
		FGsManagedInteractor_IsValid = intPtr != IntPtr.Zero && Actor_IsValid && State_IsValid && GroupID_IsValid && ActorGuid_IsValid && NeedStateManaged_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedInteractor", FGsManagedInteractor_IsValid);
	}
}
