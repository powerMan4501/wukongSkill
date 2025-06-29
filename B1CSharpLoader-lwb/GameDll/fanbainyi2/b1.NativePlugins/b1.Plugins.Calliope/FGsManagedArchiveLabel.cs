using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedArchiveLabel", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedArchiveLabel
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

	private static bool ArchiveLabel_IsValid;

	private static int ArchiveLabel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedArchiveLabel:ArchiveLabel")]
	public FName ArchiveLabel;

	private static bool FGsManagedArchiveLabel_IsValid;

	private static int FGsManagedArchiveLabel_StructSize;

	public FGsManagedArchiveLabel Copy()
	{
		return this;
	}

	public static FGsManagedArchiveLabel FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedArchiveLabel(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedArchiveLabel value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedArchiveLabel FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedArchiveLabel(nativeBuffer + arrayIndex * FGsManagedArchiveLabel_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedArchiveLabel value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedArchiveLabel_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedArchiveLabel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedArchiveLabel");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ArchiveLabel_Offset), ArchiveLabel);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedArchiveLabel(IntPtr nativeStruct)
	{
		if (!FGsManagedArchiveLabel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedArchiveLabel");
			ArchiveLabel = default(FName);
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			ArchiveLabel = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ArchiveLabel_Offset));
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedArchiveLabel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedArchiveLabel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedArchiveLabel));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedArchiveLabel");
		FGsManagedArchiveLabel_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		ArchiveLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArchiveLabel");
		ArchiveLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArchiveLabel", Classes.FNameProperty);
		FGsManagedArchiveLabel_IsValid = intPtr != IntPtr.Zero && ArchiveLabel_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedArchiveLabel", FGsManagedArchiveLabel_IsValid);
	}
}
