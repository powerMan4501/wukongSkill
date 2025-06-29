using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsOverlapPoliceConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsOverlapPoliceConfig
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
	[UMetaPath("/Script/Calliope.GsOverlapPoliceConfig:ManagePolice")]
	public EGsOverlapManagePolice ManagePolice;

	private static bool State_IsValid;

	private static FFieldAddress State_PropertyAddress;

	private static int State_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.GsOverlapPoliceConfig:State")]
	public EGsOverlapState State;

	private static bool OutState_IsValid;

	private static FFieldAddress OutState_PropertyAddress;

	private static int OutState_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsOverlapPoliceConfig:OutState")]
	public EGsOverlapState OutState;

	private static bool DefaultState_IsValid;

	private static FFieldAddress DefaultState_PropertyAddress;

	private static int DefaultState_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsOverlapPoliceConfig:DefaultState")]
	public EGsOverlapState DefaultState;

	private static bool ActualManagePolice_IsValid;

	private static FFieldAddress ActualManagePolice_PropertyAddress;

	private static int ActualManagePolice_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsOverlapPoliceConfig:ActualManagePolice")]
	public EGsOverlapManagePolice ActualManagePolice;

	private static bool FGsOverlapPoliceConfig_IsValid;

	private static int FGsOverlapPoliceConfig_StructSize;

	public FGsOverlapPoliceConfig Copy()
	{
		return this;
	}

	public static FGsOverlapPoliceConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsOverlapPoliceConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsOverlapPoliceConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsOverlapPoliceConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsOverlapPoliceConfig(nativeBuffer + arrayIndex * FGsOverlapPoliceConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsOverlapPoliceConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsOverlapPoliceConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsOverlapPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsOverlapPoliceConfig");
			return;
		}
		EnumMarshaler<EGsOverlapManagePolice>.ToNative(IntPtr.Add(nativeStruct, ManagePolice_Offset), 0, ManagePolice_PropertyAddress.Address, ManagePolice);
		EnumMarshaler<EGsOverlapState>.ToNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address, State);
		EnumMarshaler<EGsOverlapState>.ToNative(IntPtr.Add(nativeStruct, OutState_Offset), 0, OutState_PropertyAddress.Address, OutState);
		EnumMarshaler<EGsOverlapState>.ToNative(IntPtr.Add(nativeStruct, DefaultState_Offset), 0, DefaultState_PropertyAddress.Address, DefaultState);
		EnumMarshaler<EGsOverlapManagePolice>.ToNative(IntPtr.Add(nativeStruct, ActualManagePolice_Offset), 0, ActualManagePolice_PropertyAddress.Address, ActualManagePolice);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
	}

	public FGsOverlapPoliceConfig(IntPtr nativeStruct)
	{
		if (!FGsOverlapPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsOverlapPoliceConfig");
			ManagePolice = EGsOverlapManagePolice.SameAsPrevious;
			State = EGsOverlapState.Enabled;
			OutState = EGsOverlapState.Enabled;
			DefaultState = EGsOverlapState.Enabled;
			ActualManagePolice = EGsOverlapManagePolice.SameAsPrevious;
			ConfigGuid = default(Guid);
		}
		else
		{
			ManagePolice = EnumMarshaler<EGsOverlapManagePolice>.FromNative(IntPtr.Add(nativeStruct, ManagePolice_Offset), 0, ManagePolice_PropertyAddress.Address);
			State = EnumMarshaler<EGsOverlapState>.FromNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address);
			OutState = EnumMarshaler<EGsOverlapState>.FromNative(IntPtr.Add(nativeStruct, OutState_Offset), 0, OutState_PropertyAddress.Address);
			DefaultState = EnumMarshaler<EGsOverlapState>.FromNative(IntPtr.Add(nativeStruct, DefaultState_Offset), 0, DefaultState_PropertyAddress.Address);
			ActualManagePolice = EnumMarshaler<EGsOverlapManagePolice>.FromNative(IntPtr.Add(nativeStruct, ActualManagePolice_Offset), 0, ActualManagePolice_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
		}
	}

	static FGsOverlapPoliceConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsOverlapPoliceConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsOverlapPoliceConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsOverlapPoliceConfig");
		FGsOverlapPoliceConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ManagePolice_PropertyAddress, intPtr, "ManagePolice");
		ManagePolice_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagePolice");
		ManagePolice_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagePolice", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref State_PropertyAddress, intPtr, "State");
		State_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "State");
		State_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "State", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OutState_PropertyAddress, intPtr, "OutState");
		OutState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutState");
		OutState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutState", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DefaultState_PropertyAddress, intPtr, "DefaultState");
		DefaultState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultState");
		DefaultState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultState", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ActualManagePolice_PropertyAddress, intPtr, "ActualManagePolice");
		ActualManagePolice_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActualManagePolice");
		ActualManagePolice_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActualManagePolice", Classes.FEnumProperty);
		FGsOverlapPoliceConfig_IsValid = intPtr != IntPtr.Zero && ManagePolice_IsValid && State_IsValid && OutState_IsValid && DefaultState_IsValid && ActualManagePolice_IsValid && ConfigGuid_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsOverlapPoliceConfig", FGsOverlapPoliceConfig_IsValid);
	}
}
