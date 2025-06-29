using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedAssociationUnitConfigID", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedAssociationUnitConfigID
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

	private static bool ConfigID_IsValid;

	private static int ConfigID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedAssociationUnitConfigID:ConfigID")]
	public int ConfigID;

	private static bool FGsManagedAssociationUnitConfigID_IsValid;

	private static int FGsManagedAssociationUnitConfigID_StructSize;

	public FGsManagedAssociationUnitConfigID Copy()
	{
		return this;
	}

	public static FGsManagedAssociationUnitConfigID FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedAssociationUnitConfigID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedAssociationUnitConfigID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedAssociationUnitConfigID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedAssociationUnitConfigID(nativeBuffer + arrayIndex * FGsManagedAssociationUnitConfigID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedAssociationUnitConfigID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedAssociationUnitConfigID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedAssociationUnitConfigID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedAssociationUnitConfigID");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ConfigID_Offset), ConfigID);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedAssociationUnitConfigID(IntPtr nativeStruct)
	{
		if (!FGsManagedAssociationUnitConfigID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedAssociationUnitConfigID");
			ConfigID = 0;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			ConfigID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ConfigID_Offset));
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedAssociationUnitConfigID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedAssociationUnitConfigID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedAssociationUnitConfigID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedAssociationUnitConfigID");
		FGsManagedAssociationUnitConfigID_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		ConfigID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigID");
		ConfigID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigID", Classes.FIntProperty);
		FGsManagedAssociationUnitConfigID_IsValid = intPtr != IntPtr.Zero && ConfigID_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedAssociationUnitConfigID", FGsManagedAssociationUnitConfigID_IsValid);
	}
}
