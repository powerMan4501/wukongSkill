using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsSpawnerPoliceConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsSpawnerPoliceConfig
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
	[UMetaPath("/Script/Calliope.GsSpawnerPoliceConfig:ManagePolice")]
	public EGsSpawnerManagePolice ManagePolice;

	private static bool State_IsValid;

	private static FFieldAddress State_PropertyAddress;

	private static int State_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.GsSpawnerPoliceConfig:State")]
	public EGsSpawnerState State;

	private static bool DefaultState_IsValid;

	private static FFieldAddress DefaultState_PropertyAddress;

	private static int DefaultState_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsSpawnerPoliceConfig:DefaultState")]
	public EGsSpawnerState DefaultState;

	private static bool ActualManagePolice_IsValid;

	private static FFieldAddress ActualManagePolice_PropertyAddress;

	private static int ActualManagePolice_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsSpawnerPoliceConfig:ActualManagePolice")]
	public EGsSpawnerManagePolice ActualManagePolice;

	private static bool OutState_IsValid;

	private static FFieldAddress OutState_PropertyAddress;

	private static int OutState_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsSpawnerPoliceConfig:OutState")]
	public EGsSpawnerState OutState;

	private static bool FGsSpawnerPoliceConfig_IsValid;

	private static int FGsSpawnerPoliceConfig_StructSize;

	public FGsSpawnerPoliceConfig Copy()
	{
		return this;
	}

	public static FGsSpawnerPoliceConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsSpawnerPoliceConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsSpawnerPoliceConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsSpawnerPoliceConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsSpawnerPoliceConfig(nativeBuffer + arrayIndex * FGsSpawnerPoliceConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsSpawnerPoliceConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsSpawnerPoliceConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsSpawnerPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsSpawnerPoliceConfig");
			return;
		}
		EnumMarshaler<EGsSpawnerManagePolice>.ToNative(IntPtr.Add(nativeStruct, ManagePolice_Offset), 0, ManagePolice_PropertyAddress.Address, ManagePolice);
		EnumMarshaler<EGsSpawnerState>.ToNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address, State);
		EnumMarshaler<EGsSpawnerState>.ToNative(IntPtr.Add(nativeStruct, DefaultState_Offset), 0, DefaultState_PropertyAddress.Address, DefaultState);
		EnumMarshaler<EGsSpawnerManagePolice>.ToNative(IntPtr.Add(nativeStruct, ActualManagePolice_Offset), 0, ActualManagePolice_PropertyAddress.Address, ActualManagePolice);
		EnumMarshaler<EGsSpawnerState>.ToNative(IntPtr.Add(nativeStruct, OutState_Offset), 0, OutState_PropertyAddress.Address, OutState);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
	}

	public FGsSpawnerPoliceConfig(IntPtr nativeStruct)
	{
		if (!FGsSpawnerPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsSpawnerPoliceConfig");
			ManagePolice = EGsSpawnerManagePolice.SameAsPrevious;
			State = EGsSpawnerState.Disabled;
			DefaultState = EGsSpawnerState.Disabled;
			ActualManagePolice = EGsSpawnerManagePolice.SameAsPrevious;
			OutState = EGsSpawnerState.Disabled;
			ConfigGuid = default(Guid);
		}
		else
		{
			ManagePolice = EnumMarshaler<EGsSpawnerManagePolice>.FromNative(IntPtr.Add(nativeStruct, ManagePolice_Offset), 0, ManagePolice_PropertyAddress.Address);
			State = EnumMarshaler<EGsSpawnerState>.FromNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address);
			DefaultState = EnumMarshaler<EGsSpawnerState>.FromNative(IntPtr.Add(nativeStruct, DefaultState_Offset), 0, DefaultState_PropertyAddress.Address);
			ActualManagePolice = EnumMarshaler<EGsSpawnerManagePolice>.FromNative(IntPtr.Add(nativeStruct, ActualManagePolice_Offset), 0, ActualManagePolice_PropertyAddress.Address);
			OutState = EnumMarshaler<EGsSpawnerState>.FromNative(IntPtr.Add(nativeStruct, OutState_Offset), 0, OutState_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
		}
	}

	static FGsSpawnerPoliceConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsSpawnerPoliceConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsSpawnerPoliceConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsSpawnerPoliceConfig");
		FGsSpawnerPoliceConfig_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FGsSpawnerPoliceConfig_IsValid = intPtr != IntPtr.Zero && ManagePolice_IsValid && State_IsValid && DefaultState_IsValid && ActualManagePolice_IsValid && OutState_IsValid && ConfigGuid_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsSpawnerPoliceConfig", FGsSpawnerPoliceConfig_IsValid);
	}
}
