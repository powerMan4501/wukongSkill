using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedFollowPartnerConfigID", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedFollowPartnerConfigID
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
	[UMetaPath("/Script/Calliope.GsManagedFollowPartnerConfigID:ConfigID")]
	public int ConfigID;

	private static bool FGsManagedFollowPartnerConfigID_IsValid;

	private static int FGsManagedFollowPartnerConfigID_StructSize;

	public FGsManagedFollowPartnerConfigID Copy()
	{
		return this;
	}

	public static FGsManagedFollowPartnerConfigID FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedFollowPartnerConfigID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedFollowPartnerConfigID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedFollowPartnerConfigID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedFollowPartnerConfigID(nativeBuffer + arrayIndex * FGsManagedFollowPartnerConfigID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedFollowPartnerConfigID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedFollowPartnerConfigID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedFollowPartnerConfigID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedFollowPartnerConfigID");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ConfigID_Offset), ConfigID);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedFollowPartnerConfigID(IntPtr nativeStruct)
	{
		if (!FGsManagedFollowPartnerConfigID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedFollowPartnerConfigID");
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

	static FGsManagedFollowPartnerConfigID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedFollowPartnerConfigID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedFollowPartnerConfigID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedFollowPartnerConfigID");
		FGsManagedFollowPartnerConfigID_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		ConfigID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigID");
		ConfigID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigID", Classes.FIntProperty);
		FGsManagedFollowPartnerConfigID_IsValid = intPtr != IntPtr.Zero && ConfigID_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedFollowPartnerConfigID", FGsManagedFollowPartnerConfigID_IsValid);
	}
}
