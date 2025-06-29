using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedBuffID", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedBuffID
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

	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedBuffID:BuffID")]
	public int BuffID;

	private static bool NPCUnit_IsValid;

	private static int NPCUnit_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Calliope.GsManagedBuffID:NPCUnit")]
	public FGsSmartParamArray NPCUnit;

	private static bool FGsManagedBuffID_IsValid;

	private static int FGsManagedBuffID_StructSize;

	public FGsManagedBuffID Copy()
	{
		return this;
	}

	public static FGsManagedBuffID FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedBuffID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedBuffID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedBuffID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedBuffID(nativeBuffer + arrayIndex * FGsManagedBuffID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedBuffID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedBuffID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedBuffID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedBuffID");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffID_Offset), BuffID);
		FGsSmartParamArray.ToNative(IntPtr.Add(nativeStruct, NPCUnit_Offset), NPCUnit);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedBuffID(IntPtr nativeStruct)
	{
		if (!FGsManagedBuffID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedBuffID");
			BuffID = 0;
			NPCUnit = default(FGsSmartParamArray);
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			BuffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffID_Offset));
			NPCUnit = FGsSmartParamArray.FromNative(IntPtr.Add(nativeStruct, NPCUnit_Offset));
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedBuffID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedBuffID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedBuffID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedBuffID");
		FGsManagedBuffID_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		BuffID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		NPCUnit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NPCUnit");
		NPCUnit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NPCUnit", Classes.FStructProperty);
		FGsManagedBuffID_IsValid = intPtr != IntPtr.Zero && BuffID_IsValid && NPCUnit_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedBuffID", FGsManagedBuffID_IsValid);
	}
}
