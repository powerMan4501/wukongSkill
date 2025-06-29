using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsInteractorPoliceConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsInteractorPoliceConfig
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
	[UMetaPath("/Script/Calliope.GsInteractorPoliceConfig:ManagePolice")]
	public EGsInteractorManagePolice ManagePolice;

	private static bool State_IsValid;

	private static FFieldAddress State_PropertyAddress;

	private static int State_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.GsInteractorPoliceConfig:State")]
	public EGsInteractorState State;

	private static bool DefaultState_IsValid;

	private static FFieldAddress DefaultState_PropertyAddress;

	private static int DefaultState_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsInteractorPoliceConfig:DefaultState")]
	public EGsInteractorState DefaultState;

	private static bool ActualManagePolice_IsValid;

	private static FFieldAddress ActualManagePolice_PropertyAddress;

	private static int ActualManagePolice_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsInteractorPoliceConfig:ActualManagePolice")]
	public EGsInteractorManagePolice ActualManagePolice;

	private static bool OutState_IsValid;

	private static FFieldAddress OutState_PropertyAddress;

	private static int OutState_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsInteractorPoliceConfig:OutState")]
	public EGsInteractorState OutState;

	private static bool CanModify_IsValid;

	private static FFieldAddress CanModify_PropertyAddress;

	private static int CanModify_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsInteractorPoliceConfig:bCanModify")]
	public bool CanModify;

	private static bool ActualValue_IsValid;

	private static int ActualValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346978309uL)]
	[UMetaPath("/Script/Calliope.GsInteractorPoliceConfig:ActualValue")]
	public FGsSmartParam ActualValue;

	private static bool ModifyValue_IsValid;

	private static int ModifyValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsInteractorPoliceConfig:ModifyValue")]
	public FGsSmartParam ModifyValue;

	private static bool DefaultValue_IsValid;

	private static int DefaultValue_Offset;

	[UProperty(Flags = (PropFlags)4503668346978309uL)]
	[UMetaPath("/Script/Calliope.GsInteractorPoliceConfig:DefaultValue")]
	public FGsSmartParam DefaultValue;

	private static bool FGsInteractorPoliceConfig_IsValid;

	private static int FGsInteractorPoliceConfig_StructSize;

	public FGsInteractorPoliceConfig Copy()
	{
		return this;
	}

	public static FGsInteractorPoliceConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsInteractorPoliceConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsInteractorPoliceConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsInteractorPoliceConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsInteractorPoliceConfig(nativeBuffer + arrayIndex * FGsInteractorPoliceConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsInteractorPoliceConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsInteractorPoliceConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsInteractorPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsInteractorPoliceConfig");
			return;
		}
		EnumMarshaler<EGsInteractorManagePolice>.ToNative(IntPtr.Add(nativeStruct, ManagePolice_Offset), 0, ManagePolice_PropertyAddress.Address, ManagePolice);
		EnumMarshaler<EGsInteractorState>.ToNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address, State);
		EnumMarshaler<EGsInteractorState>.ToNative(IntPtr.Add(nativeStruct, DefaultState_Offset), 0, DefaultState_PropertyAddress.Address, DefaultState);
		EnumMarshaler<EGsInteractorManagePolice>.ToNative(IntPtr.Add(nativeStruct, ActualManagePolice_Offset), 0, ActualManagePolice_PropertyAddress.Address, ActualManagePolice);
		EnumMarshaler<EGsInteractorState>.ToNative(IntPtr.Add(nativeStruct, OutState_Offset), 0, OutState_PropertyAddress.Address, OutState);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address, CanModify);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, ActualValue_Offset), ActualValue);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, ModifyValue_Offset), ModifyValue);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, DefaultValue_Offset), DefaultValue);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
	}

	public FGsInteractorPoliceConfig(IntPtr nativeStruct)
	{
		if (!FGsInteractorPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsInteractorPoliceConfig");
			ManagePolice = EGsInteractorManagePolice.SameAsPrevious;
			State = EGsInteractorState.Interactive;
			DefaultState = EGsInteractorState.Interactive;
			ActualManagePolice = EGsInteractorManagePolice.SameAsPrevious;
			OutState = EGsInteractorState.Interactive;
			CanModify = false;
			ActualValue = default(FGsSmartParam);
			ModifyValue = default(FGsSmartParam);
			DefaultValue = default(FGsSmartParam);
			ConfigGuid = default(Guid);
		}
		else
		{
			ManagePolice = EnumMarshaler<EGsInteractorManagePolice>.FromNative(IntPtr.Add(nativeStruct, ManagePolice_Offset), 0, ManagePolice_PropertyAddress.Address);
			State = EnumMarshaler<EGsInteractorState>.FromNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address);
			DefaultState = EnumMarshaler<EGsInteractorState>.FromNative(IntPtr.Add(nativeStruct, DefaultState_Offset), 0, DefaultState_PropertyAddress.Address);
			ActualManagePolice = EnumMarshaler<EGsInteractorManagePolice>.FromNative(IntPtr.Add(nativeStruct, ActualManagePolice_Offset), 0, ActualManagePolice_PropertyAddress.Address);
			OutState = EnumMarshaler<EGsInteractorState>.FromNative(IntPtr.Add(nativeStruct, OutState_Offset), 0, OutState_PropertyAddress.Address);
			CanModify = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address);
			ActualValue = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, ActualValue_Offset));
			ModifyValue = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, ModifyValue_Offset));
			DefaultValue = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, DefaultValue_Offset));
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
		}
	}

	static FGsInteractorPoliceConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsInteractorPoliceConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsInteractorPoliceConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsInteractorPoliceConfig");
		FGsInteractorPoliceConfig_StructSize = NativeReflection.GetStructSize(intPtr);
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
		NativeReflectionCached.GetPropertyRef(ref CanModify_PropertyAddress, intPtr, "bCanModify");
		CanModify_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanModify");
		CanModify_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanModify", Classes.FBoolProperty);
		ActualValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActualValue");
		ActualValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActualValue", Classes.FStructProperty);
		ModifyValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModifyValue");
		ModifyValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModifyValue", Classes.FStructProperty);
		DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultValue");
		DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultValue", Classes.FStructProperty);
		FGsInteractorPoliceConfig_IsValid = intPtr != IntPtr.Zero && ManagePolice_IsValid && State_IsValid && DefaultState_IsValid && ActualManagePolice_IsValid && OutState_IsValid && CanModify_IsValid && ActualValue_IsValid && ModifyValue_IsValid && DefaultValue_IsValid && ConfigGuid_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsInteractorPoliceConfig", FGsInteractorPoliceConfig_IsValid);
	}
}
