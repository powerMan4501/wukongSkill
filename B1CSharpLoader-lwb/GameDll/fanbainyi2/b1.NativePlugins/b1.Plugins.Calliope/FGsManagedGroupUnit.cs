using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedGroupUnit", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedGroupUnit
{
	private static bool GroupTag_IsValid;

	private static int GroupTag_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Calliope.GsManagedGroupUnitObjBase:GroupTag")]
	public FGameplayTag GroupTag;

	private static bool NeedStateManaged_IsValid;

	private static FFieldAddress NeedStateManaged_PropertyAddress;

	private static int NeedStateManaged_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedGroupUnitObjBase:bNeedStateManaged")]
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

	private static bool State_IsValid;

	private static FFieldAddress State_PropertyAddress;

	private static int State_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedGroupUnit:State")]
	public EGsUnitResetType State;

	private static bool FGsManagedGroupUnit_IsValid;

	private static int FGsManagedGroupUnit_StructSize;

	public FGsManagedGroupUnit Copy()
	{
		return this;
	}

	public static FGsManagedGroupUnit FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedGroupUnit(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedGroupUnit value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedGroupUnit FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedGroupUnit(nativeBuffer + arrayIndex * FGsManagedGroupUnit_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedGroupUnit value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedGroupUnit_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedGroupUnit_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedGroupUnit");
			return;
		}
		EnumMarshaler<EGsUnitResetType>.ToNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address, State);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(nativeStruct, GroupTag_Offset), GroupTag);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedStateManaged_Offset), 0, NeedStateManaged_PropertyAddress.Address, NeedStateManaged);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedGroupUnit(IntPtr nativeStruct)
	{
		if (!FGsManagedGroupUnit_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedGroupUnit");
			State = EGsUnitResetType.No;
			GroupTag = default(FGameplayTag);
			NeedStateManaged = false;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			State = EnumMarshaler<EGsUnitResetType>.FromNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address);
			GroupTag = BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(nativeStruct, GroupTag_Offset));
			NeedStateManaged = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NeedStateManaged_Offset), 0, NeedStateManaged_PropertyAddress.Address);
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedGroupUnit()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedGroupUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedGroupUnit));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedGroupUnit");
		FGsManagedGroupUnit_StructSize = NativeReflection.GetStructSize(intPtr);
		GroupTag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupTag");
		GroupTag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupTag", Classes.FStructProperty);
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
		NativeReflectionCached.GetPropertyRef(ref State_PropertyAddress, intPtr, "State");
		State_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "State");
		State_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "State", Classes.FEnumProperty);
		FGsManagedGroupUnit_IsValid = intPtr != IntPtr.Zero && State_IsValid && GroupTag_IsValid && NeedStateManaged_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedGroupUnit", FGsManagedGroupUnit_IsValid);
	}
}
