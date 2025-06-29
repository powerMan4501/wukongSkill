using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsUnitPoliceConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsUnitPoliceConfig
{
	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsSceneObjPoliceConfigBase:ConfigGuid")]
	public Guid ConfigGuid;

	private static bool ManagePolice_IsValid;

	private static FFieldAddress ManagePolice_PropertyAddress;

	private static int ManagePolice_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsUnitPoliceConfig:ManagePolice")]
	public EGsUnitManagePolice ManagePolice;

	private static bool State_IsValid;

	private static FFieldAddress State_PropertyAddress;

	private static int State_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.GsUnitPoliceConfig:State")]
	public EGsUnitResetType State;

	private static bool DefaultState_IsValid;

	private static FFieldAddress DefaultState_PropertyAddress;

	private static int DefaultState_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsUnitPoliceConfig:DefaultState")]
	public EGsUnitResetType DefaultState;

	private static bool ActualManagePolice_IsValid;

	private static FFieldAddress ActualManagePolice_PropertyAddress;

	private static int ActualManagePolice_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsUnitPoliceConfig:ActualManagePolice")]
	public EGsUnitManagePolice ActualManagePolice;

	private static bool OutState_IsValid;

	private static FFieldAddress OutState_PropertyAddress;

	private static int OutState_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsUnitPoliceConfig:OutState")]
	public EGsUnitResetType OutState;

	private static bool FGsUnitPoliceConfig_IsValid;

	private static int FGsUnitPoliceConfig_StructSize;

	public FGsUnitPoliceConfig Copy()
	{
		return this;
	}

	public static FGsUnitPoliceConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsUnitPoliceConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsUnitPoliceConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsUnitPoliceConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsUnitPoliceConfig(nativeBuffer + arrayIndex * FGsUnitPoliceConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsUnitPoliceConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsUnitPoliceConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsUnitPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsUnitPoliceConfig");
			return;
		}
		EnumMarshaler<EGsUnitManagePolice>.ToNative(IntPtr.Add(nativeStruct, ManagePolice_Offset), 0, ManagePolice_PropertyAddress.Address, ManagePolice);
		EnumMarshaler<EGsUnitResetType>.ToNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address, State);
		EnumMarshaler<EGsUnitResetType>.ToNative(IntPtr.Add(nativeStruct, DefaultState_Offset), 0, DefaultState_PropertyAddress.Address, DefaultState);
		EnumMarshaler<EGsUnitManagePolice>.ToNative(IntPtr.Add(nativeStruct, ActualManagePolice_Offset), 0, ActualManagePolice_PropertyAddress.Address, ActualManagePolice);
		EnumMarshaler<EGsUnitResetType>.ToNative(IntPtr.Add(nativeStruct, OutState_Offset), 0, OutState_PropertyAddress.Address, OutState);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
	}

	public FGsUnitPoliceConfig(IntPtr nativeStruct)
	{
		if (!FGsUnitPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsUnitPoliceConfig");
			ManagePolice = EGsUnitManagePolice.SameAsPrevious;
			State = EGsUnitResetType.No;
			DefaultState = EGsUnitResetType.No;
			ActualManagePolice = EGsUnitManagePolice.SameAsPrevious;
			OutState = EGsUnitResetType.No;
			ConfigGuid = default(Guid);
		}
		else
		{
			ManagePolice = EnumMarshaler<EGsUnitManagePolice>.FromNative(IntPtr.Add(nativeStruct, ManagePolice_Offset), 0, ManagePolice_PropertyAddress.Address);
			State = EnumMarshaler<EGsUnitResetType>.FromNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address);
			DefaultState = EnumMarshaler<EGsUnitResetType>.FromNative(IntPtr.Add(nativeStruct, DefaultState_Offset), 0, DefaultState_PropertyAddress.Address);
			ActualManagePolice = EnumMarshaler<EGsUnitManagePolice>.FromNative(IntPtr.Add(nativeStruct, ActualManagePolice_Offset), 0, ActualManagePolice_PropertyAddress.Address);
			OutState = EnumMarshaler<EGsUnitResetType>.FromNative(IntPtr.Add(nativeStruct, OutState_Offset), 0, OutState_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
		}
	}

	static FGsUnitPoliceConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsUnitPoliceConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsUnitPoliceConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsUnitPoliceConfig");
		FGsUnitPoliceConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ManagePolice_PropertyAddress, intPtr, "ManagePolice");
		ManagePolice_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagePolice");
		ManagePolice_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagePolice", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref State_PropertyAddress, intPtr, "State");
		State_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "State");
		State_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "State", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DefaultState_PropertyAddress, intPtr, "DefaultState");
		DefaultState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultState");
		DefaultState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultState", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ActualManagePolice_PropertyAddress, intPtr, "ActualManagePolice");
		ActualManagePolice_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActualManagePolice");
		ActualManagePolice_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActualManagePolice", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OutState_PropertyAddress, intPtr, "OutState");
		OutState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutState");
		OutState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutState", Classes.FEnumProperty);
		FGsUnitPoliceConfig_IsValid = intPtr != IntPtr.Zero && ManagePolice_IsValid && State_IsValid && DefaultState_IsValid && ActualManagePolice_IsValid && OutState_IsValid && ConfigGuid_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsUnitPoliceConfig", FGsUnitPoliceConfig_IsValid);
	}
}
