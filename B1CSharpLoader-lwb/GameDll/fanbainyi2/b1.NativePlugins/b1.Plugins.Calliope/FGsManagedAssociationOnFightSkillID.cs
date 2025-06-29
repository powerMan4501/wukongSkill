using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedAssociationOnFightSkillID", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedAssociationOnFightSkillID
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

	private static bool OnFightSkillID_IsValid;

	private static int OnFightSkillID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedAssociationOnFightSkillID:OnFightSkillID")]
	public int OnFightSkillID;

	private static bool FGsManagedAssociationOnFightSkillID_IsValid;

	private static int FGsManagedAssociationOnFightSkillID_StructSize;

	public FGsManagedAssociationOnFightSkillID Copy()
	{
		return this;
	}

	public static FGsManagedAssociationOnFightSkillID FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedAssociationOnFightSkillID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedAssociationOnFightSkillID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedAssociationOnFightSkillID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedAssociationOnFightSkillID(nativeBuffer + arrayIndex * FGsManagedAssociationOnFightSkillID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedAssociationOnFightSkillID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedAssociationOnFightSkillID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedAssociationOnFightSkillID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedAssociationOnFightSkillID");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OnFightSkillID_Offset), OnFightSkillID);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedAssociationOnFightSkillID(IntPtr nativeStruct)
	{
		if (!FGsManagedAssociationOnFightSkillID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedAssociationOnFightSkillID");
			OnFightSkillID = 0;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			OnFightSkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OnFightSkillID_Offset));
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedAssociationOnFightSkillID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedAssociationOnFightSkillID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedAssociationOnFightSkillID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedAssociationOnFightSkillID");
		FGsManagedAssociationOnFightSkillID_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		OnFightSkillID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnFightSkillID");
		OnFightSkillID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnFightSkillID", Classes.FIntProperty);
		FGsManagedAssociationOnFightSkillID_IsValid = intPtr != IntPtr.Zero && OnFightSkillID_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedAssociationOnFightSkillID", FGsManagedAssociationOnFightSkillID_IsValid);
	}
}
